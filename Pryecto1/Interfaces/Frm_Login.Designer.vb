<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.txt_contraseñalogin = New System.Windows.Forms.TextBox()
        Me.txt_usuariologin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chb_mostrar_contraseña = New System.Windows.Forms.CheckBox()
        Me.BarraProgreso = New System.Windows.Forms.ProgressBar()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(296, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(295, 47)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Ingrese su usuario y contraseña para poder acceder al sistema"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(384, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Acceso al Sistema de SiempreSoft"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(491, 303)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(100, 34)
        Me.btn_salir.TabIndex = 13
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(325, 303)
        Me.btn_ingresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(101, 34)
        Me.btn_ingresar.TabIndex = 12
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'txt_contraseñalogin
        '
        Me.txt_contraseñalogin.Location = New System.Drawing.Point(417, 215)
        Me.txt_contraseñalogin.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_contraseñalogin.Name = "txt_contraseñalogin"
        Me.txt_contraseñalogin.Size = New System.Drawing.Size(172, 22)
        Me.txt_contraseñalogin.TabIndex = 11
        Me.txt_contraseñalogin.UseSystemPasswordChar = True
        '
        'txt_usuariologin
        '
        Me.txt_usuariologin.Location = New System.Drawing.Point(417, 166)
        Me.txt_usuariologin.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_usuariologin.Name = "txt_usuariologin"
        Me.txt_usuariologin.Size = New System.Drawing.Size(172, 22)
        Me.txt_usuariologin.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(291, 217)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(296, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(16, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 209)
        Me.Label5.TabIndex = 16
        '
        'chb_mostrar_contraseña
        '
        Me.chb_mostrar_contraseña.AutoSize = True
        Me.chb_mostrar_contraseña.BackColor = System.Drawing.Color.Transparent
        Me.chb_mostrar_contraseña.Location = New System.Drawing.Point(439, 247)
        Me.chb_mostrar_contraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.chb_mostrar_contraseña.Name = "chb_mostrar_contraseña"
        Me.chb_mostrar_contraseña.Size = New System.Drawing.Size(155, 21)
        Me.chb_mostrar_contraseña.TabIndex = 17
        Me.chb_mostrar_contraseña.Text = "Mostrar Contraseña"
        Me.chb_mostrar_contraseña.UseVisualStyleBackColor = False
        '
        'BarraProgreso
        '
        Me.BarraProgreso.Location = New System.Drawing.Point(39, 366)
        Me.BarraProgreso.Margin = New System.Windows.Forms.Padding(4)
        Me.BarraProgreso.Name = "BarraProgreso"
        Me.BarraProgreso.Size = New System.Drawing.Size(551, 42)
        Me.BarraProgreso.TabIndex = 18
        '
        'Tiempo
        '
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 422)
        Me.Controls.Add(Me.BarraProgreso)
        Me.Controls.Add(Me.chb_mostrar_contraseña)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txt_contraseñalogin)
        Me.Controls.Add(Me.txt_usuariologin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Login_Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents txt_contraseñalogin As TextBox
    Friend WithEvents txt_usuariologin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chb_mostrar_contraseña As CheckBox
    Friend WithEvents BarraProgreso As ProgressBar
    Friend WithEvents Tiempo As Timer
End Class
