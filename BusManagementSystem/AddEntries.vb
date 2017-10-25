Imports System.ComponentModel
Imports Oracle.DataAccess.Client

Public Class AddEntries

    Dim Con As New OracleConnection("Data Source=ORCL;User ID=Amar;Password=amar")

    Dim table As New DataTable
    Dim sid As String
    Dim names As String
    Dim Roll As Integer
    Dim Dept As String
    Dim yr As Integer
    Dim sec As String
    Dim bus As Integer
    Dim stpid As Integer
    Dim gen As String
    Dim addrs As String

    Private Sub AddEntries_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "ADDING MEMBERS"
        StudentPanel.Show()
        FacultyPanel.Hide()

        Dim cmd As New OracleCommand("Select * from STOPS order by STOPNAME", Con)

        Dim adapter As New OracleDataAdapter(cmd)

        adapter.Fill(table)

        stops.DataSource = table

        stops.DisplayMember = "StopName"

        stops.ValueMember = "StopID"

        stopfac.DataSource = table

        stopfac.DisplayMember = "StopName"

        stopfac.ValueMember = "StopID"
        If busfac.Items.Count > 0 Then
            busfac.SelectedIndex = 0
        End If
        If busno.Items.Count > 0 Then
            busno.SelectedIndex = 0
        End If
        If section.Items.Count > 0 Then
            section.SelectedIndex = 0
        End If

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Main.Show()
        Hide()
        For Each txt In {namefa, rollfa, addfa}
            txt.Clear()
        Next
        deptfa.SelectedIndex = -1
        genfa.SelectedIndex = -1
        busfac.SelectedIndex = -1
        stopfac.SelectedIndex = -1
    End Sub

    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click

        Try
            If busno.SelectedItem.ToString() = "NONE" Then
                bus = 0
            Else
                bus = Integer.Parse(busno.SelectedItem.ToString())
            End If

            If section.SelectedItem.ToString() = "NONE" Then
                sec = "-"
            Else
                sec = section.SelectedItem.ToString()
            End If
            sid = Refs.Text
            names = namebox.Text
            Roll = Integer.Parse(rollno.Text)
            Dept = department.SelectedItem.ToString()
            yr = Integer.Parse(year.SelectedItem.ToString())
            stpid = stops.SelectedValue
            gen = gender.SelectedItem.ToString()
            addrs = address.Text
            If addrs = "" Then
                addrs = "No Address"
            End If

            Dim cmd1 As New OracleCommand("INSERT INTO Student VALUES('" & names & "','" & Roll & "','" & yr & "','" & Dept & "','" & sec & "','" & gen & "','" & bus & "','" & stpid & "','" & addrs & "','" & sid & "')", Con)

            cmd1.CommandType = CommandType.Text

            Con.Open()

            cmd1.ExecuteNonQuery()

            MsgBox("Record Inserted",, "INFO")

            For Each txt In {namebox, rollno, address, Refs}
                txt.Clear()
            Next
            department.SelectedIndex = -1
            year.SelectedIndex = -1
            gender.SelectedIndex = -1
            section.SelectedIndex = 0
            busno.SelectedIndex = 0
            stops.SelectedIndex = 0

        Catch ex As Exception

            If ex.Message = "Input string was not in a correct format." Or ex.Message = "Object reference not set to an instance of an object." Or ex.Message = "ORA-01400: cannot insert NULL into (""AMAR"".""STUDENT"".""SID"")" Then

                MessageBox.Show("INSERTION INVALID", "ERROR!!!")


            ElseIf ex.Message = "ORA-00001: unique constraint (AMAR.STUDENT_PK) violated" Then

                MessageBox.Show("ENTER CORRECT ROLLNO", "ERROR!!!")

            Else

                MessageBox.Show("Error while inserting record on table..." & ex.Message, "ERROR!!!")

            End If
        Finally

            Con.Close()

        End Try

    End Sub

    Private Sub student_Click(sender As Object, e As EventArgs) Handles student.Click

        student.BackColor = Color.DeepSkyBlue
        faculty.BackColor = Color.Silver
        FacultyPanel.Hide()

        StudentPanel.Show()

    End Sub



    Private Sub rollno_MouseClick(sender As Object, e As MouseEventArgs) Handles rollno.MouseClick

        not1.Text = "Only enter numbers"

    End Sub

    Private Sub rollno_Validated(sender As Object, e As EventArgs) Handles rollno.Validated

        If IsNumeric(rollno.Text) = True Or rollno.Text = "" Then

        Else

            MessageBox.Show("* Only accepts numbers", "ERROR!!!")

            rollno.Text = ""

        End If

    End Sub

    Private Sub faculty_Click(sender As Object, e As EventArgs) Handles faculty.Click

        student.BackColor = Color.Silver
        faculty.BackColor = Color.DeepSkyBlue



        StudentPanel.Show()

        FacultyPanel.Show()

        FacultyPanel.BringToFront()

    End Sub

    Private Sub insertfa_Click(sender As Object, e As EventArgs) Handles insertfa.Click
        Try
            names = namefa.Text
            Roll = Integer.Parse(rollfa.Text)
            Dept = deptfa.SelectedItem.ToString()
            sid = Ref.Text
            If busfac.SelectedItem.ToString() = "NONE" Then
                bus = 0
            Else
                bus = Integer.Parse(busfac.SelectedItem.ToString())
            End If
            stpid = stopfac.SelectedValue
            gen = genfa.SelectedItem.ToString()
            addrs = addfa.Text
            If addrs = "" Then
                addrs = "No Address"
            End If
            Dim cmd2 As New OracleCommand("INSERT INTO Faculty VALUES('" & names & "','" & Roll & "','" & Dept & "','" & gen & "','" & bus & "','" & stpid & "','" & addrs & "','" & sid & "')", Con)

            cmd2.CommandType = CommandType.Text

            Con.Open()

            cmd2.ExecuteNonQuery()

            MsgBox("Record Inserted",, "INFO")
            For Each txt In {namefa, rollfa, addfa, Ref}
                txt.Clear()
            Next
            deptfa.SelectedIndex = -1
            genfa.SelectedIndex = -1
            busfac.SelectedIndex = 0
            stopfac.SelectedIndex = 0


        Catch ex As Exception

            If ex.Message = "Input string was not in a correct format." Or ex.Message = "Object reference not set to an instance of an object." Or ex.Message = "ORA-01400: cannot insert NULL into (""AMAR"".""STUDENT"".""SID"")" Then

                MessageBox.Show("INSERTION INVALID", "ERROR!!!")


            ElseIf ex.Message = "ORA-00001: unique constraint (AMAR.FACULTY_PK) violated" Then

                MessageBox.Show("ENTER CORRECT ROLLNO", "ERROR!!!")

            Else

                MessageBox.Show(ex.Message, "ERROR!!!")

            End If

        Finally

            Con.Close()

        End Try


    End Sub

    Private Sub rollfa_MouseClick(sender As Object, e As MouseEventArgs) Handles rollfa.MouseClick

        not2.Text = "Only enter numbers"

    End Sub

    Private Sub rollfa_Validated(sender As Object, e As EventArgs) Handles rollfa.Validated

        If IsNumeric(rollfa.Text) = True Or rollfa.Text = "" Then

        Else

            MessageBox.Show("* Only accepts numbers", "ERROR!!!")

            rollfa.Text = ""

        End If

    End Sub

    Private Sub ExitBut_Click(sender As Object, e As EventArgs) Handles ExitBut.Click
        Close()
    End Sub

    Private Sub AddEntries_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

End Class