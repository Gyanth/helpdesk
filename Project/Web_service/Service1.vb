' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.

Imports CapaNegocio
Public Class Service1
    Implements IService1

    Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
        Return String.Format("You entered: {0}", value)
    End Function

    <OperationBehavior>
    Public Function GetDataUsingDataContract(ByVal composite As ClsUsuarioWeb) As Integer Implements IService1.validarLogin
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If String.IsNullOrEmpty(composite.usuario) = False And String.IsNullOrEmpty(composite.password) = False Then
            Dim ctr As New LgUsuario
            Dim temp As DataTable

            Dim cls As New CapaEntidades.ClsUsuario
            cls.Usuario = composite.usuario
            cls.Password = composite.password

            temp = ctr.procesarLogin(cls)
            If temp.Rows.Count > 0 Then
                Return temp.Rows(0).Item(0)
            End If
        End If
        Return -1
    End Function

    <OperationBehavior>
    Public Function getListaServidoresBDLogin() As DataTable Implements IService1.getListaServidoresBD




        Dim s As New ServidoresBD
        s.pruebas = "hoka"

        '  s.lista = temp

        Dim ctr As New LgServidorBD

        Dim temp As DataTable = ctr.listaServidoresBD
        temp.TableName = "lista"


        Return temp





    End Function

End Class
