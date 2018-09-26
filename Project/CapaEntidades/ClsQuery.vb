Public Class ClsQuery

    Private mResponseTable As DataTable
    Private mResponseString As String
    Private mSuccess As Boolean

    Public Property ResponseTable As DataTable
        Get
            Return mResponseTable
        End Get
        Set(value As DataTable)
            mResponseTable = value
        End Set
    End Property

    Public Property ResponseString As String
        Get
            Return mResponseString
        End Get
        Set(value As String)
            mResponseString = value
        End Set
    End Property

    Public Property Success As Boolean
        Get
            Return mSuccess
        End Get
        Set(value As Boolean)
            mSuccess = value
        End Set
    End Property
End Class
