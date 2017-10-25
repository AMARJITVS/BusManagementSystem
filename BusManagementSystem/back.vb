Imports System.ComponentModel
Imports Oracle.DataAccess.Client
Imports Excel = Microsoft.Office.Interop.Excel
Public Class back
    Dim processid As Integer
    Dim i As Integer
    Dim processk, p As Process
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim xlworksheet1 As Excel.Worksheet
    Dim misValue As Object = Reflection.Missing.Value
    Dim Con As New OracleConnection("Data Source=ORCL;User ID=Amar;Password=amar")
    Dim save As New SaveFileDialog
    Dim filename As String
    Dim dscmd As New OracleDataAdapter("SELECT * FROM Student", Con)
    Dim ds, ds1 As New DataSet
    Dim dscmd1 As New OracleDataAdapter("SELECT * FROM Faculty", Con)

    Private Sub fa_Click(sender As Object, e As EventArgs) Handles fa.Click
        txt.Text = ""
        Select Case MsgBox("Press YES to CREATE A EXCEL FILE WITH ALL FACULTY ENTRIES " & vbCrLf& & "Press NO to CANCEL", MsgBoxStyle.YesNo, "BACKUP - FACULTY ENTRY")

            Case MsgBoxResult.No


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
                        xlWorkSheet.Cells(1, 6) = "StopName"
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
                        txt.Text = "EXCEL FILE WITH FACULTY DETAILS CREATED"
                        Dim localByName As Process() = Process.GetProcessesByName("Excel")
                        i = localByName.Length

                        While i > 0

                            processid = (localByName((i - 1)).Id)
                            processk = Process.GetProcessById(Int32.Parse(processid))
                            processk.Kill()
                            processk.WaitForExit()
                            i -= 1
                        End While
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message,, "ERROR!!! - FACULTY ENTRY")
                End Try
        End Select
    End Sub

    Private Sub all_Click(sender As Object, e As EventArgs) Handles all.Click
        txt.Text = ""
        Select Case MsgBox("Press YES to CREATE A EXCEL FILE WITH ALL STUDENT AND FACULTY ENTRIES" & vbCrLf& & "Press NO to CANCEL", MsgBoxStyle.YesNo, "BACKUP")

            Case MsgBoxResult.No

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
                        txt.Text = "EXCEL FILE WITH ALL DETAILS CREATED"
                        Dim localByName As Process() = Process.GetProcessesByName("Excel")
                        i = localByName.Length

                        While i > 0

                            processid = (localByName((i - 1)).Id)
                            processk = Process.GetProcessById(Int32.Parse(processid))
                            processk.Kill()
                            processk.WaitForExit()
                            i -= 1
                        End While
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message,, "ERROR!!!")
                End Try
        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Hide()
    End Sub

    Private Sub st_Click(sender As Object, e As EventArgs) Handles st.Click
        txt.Text = ""
        Select Case MsgBox("Press YES to CREATE A EXCEL FILE WITH ALL STUDENT ENTRIES" & vbCrLf& & "Press NO to CANCEL", MsgBoxStyle.YesNo, "BACKUP - STUDENT ENTRIES")

            Case MsgBoxResult.No

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
                        txt.Text = "EXCEL FILE WITH STUDENT DETAILS CREATED"
                        Dim localByName As Process() = Process.GetProcessesByName("Excel")
                        i = localByName.Length

                        While i > 0

                            processid = (localByName((i - 1)).Id)
                            processk = Process.GetProcessById(Int32.Parse(processid))
                            processk.Kill()
                            processk.WaitForExit()
                            i -= 1
                        End While

                    End If
                Catch ex As Exception

                    MsgBox(ex.Message,, "ERROR!!! - STUDENT ENTRY")

                End Try
        End Select

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

    Private Sub back_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class