Imports System.Data.OleDb

Public Class Form4
    Const cmdtext As String = "Provider=Microsoft.ACE.OLEDB.12.0;data source=Database1.mdb"
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiDataGridView1.DataSource = BindingSource1
        GetData("SELECT * FROM Students")
    End Sub

    Sub GetData(selcmd As String)
        Try
            Dim odc As New OleDbConnection() With {
            .ConnectionString = cmdtext
        }
            odc.Open()
            Dim Adapter As New OleDbDataAdapter(selcmd, cmdtext)
            Dim cmdbuilder As New OleDbCommandBuilder()
            Dim table As New DataTable With {.Locale = Globalization.CultureInfo.InvariantCulture
                }
            Adapter.Fill(table)
            BindingSource1.DataSource = table
            ' 重置大小
            UiDataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)
            odc.Close()
        Catch f As OleDbException
            MsgBox("Fatal Error.")
        Finally
            MsgBox("Succeed.")
        End Try
    End Sub
End Class