Public Class FormUsuarios

    Dim ds As DataSet = New DataSet()
    Dim usuario As DataRow

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        ControladorUsuarios.TestConexion()

        ControladorUsuarios.FillUsuarios(ds, "USUARIOS")
        LogUsuarios()

        ControladorUsuarios.FillMascotas(ds, "MASCOTAS")

        ds.Relations.Add("PROPIETARIOS",
            ds.Tables("USUARIOS").Columns("ID"),
            ds.Tables("MASCOTAS").Columns("IDPROPIETARIO"))

        'Control BindingSourceUsuarios
        BindingSourcePropietarios = New BindingSource()
        BindingSourcePropietarios.DataSource = ds

        BindingSourcePropietarios.DataMember = "USUARIOS"

        'Control BindingNavigatorUsuarios
        BindingNavigatorUsuarios.BindingSource = BindingSourcePropietarios

        'Controles Textos
        TextBoxID.DataBindings.Add("Text", BindingSourcePropietarios, "ID", True)
        TextBoxNombre.DataBindings.Add("Text", BindingSourcePropietarios, "NOMBRE", True)
        TextBoxFecha.DataBindings.Add("Text", BindingSourcePropietarios, "FNACIMIENTO", True)

        'Control DataGridViewMascotas
        'https://stackoverflow.com/questions/6063902/datagridview-parent-to-child-database-relation-updating-child-datagridview-d
        DataGridViewMascotas.DataSource = BindingSourcePropietarios
        DataGridViewMascotas.DataMember = "PROPIETARIOS"

    End Sub

    Sub LogUsuarios()
        Dim i = 0
        Dim dt = ds.Tables("USUARIOS")
        Dim row As DataRow
        For i = 0 To dt.Rows.Count - 1
            row = dt.Rows(i)
            'Console.WriteLine($"{i}: {row.Item(dt.Columns.IndexOf("NOMBRE"))}")
            Console.WriteLine($"{i}: {row.Item(0)} {row.Item(1)} {row.Item(2)}")
        Next i
    End Sub

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub


End Class
