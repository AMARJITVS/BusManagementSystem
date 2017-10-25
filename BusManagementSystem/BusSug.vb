Imports System.ComponentModel
Imports Oracle.DataAccess.Client

Public Class BusSug
    Dim listitems As String
    Dim Con As New OracleConnection("Data Source=ORCL;User ID=Amar;Password=amar")
    Dim selected As New List(Of String)
    Dim result As New List(Of String)
    Dim result1 As String
    Dim buffer As New List(Of String)
    Dim a, i, j As Integer

    Private Sub busnobs_MouseMove(sender As Object, e As MouseEventArgs) Handles busnobs.MouseMove
        listitems = ControlChars.CrLf
        For i = 0 To (busnobs.Items.Count - 1)
            If busnobs.GetItemChecked(i) = True Then
                listitems = listitems & (i + 1).ToString & ControlChars.CrLf
            End If
        Next
        selectedbs.Text = listitems

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles backbs.Click
        Main.Show()
        Hide()
        busnobs.ClearSelected()
        selectedbs.Clear()
        resultbs.Clear()
    End Sub

    Private Sub exitsg_Click(sender As Object, e As EventArgs) Handles exitbs.Click
        Application.Exit()
    End Sub

    Private Sub okbs_Click(sender As Object, e As EventArgs) Handles okbs.Click
        Try
            resultbs.Clear()
            buffer.Clear()
            For i = 0 To busnobs.Items.Count - 1
                If busnobs.GetItemChecked(i) = True Then
                    buffer.Add(busnobs.Items(i).ToString)
                End If
            Next
            For i = 0 To buffer.Count - 1
                a = Integer.Parse(buffer.Item(i))
                Dim cmd As New OracleCommand("select stopid from busdetails where busno='" & a & "'", Con)

                Con.Open()
                Dim read As OracleDataReader = cmd.ExecuteReader()

                While read.Read()

                    selected.Add(read.GetValue(0))

                End While
                read.Close()
                Con.Close()
            Next
            selected = selected.Distinct().ToList


            For i = 0 To selected.Count - 1
                Dim cmd1 As New OracleCommand("select busno from busdetails where stopid='" & selected.Item(i) & "'", Con)
                Dim cmd2 As New OracleCommand("select stopname from stops where stopid='" & selected.Item(i) & "'", Con)
                Con.Open()
                Dim read As OracleDataReader = cmd1.ExecuteReader()
                result.Clear()
                While read.Read()

                    result.Add(read.GetValue(0))

                End While
                read.Close()
                Dim read1 As OracleDataReader = cmd2.ExecuteReader()
                While read1.Read()

                    result1 = read1.GetValue(0)

                End While
                read1.Close()
                Con.Close()
                For j = 0 To buffer.Count - 1
                    result.Remove(buffer.Item(j))
                    result.Remove("2")
                Next
                If result.Count = 0 Then

                    resultbs.Text = resultbs.Text + "Passengers going to """ & result1 & """ has NO ALTERNATIVES " & ControlChars.CrLf

                Else
                    resultbs.Text = resultbs.Text + "Passengers going to """ & result1 & """ can go to BUSNO: "
                    For j = 0 To result.Count - 1
                        resultbs.Text = resultbs.Text + result.Item(j).ToString() + " , "
                    Next
                    resultbs.Text = resultbs.Text & ControlChars.CrLf

                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message,, "ERROR!!!")
        End Try
    End Sub

    Private Sub busnobs_MouseClick(sender As Object, e As MouseEventArgs) Handles busnobs.MouseClick
        selected.Clear()
        result.Clear()
        selected.Clear()
        resultbs.Clear()
    End Sub

    Private Sub BusSug_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class