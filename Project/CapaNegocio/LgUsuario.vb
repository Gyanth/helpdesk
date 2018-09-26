Imports CapaDatos
Imports CapaEntidades
Public Class LgUsuario
    Public Function procesarLogin(ent As ClsUsuario) As DataTable
        Dim ctr As New CtrUsuario
        Dim temp As DataTable
        temp = ctr.procesarLogin(ent)
        Return temp
    End Function
    Public Function buscarDatosUsuario(IdUsuario As Integer) As DataTable
        Dim ctr2 As New CtrUsuario
        Dim emp As DataTable = ctr2.retornarUsuario(IdUsuario)
        Return emp
    End Function
    Public Function buscarUsuario(id As Integer) As DataTable
        Dim ctr2 As New CtrUsuario
        Dim tabla As DataTable = ctr2.buscarUsuario(id)
        Return tabla
    End Function
    Public Function validarUsuario(user As String) As Boolean
        Dim ctr2 As New CtrUsuario
        Return ctr2.validarUsuario(user)
    End Function
    Public Function validarUsuario(user As String, id As Integer) As Boolean
        Dim ctr2 As New CtrUsuario
        Return ctr2.validarUsuario(user, id)
    End Function
    Public Sub ValidarPermiso()

    End Sub
End Class

