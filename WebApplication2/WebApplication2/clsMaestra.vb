Public Class clsMaestra
    Public Con As SqlBaseCon.ClsBDGupta
    Public Usuario As New Usuario
    Public MensajeError As String = ""
    Public Loggeado As Boolean = False

    Public Function IniciarConexion() As Boolean
        Con = New SqlBaseCon.ClsBDGupta
        'If con.CrearConexion("192.11.11.3", "SYSADM", "panasoni", "SICP") = False Then
        If Con.CrearConexion("192.11.11.3", "LOTES", "LOTES", "SICP") = False Then
            MensajeError = Con.MensajesError
            Return False
        End If
        Return True
    End Function

End Class

Public Class Usuario
    Public K_EMPLEADO As String = ""
    Public K_EMPRESA As String = ""
    Public CEM_DEPTO As String = ""
    Public CEM_NOMBRE As String = ""

    Public Function LOGEAR(vMae As clsMaestra, vK_EMPLEADO As String, vPASS As String) As Boolean
        'BUSCAMOS K_EMPLEADO
        Dim TABLA As New DataTable
        If vMae.Con.CargarTabla("SELECT * FROM CAT_EMPLEADOS WHERE K_EMPLEADO =" & vK_EMPLEADO, "LOGEANDO", TABLA) = True Then
            If TABLA.Rows.Count = 1 Then
                'CHECAMOS CONTRASEÑA
                Dim R As DataRow = TABLA(0)
                If R("CEM_DEPTO") = vPASS Then
                    K_EMPLEADO = R("K_EMPLEADO")
                    K_EMPRESA = R("K_EMPRESA")
                    CEM_DEPTO = R("CEM_DEPTO")
                    CEM_NOMBRE = R("CEM_NOMBRE")
                    vMae.Loggeado = True
                    Return True
                End If
            End If
        End If
        Return False
    End Function


End Class