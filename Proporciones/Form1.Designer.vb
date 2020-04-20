<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtLista = New System.Windows.Forms.TextBox()
        Me.lblValores = New System.Windows.Forms.Label()
        Me.pnlPresentacion = New System.Windows.Forms.Panel()
        Me.txtAncho = New System.Windows.Forms.TextBox()
        Me.txtAlto = New System.Windows.Forms.TextBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnWplus = New System.Windows.Forms.Button()
        Me.btnWMinus = New System.Windows.Forms.Button()
        Me.btnHMinus = New System.Windows.Forms.Button()
        Me.btnHPlus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLista
        '
        Me.txtLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLista.Location = New System.Drawing.Point(62, 39)
        Me.txtLista.Name = "txtLista"
        Me.txtLista.Size = New System.Drawing.Size(373, 29)
        Me.txtLista.TabIndex = 0
        Me.txtLista.Text = "10 5 5 20"
        '
        'lblValores
        '
        Me.lblValores.AutoSize = True
        Me.lblValores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValores.Location = New System.Drawing.Point(58, 12)
        Me.lblValores.Name = "lblValores"
        Me.lblValores.Size = New System.Drawing.Size(74, 24)
        Me.lblValores.TabIndex = 1
        Me.lblValores.Tag = ""
        Me.lblValores.Text = "Valores"
        '
        'pnlPresentacion
        '
        Me.pnlPresentacion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnlPresentacion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.pnlPresentacion.Location = New System.Drawing.Point(65, 148)
        Me.pnlPresentacion.Name = "pnlPresentacion"
        Me.pnlPresentacion.Size = New System.Drawing.Size(370, 104)
        Me.pnlPresentacion.TabIndex = 2
        '
        'txtAncho
        '
        Me.txtAncho.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAncho.Location = New System.Drawing.Point(85, 111)
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.Size = New System.Drawing.Size(40, 29)
        Me.txtAncho.TabIndex = 3
        Me.txtAncho.Text = "250"
        '
        'txtAlto
        '
        Me.txtAlto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlto.Location = New System.Drawing.Point(19, 186)
        Me.txtAlto.Name = "txtAlto"
        Me.txtAlto.Size = New System.Drawing.Size(40, 29)
        Me.txtAlto.TabIndex = 4
        Me.txtAlto.Text = "140"
        '
        'btnGenerar
        '
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(294, 108)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(141, 34)
        Me.btnGenerar.TabIndex = 5
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(62, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(381, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Introduce una lista de valores enteros separados por espacios"
        '
        'btnWplus
        '
        Me.btnWplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWplus.Location = New System.Drawing.Point(125, 108)
        Me.btnWplus.Name = "btnWplus"
        Me.btnWplus.Size = New System.Drawing.Size(23, 34)
        Me.btnWplus.TabIndex = 7
        Me.btnWplus.Text = "+"
        Me.btnWplus.UseVisualStyleBackColor = True
        '
        'btnWMinus
        '
        Me.btnWMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWMinus.Location = New System.Drawing.Point(62, 108)
        Me.btnWMinus.Name = "btnWMinus"
        Me.btnWMinus.Size = New System.Drawing.Size(23, 34)
        Me.btnWMinus.TabIndex = 8
        Me.btnWMinus.Text = "-"
        Me.btnWMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnWMinus.UseVisualStyleBackColor = True
        '
        'btnHMinus
        '
        Me.btnHMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHMinus.Location = New System.Drawing.Point(36, 148)
        Me.btnHMinus.Name = "btnHMinus"
        Me.btnHMinus.Size = New System.Drawing.Size(23, 35)
        Me.btnHMinus.TabIndex = 9
        Me.btnHMinus.Text = "-"
        Me.btnHMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHMinus.UseVisualStyleBackColor = True
        '
        'btnHPlus
        '
        Me.btnHPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHPlus.Location = New System.Drawing.Point(36, 221)
        Me.btnHPlus.Name = "btnHPlus"
        Me.btnHPlus.Size = New System.Drawing.Size(23, 34)
        Me.btnHPlus.TabIndex = 10
        Me.btnHPlus.Text = "+"
        Me.btnHPlus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 366)
        Me.Controls.Add(Me.btnHPlus)
        Me.Controls.Add(Me.btnHMinus)
        Me.Controls.Add(Me.btnWMinus)
        Me.Controls.Add(Me.btnWplus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtAlto)
        Me.Controls.Add(Me.txtAncho)
        Me.Controls.Add(Me.pnlPresentacion)
        Me.Controls.Add(Me.lblValores)
        Me.Controls.Add(Me.txtLista)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Tag = ""
        Me.Text = "Números a 2D"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLista As TextBox
    Friend WithEvents lblValores As Label
    Friend WithEvents pnlPresentacion As Panel
    Friend WithEvents txtAncho As TextBox
    Friend WithEvents txtAlto As TextBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnWplus As Button
    Friend WithEvents btnWMinus As Button
    Friend WithEvents btnHMinus As Button
    Friend WithEvents btnHPlus As Button
End Class
