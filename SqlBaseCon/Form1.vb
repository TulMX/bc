Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As New ClsBDGupta
        If s.CrearConexion("192.11.11.3", "LOTES", "LOTES", "SICP") = False Then
            MsgBox(s.MensajesError)
        End If
        MsgBox(s.CargarCeldaInteger("SELECT COUNT(*) FROM CAT_FASES1RAETAPA", "PRUEBA"))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("alerta")
    End Sub
End Class
