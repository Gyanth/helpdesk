Imports CapaEntidades
Imports CapaDatos


Public Class LgServidorBD


    Public Function listaServidoresBD() As DataTable

        Dim ctr As New CtrServidorBD
        Return ctr.listarServidoresBD()

    End Function
    Public Sub registrarEjecuciones(idUSer As Integer, query As String, response As String)

        Dim ctr As New CtrServidorBD
        ctr.registrarEjecuciones(idUSer, query, response)

    End Sub

End Class
