<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUsuarios))
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BindingNavigatorUsuarios = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingSourcePropietarios = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewMascotas = New System.Windows.Forms.DataGridView()
        Me.btnAplicar = New System.Windows.Forms.Button()
        BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.BindingNavigatorUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigatorUsuarios.SuspendLayout()
        CType(Me.BindingSourcePropietarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewMascotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingNavigatorPositionItem
        '
        BindingNavigatorPositionItem.AccessibleName = "Posición"
        BindingNavigatorPositionItem.AutoSize = False
        BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        BindingNavigatorPositionItem.Text = "0"
        BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(182, 12)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(303, 26)
        Me.txtID.TabIndex = 0
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(150, 18)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(26, 20)
        Me.LabelID.TabIndex = 1
        Me.LabelID.Text = "ID"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.Location = New System.Drawing.Point(115, 47)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(65, 20)
        Me.LabelNombre.TabIndex = 3
        Me.LabelNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(182, 41)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(303, 26)
        Me.txtNombre.TabIndex = 2
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.Location = New System.Drawing.Point(126, 76)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(54, 20)
        Me.LabelFecha.TabIndex = 5
        Me.LabelFecha.Text = "Fecha"
        '
        'txtFecha
        '
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(182, 70)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(303, 26)
        Me.txtFecha.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(508, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(108, 32)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'BindingNavigatorUsuarios
        '
        Me.BindingNavigatorUsuarios.AddNewItem = Nothing
        Me.BindingNavigatorUsuarios.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigatorUsuarios.DeleteItem = Nothing
        Me.BindingNavigatorUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigatorUsuarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigatorUsuarios.Location = New System.Drawing.Point(0, 370)
        Me.BindingNavigatorUsuarios.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigatorUsuarios.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigatorUsuarios.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigatorUsuarios.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigatorUsuarios.Name = "BindingNavigatorUsuarios"
        Me.BindingNavigatorUsuarios.PositionItem = BindingNavigatorPositionItem
        Me.BindingNavigatorUsuarios.Size = New System.Drawing.Size(634, 25)
        Me.BindingNavigatorUsuarios.TabIndex = 9
        Me.BindingNavigatorUsuarios.Text = "BindingNavigatorUsuarios"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DataGridViewMascotas
        '
        Me.DataGridViewMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMascotas.Location = New System.Drawing.Point(57, 103)
        Me.DataGridViewMascotas.Name = "DataGridViewMascotas"
        Me.DataGridViewMascotas.Size = New System.Drawing.Size(428, 197)
        Me.DataGridViewMascotas.TabIndex = 10
        '
        'btnAplicar
        '
        Me.btnAplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicar.Location = New System.Drawing.Point(377, 306)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(108, 32)
        Me.btnAplicar.TabIndex = 11
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = True
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(634, 395)
        Me.Controls.Add(Me.btnAplicar)
        Me.Controls.Add(Me.DataGridViewMascotas)
        Me.Controls.Add(Me.BindingNavigatorUsuarios)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.txtID)
        Me.Name = "FormUsuarios"
        Me.RightToLeftLayout = True
        Me.Text = "Formulario de Propietarios"
        CType(Me.BindingNavigatorUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigatorUsuarios.ResumeLayout(False)
        Me.BindingNavigatorUsuarios.PerformLayout()
        CType(Me.BindingSourcePropietarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewMascotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents LabelFecha As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents BindingNavigatorUsuarios As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingSourcePropietarios As BindingSource
    Friend WithEvents DataGridViewMascotas As DataGridView
    Friend WithEvents btnAplicar As Button
End Class
