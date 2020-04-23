Imports System.Globalization

Public Class FormBase

    Dim usuarios As New ArrayList

    Sub ClearForm()
        txtID.Text = ""
        txtNombre.Text = ""
        txtFecha.Text = ""
        txtEmail.Text = ""
        lstUsuarios.Items.Clear()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim expenddt As Date = Date.ParseExact(txtFecha.Text, "dd/MM/yyyy",
            System.Globalization.DateTimeFormatInfo.InvariantInfo)

            If txtID.Text <> "" Then
                UpdateUsuario(txtID.Text,
                            txtNombre.Text,
                            expenddt,
                            txtEmail.Text)
            Else

                InsertUsuario(txtNombre.Text,
                            expenddt,
                            txtEmail.Text)
            End If
        Catch ex As Exception
            Dim s = "Exception Error:" + vbCrLf _
                + "Target: " + ex.TargetSite.ToString _
                + vbCrLf + "Error: " _
                + ex.Message.ToString + vbCrLf _
                + "Trace: " + ex.StackTrace.ToString
            MsgBox(s)

        Finally
            ClearForm()
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        lstUsuarios.Items.Clear()
        usuarios.Clear()
        usuarios = SelectUsuariosLIKE(txtBuscar.Text)
        For Each item In usuarios
            lstUsuarios.Items.Add(item.Item2)
        Next
    End Sub

    Private Sub lstUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsuarios.SelectedIndexChanged
        Console.WriteLine(lstUsuarios.SelectedItem)
        Console.WriteLine(lstUsuarios.SelectedIndex)
        Console.WriteLine(usuarios(lstUsuarios.SelectedIndex).Item1)


        Dim id = usuarios(lstUsuarios.SelectedIndex).Item1
        Dim usuario = SelectUsuariosByID(id)
        txtID.Text = usuario.id
        txtNombre.Text = usuario.nombre
        txtFecha.Text = usuario.fecha '.ToString("d", DateTimeFormatInfo.InvariantInfo)
        txtEmail.Text = usuario.email
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteUsuariosByID(txtID.Text)
        ClearForm()
    End Sub
End Class