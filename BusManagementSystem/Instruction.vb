Imports System.ComponentModel

Public Class Instruction
    Private Sub Instruction_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Main.Enabled = True

    End Sub

    Private Sub Instruction_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "HELP ?"
        TopMost = True
        Main.Enabled = False
    End Sub
End Class