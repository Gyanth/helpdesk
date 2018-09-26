Public Module UsuarioAcceso
    Private mIdUsuario As Integer
    Private mUsuario As String

    Public Property IdUsuario As Integer
        Get
            Return mIdUsuario
        End Get
        Set(value As Integer)
            mIdUsuario = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return mUsuario
        End Get
        Set(value As String)
            mUsuario = value
        End Set
    End Property
End Module
