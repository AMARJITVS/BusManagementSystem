Imports System.ComponentModel

Public Class Main


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "BUS MANAGEMENT SYSTEM"
        Indication.Text = "Login Successfull..."
    End Sub

    Private Sub Exit1_Click(sender As Object, e As EventArgs) Handles Exit1.Click
        Application.Exit()
    End Sub

    Private Sub add1_Click(sender As Object, e As EventArgs) Handles add1.Click
        AddEntries.Show()
        Hide()
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        DelLogin.Show()
    End Sub

    Private Sub stage_Click(sender As Object, e As EventArgs) Handles stage.Click
        StageReading.totalstudents()
        StageReading.Show()
        Hide()
    End Sub

    Private Sub BusSuggestion_Click(sender As Object, e As EventArgs) Handles BusSuggestion.Click
        BusSug.Show()
        Hide()
    End Sub

    Private Sub feesmain_Click(sender As Object, e As EventArgs) Handles feesmain.Click
        Fees.Show()
        Hide()
    End Sub

    Private Sub backmain_Click(sender As Object, e As EventArgs) Handles backmain.Click
        back.Show()
        Hide()
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        Instruction.Show()
    End Sub

    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class