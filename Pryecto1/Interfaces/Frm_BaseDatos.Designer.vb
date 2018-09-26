<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BaseDatos
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
        Me.cmb_servidor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_conectar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_basedatos = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmb_servidor
        '
        Me.cmb_servidor.FormattingEnabled = True
        Me.cmb_servidor.Location = New System.Drawing.Point(235, 80)
        Me.cmb_servidor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_servidor.Name = "cmb_servidor"
        Me.cmb_servidor.Size = New System.Drawing.Size(161, 24)
        Me.cmb_servidor.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Servidor"
        '
        'btn_conectar
        '
        Me.btn_conectar.Location = New System.Drawing.Point(205, 322)
        Me.btn_conectar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_conectar.Name = "btn_conectar"
        Me.btn_conectar.Size = New System.Drawing.Size(140, 39)
        Me.btn_conectar.TabIndex = 8
        Me.btn_conectar.Text = "Conectar"
        Me.btn_conectar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 153)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Base Datos"
        '
        'cmb_basedatos
        '
        Me.cmb_basedatos.FormattingEnabled = True
        Me.cmb_basedatos.Location = New System.Drawing.Point(236, 151)
        Me.cmb_basedatos.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_basedatos.Name = "cmb_basedatos"
        Me.cmb_basedatos.Size = New System.Drawing.Size(160, 24)
        Me.cmb_basedatos.TabIndex = 10
        '
        'Frm_BaseDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 402)
        Me.Controls.Add(Me.cmb_basedatos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_conectar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_servidor)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_BaseDatos"
        Me.Text = "Servidor - BD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_servidor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_conectar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_basedatos As ComboBox
End Class
