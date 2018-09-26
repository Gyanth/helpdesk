Imports System.Data
Imports System.Data.SqlClient
Public Class clsConexion
#Region "Campos"
    Private mUsuario As String 'Usuario de la BD
    Private mPassword As String 'Clave Servidor
    Private mAunten As Boolean = False 'False = autenticacion mixta y True = Autenticacion Winows'
    Private mServidor As String 'Nombre del Servidor 
    Private mBaseDatos As String 'Nombre de la BD
    Private mConn As SqlConnection 'Variable para establecer la cadena de conexion'
#End Region


#Region "Singleton"
    Private Shared Conexion As clsConexion = Nothing
    Private Shared ReadOnly _Sync As New Object

    Public Shared ReadOnly Property Instance() As clsConexion
        Get
            If Conexion Is Nothing Then
                SyncLock _Sync
                    If Conexion Is Nothing Then
                        Conexion = New clsConexion()
                    End If
                End SyncLock
            End If
            Return Conexion
        End Get
    End Property
#End Region

#Region "Propiedades"
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

    Public Property Aunten As Boolean
        Get
            Return mAunten
        End Get
        Set(value As Boolean)
            mAunten = value
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

    Public Property BaseDatos As String
        Get
            Return mBaseDatos
        End Get
        Set(value As String)
            mBaseDatos = value
        End Set
    End Property

    Public Property Conn As SqlConnection
        Get
            Return mConn
        End Get
        Set(value As SqlConnection)
            mConn = value
        End Set
    End Property
#End Region

    'Constructor'
    Public Sub New()
        Try
            Me.Usuario = "sa"
            Me.Password = "123456"
            Me.Servidor = "DESKTOP-F70B7DD"
            Me.BaseDatos = "servidorestrabajo"
            ConexionBD()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Public Function ConexionBD() As SqlConnection
        ' Crea y establece la cadena de conexion debiéndosele enviar los parametros
        ' vamos a declarar de que computadora y que servidor estoy jalando la cadena de conexion  
        Me.Conn = New SqlConnection("Initial Catalog=" & Me.BaseDatos &
                                           ";Data Source=" & Me.Servidor &
                                           ";user id =" & Usuario &
                                           "; password =" & Me.Password & ";")
        Return Conn
    End Function

    'Protected Overrides Sub Finalize()

    '    Try
    '        If Me.Conn.State = ConnectionState.Open Then
    '            Me.Conn.Close()
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub


End Class
