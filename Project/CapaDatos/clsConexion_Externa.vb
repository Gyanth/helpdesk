Imports System.Data

Imports System.Data.SqlClient
Public Class clsConexion_Externa
#Region "Campos"
    Private mUsuario As String 'Usuario de la BD
    Private mPassword As String 'Clave Servidor
    Private mAunten As Boolean = False 'False = autenticacion mixta y True = Autenticacion Winows'
    Private mServidor As String 'Nombre del Servidor 
    Private mBaseDatos As String 'Nombre de la BD
    Private mConn As SqlConnection 'Variable para establecer la cadena de conexion'
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

    Public Function ConexionBD() As SqlConnection
        ' Crea y establece la cadena de conexion debiéndosele enviar los parametros
        ' vamos a declarar de que computadora y que servidor estoy jalando la cadena de conexion  
        Me.Conn = New SqlConnection("Initial Catalog=" & Me.BaseDatos &
                                           ";Data Source=" & Me.Servidor &
                                           ";user id =" & Usuario &
                                           "; password =" & Me.Password & ";")
        Return Conn
    End Function


    Public Function ejecutarQuery(query As String) As CapaEntidades.ClsQuery
        Dim rpt As New CapaEntidades.ClsQuery
        Dim datatable As DataTable = New DataTable
        Dim cmd As SqlCommand = New SqlCommand(query, Me.Conn)
        Me.Conn.Open()
        Try


            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If (rowsAffected = -1) Then
                Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter()
                dataAdapter.SelectCommand = cmd
                dataAdapter.Fill(datatable)
                rpt.ResponseString = "Consulta ejecutada correctamente!"
            Else
                rpt.ResponseString = "( " & rowsAffected & " filas afectadas)"
            End If

            Me.Conn.Close()
            rpt.Success = True
            rpt.ResponseTable = datatable
            rpt.ResponseTable.TableName = "consulta"
        Catch ex As Exception
            rpt.Success = False
            rpt.ResponseString = ex.Message

            Me.Conn.Close()
        End Try

        Return rpt
    End Function
End Class
