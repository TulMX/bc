﻿Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As New ClsBDGupta
        s.CrearConexion("192.11.11.3", "LOTES", "LOTES", "SICP")
        MsgBox(s.CargarCeldaInteger("SELECT COUNT(*) FROM CAT_FASES1RAETAPA", "PRUEBA"))
    End Sub

End Class
