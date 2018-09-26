Imports System.Data
Imports System.Data.SqlClient
Imports CapaEntidades

Public Class CtrServidorBD

    Public Function listarServidoresBD() As DataTable

        Dim con As clsConexion = clsConexion.Instance
        con.Conn.Open()

        Dim Com As New SqlCommand("listarBDs", con.Conn)
        Com.CommandType = CommandType.StoredProcedure

        Dim Result As SqlDataReader

        Dim Tabla As New DataTable

        con.ConexionBD.Open()

        Result = Com.ExecuteReader()

        Tabla.Load(Result)
        con.Conn.Close()

        Return Tabla
    End Function

End Class
