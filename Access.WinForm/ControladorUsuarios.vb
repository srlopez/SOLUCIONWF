Imports System.Data.SqlClient
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

