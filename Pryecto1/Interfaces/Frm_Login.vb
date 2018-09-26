
Public Class Frm_Login
    Public Cont As Integer
    Public idUsuario As Integer

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MsgBox("¿Estas Seguro que quieres salir?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Cerrar Aplicacion") = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        procesarLogin()


    End Sub

    Sub procesarLogin()
        Try
            If txt_usuariologin.Text.Trim = "" Or txt_contraseñalogin.Text.Trim = "" Then
                MsgBox("Ingresar Datos, Por Favor..!", MsgBoxStyle.Critical, "Sistema HelpDesk")
                Exit Sub
            Else
                Dim cls As New ServiceReference1.validarLoginRequest
                Dim cls_user = New ServiceReference1.ClsUsuarioWeb


                cls_user.usuario = txt_usuariologin.Text
                cls_user.password = txt_contraseñalogin.Text
                cls.usue = cls_user

                Dim cliente As ServiceReference1.Service1Client = New ServiceReference1.Service1Client


                Dim response As ServiceReference1.validarLoginResponse = cliente.validarLogin(cls)
                Dim rptVal As Integer = response.validarLoginResult




                If rptVal > 0 Then
                    BarraProgreso.Visible = True
                    BarraProgreso.Value = 0.0
                    BarraProgreso.Maximum = 100
                    Tiempo.Interval = 10
                    Tiempo.Enabled = True
                    txt_usuariologin.Enabled = False
                    txt_contraseñalogin.Enabled = False
                    idUsuario = rptVal
                    Exit Sub

                Else
                    MsgBox("Error, Ud. No puede Ingresar, Datos Incorrectos.", MsgBoxStyle.Exclamation, "Sistema Desk")
                    txt_usuariologin.Text = ""
                    txt_contraseñalogin.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Tiempo.Stop()
        End Try
    End Sub

    Private Sub chb_mostrar_contraseña_CheckedChanged(sender As Object, e As EventArgs) Handles chb_mostrar_contraseña.CheckedChanged
        If chb_mostrar_contraseña.Checked = True Then
            txt_contraseñalogin.UseSystemPasswordChar = False
        Else
            txt_contraseñalogin.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        TiempoCargar()

    End Sub

    Sub TiempoCargar()
        If Cont < 100 Then
            BarraProgreso.Value = Cont
            Cont = Cont + 5
        Else
            Tiempo.Enabled = False

            Dim frm As New Frm_Principal
            frm.Show()

            Me.Close()


        End If
    End Sub

    Private Sub txt_contraseñalogin_TextChanged(sender As Object, e As KeyEventArgs) Handles txt_contraseñalogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            procesarLogin()
        End If
    End Sub

    Private Sub txt_usuariologin_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txt_usuariologin.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class