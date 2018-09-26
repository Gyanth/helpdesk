Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Comandos

    Public host As String
    Public bd As String
    Public con As New clsConexion
    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        If MsgBox("¿Estas Seguro que quieres Regresar?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Cerrar Interfaz") = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_nuevaconsulta_Click(sender As Object, e As EventArgs) Handles btn_nuevaconsulta.Click
        txt_sentenciaSQL.Clear()
        txt_errores.Clear()
        dgv_visualizardatos.ClearSelection()

    End Sub

    Private Sub Frm_Comandos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        txt_sentenciaSQL.Text = "select * from holi"
    End Sub


    Sub abrirConexion()
        con.BaseDatos = bd
        con.Servidor = host
        con.Usuario = "sa"
        con.Password = "123456"
        con.ConexionBD()
        MsgBox("Conexion exitosa!")

    End Sub

    Private Sub btn_ejecutarconsulta_Click(sender As Object, e As EventArgs) Handles btn_ejecutarconsulta.Click
        Dim sql As String = txt_sentenciaSQL.Text
        'This only gets datatables'
        Dim dt As DataTable = con.ejecutarQuery(sql)

        dgv_visualizardatos.DataSource = dt

    End Sub
End Class