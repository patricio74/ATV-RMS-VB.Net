Imports MongoDB.Bson
Public Class rmsLogin
    Dim loginToolTip As New ToolTip
    Public Sub clearLoginForm()
        'rmsLogin.tboxUsername.Clear()
        tboxPassword.Clear()
        tboxRFID.Clear()
        checkShow.Checked = False
        hideErrorLabel()
    End Sub
    Private Sub rmsLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsAdmin")
        initializeDraggablePanel(panelTop)
        loadRMSLogin()
    End Sub
    Private Sub suppressKeySound(sender As Object, e As KeyPressEventArgs) Handles tboxUsername.KeyPress, tboxPassword.KeyPress, tboxRFID.KeyPress
        'suppress enter key sound sa mga textboxes
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub tboxUsername_MouseHover(sender As Object, e As EventArgs) Handles tboxUsername.MouseHover
        loginToolTip.Show("You may use your username or email here.", Me, Cursor.Position.X - Me.Left, Cursor.Position.Y - Me.Top + 10, 2000)
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
    Private Sub loginMouseClick(sender As Object, e As EventArgs) Handles btnMinimize.Click, btnClose.Click, btnLogin.Click,
        lblSwitchLoginRFID.Click, lblSwitchLoginPass.Click, labelForgotPass.Click, labelRegister.Click
        If sender Is btnMinimize Then
            Me.WindowState = FormWindowState.Minimized

        ElseIf sender Is btnClose Then
            Dim response As DialogResult = MessageBox.Show(" Are you sure you want to close ATV-RMS app?", "Confirmation", MessageBoxButtons.YesNo)
            If response = DialogResult.Yes Then
                Me.Close()
            End If

        ElseIf sender Is btnLogin Then
            If tboxUsername.Text = "" And tboxPassword.Text = "" Then
                lblLoginError.Text = "Error: Please enter the required field to continue."
                lblUserError.Visible = True
                lblPassError.Visible = True
                lblLoginError.Visible = True
            ElseIf tboxUsername.Text = "" And tboxPassword IsNot "" Then
                lblUserError.Visible = True
                tboxUsername.Focus()
            ElseIf tboxUsername.Text IsNot "" And tboxPassword.Text = "" Then
                lblPassError.Visible = True
                tboxPassword.Focus()
            Else
                adminPassLogin()
            End If

        ElseIf sender Is lblSwitchLoginRFID Then
            panelRFIDLogin.Show()
            panelPassLogin.Hide()
            clearLoginForm()
            tboxRFID.Focus()

        ElseIf sender Is lblSwitchLoginPass Then
            panelRFIDLogin.Hide()
            panelPassLogin.Show()
            clearLoginForm()
            If tboxUsername.Text = "" Then
                tboxUsername.Focus()
            Else
                tboxPassword.Focus()
            End If

        ElseIf sender Is labelForgotPass Then
            'MessageBox.Show("Relax and try to remember your password.", "Forgot Password?", MessageBoxButtons.OK, MessageBoxIcon.None)
            rmsPassReset.Show()
            rmsPassReset.tbxResetUsername.Focus()
            Me.Hide()
            clearLoginForm()

        ElseIf sender Is labelRegister Then
            rmsRegistration.Show()
            rmsRegistration.Location = Me.Location
            Me.Hide()
            clearLoginForm()
        End If
    End Sub
    Private Sub txtboxTextChanged(sender As Object, e As EventArgs) Handles tboxUsername.TextChanged, tboxPassword.TextChanged, tboxRFID.TextChanged
        If sender Is tboxUsername Then
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

        ElseIf sender Is tboxPassword Then
            Dim cursorPos As Integer = tboxPassword.SelectionStart
            tboxPassword.Text = tboxPassword.Text.Replace(" ", "")
            tboxPassword.SelectionStart = cursorPos
            If tboxPassword.Text = "" Then
                lblPassError.Visible = True
                tboxPassword.Focus()
            Else
                lblPassError.Visible = False
            End If

        ElseIf sender Is tboxRFID Then
            lblRFIDErr.Visible = False
            Dim cursorPos As Integer = tboxRFID.SelectionStart
            tboxRFID.Text = tboxRFID.Text.Replace(" ", "")
            tboxRFID.SelectionStart = cursorPos
            If tboxRFID.Text.Length = 0 Then
                lblRFIDErr.Text = "Please swipe your RFID Card to login."
                lblRFIDErr.Visible = True
                tboxRFID.Focus()
            End If
        End If
    End Sub
    Private Sub enterKey(sender As Object, e As KeyEventArgs) Handles tboxUsername.KeyDown, tboxPassword.KeyDown, tboxRFID.KeyDown
        'login using enter key
        If e.KeyCode = Keys.Enter Then
            If sender Is tboxUsername Then
                If tboxUsername.Text = "" And tboxPassword.Text = "" Then
                    lblLoginError.Text = "Error: Please enter the required field to continue."
                    lblUserError.Visible = True
                    lblPassError.Visible = True
                    lblLoginError.Visible = True
                ElseIf tboxUsername.Text = "" And tboxPassword IsNot "" Then
                    lblUserError.Visible = True
                    tboxUsername.Focus()
                ElseIf tboxUsername.Text IsNot "" And tboxPassword.Text = "" Then
                    lblPassError.Visible = True
                    tboxPassword.Focus()
                Else
                    adminPassLogin()
                End If

            ElseIf sender Is tboxPassword Then
                If tboxUsername.Text = "" And tboxPassword.Text = "" Then
                    lblLoginError.Text = "Error: Please enter the required field to continue."
                    lblUserError.Visible = True
                    lblPassError.Visible = True
                    lblLoginError.Visible = True
                ElseIf tboxUsername.Text = "" And tboxPassword IsNot "" Then
                    lblUserError.Visible = True
                    tboxUsername.Focus()
                ElseIf tboxUsername.Text IsNot "" And tboxPassword.Text = "" Then
                    lblPassError.Visible = True
                    tboxPassword.Focus()
                Else
                    adminPassLogin()
                End If

            ElseIf sender Is tboxRFID Then
                If tboxRFID.Text.Length = 0 Then
                    lblRFIDErr.Text = "Please swipe your RFID Card to login."
                    lblRFIDErr.Visible = True
                    tboxRFID.Focus()
                Else
                    adminRFIDLogin()
                End If
            End If
        End If
    End Sub
    Private Sub rmsLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        closeMongoConn()
    End Sub
End Class