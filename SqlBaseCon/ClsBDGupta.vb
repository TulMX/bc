Imports Gupta

Public Class ClsBDGupta
    Public Coman As New Gupta.SQLBase.Data.SQLBaseCommand
    Public Conexion As New Gupta.SQLBase.Data.SQLBaseConnection
    Public Mensajes As Boolean
    Public MensajesError As String = ""

    Public Function ObtenerFechaParaGUPTA(ByVal Fecha As Date) As Date
        Return Fecha
    End Function

    Public Function CrearConexion(ByVal DataSource As String, ByVal Usuario As String, ByVal Contraseña As String, ByVal BasedeDatos As String) As Boolean
        Try
            'Creando la conexion con la Base de Datos}
            'Conexion.ConnectionString = "DataSource=192.11.11.3;UserId=LOTES;Password=LOTES;"
            'Conexion.ChangeDatabase("SICP")
            Conexion.ConnectionString = "DataSource=" & DataSource & ";db=" & BasedeDatos & ";uid=" & Usuario & "; pwd =" & Contraseña & ";Autocommit = True;Isolevel=RL"
            Conexion.Open()
            Coman = Conexion.CreateCommand
            Return True
        Catch ex As Exception
            MensajesError = ex.Message
            Return False
        End Try
    End Function

    Public Sub Commits()
        'Funcion que crea una tabla en base al comando de consulta
        Dim tabla As New DataTable
        Dim adap As New Gupta.SQLBase.Data.SQLBaseDataAdapter
        Coman.CommandText = "Commit"
        adap.SelectCommand = Coman
        If Mensajes = True Then
            'MostrarComando(Comando)
        End If
        Try
            adap.Fill(tabla)
        Catch mes As Exception
            MensajesError = mes.Message
        End Try
    End Sub


    Public Sub FinalizarConexion()
        Conexion.Close()
    End Sub

    Public Function CrearTabla(ByVal Comando As String, ByVal NombreFormulario As String) As DataTable
        'Funcion que crea una tabla en base al comando de consulta
        Dim tabla As New DataTable
        Dim adap As New Gupta.SQLBase.Data.SQLBaseDataAdapter
        Coman.CommandText = Comando
        adap.SelectCommand = Coman
        If Mensajes = True Then
            'MostrarComando(Comando)
        End If
        Try
            adap.Fill(tabla)
            CrearTabla = tabla
        Catch ex As Exception
            MensajesError = ex.Message
            CrearTabla = tabla
        End Try
    End Function

    Public Function EnviarComando(ByVal Comando As String, ByVal NombreFormulario As String) As Boolean
        'Funcion que crea una tabla en base al comando de consulta
        Dim tabla As New DataTable
        Dim adap As New Gupta.SQLBase.Data.SQLBaseDataAdapter
        Coman.CommandText = Comando
        adap.SelectCommand = Coman
        If Mensajes = True Then
            'MostrarComando(Comando)
        End If
        Try
            adap.Fill(tabla)
            Commits()
            EnviarComando = True
        Catch ex As Exception
            MensajesError = ex.Message
            'MostrarComando(Comando)
            EnviarComando = False
        End Try
    End Function


    Public Sub MostrarComando(ByVal Mostrar As String)
        'Dim f As New FrmMostrarComando
        'f.Mostrar = Mostrar
        'f.ShowDialog()
    End Sub

    Public Function CargarTabla(ByVal Comando As String, ByVal Nombredelfrm As String, ByVal Tabla As DataTable) As Boolean
        'Funcion que carga una tabla basada en el comando
        Dim adap As New Gupta.SQLBase.Data.SQLBaseDataAdapter
        Coman.CommandText = Comando
        adap.SelectCommand = Coman
        If Mensajes = True Then
            'MostrarComando(Comando)
        End If
        Try
            adap.Fill(Tabla)
            CargarTabla = True
        Catch ex As Exception
            MensajesError = ex.Message
            CargarTabla = False
        End Try
    End Function

    Public Function CargarFila(ByVal Comando As String, ByVal Nombredelfrm As String) As DataRow
        'Funcion que carga la primera fila de un consulta
        Dim adap As New Gupta.SQLBase.Data.SQLBaseDataAdapter
        Dim tabla As New DataTable
        Coman.CommandText = Comando
        adap.SelectCommand = Coman
        If Mensajes = True Then
            'MostrarComando(Comando)
        End If
        Try
            adap.Fill(tabla)
            If tabla.Rows.Count > 1 Then
                MsgBox("Hay inconsistencia en los datos apareciendo mas de un registro similar")
            End If
            If tabla.Rows.Count = 0 Then
                MsgBox("Err" & Nombredelfrm & ",No se encontraron filas")
                CargarFila = tabla.NewRow
            End If
            CargarFila = tabla.Rows(0)
        Catch ex As Exception
            MensajesError = ex.Message
            CargarFila = tabla.NewRow
        End Try
    End Function

    Public Function CargarCeldaString(ByVal Comando As String, ByVal Nombredelfrm As String) As String
        'Funcion que carga la primera fila de un consulta
        Dim adap As New Gupta.SQLBase.Data.SQLBaseDataAdapter
        Dim tabla As New DataTable
        Coman.CommandText = Comando
        adap.SelectCommand = Coman
        If Mensajes = True Then
            'MostrarComando(Comando)
        End If
        Try
            adap.Fill(tabla)
            If tabla.Rows.Count = 0 Then
                MsgBox("Err" & Nombredelfrm & ",No se encontraron filas")
                CargarCeldaString = " "
            End If
            Dim L As DataRow
            L = tabla.Rows(0)
            CargarCeldaString = Trim(L(0))
        Catch ex As Exception
            MensajesError = ex.Message
            CargarCeldaString = " "
        End Try
    End Function

    Public Function CargarCeldaDateTime(ByVal Comando As String, ByVal Nombredelfrm As String) As Date
        'Funcion que carga la primera fila de un consulta
        Dim adap As New Gupta.SQLBase.Data.SQLBaseDataAdapter
        Dim tabla As New DataTable
        Coman.CommandText = Comando
        adap.SelectCommand = Coman
        If Mensajes = True Then
            'MostrarComando(Comando)
        End If
        Try
            adap.Fill(tabla)
            If tabla.Rows.Count = 0 Then
                MsgBox("Err" & Nombredelfrm & ",No se encontraron filas")
                CargarCeldaDateTime = Now
            End If
            Dim L As DataRow
            L = tabla.Rows(0)
            CargarCeldaDateTime = Trim(L(0))
        Catch ex As Exception
            MensajesError = ex.Message
            CargarCeldaDateTime = Now
        End Try
    End Function


    Public Function ObtenerFechadelServidor() As DateTime
        'Funcion que carga la primera fila de un consulta
        Dim adap As New Gupta.SQLBase.Data.SQLBaseDataAdapter
        Dim tabla As New DataTable
        Coman.CommandText = "Select GetDate()"
        adap.SelectCommand = Coman
        If Mensajes = True Then
            'MostrarComando(Coman.CommandText)
        End If
        Try
            adap.Fill(tabla)
            If tabla.Rows.Count = 0 Then
                MsgBox("Err" & "ObtenerFechadelServidor" & ",No se encontraron filas")
            End If
            Dim L As DataRow
            L = tabla.Rows(0)
            ObtenerFechadelServidor = L(0)
        Catch ex As Exception
            MensajesError = ex.Message
            ObtenerFechadelServidor = Now
        End Try
    End Function

    Public Function CargarCeldaInteger(ByVal Comando As String, ByVal Nombredelfrm As String) As Long
        'Funcion que carga la primera fila de un consulta
        Dim adap As New Gupta.SQLBase.Data.SQLBaseDataAdapter
        Dim tabla As New DataTable
        Coman.CommandText = Comando
        adap.SelectCommand = Coman
        If Mensajes = True Then
            'MostrarComando(Comando)
        End If
        Try
            adap.Fill(tabla)
            If tabla.Rows.Count = 0 Then
                MsgBox("Err" & Nombredelfrm & ",No se encontraron filas")
                CargarCeldaInteger = " "
            End If
            Dim L As DataRow
            L = tabla.Rows(0)
            CargarCeldaInteger = L(0)
        Catch ex As Exception
            MensajesError = ex.Message
            CargarCeldaInteger = 0
        End Try
    End Function

    Public Function CargarCeldaDouble(ByVal Comando As String, ByVal Nombredelfrm As String) As Double
        'Funcion que carga la primera fila de un consulta
        Dim adap As New Gupta.SQLBase.Data.SQLBaseDataAdapter
        Dim tabla As New DataTable
        Coman.CommandText = Comando
        adap.SelectCommand = Coman
        If Mensajes = True Then
            'MostrarComando(Comando)
        End If
        Try
            adap.Fill(tabla)
            If tabla.Rows.Count = 0 Then
                MsgBox("Err" & Nombredelfrm & ",No se encontraron filas")
                CargarCeldaDouble = " "
            End If
            Dim L As DataRow
            L = tabla.Rows(0)
            CargarCeldaDouble = L(0)
        Catch ex As Exception
            MensajesError = ex.Message

            CargarCeldaDouble = 0
        End Try
    End Function


    Public Function EjecutarProcedimiento(ByVal Nombre As String, ByVal ParamArray Parametros() As String) As Boolean
        'funcion que ejecuta un procedimiento almacenado
        If Parametros.Length <= 0 Then
            EjecutarProcedimiento = False
            Exit Function
        End If
        Dim comando As String
        comando = "Exec " & Nombre & " "
        comando = comando & "@" & Parametros(0) & "=" & Parametros(1) & " "
        Dim i As Integer
        For i = 2 To UBound(Parametros) Step +2
            If Not (IsNumeric(Parametros(i + 1))) Then
                Parametros(i + 1) = "'" & Parametros(i + 1) & "'"
            End If
            comando = comando & ",@" & Parametros(i) & "=" & Parametros(i + 1) & " "
        Next
        'MostrarComando(Comando)
        EjecutarProcedimiento = EnviarComando(comando, Nombre)
        Commits()
    End Function

    Public Function EjecutarProcedimientoMejorado(ByVal Nombre As String, ByVal ParamArray Parametros() As String) As Boolean
        'funcion que ejecuta un procedimiento almacenado
        If Parametros.Length <= 0 Then
            EjecutarProcedimientoMejorado = False
            Exit Function
        End If
        Dim comando As String
        comando = "Exec " & Nombre & " "
        comando = comando & "@" & Parametros(0) & "=" & Parametros(1) & " "
        Dim i As Integer
        For i = 2 To UBound(Parametros) Step +2
            comando = comando & ",@" & Parametros(i) & "=" & Parametros(i + 1) & " "
        Next
        'MostrarComando(Comando)
        EjecutarProcedimientoMejorado = EnviarComando(comando, Nombre)
        Commits()
    End Function


    Public Function EjecutarProcedimientoTextosConelPrimeroID(ByVal Nombre As String, ByVal ParamArray Parametros() As String) As Boolean
        'funcion que ejecuta un procedimiento almacenado
        If Parametros.Length <= 0 Then
            EjecutarProcedimientoTextosConelPrimeroID = False
            Exit Function
        End If
        Dim comando As String
        comando = "Exec " & Nombre & " "
        comando = comando & "@" & Parametros(0) & "=" & Parametros(1) & " "
        Dim i As Integer
        For i = 2 To UBound(Parametros) Step +2
            Parametros(i + 1) = "'" & Parametros(i + 1) & "'"
            comando = comando & ",@" & Parametros(i) & "=" & Parametros(i + 1) & " "
        Next
        'MostrarComando(Comando)
        EjecutarProcedimientoTextosConelPrimeroID = EnviarComando(comando, Nombre)
        Commits()
    End Function
End Class
