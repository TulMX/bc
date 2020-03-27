Public Class Empleado
    Inherits System.Web.UI.Page
    Private Mae As clsMaestra
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Mae = Session("Maestra")
        Acceso(Mae, Page)
        'For Each S As String In Request.QueryString
        '    MsgBox(S)
        'Next
        Dim K As String = Request.QueryString("K")
        Dim T As New DataTable
        Mae.Con.CargarTabla("SELECT * FROM CAT_EMPLEADOS WHERE K_EMPLEADO='" & K & "'", "", T)
        If T.Rows.Count > 0 Then
            Dim R As DataRow = T(0)
            K_EMPLEADO.Text = R("K_EMPLEADO")
            CEM_DEPTO.Text = R("CEM_DEPTO")
            CEM_NOMBRE.Text = R("CEM_NOMBRE")
        End If
    End Sub



End Class