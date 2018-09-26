Public Class Frm_Principal
    Private Sub ConsultasBDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasBDToolStripMenuItem.Click
        Frm_BaseDatos.ShowDialog()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Dim frm As New Frm_Login
        frm.Show()
        Close()
    End Sub
End Class