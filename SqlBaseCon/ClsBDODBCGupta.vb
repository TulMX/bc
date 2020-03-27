Public Class ClsODBCSQLGupta

    'Public Coman As Odbc.OdbcCommand
    'Public Conexion As New Odbc.OdbcConnection
    'Public Mensajes As Boolean


    'Public Function CrearConexion(ByVal Usuario As String, ByVal Contraseña As String, ByVal BasedeDatos As String) As Boolean
    '    Try
    '        'Creando la conexion con la Base de Datos
    '        Conexion.ConnectionString = "Dsn=GUPTA;db=SICP;uid=LOTES;isolevel=RL;Autocommit = True"
    '        Conexion.Open()
    '        Coman = Conexion.CreateCommand
    '        Return True
    '    Catch ex As Exception
    '        MsgBox("No es posible conectarse con el servidor, " & ex.Message)
    '        Return False
    '    End Try
    'End Function

    'Public Sub MostrarComando(ByVal Mostrar As String)
    '    Dim f As New FrmMostrarComando
    '    f.Mostrar = Mostrar
    '    f.ShowDialog()
    'End Sub

    'Public Function CrearTabla(ByVal Comando As String, ByVal NombreFormulario As String) As DataTable
    '    'Funcion que crea una tabla en base al comando de consulta
    '    Dim tabla As New DataTable
    '    Dim adap As New Odbc.OdbcDataAdapter
    '    Coman.CommandText = Comando
    '    adap.SelectCommand = Coman
    '    If Mensajes = True Then
    '        MostrarComando(Comando)
    '    End If
    '    Try
    '        adap.Fill(tabla)
    '        CrearTabla = tabla
    '    Catch ex As Exception
    '        MsgBox("Err" & NombreFormulario & "," & ex.Message)
    '        CrearTabla = tabla
    '    End Try
    'End Function

    'Public Function EnviarComando(ByVal Comando As String, ByVal NombreFormulario As String) As Boolean
    '    'Funcion que crea una tabla en base al comando de consulta
    '    Dim tabla As New DataTable
    '    Dim adap As New Odbc.OdbcDataAdapter
    '    Coman.CommandText = Comando
    '    adap.SelectCommand = Coman
    '    If Mensajes = True Then
    '        MostrarComando(Comando)
    '    End If
    '    Try
    '        adap.Fill(tabla)
    '        EnviarComando = True
    '    Catch ex As Exception
    '        MsgBox("Err" & NombreFormulario & "," & ex.Message)
    '        EnviarComando = False
    '    End Try
    'End Function

    'Public Function CargarTabla(ByVal Comando As String, ByVal Nombredelfrm As String, ByVal Tabla As DataTable) As Boolean
    '    'Funcion que carga una tabla basada en el comando
    '    Dim adap As New Odbc.OdbcDataAdapter
    '    Coman.CommandText = Comando
    '    adap.SelectCommand = Coman
    '    If Mensajes = True Then
    '        MostrarComando(Comando)
    '    End If
    '    Try
    '        adap.Fill(Tabla)
    '        CargarTabla = True
    '    Catch ex As Exception
    '        MsgBox("Err" & Nombredelfrm & "," & ex.Message)
    '        MostrarComando(Comando)
    '        CargarTabla = False
    '    End Try
    'End Function




    'Public Function CargarFila(ByVal Comando As String, ByVal Nombredelfrm As String) As DataRow
    '    'Funcion que carga la primera fila de un consulta
    '    Dim adap As New Odbc.OdbcDataAdapter
    '    Dim tabla As New DataTable
    '    Coman.CommandText = Comando
    '    adap.SelectCommand = Coman
    '    If Mensajes = True Then
    '        MostrarComando(Comando)
    '    End If
    '    Try
    '        adap.Fill(tabla)
    '        If tabla.Rows.Count > 1 Then
    '            MsgBox("Hay inconsistencia en los datos apareciendo mas de un registro similar")
    '        End If
    '        If tabla.Rows.Count = 0 Then
    '            MsgBox("Err" & Nombredelfrm & ",No se encontraron filas")
    '            CargarFila = tabla.NewRow
    '        End If
    '        CargarFila = tabla.Rows(0)
    '    Catch ex As Exception
    '        MsgBox("Err" & Nombredelfrm & "," & ex.Message)
    '        CargarFila = tabla.NewRow
    '    End Try
    'End Function

    'Public Function CargarCeldaString(ByVal Comando As String, ByVal Nombredelfrm As String) As String
    '    'Funcion que carga la primera fila de un consulta
    '    Dim adap As New Odbc.OdbcDataAdapter
    '    Dim tabla As New DataTable
    '    Coman.CommandText = Comando
    '    adap.SelectCommand = Coman
    '    If Mensajes = True Then
    '        MostrarComando(Comando)
    '    End If
    '    Try
    '        adap.Fill(tabla)
    '        If tabla.Rows.Count = 0 Then
    '            MsgBox("Err" & Nombredelfrm & ",No se encontraron filas")
    '            CargarCeldaString = " "
    '        End If
    '        Dim L As DataRow
    '        L = tabla.Rows(0)
    '        CargarCeldaString = Trim(L(0))
    '    Catch ex As Exception
    '        MsgBox("Err" & Nombredelfrm & "," & ex.Message)
    '        CargarCeldaString = " "
    '    End Try
    'End Function

    'Public Function CargarCeldaDateTime(ByVal Comando As String, ByVal Nombredelfrm As String) As Date
    '    'Funcion que carga la primera fila de un consulta
    '    Dim adap As New Odbc.OdbcDataAdapter
    '    Dim tabla As New DataTable
    '    Coman.CommandText = Comando
    '    adap.SelectCommand = Coman
    '    If Mensajes = True Then
    '        MostrarComando(Comando)
    '    End If
    '    Try
    '        adap.Fill(tabla)
    '        If tabla.Rows.Count = 0 Then
    '            MsgBox("Err" & Nombredelfrm & ",No se encontraron filas")
    '            CargarCeldaDateTime = Now
    '        End If
    '        Dim L As DataRow
    '        L = tabla.Rows(0)
    '        CargarCeldaDateTime = Trim(L(0))
    '    Catch ex As Exception
    '        MsgBox("Err" & Nombredelfrm & "," & ex.Message)
    '        CargarCeldaDateTime = Now
    '    End Try
    'End Function


    'Public Function ObtenerFechadelServidor() As DateTime
    '    'Funcion que carga la primera fila de un consulta
    '    Dim adap As New Odbc.OdbcDataAdapter
    '    Dim tabla As New DataTable
    '    Coman.CommandText = "Select GetDate()"
    '    adap.SelectCommand = Coman
    '    If Mensajes = True Then
    '        MostrarComando(Coman.CommandText)
    '    End If
    '    Try
    '        adap.Fill(tabla)
    '        If tabla.Rows.Count = 0 Then
    '            MsgBox("Err" & "ObtenerFechadelServidor" & ",No se encontraron filas")
    '        End If
    '        Dim L As DataRow
    '        L = tabla.Rows(0)
    '        ObtenerFechadelServidor = L(0)
    '    Catch ex As Exception
    '        MsgBox("Err" & "ObtenerFechadelServidor" & "," & ex.Message)
    '        ObtenerFechadelServidor = Now
    '    End Try
    'End Function

    'Public Function CargarCeldaInteger(ByVal Comando As String, ByVal Nombredelfrm As String) As Long
    '    'Funcion que carga la primera fila de un consulta
    '    Dim adap As New Odbc.OdbcDataAdapter
    '    Dim tabla As New DataTable
    '    Coman.CommandText = Comando
    '    adap.SelectCommand = Coman
    '    If Mensajes = True Then
    '        MostrarComando(Comando)
    '    End If
    '    Try
    '        adap.Fill(tabla)
    '        If tabla.Rows.Count = 0 Then
    '            MsgBox("Err" & Nombredelfrm & ",No se encontraron filas")
    '            CargarCeldaInteger = " "
    '        End If
    '        Dim L As DataRow
    '        L = tabla.Rows(0)
    '        CargarCeldaInteger = L(0)
    '    Catch ex As Exception
    '        MsgBox("Err" & Nombredelfrm & "," & ex.Message)
    '        CargarCeldaInteger = 0
    '    End Try
    'End Function

    'Public Function CargarCeldaDouble(ByVal Comando As String, ByVal Nombredelfrm As String) As Double
    '    'Funcion que carga la primera fila de un consulta
    '    Dim adap As New Odbc.OdbcDataAdapter
    '    Dim tabla As New DataTable
    '    Coman.CommandText = Comando
    '    adap.SelectCommand = Coman
    '    If Mensajes = True Then
    '        MostrarComando(Comando)
    '    End If
    '    Try
    '        adap.Fill(tabla)
    '        If tabla.Rows.Count = 0 Then
    '            MsgBox("Err" & Nombredelfrm & ",No se encontraron filas")
    '            CargarCeldaDouble = " "
    '        End If
    '        Dim L As DataRow
    '        L = tabla.Rows(0)
    '        CargarCeldaDouble = L(0)
    '    Catch ex As Exception
    '        MsgBox("Err" & Nombredelfrm & "," & ex.Message)
    '        CargarCeldaDouble = " "
    '    End Try
    'End Function


    'Public Function EjecutarProcedimiento(ByVal Nombre As String, ByVal ParamArray Parametros() As String) As Boolean
    '    'funcion que ejecuta un procedimiento almacenado
    '    If Parametros.Length <= 0 Then
    '        EjecutarProcedimiento = False
    '        Exit Function
    '    End If
    '    Dim comando As String
    '    comando = "Exec " & Nombre & " "
    '    comando = comando & "@" & Parametros(0) & "=" & Parametros(1) & " "
    '    Dim i As Integer
    '    For i = 2 To UBound(Parametros) Step +2
    '        If Not (IsNumeric(Parametros(i + 1))) Then
    '            Parametros(i + 1) = "'" & Parametros(i + 1) & "'"
    '        End If
    '        comando = comando & ",@" & Parametros(i) & "=" & Parametros(i + 1) & " "
    '    Next
    '    'MostrarComando(Comando)
    '    EjecutarProcedimiento = EnviarComando(comando, Nombre)
    'End Function

    'Public Function EjecutarProcedimientoMejorado(ByVal Nombre As String, ByVal ParamArray Parametros() As String) As Boolean
    '    'funcion que ejecuta un procedimiento almacenado
    '    If Parametros.Length <= 0 Then
    '        EjecutarProcedimientoMejorado = False
    '        Exit Function
    '    End If
    '    Dim comando As String
    '    comando = "Exec " & Nombre & " "
    '    comando = comando & "@" & Parametros(0) & "=" & Parametros(1) & " "
    '    Dim i As Integer
    '    For i = 2 To UBound(Parametros) Step +2
    '        comando = comando & ",@" & Parametros(i) & "=" & Parametros(i + 1) & " "
    '    Next
    '    'MostrarComando(Comando)
    '    EjecutarProcedimientoMejorado = EnviarComando(comando, Nombre)
    'End Function


    'Public Function EjecutarProcedimientoTextosConelPrimeroID(ByVal Nombre As String, ByVal ParamArray Parametros() As String) As Boolean
    '    'funcion que ejecuta un procedimiento almacenado
    '    If Parametros.Length <= 0 Then
    '        EjecutarProcedimientoTextosConelPrimeroID = False
    '        Exit Function
    '    End If
    '    Dim comando As String
    '    comando = "Exec " & Nombre & " "
    '    comando = comando & "@" & Parametros(0) & "=" & Parametros(1) & " "
    '    Dim i As Integer
    '    For i = 2 To UBound(Parametros) Step +2
    '        Parametros(i + 1) = "'" & Parametros(i + 1) & "'"
    '        comando = comando & ",@" & Parametros(i) & "=" & Parametros(i + 1) & " "
    '    Next
    '    'MostrarComando(Comando)
    '    EjecutarProcedimientoTextosConelPrimeroID = EnviarComando(comando, Nombre)
    'End Function

End Class
