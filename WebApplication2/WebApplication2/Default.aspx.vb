Imports System.Data
Imports System.Text
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms
Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub IniciarConexion_Click(sender As Object, e As EventArgs) Handles IniciarConexion.Click
        con = New SqlBaseCon.ClsBDGupta
        'If con.CrearConexion("192.11.11.3", "SYSADM", "panasoni", "SICP") = False Then
        If con.CrearConexion("192.11.11.3", "LOTES", "LOTES", "SICP") = False Then
            Detalles.Text = con.MensajesError
            Exit Sub
        End If
        Detalles.Text = "Ok conectado."
        'AGREGAMOS UN BOTON
        'Dim BOT As New Button
        'BOT.Text = "HOLA"
        'BOT.Page = Page
        'Page.Controls.Add(BOT)
        'If Not Me.IsPostBack Then
        'Populating a DataTable from database.
        Dim dt As New DataTable ' = Me.GetData()
        dt.Columns.Add("CustomerId", GetType(String))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Country", GetType(String))
        ''html.Append(vbCrLf)
        ''html.Append("<div>")
        ''html.Append("<Button ID=" & Chr(34) & "InicarCon2" & Chr(34) & "runat=" & Chr(34) & "server" & Chr(34) & " Text=" & Chr(34) & "IniciarConexion" & Chr(34) & " />")
        ''html.Append(vbCrLf)
        ''html.Append("</div>")
        'Append the HTML string to Placeholder.
        'MostrarTabla(dt)
        'End If
        texto.Visible = True
        Button2.Visible = True
    End Sub

    Public Sub MostrarTabla(dt As DataTable)

        'Building an HTML string.
        Dim html As New StringBuilder()

        'Table start.
        html.Append("<table bgcolor=" & Chr(34) & "#3366FF" & Chr(34) & "  border = '1'>")

        'Building the Header row.
        html.Append("<tr>")
        For Each column As DataColumn In dt.Columns
            html.Append("<th>")
            html.Append(column.ColumnName)
            html.Append("</th>")
        Next
        html.Append("</tr>")

        'Building the Data rows.
        For Each row As DataRow In dt.Rows
            html.Append("<tr>")
            For Each column As DataColumn In dt.Columns
                html.Append("<td class=" & Chr(34) & "table table-dark" & Chr(34) & ">")
                html.Append(row(column.ColumnName))
                html.Append("</td>")
            Next
            html.Append("</tr>")
        Next

        'Table 
        html.Append("</table>")

        Page.Controls.Add(New Literal() With {
         .Text = html.ToString()
       })
    End Sub


    Private Function GetData() As DataTable
        Dim constr As String = ConfigurationManager.ConnectionStrings("constr").ConnectionString
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("SELECT CustomerId, Name, Country FROM Customers")
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        Return dt
                    End Using
                End Using
            End Using
        End Using
    End Function

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        '    coman.CommandText = "SELECT COUNT(*) FROM CAT_FASES1RAETAPA"
        '    Dim adap As New Gupta.SQLBase.Data.SQLBaseDataAdapter
        '    adap.SelectCommand = coman
        '    Dim t As New DataTable
        '    adap.Fill(t)
        '    etiqueta.Text = t.Rows(0)(0)
        'Catch ex As Exception
        '    etiqueta.Text = ex.Message
        'End Try
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim t As New DataTable

        con.CargarTabla("SELECT * FROM " & texto.Text, "", t)
        MostrarTabla(t)

    End Sub
End Class