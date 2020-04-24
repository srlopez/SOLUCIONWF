﻿Public Class FormUsuarios

    Dim ds As DataSet = New DataSet()
    'Dim usuario As DataRow

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' test
        ControladorUsuarios.TestConexion()

        ' fill dataset
        ControladorUsuarios.FillUsuarios(ds, "USUARIOS")
        'LogUsuarios()

        ControladorUsuarios.FillMascotas(ds, "MASCOTAS")

        ds.Relations.Add("PROPIETARIOS",
            ds.Tables("USUARIOS").Columns("ID"),
            ds.Tables("MASCOTAS").Columns("IDPROPIETARIO"))

        'Control BindingSource
        BindingSourcePropietarios = New BindingSource()
        BindingSourcePropietarios.DataSource = ds

        BindingSourcePropietarios.DataMember = "USUARIOS"

        'Control BindingNavigatorUsuarios
        BindingNavigatorUsuarios.BindingSource = BindingSourcePropietarios

        'Controles Textos
        txtID.DataBindings.Add("Text", BindingSourcePropietarios, "ID", True)
        txtNombre.DataBindings.Add("Text", BindingSourcePropietarios, "NOMBRE", True)
        txtFecha.DataBindings.Add("Text", BindingSourcePropietarios, "FNACIMIENTO", True)

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

    Private Sub ButtonCerrar_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub





    Private Sub DataGridViewMascotas_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridViewMascotas.UserAddedRow
        'DataGridViewRow
        Dim row = DataGridViewMascotas.CurrentRow()
        Console.WriteLine(row.IsNewRow)
        'If IsDBNull(row("ID")) Then
        '    row("ID") = Guid.NewGuid()
        '    txtID.Text = row("ID")
        'End If
    End Sub

    Private Sub DataGridViewMascotas_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridViewMascotas.RowsAdded
        Try
            Dim row = DataGridViewMascotas.CurrentRow()
            If Not row Is Nothing Then
                'Console.WriteLine(row.IsNewRow)
                If IsDBNull(row.Cells("ID").Value) Then
                    row.Cells("ID").Value = Guid.NewGuid()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        Me.Validate()
        BindingSourcePropietarios.EndEdit()
        UpdateData(ds, "MASCOTAS")
    End Sub
End Class
