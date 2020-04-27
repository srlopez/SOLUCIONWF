Imports System.Globalization

Public Class FormBase

    Dim usuarios As New ArrayList
    Dim nClicks = 0

    'Dim usuarios As (id As String, nombre As String, fecha As Date, email As String)()
    'Manejo de tuplas http://www.elguille.info/NET/dotnet/como-usar-las-tuplas-en-visual-basic-y-c-sharp-con-net-core-2-1-o-visual-studio-2017-con-net-4-7-2.aspx

    Sub ClearForm()
        txtID.Text = ""
        txtNombre.Text = ""
        txtFecha.Text = ""
        txtEmail.Text = ""

        lstUsuarios.Items.Clear()
        cmbSelect.Items.Clear()
        flPanel.Controls.Clear()

        btnDelete.Enabled = False
    End Sub

    Sub SetForm(id As String)
        Dim usuario = SelectUsuariosByID(id)
        txtID.Text = usuario.id
        txtNombre.Text = usuario.nombre
        txtFecha.Text = usuario.fecha '.ToString("d", DateTimeFormatInfo.InvariantInfo)
        txtEmail.Text = usuario.email

        btnDelete.Enabled = True

        'Establecemos el elemento seleccionado
        cmbSelect.SelectedItem = usuario.nombre
        lstUsuarios.SelectedItem = usuario.nombre
        For Each btn In flPanel.Controls
            If btn.Text = usuario.nombre Then btn.Select()
        Next

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
        nClicks += 1
        lblClicks.Text = $"número de Clicks = {nClicks}"
        usuarios.Clear()

        lstUsuarios.Items.Clear()
        cmbSelect.Items.Clear()
        flPanel.Controls.Clear()

        usuarios = SelectUsuariosLIKE(txtBuscar.Text)
        For Each item In usuarios
            lstUsuarios.Items.Add(item.Item2)
            cmbSelect.Items.Add(item.Item2)
            flPanel.Controls.Add(CreateButton(item.Item2, item.Item1))
        Next

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteUsuariosByID(txtID.Text)
        ClearForm()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        ClearForm()
    End Sub

    Private Sub cmbSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelect.SelectedIndexChanged
        Dim id = usuarios(cmbSelect.SelectedIndex).Item1 'ID
        SetForm(id)
    End Sub

    Private Sub lstUsuarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUsuarios.SelectedIndexChanged
        Console.WriteLine(lstUsuarios.SelectedItem)
        Console.WriteLine(lstUsuarios.SelectedIndex)
        Console.WriteLine(usuarios(lstUsuarios.SelectedIndex).Item1)

        SetForm(usuarios(lstUsuarios.SelectedIndex).Item1)
    End Sub

    Private Sub theButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Handle your Button clicks here
        MsgBox("HOLA SOY EL BOTON" + vbCrLf +
               sender.Text + vbCrLf +
               "ID: " + sender.tag)
        Console.WriteLine(sender)
        Console.WriteLine(e)
        SetForm(sender.tag)
    End Sub

    Function CreateButton(nombre As String, id As String) As Button
        Dim myCrtl As New Button
        With myCrtl
            .Size = New Size(100, 100)
            .Text = nombre
            .TextAlign = ContentAlignment.BottomCenter
            .Font = lblBuscar.Font
            .ForeColor = Color.IndianRed
            .Tag = id
            '.Image = Access.WinForm.My.Resources.Resources.pnglogo2
            '.ImageAlign = ContentAlignment.BottomCenter
            .BackgroundImageLayout = ImageLayout.Zoom
            .BackgroundImage = Access.WinForm.My.Resources.Resources.pnglogo2
        End With
        AddHandler myCrtl.Click, AddressOf Me.theButton_Click
        Dim myToolTip As New ToolTip
        myToolTip.SetToolTip(myCrtl, $"{nombre}")

        Return myCrtl
    End Function

    Private Sub btnAbrirMain_Click(sender As Object, e As EventArgs) Handles btnAbrirMain.Click
        FormUsuarios.Show()
    End Sub


End Class