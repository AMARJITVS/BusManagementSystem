Imports System.ComponentModel
Imports Oracle.DataAccess.Client
Public Class Fees
    Dim Con As New OracleConnection("Data Source=ORCL;User ID=Amar;Password=amar")
    Dim a, b, c As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Hide()
        clear()
    End Sub


    Private Sub feesbt_Click(sender As Object, e As EventArgs) Handles feesbt.Click
        clear()
        reftx.Text = ""
        If IsNumeric(rolltxt.Text) = False Then
            MsgBox("*Only numeric values accepted",, "ERROR!!!")
            rolltxt.Text = ""
        Else
            Try
                Dim cmdck As New OracleCommand("select count(*) from student where rollno='" + rolltxt.Text + "'", Con)
                cmdck.CommandType = CommandType.Text
                Con.Open()

                Dim readck As OracleDataReader = cmdck.ExecuteReader()

                If readck.Read() Then

                    a = readck.GetValue(0)

                    readck.Close()
                End If
                Con.Close()
                If a = 1 Then

                    Dim cmdst As New OracleCommand("select stopid from student where rollno='" + rolltxt.Text + "'", Con)
                Dim cmdn As New OracleCommand("select name from student where rollno='" + rolltxt.Text + "'", Con)
                Dim cmdy As New OracleCommand("select year from student where rollno='" + rolltxt.Text + "'", Con)
                Dim cmdd As New OracleCommand("select department from student where rollno='" + rolltxt.Text + "'", Con)
                cmdst.CommandType = CommandType.Text
                cmdn.CommandType = CommandType.Text
                cmdy.CommandType = CommandType.Text
                cmdd.CommandType = CommandType.Text

                Con.Open()

                Dim readn As OracleDataReader = cmdn.ExecuteReader()

                If readn.Read() Then

                    nametx.Text = readn.GetValue(0)

                    readn.Close()
                End If
                Dim ready As OracleDataReader = cmdy.ExecuteReader()

                If ready.Read() Then

                    yrtx.Text = ready.GetValue(0)

                    ready.Close()
                End If
                Dim readd As OracleDataReader = cmdd.ExecuteReader()

                If readd.Read() Then

                    depttx.Text = readd.GetValue(0)

                    readd.Close()
                End If
                Dim reads As OracleDataReader = cmdst.ExecuteReader()

                If reads.Read() Then

                    c = reads.GetValue(0)

                    reads.Close()
                End If
                Dim cmdstpn As New OracleCommand("select stopname from stops where stopid='" & c & "'", Con)
                Dim cmdf As New OracleCommand("select fees from stops where stopid='" & c & "'", Con)
                cmdstpn.CommandType = CommandType.Text
                cmdf.CommandType = CommandType.Text

                Dim readst As OracleDataReader = cmdstpn.ExecuteReader()

                If readst.Read() Then

                    stp.Text = readst.GetValue(0)

                    readst.Close()
                End If
                Dim readf As OracleDataReader = cmdf.ExecuteReader()

                If readf.Read() Then

                    feestx.Text = readf.GetValue(0)

                    readf.Close()
                End If
                Con.Close()
                    rolltxt.Text = ""
                Else
                    MsgBox("INCORRECT REG.NO !!!")
                    clear()
                End If

            Catch ex As Exception
                MsgBox(ex.Message.ToString())
            End Try


        End If
    End Sub

    Private Sub Fees_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub Fees_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "SEARCH"
    End Sub

    Private Sub refsr_Click(sender As Object, e As EventArgs) Handles refsr.Click
        Try
            rolltxt.Text = ""
            clear()
            Dim cmdck As New OracleCommand("select count(*) from student where sid='" + reftx.Text + "'", Con)
            cmdck.CommandType = CommandType.Text
            Con.Open()

            Dim readck As OracleDataReader = cmdck.ExecuteReader()

            If readck.Read() Then

                b = readck.GetValue(0)

                readck.Close()
            End If
            Con.Close()
            If b = 1 Then
                Dim cmdst As New OracleCommand("select stopid from student where sid='" + reftx.Text + "'", Con)
                Dim cmdn As New OracleCommand("select name from student where sid='" + reftx.Text + "'", Con)
                Dim cmdy As New OracleCommand("select year from student where sid='" + reftx.Text + "'", Con)
                Dim cmdd As New OracleCommand("select department from student where sid='" + reftx.Text + "'", Con)
                cmdst.CommandType = CommandType.Text
                cmdn.CommandType = CommandType.Text
                cmdy.CommandType = CommandType.Text
                cmdd.CommandType = CommandType.Text

                Con.Open()

                Dim readn As OracleDataReader = cmdn.ExecuteReader()

                If readn.Read() Then

                    nametx.Text = readn.GetValue(0)

                    readn.Close()
                End If
                Dim ready As OracleDataReader = cmdy.ExecuteReader()

                If ready.Read() Then

                    yrtx.Text = ready.GetValue(0)

                    ready.Close()
                End If
                Dim readd As OracleDataReader = cmdd.ExecuteReader()

                If readd.Read() Then

                    depttx.Text = readd.GetValue(0)

                    readd.Close()
                End If
                Dim reads As OracleDataReader = cmdst.ExecuteReader()

                If reads.Read() Then

                    c = reads.GetValue(0)

                    reads.Close()
                End If
                Dim cmdstpn As New OracleCommand("select stopname from stops where stopid='" & c & "'", Con)
                Dim cmdf As New OracleCommand("select fees from stops where stopid='" & c & "'", Con)
                cmdstpn.CommandType = CommandType.Text
                cmdf.CommandType = CommandType.Text

                Dim readst As OracleDataReader = cmdstpn.ExecuteReader()

                If readst.Read() Then

                    stp.Text = readst.GetValue(0)

                    readst.Close()
                End If
                Dim readf As OracleDataReader = cmdf.ExecuteReader()

                If readf.Read() Then

                    feestx.Text = readf.GetValue(0)

                    readf.Close()
                End If
                Con.Close()
                reftx.Text = ""
            Else
                MsgBox("INVALID REF.ID !!!")
                clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub
    Private Sub clear()
        nametx.Text = ""
        yrtx.Text = ""
        depttx.Text = ""
        feestx.Text = ""
        stp.Text = ""
    End Sub
End Class