Imports System.ComponentModel
Imports Oracle.DataAccess.Client

Public Class StageReading

    Dim Con As New OracleConnection("Data Source=ORCL;User ID=Amar;Password=amar")
    Dim table, table1 As New DataTable
    Dim cmd As New OracleCommand("Select * from STOPS", Con)
    Dim cmds As New OracleCommand("Select count(*) from Student", Con)
    Dim ysr, dsr, ssr, gsr, stsr, bssr, dsrf, bssrf, stsrf, gsrf, finalsr, finalsrf, exp As String
    Dim countsr1 As Integer = 0
    Dim countsr2 As Integer = 0
    Dim countsrf1 As Integer = 0
    Dim countsrf2 As Integer = 0
    Dim counttot As Integer = 0
    Dim b As String = "-1"
    Dim totaln, counts, countf As Integer
    Dim value(5), valuef(5) As String
    Dim value1 As String = ""
    Dim valuef1 As String = ""


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles back.Click
        Main.Show()
        Hide()
        yearsr.SelectedIndex = -1
        deptsr.SelectedIndex = -1
        secsr.SelectedIndex = -1
        gensr.SelectedIndex = -1
        busr.SelectedIndex = -1
        stopsr.SelectedIndex = -1
        deptsrf.SelectedIndex = -1
        gensrf.SelectedIndex = -1
        bussrf.SelectedIndex = -1
        stopsrf.SelectedIndex = -1

    End Sub

    Private Sub exitsr_Click(sender As Object, e As EventArgs) Handles exitsr.Click
        Application.Exit()
    End Sub
    Public Sub totalstudents()
        totals.Text = ""
        cmds.CommandType = CommandType.Text
        Con.Open()
        Dim rd1 As OracleDataReader = cmds.ExecuteReader()
        If rd1.Read() Then
            counttot = rd1.GetValue(0)
            Con.Close()
            totals.Text = counttot.ToString()
        End If
        rd1.Close()
    End Sub
    Private Sub StageReading_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "STAGE READINGS"
        Dim adapter As New OracleDataAdapter(cmd)
        Dim adapter1 As New OracleDataAdapter(cmd)

        Dim dt As DataRow = table.NewRow()
        table.Rows.InsertAt(dt, 0)
        Dim dt1 As DataRow = table1.NewRow()
        table1.Rows.InsertAt(dt1, 0)

        adapter.Fill(table)
        adapter1.Fill(table1)

        stopsr.DataSource = table

        stopsr.DisplayMember = "StopName"

        stopsr.ValueMember = "StopID"

        stopsrf.DataSource = table1

        stopsrf.DisplayMember = "StopName"

        stopsrf.ValueMember = "StopID"

        stopsr.SelectedIndex = -1
        stopsrf.SelectedIndex = -1

    End Sub

    Private Sub countsr_Click(sender As Object, e As EventArgs) Handles countsr.Click

        Try
            value1 = ""
            ysr = yearsr.SelectedItem
            dsr = deptsr.SelectedItem
            ssr = secsr.SelectedItem
            bssr = busr.SelectedItem
            stsr = stopsr.SelectedIndex
            gsr = gensr.SelectedItem

            value(0) = check(ysr)
            value(1) = check(dsr)
            value(2) = check(ssr)
            value(3) = check(gsr)
            value(4) = check(bssr)
            value(5) = check(stsr)


            For i As Integer = 0 To 5

                value1 = value1 + value(i)

            Next
            'MsgBox("select count(*) from Student where " & value1)
            Dim cmd As New OracleCommand("select count(*) from STUDENT where " & value1, Con)
            cmd.CommandType = CommandType.Text
            Con.Open()
            Dim rd As OracleDataReader = cmd.ExecuteReader()
            If rd.Read() Then

                counts = rd.GetValue(0)
                Con.Close()
                txtsr.Text = counts.ToString()

            End If
            rd.Close()
            totaln = Integer.Parse(txtsr.Text) + Integer.Parse(txtsrf.Text)
            total.Text = totaln.ToString()

        Catch ex As Exception
            txtsr.Text = "0"
            total.Text = "0"
            If ex.Message = "ORA-00936: missing expression" Then
                MsgBox("INVALID SEARCH",, "INVALID")

            Else
                MsgBox(ex.Message,, "ERROR!!!")
            End If
        Finally
            Con.Close()
        End Try

    End Sub

    Private Function check(a As String) As String

        countsr2 = countsr2 + 1

        If a = "" Or a = b Or a = "0" Then
            finalsr = ""
        Else

            countsr1 = countsr1 + 1

            If countsr1 = 1 Then
                txtsr.Clear()
                If countsr2 = 1 Then

                    finalsr = "year='" & ysr & "'"

                ElseIf countsr2 = 2 Then

                    finalsr = "department='" & dsr & "'"

                ElseIf countsr2 = 3 Then

                    finalsr = "section='" & ssr & "'"

                ElseIf countsr2 = 4 Then

                    finalsr = "gender='" & gsr & "'"

                ElseIf countsr2 = 5 Then

                    finalsr = "busno='" & bssr & "'"


                ElseIf countsr2 = 6 Then

                    finalsr = "stopid='" & stsr & "'"

                End If

            Else

                If countsr2 = 1 Then

                    finalsr = " AND year='" & ysr & "'"

                ElseIf countsr2 = 2 Then

                    finalsr = " AND department='" & dsr & "'"

                ElseIf countsr2 = 3 Then

                    finalsr = " AND section='" & ssr & "'"

                ElseIf countsr2 = 4 Then

                    finalsr = " AND gender='" & gsr & "'"

                ElseIf countsr2 = 5 Then

                    finalsr = " AND busno='" & bssr & "'"


                ElseIf countsr2 = 6 Then

                    finalsr = " AND stopid='" & stsr & "'"

                End If

            End If

        End If
        If countsr2 = 6 Then
            countsr1 = 0
            countsr2 = 0
        End If

        Return finalsr

    End Function


    Private Sub busr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles busr.SelectedIndexChanged

        If busr.SelectedIndex = 0 Then
            busr.SelectedIndex = -1
        End If

    End Sub

    Private Sub yearsr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles yearsr.SelectedIndexChanged
        If yearsr.SelectedIndex = 0 Then
            yearsr.SelectedIndex = -1
        End If
    End Sub

    Private Sub deptsr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles deptsr.SelectedIndexChanged
        If deptsr.SelectedIndex = 0 Then
            deptsr.SelectedIndex = -1
        End If
    End Sub

    Private Sub secsr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles secsr.SelectedIndexChanged
        If secsr.SelectedIndex = 0 Then
            secsr.SelectedIndex = -1
        End If
    End Sub

    Private Sub gensr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gensr.SelectedIndexChanged
        If gensr.SelectedIndex = 0 Then
            gensr.SelectedIndex = -1
        End If
    End Sub

    Private Sub deptsrf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles deptsrf.SelectedIndexChanged
        If deptsrf.SelectedIndex = 0 Then
            deptsrf.SelectedIndex = -1
        End If
    End Sub

    Private Sub gensrf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gensrf.SelectedIndexChanged
        If gensrf.SelectedIndex = 0 Then
            gensrf.SelectedIndex = -1
        End If
    End Sub

    Private Sub bussrf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bussrf.SelectedIndexChanged
        If bussrf.SelectedIndex = 0 Then
            bussrf.SelectedIndex = -1
        End If
    End Sub

    Private Sub stopsrf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stopsrf.SelectedIndexChanged
        If stopsrf.SelectedIndex = 0 Then
            stopsrf.SelectedIndex = -1
        End If
    End Sub

    Private Sub countsrf_Click(sender As Object, e As EventArgs) Handles countsrf.Click
        Try
            valuef1 = ""
            dsrf = deptsrf.SelectedItem
            bssrf = bussrf.SelectedItem
            stsrf = stopsrf.SelectedIndex
            gsrf = gensrf.SelectedItem

            valuef(0) = check1(dsrf)
            valuef(1) = check1(gsrf)
            valuef(2) = check1(bssrf)
            valuef(3) = check1(stsrf)


            For i As Integer = 0 To 3

                valuef1 = valuef1 + valuef(i)

            Next
            Dim cmd1 As New OracleCommand("select count(*) from Faculty where " & valuef1, Con)
            cmd1.CommandType = CommandType.Text
            Con.Open()
            Dim rd1 As OracleDataReader = cmd1.ExecuteReader()
            If rd1.Read() Then

                countf = rd1.GetValue(0)
                Con.Close()
                txtsrf.Text = countf.ToString()

            End If
            rd1.Close()
            totaln = Integer.Parse(txtsr.Text) + Integer.Parse(txtsrf.Text)
            total.Text = totaln.ToString()
        Catch ex As Exception
            txtsrf.Text = "0"
            total.Text = "0"

            If ex.Message = "ORA-00936: missing expression" Then
                MsgBox("INVALID SEARCH",, "INVALID")

            Else
                MsgBox(ex.Message,, "ERROR!!!")
            End If
        Finally
            Con.Close()
        End Try

    End Sub

    Private Function check1(a As String) As String

        countsrf2 = countsrf2 + 1

        If a = "" Or a = b Or a = "0" Then
            finalsrf = ""
        Else

            countsrf1 = countsrf1 + 1

            If countsrf1 = 1 Then
                txtsrf.Clear()
                If countsrf2 = 1 Then

                    finalsrf = "department='" & dsrf & "'"

                ElseIf countsrf2 = 2 Then

                    finalsrf = "gender='" & gsrf & "'"

                ElseIf countsrf2 = 3 Then

                    finalsrf = "busno='" & bssrf & "'"


                ElseIf countsrf2 = 4 Then

                    finalsrf = "stopid='" & stsrf & "'"

                End If

            Else

                If countsrf2 = 1 Then

                    finalsrf = " AND department='" & dsrf & "'"

                ElseIf countsrf2 = 2 Then

                    finalsrf = " AND gender='" & gsrf & "'"

                ElseIf countsrf2 = 3 Then

                    finalsrf = " AND busno='" & bssrf & "'"


                ElseIf countsrf2 = 4 Then

                    finalsrf = " AND stopid='" & stsrf & "'"

                End If

            End If

        End If
        If countsrf2 = 4 Then
            countsrf1 = 0
            countsrf2 = 0
        End If

        Return finalsrf

    End Function

    Private Sub StageReading_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub StageReading_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub
End Class