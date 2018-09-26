Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Comandos

    Public host As String
    Public bd As String

    Public parametros As New ServiceReference1.ParametrosConexion
    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        If MsgBox("¿Estas Seguro que quieres Regresar?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Cerrar Interfaz") = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_nuevaconsulta_Click(sender As Object, e As EventArgs) Handles btn_nuevaconsulta.Click
        txt_sentenciaSQL.Clear()
        txt_errores.Text = ""
        dgv_visualizardatos.ClearSelection()

    End Sub

    Private Sub Frm_Comandos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        lbl_mostrarservidor.Text = bd
        txt_sentenciaSQL.Text = "select * from holi"
    End Sub


    Sub abrirConexion()

        parametros.bd = bd
        parametros.hostname = host
        parametros.username = "sa"
        parametros.password = "123456"
        ' MsgBox("Conexion exitosa!")

    End Sub

    Private Sub btn_ejecutarconsulta_Click(sender As Object, e As EventArgs) Handles btn_ejecutarconsulta.Click
        Dim sql As String = txt_sentenciaSQL.Text

        parametros.idUSer = Variables.idUSer
        parametros.query = sql

        Dim cliente As New ServiceReference1.Service1Client
        Dim response As ServiceReference1.PeticionBD = cliente.realizarQuery(parametros)
        If response.Success Then
            txt_errores.ForeColor = Color.Green
        Else
            txt_errores.ForeColor = Color.Red
        End If
        txt_errores.Text = response.responseString
        dgv_visualizardatos.DataSource = response.responseTable
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles txt_errores.Click

    End Sub
End Class