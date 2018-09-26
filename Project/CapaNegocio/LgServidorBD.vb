Imports CapaEntidades
Imports CapaDatos


Public Class LgServidorBD


    Public Function listaServidoresBD() As DataTable

        Dim ctr As New CtrServidorBD
        Return ctr.listarServidoresBD()

    End Function
End Class
