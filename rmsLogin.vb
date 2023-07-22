﻿Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class rmsLogin
    Private Sub rmsLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRMSLogin()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub labelRFIDSwitch_Click(sender As Object, e As EventArgs) Handles labelRFIDSwitch.Click
        rmsRFIDLogin()
    End Sub

    Private Sub labelPassSwitch_Click(sender As Object, e As EventArgs) Handles labelPassSwitch.Click
        rmsPassLogin()
    End Sub

    Private Sub labelForgotPass_Click(sender As Object, e As EventArgs) Handles labelForgotPass.Click
        'add code para ireset yung pass. send sms code gamit gsm module pag may match na username sa db
        MessageBox.Show("Relax and try to remember your password.", "Forgot Password?", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub labelRegister_Click(sender As Object, e As EventArgs) Handles labelRegister.Click
        Process.Start("https://youtu.be/dQw4w9WgXcQ")
    End Sub

    Private Sub checkShow_CheckedChanged(sender As Object, e As EventArgs) Handles checkShow.CheckedChanged
        If checkShow.Checked = True Then
            tboxPassword.UseSystemPasswordChar = False
        Else
            tboxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub tboxUsername_TextChanged(sender As Object, e As EventArgs) Handles tboxUsername.TextChanged
        'para walang space na ma-input
        tboxUsername.Text = tboxUsername.Text.Replace(" ", "")
    End Sub

    Private Sub tboxPassword_TextChanged(sender As Object, e As EventArgs) Handles tboxPassword.TextChanged
        tboxPassword.Text = tboxPassword.Text.Replace(" ", "")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        adminLogin()
    End Sub

    Private Sub rmsLogin_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        tboxUsername.Focus()
    End Sub

    Private Sub panelRFIDLogin_Paint(sender As Object, e As PaintEventArgs) Handles panelRFIDLogin.Paint
        If panelRFIDLogin.Visible = True Then
            tboxRFID.Focus()
        End If
    End Sub

    Private Sub tboxRFID_TextChanged(sender As Object, e As EventArgs) Handles tboxRFID.TextChanged
        tboxRFID.Text = tboxRFID.Text.Replace(" ", "")
    End Sub

    Private Sub tboxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tboxPassword.KeyDown
        'enter key sa password textbox
        If e.KeyCode = Keys.Enter Then
            adminLogin()
        End If
    End Sub

    Private Sub tboxUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles tboxUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            adminLogin()
        End If
    End Sub

    Private Sub tboxRFID_KeyDown(sender As Object, e As KeyEventArgs) Handles tboxRFID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim rfid As String = tboxRFID.Text
                Dim userDocument As BsonDocument = rmsModule.getAdminRFID(rfid)
                If userDocument IsNot Nothing Then
                    rmsDashboard.Show()
                    Me.Hide()
                ElseIf tboxRFID.Text = "" Then
                    MessageBox.Show("Please swipe your RFID to continue.", "Blank RFID!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tboxRFID.Focus()
                Else
                    MessageBox.Show("User not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End If
    End Sub

End Class