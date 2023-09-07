Imports MongoDB.Bson

Public Class rmsLogin

    Dim loginToolTip As New ToolTip

    Private Sub rmsLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectToMongo()
        initializeDraggablePanel(panelTop)
        loadRMSLogin()
    End Sub

    Private Sub rmsLogin_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        loadRMSLogin()
        If tboxUsername.Text = "" Then
            tboxUsername.Focus()
        Else
            tboxPassword.Focus()
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tboxUsername.KeyPress, tboxPassword.KeyPress, tboxRFID.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tboxUsername_TextChanged(sender As Object, e As EventArgs) Handles tboxUsername.TextChanged
        Dim cursorPos As Integer = tboxUsername.SelectionStart
        'para walang space na ma-input
        tboxUsername.Text = tboxUsername.Text.Replace(" ", "")
        tboxUsername.SelectionStart = cursorPos
        If tboxUsername.Text = "" Then
            lblUserError.Visible = True
            tboxUsername.Focus()
        Else
            lblUserError.Visible = False
        End If
    End Sub

    Private Sub tboxUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles tboxUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            adminLogin()
        End If
    End Sub

    Private Sub tboxUsername_MouseHover(sender As Object, e As EventArgs) Handles tboxUsername.MouseHover
        loginToolTip.Show("You may use your username or email here.", Me, Cursor.Position.X - Me.Left, Cursor.Position.Y - Me.Top + 10, 2000)
    End Sub

    Private Sub tboxPassword_TextChanged(sender As Object, e As EventArgs) Handles tboxPassword.TextChanged
        Dim cursorPos As Integer = tboxPassword.SelectionStart
        tboxPassword.Text = tboxPassword.Text.Replace(" ", "")
        tboxPassword.SelectionStart = cursorPos
        If tboxPassword.Text = "" Then
            lblPassError.Visible = True
            tboxPassword.Focus()
        Else
            lblPassError.Visible = False
        End If
    End Sub

    Private Sub tboxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles tboxPassword.KeyDown
        'login using enter key
        If e.KeyCode = Keys.Enter Then
            adminLogin()
        End If
    End Sub

    Private Sub checkShow_CheckedChanged(sender As Object, e As EventArgs) Handles checkShow.CheckedChanged
        If checkShow.Checked = True Then
            tboxPassword.UseSystemPasswordChar = False
            tboxPassword.Focus()
        Else
            tboxPassword.UseSystemPasswordChar = True
            tboxPassword.Focus()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        adminLogin()
    End Sub

    Private Sub lblSwitchLoginRFID_Click(sender As Object, e As EventArgs) Handles lblSwitchLoginRFID.Click
        panelRFIDLogin.Show()
        panelPassLogin.Hide()
        clearLoginForm()
        tboxRFID.Focus()
    End Sub

    Private Sub lblSwitchLoginPass_Click(sender As Object, e As EventArgs) Handles lblSwitchLoginPass.Click
        panelRFIDLogin.Hide()
        panelPassLogin.Show()
        clearLoginForm()
        tboxUsername.Focus()
    End Sub

    Private Sub tboxRFID_TextChanged(sender As Object, e As EventArgs) Handles tboxRFID.TextChanged
        lblRFIDErr.Visible = False
        Dim cursorPos As Integer = tboxRFID.SelectionStart
        tboxRFID.Text = tboxRFID.Text.Replace(" ", "")
        tboxRFID.SelectionStart = cursorPos
    End Sub

    Private Sub tboxRFID_KeyDown(sender As Object, e As KeyEventArgs) Handles tboxRFID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(tboxRFID.Text) Then
                lblRFIDErr.Text = "Please swipe your RFID Card to login."
                lblRFIDErr.Visible = True
                tboxRFID.Focus()
            Else
                Try
                    Dim RFID As String = tboxRFID.Text
                    Dim userDocument As BsonDocument = moduleLogin.getAdminRFID(RFID)
                    If userDocument Is Nothing Then
                        lblRFIDErr.Text = "Error: RFID not registered."
                        lblRFIDErr.Visible = True
                        tboxRFID.Focus()
                    ElseIf userDocument IsNot Nothing Then
                        hideErrorLabel()
                        Dim admnFullName As String = $"{userDocument("First Name")} {userDocument("Middle Name")} {userDocument("Surname")}"
                        rmsDashboard.labelName = admnFullName
                        rmsDashboard.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Error lodz", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End If
        End If
    End Sub

    Private Sub labelForgotPass_Click(sender As Object, e As EventArgs) Handles labelForgotPass.Click
        'add code para ireset yung pass. send sms code gamit gsm module pag may match na username sa db
        MessageBox.Show("Relax and try to remember your password.", "Forgot Password?", MessageBoxButtons.OK, MessageBoxIcon.None)

    End Sub

    Private Sub labelRegister_Click(sender As Object, e As EventArgs) Handles labelRegister.Click
        rmsRegistration.Show()
        rmsRegistration.Location = Me.Location
        Me.Hide()
        clearLoginForm()
    End Sub

End Class