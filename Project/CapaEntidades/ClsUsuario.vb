
Public Class ClsUsuario
    Private mIdUsuario As Integer
    Private mUsuario As String
    Private mPassword As String
    Private mEstado As Boolean

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

    Public Property Password As String
        Get
            Return mPassword
        End Get
        Set(value As String)
            mPassword = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return mEstado
        End Get
        Set(value As Boolean)
            mEstado = value
        End Set
    End Property
End Class
