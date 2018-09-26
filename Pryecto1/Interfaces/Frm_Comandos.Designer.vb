<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Comandos
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
        Me.txt_sentenciaSQL = New System.Windows.Forms.TextBox()
        Me.btn_ejecutarconsulta = New System.Windows.Forms.Button()
        Me.lbl_mostrarservidor = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_visualizardatos = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_nuevaconsulta = New System.Windows.Forms.Button()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.txt_errores = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_visualizardatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_sentenciaSQL
        '
        Me.txt_sentenciaSQL.Location = New System.Drawing.Point(8, 23)
        Me.txt_sentenciaSQL.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_sentenciaSQL.Multiline = True
        Me.txt_sentenciaSQL.Name = "txt_sentenciaSQL"
        Me.txt_sentenciaSQL.Size = New System.Drawing.Size(389, 213)
        Me.txt_sentenciaSQL.TabIndex = 0
        '
        'btn_ejecutarconsulta
        '
        Me.btn_ejecutarconsulta.Location = New System.Drawing.Point(16, 507)
        Me.btn_ejecutarconsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ejecutarconsulta.Name = "btn_ejecutarconsulta"
        Me.btn_ejecutarconsulta.Size = New System.Drawing.Size(159, 32)
        Me.btn_ejecutarconsulta.TabIndex = 1
        Me.btn_ejecutarconsulta.Text = "Ejecutar Consulta"
        Me.btn_ejecutarconsulta.UseVisualStyleBackColor = True
        '
        'lbl_mostrarservidor
        '
        Me.lbl_mostrarservidor.AutoSize = True
        Me.lbl_mostrarservidor.Location = New System.Drawing.Point(28, 11)
        Me.lbl_mostrarservidor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mostrarservidor.Name = "lbl_mostrarservidor"
        Me.lbl_mostrarservidor.Size = New System.Drawing.Size(20, 17)
        Me.lbl_mostrarservidor.TabIndex = 3
        Me.lbl_mostrarservidor.Text = "..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_sentenciaSQL)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(407, 250)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sentencias SQL"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_visualizardatos)
        Me.GroupBox2.Location = New System.Drawing.Point(431, 48)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(404, 250)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Visualizar Datos"
        '
        'dgv_visualizardatos
        '
        Me.dgv_visualizardatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_visualizardatos.Location = New System.Drawing.Point(8, 23)
        Me.dgv_visualizardatos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_visualizardatos.Name = "dgv_visualizardatos"
        Me.dgv_visualizardatos.Size = New System.Drawing.Size(388, 214)
        Me.dgv_visualizardatos.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_errores)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 376)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(819, 123)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Consola"
        '
        'btn_nuevaconsulta
        '
        Me.btn_nuevaconsulta.Location = New System.Drawing.Point(344, 507)
        Me.btn_nuevaconsulta.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nuevaconsulta.Name = "btn_nuevaconsulta"
        Me.btn_nuevaconsulta.Size = New System.Drawing.Size(159, 31)
        Me.btn_nuevaconsulta.TabIndex = 7
        Me.btn_nuevaconsulta.Text = "Nueva Consulta"
        Me.btn_nuevaconsulta.UseVisualStyleBackColor = True
        '
        'btn_regresar
        '
        Me.btn_regresar.Location = New System.Drawing.Point(676, 508)
        Me.btn_regresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(159, 32)
        Me.btn_regresar.TabIndex = 8
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'txt_errores
        '
        Me.txt_errores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_errores.Location = New System.Drawing.Point(12, 23)
        Me.txt_errores.Name = "txt_errores"
        Me.txt_errores.Size = New System.Drawing.Size(776, 96)
        Me.txt_errores.TabIndex = 0
        '
        'Frm_Comandos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 550)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.btn_nuevaconsulta)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_mostrarservidor)
        Me.Controls.Add(Me.btn_ejecutarconsulta)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Comandos"
        Me.Text = "Consultas - Query"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_visualizardatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_sentenciaSQL As TextBox
    Friend WithEvents btn_ejecutarconsulta As Button
    Friend WithEvents lbl_mostrarservidor As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgv_visualizardatos As DataGridView
    Friend WithEvents btn_nuevaconsulta As Button
    Friend WithEvents btn_regresar As Button
    Friend WithEvents txt_errores As Label
End Class
