Imports CapaEntidades
Imports System.Data
Imports System.Data.SqlClient
Public Class CtrUsuario
    Public Function buscarUsuario(id As Integer) As DataTable
        Dim con As clsConexion = clsConexion.Instance
        con.Conn.Open()

        Dim Com As New SqlCommand("sp_BuscarUsuario", con.Conn)
        Com.CommandType = CommandType.StoredProcedure
        Com.Parameters.Add("@idUser", SqlDbType.Int).Value = id

        Dim Result As SqlDataReader

        Dim Tabla As New DataTable

        con.ConexionBD.Open()

        Result = Com.ExecuteReader()

        Tabla.Load(Result)
        con.Conn.Close()

        Return Tabla
    End Function

    Public Function retornarUsuario(id As Integer) As DataTable
        ''Obtiene la informacion que se usara para procesar Login''

        Dim con As clsConexion = clsConexion.Instance
        con.Conn.Open()

        Dim Com As New SqlCommand("sp_RetornarUsuario", con.Conn)
        Com.CommandType = CommandType.StoredProcedure
        Com.Parameters.Add("@idUser", SqlDbType.Int).Value = id

        Dim Result As SqlDataReader

        Dim Tabla As New DataTable

        con.ConexionBD.Open()

        Result = Com.ExecuteReader()

        Tabla.Load(Result)
        con.Conn.Close()

        Return Tabla

    End Function

    Public Function procesarLogin(User As ClsUsuario) As DataTable
        Dim con As clsConexion = clsConexion.Instance
        con.Conn.Open()

        Dim Com As New SqlCommand("sp_procesarLogin", con.Conn)
        Com.CommandType = CommandType.StoredProcedure
        Com.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = User.Usuario
        Com.Parameters.Add("@password", SqlDbType.NVarChar).Value = User.Password

        Dim Result As SqlDataReader

        Dim Tabla As New DataTable

        Result = Com.ExecuteReader()

        Tabla.Load(Result)

        con.Conn.Close()

        Return Tabla
    End Function

    Public Function validarUsuario(usuario As String) As Boolean
        Dim con As clsConexion = clsConexion.Instance
        con.Conn.Open()

        Dim Com As New SqlCommand("sp_validarUsuario", con.Conn)
        Com.CommandType = CommandType.StoredProcedure
        Com.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario
        Com.Parameters.Add("@resultado", SqlDbType.Bit)
        Com.Parameters("@resultado").Direction = ParameterDirection.Output
        Com.ExecuteNonQuery()
        con.Conn.Close()

        Dim res = Com.Parameters("@resultado").Value
        Return res
    End Function

    Public Function validarUsuario(usuario As String, id_p As Integer) As Boolean
        Dim con As clsConexion = clsConexion.Instance
        con.Conn.Open()

        Dim Com As New SqlCommand("sp_validarUsuario", con.Conn)
        Com.CommandType = CommandType.StoredProcedure
        Com.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario
        Com.Parameters.Add("@idUs", SqlDbType.Int).Value = id_p
        Com.Parameters.Add("@resultado", SqlDbType.Bit)
        Com.Parameters("@resultado").Direction = ParameterDirection.Output
        Com.ExecuteNonQuery()
        con.Conn.Close()

        Dim res = Com.Parameters("@resultado").Value
        Return res
    End Function
End Class
