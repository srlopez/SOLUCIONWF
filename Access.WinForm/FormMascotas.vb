Public Class FormMascotas
    Dim ds As DataSet = New DataSet()

    Private Sub FormMascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Enabled = False

        ControladorDatos.FillMascotas(ds, "MEMMASCOTAS")
        ControladorDatos.FillUsuarios(ds, "MEMUSUARIOS")

        ds.Relations.Add("PROPIETARIOS",
            ds.Tables("MEMUSUARIOS").Columns("ID"),
            ds.Tables("MEMMASCOTAS").Columns("IDPROPIETARIO"))

        BindingSource1 = New BindingSource()
        BindingSource1.DataSource = ds
        BindingSource1.DataMember = "MEMMASCOTAS"

        'Control BindingNavigator
        navFormulario.BindingSource = BindingSource1

        'Controles Textos
        txtID.DataBindings.Add("Text", BindingSource1, "ID", True)
        txtNombre.DataBindings.Add("Text", BindingSource1, "NOMBRE", True)
        cmbEspecie.DataBindings.Add("Text", BindingSource1, "IDESPECIE", True)
        cmbRaza.DataBindings.Add("Text", BindingSource1, "IDRAZA", True)

        'Desplegable
        cmbPropietario.DataBindings.Add("SelectedValue", BindingSource1, "IDPROPIETARIO", True)

        'Valores del desplegable
        cmbPropietario.DataSource = ds.Tables("MEMUSUARIOS")
        cmbPropietario.DisplayMember = "NOMBRE"
        cmbPropietario.ValueMember = "ID"

        'Console.WriteLine($"cmbPropietario.ValueMember={cmbPropietario.ValueMember}")
    End Sub

    Private Sub btmAplicar_Click(sender As Object, e As EventArgs) Handles btmAplicar.Click
        Me.Validate()
        BindingSource1.EndEdit()
        UpdateData(ds, "MEMMASCOTAS")
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged
        ' Utilizado para añadir un nuevo item.
        ' No he acertado a ponerlo en un evento más adecuado
        Try
            Dim row = BindingSource1.Current.Row
            If IsDBNull(row("ID")) Then
                row("ID") = Guid.NewGuid()
                txtID.Text = row("ID")
            End If

            Console.WriteLine($"{row("ID")} BindingSource1_CurrentChanged")
        Catch ex As Exception
            Dim s = "Exception Error:" + vbCrLf _
                + "Target: " + ex.TargetSite.ToString _
                + vbCrLf + "Error: " _
                + ex.Message.ToString + vbCrLf _
                + "Trace: " + ex.StackTrace.ToString
            'MsgBox(s)
            Console.WriteLine(s)
        End Try

    End Sub

    Private Sub BindingSource1_AddingNew(sender As Object, e As System.ComponentModel.AddingNewEventArgs) Handles BindingSource1.AddingNew
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
    End Sub

    Private Sub BindingSource1_CurrentItemChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentItemChanged
    End Sub
End Class