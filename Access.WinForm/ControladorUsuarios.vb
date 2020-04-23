﻿Imports System.Data.SqlClient
Imports System.Data.OleDb

Module ControladorUsuarios
    Private row As String
    Private connectionstring As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\BASE.accdb;Persist Security Info=False"
    'Instalar https://www.microsoft.com/es-ES/download/details.aspx?id=13255
    'Proyecto CPU 64x

    Private Function Connection() As OleDbConnection 'SqlConnection
        'Return New SqlClient.SqlConnection(connectionstring) 'ADO.NET no funciona con accdb
        Return New OleDbConnection(connectionstring)
    End Function

    Sub InsertUsuario(nombre As String, fecha As Date, email As String)

        Dim id = Guid.NewGuid()
        Dim conn = Connection()
        conn.Open()
        Dim cmd = conn.CreateCommand()
        cmd.CommandText = "INSERT INTO USUARIOS 
                             (ID, NOMBRE, FNACIMIENTO, EMAIL) VALUES 
                             (@ID, @Nombre, @FNacimiento, @Email)"
        cmd.Parameters.AddWithValue("@ID", id)
        cmd.Parameters.AddWithValue("@Nombre", nombre)
        cmd.Parameters.AddWithValue("@FNacimiento", fecha)
        cmd.Parameters.AddWithValue("@Email", email.ToLower)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Sub UpdateUsuario(id As String,
                      nombre As String,
                      fecha As Date,
                      email As String)

        Dim conn = Connection()
        conn.Open()
        Dim cmd = conn.CreateCommand()
        cmd.CommandText = "UPDATE USUARIOS SET
                             NOMBRE=@Nombre, 
                             FNACIMIENTO=@Fecha, 
                             EMAIL=@Email
                           WHERE ID LIKE @ID"
        cmd.Parameters.AddWithValue("@Nombre", nombre)
        cmd.Parameters.AddWithValue("@FNacimiento", fecha)
        cmd.Parameters.AddWithValue("@Email", email.ToLower)
        cmd.Parameters.AddWithValue("@ID", id)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Sub DeleteUsuariosByID(id As String)
        Dim conn = Connection()
        conn.Open()
        Dim cmd = conn.CreateCommand()
        cmd.CommandText = "DELETE FROM USUARIOS WHERE ID=@ID"
        cmd.Parameters.AddWithValue("@ID", id)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Function SelectUsuariosLIKE(filtro As String) As ArrayList
        Dim conn = Connection()
        conn.Open()
        Dim cmd = conn.CreateCommand()
        cmd.CommandText = "SELECT * FROM USUARIOS 
                    WHERE LCASE(NOMBRE) LIKE @Nombre OR EMAIL LIKE @Email"
        cmd.Parameters.AddWithValue("@Nombre", filtro + "%")
        cmd.Parameters.AddWithValue("@Email", "%" + filtro + "%")

        Dim miAlist = New ArrayList
        Using reader = cmd.ExecuteReader()
            With reader
                Dim row As String
                Do While .Read()
                    row = String.Format("{1}, {0} ", reader("ID"), reader("NOMBRE"))
                    miAlist.Add((ID:=reader("ID"), nombre:=reader("NOMBRE")))
                    'lst.Items.Add(row)
                    Console.WriteLine(row)
                Loop
            End With
        End Using
        cmd.Dispose()
        conn.Close()
        conn.Dispose()
        Return miAlist
    End Function

    Function SelectUsuariosByID(id As String) As (id As String, nombre As String, fecha As Date, email As String)
        Dim conn = Connection()
        conn.Open()
        Dim cmd = conn.CreateCommand()
        cmd.CommandText = "SELECT * FROM USUARIOS 
                    WHERE ID = @ID"
        cmd.Parameters.AddWithValue("@ID", id)

        Dim result As Object
        Dim reader = cmd.ExecuteReader()
        reader.Read()
        result = (reader("ID"),
                    reader("NOMBRE"),
                    reader("FNACIMIENTO"),
                    reader("EMAIL"))
        reader.Close()
        cmd.Dispose()
        conn.Close()
        conn.Dispose()
        Return (id:=result.Item1, nombre:=result.Item2, fecha:=result.Item3, email:=result.Item4)
    End Function


    Private Function DataAdapter(ByRef cmd As Object) As OleDbDataAdapter 'SqlDataAdapter
        'Return New SqlClient.SqlDataAdapter(DirectCast(cmd, SqlCommand))
        Return New OleDbDataAdapter(DirectCast(cmd, OleDbCommand))
    End Function

    Sub TestConexion()
        Try
            Using conn = Connection()
                conn.Open()
                Using cmd = conn.CreateCommand()
                    With cmd
                        .CommandText = "
                        SELECT ID, NOMBRE, FNACIMIENTO1 
                        FROM USUARIOS
                        "
                        Using reader = cmd.ExecuteReader()
                            Do While reader.Read()
                                row = String.Format("{0}", reader.GetValue("NOMBRE"))
                                Console.WriteLine(row)
                            Loop
                        End Using
                    End With
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Sub FillUsuarios(ByRef ds As DataSet, tabla As String)
        Try
            Using conn = Connection()
                conn.Open()
                Using cmd = conn.CreateCommand()
                    With cmd
                        .CommandText = "
                        SELECT ID, NOMBRE, FNACIMIENTO
                        FROM USUARIOS
                        "
                        DataAdapter(cmd).Fill(ds, tabla)
                    End With
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Sub FillMascotas(ByRef ds As DataSet, tabla As String)
        Try
            Using conn = Connection()
                conn.Open()
                Using cmd = conn.CreateCommand()
                    With cmd
                        .CommandText = "
                        SELECT ID, IDPROPIETARIO, NOMBRE
                        FROM MASCOTAS
                        "
                        DataAdapter(cmd).Fill(ds, tabla)
                    End With
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

End Module

