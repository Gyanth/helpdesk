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
        Me.cmb_basedatos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_conectar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmb_basedatos
        '
        Me.cmb_basedatos.FormattingEnabled = True
        Me.cmb_basedatos.Location = New System.Drawing.Point(217, 49)
        Me.cmb_basedatos.Name = "cmb_basedatos"
        Me.cmb_basedatos.Size = New System.Drawing.Size(122, 21)
        Me.cmb_basedatos.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Base de Datos"
        '
        'btn_conectar
        '
        Me.btn_conectar.Location = New System.Drawing.Point(154, 262)
        Me.btn_conectar.Name = "btn_conectar"
        Me.btn_conectar.Size = New System.Drawing.Size(105, 32)
        Me.btn_conectar.TabIndex = 8
        Me.btn_conectar.Text = "Conectar"
        Me.btn_conectar.UseVisualStyleBackColor = True
        '
        'Frm_BaseDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 327)
        Me.Controls.Add(Me.btn_conectar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_basedatos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_BaseDatos"
        Me.Text = "BD_SiempreSoft"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_basedatos As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_conectar As Button
End Class
