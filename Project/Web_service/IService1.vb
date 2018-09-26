' NOTA: puede usar el comando "Cambiar nombre" del menú contextual para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
<ServiceContract()>
Public Interface IService1

    <OperationContract()>
    Function GetData(ByVal value As Integer) As String

    <OperationContract()>
    Function validarLogin(ByVal usue As ClsUsuarioWeb) As Integer

    <OperationContract()>
    Function getListaServidoresBD() As DataTable


    ' TODO: agregue aquí sus operaciones de servicio

End Interface

' Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
' Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "Web_service.ContractType".



<DataContract()>
Public Class ClsUsuarioWeb

    <DataMember()>
    Public Property usuario As String

    <DataMember()>
    Public Property password As String



End Class

<DataContract()>
Public Class ServidoresBD

    <DataMember()>
    Public Property lista As DataTable
    <DataMember()>
    Public Property pruebas As String


End Class
