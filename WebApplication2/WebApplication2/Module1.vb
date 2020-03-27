Public Module Module1
    Public con As New SqlBaseCon.ClsBDGupta

    Public Sub Acceso(Mae As clsMaestra, Page As System.Web.UI.Page)
        If Mae.Loggeado = False Then
            Page.Response.Redirect("/Login.aspx", False)
        End If
    End Sub

    Public Sub MostrarTabla(dt As DataTable, Page As System.Web.UI.Page, ConEditar As Boolean)

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
        If ConEditar = True Then
            html.Append("<th>")
            html.Append("Editar")
            html.Append("</th>")
        End If
        html.Append("</tr>")

        'Building the Data rows.
        For Each row As DataRow In dt.Rows
            html.Append("<tr>")
            For Each column As DataColumn In dt.Columns
                html.Append("<td class=" & Chr(34) & "table table-dark" & Chr(34) & ">")
                html.Append(row(column.ColumnName))
                html.Append("</td>")
            Next
            If ConEditar = True Then
                html.Append("<td class=" & Chr(34) & "table table-dark" & Chr(34) & "><a href=" & Chr(34) & "Empleado.aspx?K=" & row("K_EMPLEADO") & Chr(34) & ">")
                html.Append("Editar")
                html.Append("</a></td>")
            End If
            html.Append("</tr>")
        Next

        'Table 
        html.Append("</table>")

        Page.Controls.Add(New Literal() With {
         .Text = html.ToString()
       })
    End Sub

End Module


