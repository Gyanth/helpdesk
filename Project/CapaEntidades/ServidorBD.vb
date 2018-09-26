Public Class ServidorBD

    Private mIdDetalle As Integer
    Private mBD As String
    Private mServidor As String
    Private mIP As String

    Public Property IdDetalle As Integer
        Get
            Return mIdDetalle
        End Get
        Set(value As Integer)
            mIdDetalle = value
        End Set
    End Property

    Public Property BD As String
        Get
            Return mBD
        End Get
        Set(value As String)
            mBD = value
        End Set
    End Property

    Public Property Servidor As String
        Get
            Return mServidor
        End Get
        Set(value As String)
            mServidor = value
        End Set
    End Property

    Public Property IP As String
        Get
            Return mIP
        End Get
        Set(value As String)
            mIP = value
        End Set
    End Property
End Class
