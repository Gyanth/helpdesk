' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.

Imports CapaNegocio
Imports Web_service

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
                Dim iduser As Integer = temp.Rows(0).Item(0)
                ctr.registrarInicioSesion(iduser, composite.sistema)
                Return iduser
            End If
        End If
        Return -1
    End Function

    <OperationBehavior>
    Public Function getListaServidoresBDLogin() As DataTable Implements IService1.getListaServidoresBD


        Dim ctr As New LgServidorBD

        Dim temp As DataTable = ctr.listaServidoresBD
        temp.TableName = "lista"
        Return temp


    End Function

    Public Function realizarQuery(parametros As ParametrosConexion) As PeticionBD Implements IService1.realizarQuery
        Dim clscon As New CapaDatos.clsConexion_Externa
        clscon.Servidor = parametros.hostname
        clscon.Password = parametros.password
        clscon.Usuario = parametros.username
        clscon.BaseDatos = parametros.bd
        clscon.ConexionBD()

        Dim rpt As CapaEntidades.ClsQuery = clscon.ejecutarQuery(parametros.query)

        Dim response As New PeticionBD
        response.responseTable = rpt.ResponseTable
        response.responseString = rpt.ResponseString
        response.Success = rpt.Success

        Dim ctrServidor As New CapaNegocio.LgServidorBD

        ctrServidor.registrarEjecuciones(parametros.idUSer, parametros.query, rpt.ResponseString)
        Return response


    End Function
End Class
