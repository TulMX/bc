Public Class ConsultaTablas
    Inherits System.Web.UI.Page
    Private Mae As clsMaestra
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Mae = Session("Maestra")
        Acceso(Mae, Page)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Mae.Loggeado = True Then
            Dim t As New DataTable
            Mae.Con.CargarTabla("SELECT * FROM " & texto.Text, "", t)
            MostrarTabla(t, Page, True)
        End If
    End Sub

    Private Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles CerrarSesion.Click
        Mae.Loggeado = False
        Acceso(Mae, Page)
    End Sub
End Class