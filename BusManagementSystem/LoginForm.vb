Imports System.ComponentModel

Public Class LOGIN


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles login1.Click

        If username.Text = "ADMIN" And password.Text = "ADMIN" Then

            Main.Show()

            Close()
        Else
            MessageBox.Show("                   LOGIN ERROR!!!" & vbNewLine & " USERNAME OR PASSWORD INVALID", "ERROR!!!")

        End If

    End Sub


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "LOGIN"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub


End Class
