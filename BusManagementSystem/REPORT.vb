Imports Oracle.DataAccess.Client

Public Class REPORT
    Dim con As New OracleConnection("Data Source=orcl;User ID=Amar;Password=amar")
    Dim da As New OracleDataAdapter("select * from student", con)
    Dim da1 As New OracleDataAdapter("select * from faculty", con)
    Dim dt As New DataTable()
    Dim dt1 As New DataTable()
    Dim bs As New BindingSource()
    Dim bs1 As New BindingSource()
    Private Sub load_Click(sender As Object, e As EventArgs) Handles load.Click
        Try
            dt.Clear()
            dt1.Clear()
            da.Fill(dt)
            da1.Fill(dt1)
            bs.DataSource = dt
            DataGridView1.DataSource = bs
            da.Update(dt)
            bs1.DataSource = dt1
            DataGridView2.DataSource = bs1
            da1.Update(dt1)
        Catch ex As Exception
            MsgBox(ex.Message,, "ERROR!!!")
        End Try
    End Sub


End Class