Imports System.ComponentModel
Imports Oracle.DataAccess.Client
Imports Excel = Microsoft.Office.Interop.Excel


Public Class DelEntries
    Dim processid, a, b, i, j, data_affector As Integer
    Dim processk, p As Process
    Dim Con As New OracleConnection("Data Source=ORCL;User ID=Amar;Password=amar")
    Dim sql1, sql, filename As String
    Dim save As New SaveFileDialog
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim xlworksheet1 As Excel.Worksheet
    Dim misValue As Object = Reflection.Missing.Value
    Dim delst As New OracleCommand("TRUNCATE TABLE Student", Con)
    Dim delfa As New OracleCommand("TRUNCATE TABLE Faculty", Con)
    Dim dscmd As New OracleDataAdapter("SELECT * FROM Student", Con)
    Dim ds, ds1 As New DataSet
    Dim dscmd1 As New OracleDataAdapter("SELECT * FROM Faculty", Con)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Hide()
        delrol.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub



    Private Sub delrol_MouseClick(sender As Object, e As MouseEventArgs)
        indi.Text = "Only accepts number"
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click

        del.BackColor = Color.DeepSkyBlue
        delall.BackColor = Color.Silver
        delallpan.Hide()
        delpan.Show()

    End Sub

    Private Sub delall_Click(sender As Object, e As EventArgs) Handles delall.Click

        del.BackColor = Color.Silver
        delall.BackColor = Color.DeepSkyBlue
        delpan.Show()
        delallpan.Show()
        delallpan.BringToFront()

    End Sub

    Private Sub dels_Click(sender As Object, e As EventArgs) Handles dels.Click

        Select Case MsgBox("Press YES to CREATE A EXCEL FILE WITH ALL STUDENT ENTRIES" & vbCrLf& & "Press NO to DELETE ALL ENTRIES OF STUDENTS", MsgBoxStyle.YesNoCancel, "WARNING - STUDENT ENTRY")

            Case MsgBoxResult.No
                Try

                    delst.CommandType = CommandType.Text

                    Con.Open()

                    delst.ExecuteNonQuery()

                    MsgBox("ALL ENTRIES DELETED",, "INFO - STUDENT ENTRY")

                    Con.Close()

                Catch ex As Exception

                    MsgBox(ex.Message,, "ERROR!!! - STUDENT ENTRY")

                End Try

            Case MsgBoxResult.Yes

                Try

                    xlApp = New Excel.Application
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    xlWorkSheet = xlWorkBook.Sheets("sheet1")

                    Con.Open()

                    save.FileName = "BUS MANAGEMENT SYSTEM-STUDENT TABLE"

                    If save.ShowDialog() = DialogResult.OK Then

                        filename = save.FileName

                        dscmd.Fill(ds)

                        xlWorkSheet.Cells(1, 1) = "Name"
                        xlWorkSheet.Cells(1, 2) = "Rollno"
                        xlWorkSheet.Cells(1, 3) = "Year"
                        xlWorkSheet.Cells(1, 4) = "Department"
                        xlWorkSheet.Cells(1, 5) = "Section"
                        xlWorkSheet.Cells(1, 6) = "Gender"
                        xlWorkSheet.Cells(1, 7) = "Busno"
                        xlWorkSheet.Cells(1, 8) = "StopName"
                        xlWorkSheet.Cells(1, 9) = "Address"
                        xlWorkSheet.Cells(1, 10) = "Ref.ID"

                        For i = 1 To ds.Tables(0).Rows.Count
                            For j = 0 To ds.Tables(0).Columns.Count - 1
                                If j = 7 Then
                                    Dim dscmd3 As New OracleCommand("SELECT STOPNAME FROM STOPS WHERE STOPID=" & ds.Tables(0).Rows(i - 1).Item(j), Con)
                                    dscmd3.CommandType = CommandType.Text
                                    Dim rd As OracleDataReader = dscmd3.ExecuteReader()
                                    If rd.Read() Then

                                        xlWorkSheet.Cells(i + 1, j + 1) = rd.GetValue(0)
                                    End If
                                    rd.Close()
                                Else
                                    xlWorkSheet.Cells(i + 1, j + 1) =
                                ds.Tables(0).Rows(i - 1).Item(j)
                                End If
                            Next
                        Next


                        xlWorkSheet.SaveAs(filename)
                        xlWorkBook.Close()
                        xlApp.Quit()

                        releaseObject(xlApp)
                        releaseObject(xlWorkBook)
                        releaseObject(xlWorkSheet)

                        Con.Close()

                        MsgBox("EXCEL FILE CREATED",, "INFO - STUDENT ENTRY")


                    End If
                    Try

                        Select Case MsgBox("Press YES to DELETE ENTRIES OF STUDENT" & vbCrLf& & "Press NO to CANCEL !!!", MsgBoxStyle.YesNo, "WARNING - STUDENT ENTRY")

                            Case MsgBoxResult.Yes
                                Try

                                    delst.CommandType = CommandType.Text

                                    Con.Open()

                                    delst.ExecuteNonQuery()

                                    MsgBox("ALL ENTRIES DELETED",, "INFO - STUDENT ENTRY")

                                    Con.Close()

                                Catch ex As Exception

                                    MsgBox(ex.Message,, "ERROR!!! - STUDENT ENTRY")

                                End Try

                            Case MsgBoxResult.No


                        End Select

                    Catch ex As Exception
                        MsgBox("ERROR!!!",, "ERROR!!! - STUDENT ENTRY")
                    Finally
                        Try

                            Dim localByName As Process() = Process.GetProcessesByName("Excel")
                            Dim i As Integer = localByName.Length

                            While i > 0

                                processid = (localByName((i - 1)).Id)
                                processk = Process.GetProcessById(Int32.Parse(processid))
                                processk.Kill()
                                processk.WaitForExit()
                                i -= 1
                            End While

                        Catch ex As Exception
                            MsgBox(ex.Message,, "ERROR!!! - STUDENT ENTRY")
                        End Try
                    End Try
                Catch ex As Exception


                    MsgBox(ex.Message,, "ERROR!!! - STUDENT ENTRY")

                End Try

        End Select
    End Sub


    Private Sub delf_Click(sender As Object, e As EventArgs) Handles delf.Click

        Select Case MsgBox("Press YES to CREATE A EXCEL FILE WITH ALL FACULTY ENTRIES " & vbCrLf& & "Press NO to DELETE ALL ENTRIES OF FACULTY", MsgBoxStyle.YesNoCancel, "WARNING - FACULTY ENTRY")

            Case MsgBoxResult.No
                Try

                    delfa.CommandType = CommandType.Text

                    Con.Open()

                    delfa.ExecuteNonQuery()

                    MsgBox("ALL ENTRIES DELETED",, "INFO - FACULTY ENTRY")

                    Con.Close()

                Catch ex As Exception

                    MsgBox(ex.Message,, "ERROR!!! - FACULTY ENTRY")

                End Try

            Case MsgBoxResult.Yes

                Try


                    xlApp = New Excel.Application
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    xlWorkSheet = xlWorkBook.Sheets("sheet1")

                    Con.Open()

                    save.FileName = "BUS MANAGEMENT SYSTEM-FACULTY TABLE"

                    If save.ShowDialog() = DialogResult.OK Then

                        filename = save.FileName

                        dscmd1.Fill(ds1)
                        xlWorkSheet.Cells(1, 1) = "Name"
                        xlWorkSheet.Cells(1, 2) = "Rollno"
                        xlWorkSheet.Cells(1, 3) = "Department"
                        xlWorkSheet.Cells(1, 4) = "Gender"
                        xlWorkSheet.Cells(1, 5) = "Busno"
                        xlWorkSheet.Cells(1, 6) = "Stopno"
                        xlWorkSheet.Cells(1, 7) = "Address"
                        xlWorkSheet.Cells(1, 8) = "Ref.ID"

                        For i = 1 To ds1.Tables(0).Rows.Count
                            For j = 0 To ds1.Tables(0).Columns.Count - 1
                                If j = 5 Then
                                    Dim dscmd3 As New OracleCommand("SELECT STOPNAME FROM STOPS WHERE STOPID=" & ds1.Tables(0).Rows(i - 1).Item(j), Con)
                                    dscmd3.CommandType = CommandType.Text
                                    Dim rd As OracleDataReader = dscmd3.ExecuteReader()
                                    If rd.Read() Then

                                        xlWorkSheet.Cells(i + 1, j + 1) = rd.GetValue(0)
                                    End If
                                    rd.Close()
                                Else
                                    xlWorkSheet.Cells(i + 1, j + 1) =
                                ds1.Tables(0).Rows(i - 1).Item(j)
                                End If
                            Next
                        Next

                        xlWorkSheet.SaveAs(filename)
                        xlWorkBook.Close()
                        xlApp.Quit()

                        releaseObject(xlApp)
                        releaseObject(xlWorkBook)
                        releaseObject(xlWorkSheet)

                        Con.Close()

                        MsgBox("EXCEL FILE CREATED",, "INFO - FACULTY ENTRY")

                    End If

                    Try

                        Select Case MsgBox("Press YES to DELETE ENTRIES OF FACULTY" & vbCrLf& & "Press NO to CANCEL !!!", MsgBoxStyle.YesNo, "WARNING - FACULTY ENTRY")

                            Case MsgBoxResult.Yes
                                Try

                                    delfa.CommandType = CommandType.Text

                                    Con.Open()

                                    delfa.ExecuteNonQuery()

                                    MsgBox("FACULTY ENTRIES DELETED",, "INFO - FACULTY ENTRY")

                                    Con.Close()

                                Catch ex As Exception

                                    MsgBox(ex.Message,, "ERROR!!! - FACULTY ENTRY")

                                End Try

                            Case MsgBoxResult.No


                        End Select

                    Catch ex As Exception
                        MsgBox("ERROR!!!",, "ERROR!!! - FACULTY ENTRY")
                    Finally

                        Try

                            Dim localByName As Process() = Process.GetProcessesByName("Excel")
                            Dim i As Integer = localByName.Length

                            While i > 0

                                processid = (localByName((i - 1)).Id)
                                processk = Process.GetProcessById(Int32.Parse(processid))
                                processk.Kill()
                                processk.WaitForExit()
                                i -= 1
                            End While

                        Catch ex As Exception
                            MsgBox(ex.Message,, "ERROR!!! - FACULTY ENTRY")
                        End Try
                    End Try


                Catch ex As Exception
                    MsgBox(ex.Message,, "ERROR!!! - FACULTY ENTRY")
                End Try


        End Select

    End Sub

    Private Sub delsf_Click(sender As Object, e As EventArgs) Handles delsf.Click

        Select Case MsgBox("Press YES to CREATE A EXCEL FILE WITH ALL STUDENT AND FACULTY ENTRIES" & vbCrLf& & "Press NO to DELETE ALL ENTRIES !!!", MsgBoxStyle.YesNoCancel, "WARNING")

            Case MsgBoxResult.No
                Try

                    delst.CommandType = CommandType.Text

                    delfa.CommandType = CommandType.Text

                    Con.Open()

                    delst.ExecuteNonQuery()

                    delfa.ExecuteNonQuery()

                    MsgBox("ALL ENTRIES DELETED",, "INFO")

                    Con.Close()

                Catch ex As Exception

                    MsgBox(ex.Message,, "ERROR!!!")

                End Try

            Case MsgBoxResult.Yes

                Try

                    xlApp = New Excel.Application
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    xlWorkBook = xlApp.Workbooks.Add
                    xlWorkSheet = CType(xlWorkBook.Worksheets.Add(), Excel.Worksheet)
                    xlWorkSheet.Name = "STUDENT"
                    save.FileName = "BUS MANAGEMENT SYSTEM-STUDENT TABLE AND FACULTY TABLE"

                    If save.ShowDialog() = DialogResult.OK Then

                        filename = save.FileName
                        Con.Open()
                        dscmd.Fill(ds)
                        xlWorkSheet.Cells(1, 1) = "Name"
                        xlWorkSheet.Cells(1, 2) = "Rollno"
                        xlWorkSheet.Cells(1, 3) = "Year"
                        xlWorkSheet.Cells(1, 4) = "Department"
                        xlWorkSheet.Cells(1, 5) = "Section"
                        xlWorkSheet.Cells(1, 6) = "Gender"
                        xlWorkSheet.Cells(1, 7) = "Busno"
                        xlWorkSheet.Cells(1, 8) = "Stopno"
                        xlWorkSheet.Cells(1, 9) = "Address"
                        xlWorkSheet.Cells(1, 10) = "Ref.ID"

                        For i = 1 To ds.Tables(0).Rows.Count
                            For j = 0 To ds.Tables(0).Columns.Count - 1
                                xlWorkSheet.Cells(i + 1, j + 1) =
                                ds.Tables(0).Rows(i - 1).Item(j)
                            Next
                        Next

                        xlWorkBook.Sheets("Sheet1").delete
                        xlWorkSheet.SaveAs(filename)
                        releaseObject(xlWorkSheet)


                        xlworksheet1 = CType(xlWorkBook.Worksheets.Add(), Excel.Worksheet)
                        xlworksheet1.Name = "FACULTY"
                        dscmd1.Fill(ds1)
                        xlworksheet1.Cells(1, 1) = "Name"
                        xlworksheet1.Cells(1, 2) = "Rollno"
                        xlworksheet1.Cells(1, 3) = "Department"
                        xlworksheet1.Cells(1, 4) = "Gender"
                        xlworksheet1.Cells(1, 5) = "Busno"
                        xlworksheet1.Cells(1, 6) = "Stopno"
                        xlworksheet1.Cells(1, 7) = "Address"
                        xlworksheet1.Cells(1, 8) = "Ref.ID"

                        For i = 1 To ds1.Tables(0).Rows.Count
                            For j = 0 To ds1.Tables(0).Columns.Count - 1
                                xlworksheet1.Cells(i + 1, j + 1) =
                                ds1.Tables(0).Rows(i - 1).Item(j)
                            Next
                        Next
                        xlworksheet1.SaveAs(filename)

                        xlWorkBook.Close()
                        xlApp.Quit()

                        releaseObject(xlApp)
                        releaseObject(xlWorkBook)
                        releaseObject(xlworksheet1)

                        Con.Close()

                        MsgBox("EXCEL FILE CREATED",, "INFO")

                    End If
                    Try


                        Select Case MsgBox("Press YES to DELETE ENTRIES OF STUDENT AND FACULTY" & vbCrLf& & "Press NO to CANCEL !!!", MsgBoxStyle.YesNo, "WARNING")

                            Case MsgBoxResult.Yes
                                Try

                                    delst.CommandType = CommandType.Text

                                    delfa.CommandType = CommandType.Text

                                    Con.Open()

                                    delst.ExecuteNonQuery()

                                    delfa.ExecuteNonQuery()

                                    MsgBox("ALL ENTRIES DELETED",, "INFO")

                                    Con.Close()

                                Catch ex As Exception

                                    MsgBox(ex.Message,, "ERROR!!!")

                                End Try

                            Case MsgBoxResult.No


                        End Select
                    Catch ex As Exception
                        MsgBox("ERROR!!! - FILE CREATION",, "ERROR!!!")
                    Finally

                        Try

                            Dim localByName As Process() = Process.GetProcessesByName("Excel")
                            Dim i As Integer = localByName.Length

                            While i > 0

                                processid = (localByName((i - 1)).Id)
                                processk = Process.GetProcessById(Int32.Parse(processid))
                                processk.Kill()
                                processk.WaitForExit()
                                i -= 1
                            End While

                        Catch ex As Exception
                            MsgBox(ex.Message,, "ERROR!!!")
                        End Try
                    End Try


                Catch ex As Exception
                    MsgBox(ex.Message,, "ERROR!!!")
                End Try


        End Select

    End Sub



    Private Sub delbutton_Click(sender As Object, e As EventArgs) Handles delbutton.Click
        If IsNumeric(delrol.Text) = False Then
            MsgBox("*Only numeric values accepted",, "ERROR!!!")
            delrol.Text = ""
        Else

            Dim cmds As New OracleCommand("select count(rollno) from STUDENT where Rollno='" + delrol.Text + "'", Con)
            Dim cmdf As New OracleCommand("select count(rollno) from FACULTY where Rollno='" + delrol.Text + "'", Con)
            Dim dels1 As New OracleCommand("delete from STUDENT where Rollno='" + delrol.Text + "'", Con)
            Dim delf1 As New OracleCommand("delete from FACULTY where Rollno='" + delrol.Text + "'", Con)
            cmds.CommandType = CommandType.Text
            cmdf.CommandType = CommandType.Text
            dels1.CommandType = CommandType.Text
            delf1.CommandType = CommandType.Text

            Con.Open()

            Dim reads As OracleDataReader = cmds.ExecuteReader()


            If reads.Read() Then

                If reads.GetValue(0) = 1 Then

                    a = 1

                ElseIf reads.GetValue(0) = 0 Then

                    a = 0

                Else
                    MsgBox("ERROR!!!")

                End If

            End If

            reads.Close()

            If a = 1 Then

                Select Case MsgBox("Press YES to DELETE THE ENTRY..." & vbCrLf& & "Press NO to cancel operation...", MsgBoxStyle.YesNo, "WARNING")

                    Case MsgBoxResult.Yes
                        Try

                            dels1.ExecuteNonQuery()

                            MsgBox("ENTRY DELETED",, "INFO")

                            delrol.Text = ""

                        Catch ex As Exception

                            MsgBox(ex.Message,, "ERROR!!!")

                        End Try

                    Case MsgBoxResult.No

                End Select

            ElseIf a = 0 Then

                Dim readf As OracleDataReader = cmdf.ExecuteReader()

                If readf.Read() Then

                    If readf.GetValue(0) = 1 Then

                        b = 1

                    ElseIf readf.GetValue(0) = 0 Then

                        b = 0

                    Else
                        MsgBox("ERROR!!!",, "ERROR!!!")

                    End If

                End If

                readf.Close()



                If b = 1 Then

                    Select Case MsgBox("Press YES to DELETE THE ENTRY..." & vbCrLf& & "Press NO to cancel operation...", MsgBoxStyle.YesNo, "WARNING")

                        Case MsgBoxResult.Yes
                            Try

                                delf1.ExecuteNonQuery()

                                MsgBox("ENTRY DELETED",, "INFO")

                                delrol.Text = ""

                            Catch ex As Exception

                                MsgBox(ex.Message,, "ERROR!!!")

                            End Try

                        Case MsgBoxResult.No

                    End Select

                ElseIf b = 0 Then

                    MsgBox("ENTRY NOT FOUND!!!   PLEASE ENTER THE CORRECT ROLLNO",, "ERROR!!!")

                End If

            End If

            Con.Close()

        End If
    End Sub

    Private Sub delrol_Validated(sender As Object, e As EventArgs)
        If delrol.Text = "" Then


        Else
            If IsNumeric(delrol.Text) = False Then

                MsgBox("* Only accepts numbers",, "ERROR!!!")

                delrol.Text = ""
            End If

        End If

    End Sub



    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub DelEntries_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "DELETE MEMBERS"
        delpan.Show()
        delallpan.Hide()

    End Sub

    Private Sub DelEntries_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

End Class