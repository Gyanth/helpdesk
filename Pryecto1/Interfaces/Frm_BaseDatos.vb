

Public Class Frm_BaseDatos

    Public datatable As DataTable
    Public Loaded = False



    Private Sub btn_conectar_Click(sender As Object, e As EventArgs) Handles btn_conectar.Click
        If (Loaded) Then
            extraerDatos(cmb_basedatos.SelectedValue)
        End If
    End Sub

    Private Sub Frm_BaseDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cliente As ServiceReference1.Service1Client = New ServiceReference1.Service1Client

        Dim request As New ServiceReference1.getListaServidoresBDRequest

        Dim response As ServiceReference1.getListaServidoresBDResponse = cliente.getListaServidoresBD(request)

        datatable = response.getListaServidoresBDResult

        Dim dataview = New DataView(datatable)

        Dim servidores As DataTable = dataview.ToTable(True, "servidor")
        cmb_servidor.DataSource = servidores
        cmb_servidor.DisplayMember = "servidor"
        cmb_servidor.ValueMember = "servidor"
        buscarBD(cmb_servidor.SelectedValue.ToString)

        Loaded = True

    End Sub

    Private Sub cmb_servidor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_servidor.SelectedValueChanged
        If (Loaded) Then
            buscarBD(cmb_servidor.SelectedValue.ToString)
        End If

    End Sub

    Sub buscarBD(search As String)
        Dim dataview = New DataView(datatable)
        dataview.RowFilter = "servidor = '" + search + "'"
        cmb_basedatos.DataSource = dataview
        cmb_basedatos.DisplayMember = "bd"
        cmb_basedatos.ValueMember = "id"
    End Sub



    Sub extraerDatos(id As Integer)
        Dim dataview = New DataView(datatable)
        dataview.RowFilter = "id = " + id.ToString

        Dim host = dataview.Item(0).Row.Item(3)
        Dim bd = dataview.Item(0).Row.Item(1)
        Dim frm As New Frm_Comandos
        frm.host = host
        frm.bd = bd
        frm.ShowDialog()

    End Sub

    Private Sub cmb_basedatos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_basedatos.SelectedValueChanged
        If (Loaded) Then
            extraerDatos(cmb_basedatos.SelectedValue)
        End If

    End Sub
End Class