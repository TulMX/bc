Public Class Login
    Inherits System.Web.UI.Page
    Private Ma As New clsMaestra
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub click(sender As Object, e As EventArgs) Handles b1.Click
        If Ma.IniciarConexion() = True Then
            'si ya nos conectamos con GUPTA
            'logeamos
            If Ma.Usuario.LOGEAR(Ma, inputEmail.Value, inputPassword.Value) = True Then
                'MsgBox("CONECTADO " & Ma.Usuario.CEM_NOMBRE)
                Session("Maestra") = Ma
                Response.Redirect("/ConsultaTablas.aspx", False)
            End If
        Else
                MsgBox("Fallo")
        End If
    End Sub
End Class