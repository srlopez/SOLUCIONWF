Public Class FormMascotas
    Dim ds As DataSet = New DataSet()

    Private Sub FormMascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ControladorUsuarios.FillMascotas(ds, "MEMMASCOTAS")
        ControladorUsuarios.FillMascotas(ds, "MEMUSUARIOS")

        BindingSource1 = New BindingSource()
        BindingSource1.DataSource = ds
        BindingSource1.DataMember = "MEMMASCOTAS"

        'Control BindingNavigatorUsuarios
        navFormulario.BindingSource = BindingSource1

        'Controles Textos
        txtID.DataBindings.Add("Text", BindingSource1, "ID", True)
        txtNombre.DataBindings.Add("Text", BindingSource1, "NOMBRE", True)
        cmbEspecie.DataBindings.Add("Text", BindingSource1, "NOMBRE", True)

        cmbPropietario.DataSource = ds.Tables("MEMUSUARIOS")
        cmbPropietario.DisplayMember = "NOMBRE"
        'cmbRaza


    End Sub
End Class