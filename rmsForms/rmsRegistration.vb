Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class rmsRegistration
    Dim adminCol As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsAdmin")
    Dim tiempoAhora As String = DateTime.Now.ToString("MMM d, yyyy hh:mm tt")
    Private Sub hideRegPanelz()
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
    End Sub
    Private Sub rmsRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        initializeDraggablePanel(panelTop)
        hideRegPanelz()
        Panel1.Show()
    End Sub
    Private Sub suppressKeySound(sender As Object, e As KeyPressEventArgs) Handles regFName.KeyPress, regMName.KeyPress, regSname.KeyPress,
        regEmail.KeyPress, regPhone.KeyPress, regRFID.KeyPress, regUsername.KeyPress, regPassw.KeyPress, regPassw2.KeyPress
        'suppress enter key sound sa mga textboxes
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub regTextbox_Leave(sender As Object, e As EventArgs) Handles regFName.Leave, regMName.Leave, regSname.Leave
        regFName.Text = regFName.Text.Trim
        regMName.Text = regMName.Text.Trim
        regSname.Text = regSname.Text.Trim
    End Sub
    Private Sub regBtnClick(sender As Object, e As EventArgs) Handles btnMinimize.Click, btnClose.Click, btnNext1.Click, btnNext2.Click, btnNext3.Click,
        btnReg.Click, btnRegOk.Click, btnRet1.Click, btnRet2.Click
        If sender Is btnMinimize Then
            Me.WindowState = FormWindowState.Minimized

        ElseIf sender Is btnClose Then
            Dim result As DialogResult = MessageBox.Show("Do you want to switch to login?" & vbCrLf & "Your registration will be discarded.", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                rmsLogin.Show()
                rmsLogin.Location = Me.Location
                Me.Close()
                loadRMSLogin()
                rmsLogin.tboxUsername.Focus()
            End If

        ElseIf sender Is btnRet1 Then 'return sa panel1
            lblPanel2Note.Visible = False
            lblEmailUsed.Visible = False
            lblPhoneInvalid.Visible = False
            lblRFIDUsed.Visible = False
            hideRegPanelz()
            Panel1.Show()

        ElseIf sender Is btnRet2 Then 'return sa panel2
            'lblPanel1Note.Visible = False
            lblPanel3Note.Visible = False
            lblUsernameUsed.Visible = False
            lblUsernameShort.Visible = False
            lblPassShort.Visible = False
            lblPassError.Visible = False
            hideRegPanelz()
            Panel2.Show()
            'lblHello.Text = "Hi, " + regFName.Text + "!"
            'regEmail.Focus()

        ElseIf sender Is btnNext1 Then 'panel1
            regFName.Text = regFName.Text.Trim()
            regMName.Text = regMName.Text.Trim()
            regSname.Text = regSname.Text.Trim()
            If String.IsNullOrWhiteSpace(regFName.Text) Then
                lblPanel1Note.Visible = True
                regFName.Focus()
            ElseIf String.IsNullOrWhiteSpace(regSname.Text) Then
                lblPanel1Note.Visible = True
                regSname.Focus()
            Else
                lblPanel1Note.Visible = False
                hideRegPanelz()
                Panel2.Show()
                Dim firstWord As String = regFName.Text.Trim()
                'split the input text by space
                Dim words As String() = firstWord.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
                If words.Length > 0 Then
                    'copy first word
                    Dim firstName As String = words(0)
                    lblHello.Text = "Hi, " & firstName & "!"
                Else

                    'dahekkkkkkkkk

                    MessageBox.Show("Hello!")
                End If
                regEmail.Focus()
            End If

        ElseIf sender Is btnNext2 Then 'panel2
            lblPanel2Note.Visible = False
            lblEmailUsed.Visible = False
            lblPhoneInvalid.Visible = False
            lblRFIDUsed.Visible = False
            regEmail.Text.Trim()
            regPhone.Text.Trim()
            regRFID.Text.Trim()
            If String.IsNullOrWhiteSpace(regEmail.Text) Or String.IsNullOrWhiteSpace(regPhone.Text) Or String.IsNullOrWhiteSpace(regRFID.Text) Then
                lblPanel2Note.Visible = True
            Else 'check if rfid, phone, email is already in use
                Dim userEmail As String = regEmail.Text
                'Dim userPhone As String = regPhone.Text.Trim()
                Dim userRFID As String = regRFID.Text
                Dim filterEmail As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Or(Builders(Of BsonDocument).Filter.Eq(Of String)("Email", userEmail))
                'Dim filterPhone As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Or(Builders(Of BsonDocument).Filter.Eq(Of String)("Phone", userPhone))
                Dim filterRFID As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Or(Builders(Of BsonDocument).Filter.Eq(Of String)("RFID", userRFID))
                Dim emailAvailability As Long = adminCol.CountDocuments(filterEmail)
                'Dim phoneAvailability As Long = adminCol.CountDocuments(filterPhone)
                Dim rfidAvailability As Long = adminCol.CountDocuments(filterRFID)
                Dim panel2ErrCheck As Boolean = False
                Try
                    If emailAvailability > 0 Then
                        panel2ErrCheck = True
                        lblEmailUsed.Visible = True
                        regEmail.Focus()
                    Else
                        lblEmailUsed.Visible = False
                    End If
                    'If phoneAvailability > 0 Then
                    ' MessageBox.Show("The phone number you entered is already in use.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'duplicatesCheck = True
                    'else
                    'End If
                    If Not ((regPhone.Text.Length = 0) OrElse (regPhone.Text.Length = 11 AndAlso Not regPhone.Text.Contains("+")) OrElse (regPhone.Text.Length = 13 AndAlso regPhone.Text.Contains("+"))) Then
                        panel2ErrCheck = True
                        lblPhoneInvalid.Visible = True
                        regPhone.Focus()
                    Else
                        lblPhoneInvalid.Visible = False
                    End If
                    If rfidAvailability > 0 Then
                        panel2ErrCheck = True
                        lblRFIDUsed.Visible = True
                        regRFID.Focus()
                    Else
                        lblRFIDUsed.Visible = False
                    End If
                    If Not panel2ErrCheck Then
                        lblPanel2Note.Visible = False
                        lblEmailUsed.Visible = False
                        lblPhoneInvalid.Visible = False
                        lblRFIDUsed.Visible = False
                        hideRegPanelz()
                        Panel3.Show()
                        regUsername.Focus()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        ElseIf sender Is btnNext3 Then 'panel3
            lblPanel3Note.Visible = False
            lblUsernameUsed.Visible = False
            lblUsernameShort.Visible = False
            lblPassShort.Visible = False
            lblPassError.Visible = False
            regUsername.Text.Trim()
            regPassw.Text.Trim()
            regPassw2.Text.Trim()
            If String.IsNullOrWhiteSpace(regUsername.Text) Or String.IsNullOrWhiteSpace(regPassw.Text) Or String.IsNullOrWhiteSpace(regPassw2.Text) Then
                lblPanel3Note.Visible = True
            Else
                'add code to module
                Dim pendingUsername As String = regUsername.Text
                Dim checkUsername As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Or(Builders(Of BsonDocument).Filter.Eq(Of String)("Username", pendingUsername))
                Dim usernameAvailability As Long = adminCol.CountDocuments(checkUsername)
                Dim panel3ErrCheck As Boolean = False
                Try
                    If usernameAvailability > 0 Then
                        panel3ErrCheck = True
                        lblUsernameUsed.Visible = True
                        regUsername.Focus()
                    Else
                        lblUsernameUsed.Visible = False
                    End If
                    If regUsername.Text.Length < 5 Then
                        panel3ErrCheck = True
                        lblUsernameShort.Visible = True
                    Else
                        lblUsernameShort.Visible = False
                    End If
                    If regPassw.Text.Length < 8 Then
                        panel3ErrCheck = True
                        lblPassShort.Visible = True
                    Else
                        lblPassShort.Visible = False
                    End If
                    If regPassw2.Text <> regPassw.Text Then
                        panel3ErrCheck = True
                        lblPassError.Visible = True
                        lblPanel3Note.Visible = True
                    Else
                        lblPassError.Visible = False
                        lblPanel3Note.Visible = False
                    End If
                    If Not panel3ErrCheck Then
                        lblPanel3Note.Visible = False
                        lblUsernameUsed.Visible = False
                        lblUsernameShort.Visible = False
                        lblPassShort.Visible = False
                        lblPassError.Visible = False
                        hideRegPanelz()
                        Panel4.Show()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        ElseIf sender Is btnReg Then 'REGISTER PANEL
            'insert to pendingAdminCollection
            If regFName.Text = "" Or regSname.Text = "" Or regEmail.Text = "" Or regPhone.Text = "" Or regRFID.Text = "" Or regUsername.Text = "" Or regPassw2.Text = "" Then
                MessageBox.Show("Fill out all the fields to continue.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim result As DialogResult = MessageBox.Show("Do you want to submit your registration?", "Confirmation", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Try
                        Dim firstName As String = regFName.Text
                        Dim midName As String = regMName.Text
                        Dim surname As String = regSname.Text
                        Dim email As String = regEmail.Text
                        Dim phone As String = regPhone.Text
                        Dim username As String = regUsername.Text
                        Dim password As String = regPassw.Text
                        Dim rfid As String = regRFID.Text
                        Dim accType As String = "admin"
                        Dim newAdmin As New BsonDocument From {
                            {"First Name", firstName},
                            {"Middle Name", midName},
                            {"Surname", surname},
                            {"Email", email},
                            {"Phone", phone},
                            {"Username", username},
                            {"Password", password},
                            {"RFID", rfid},
                            {"role", accType}
                        }
                        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Or(
                            Builders(Of BsonDocument).Filter.Eq(Of String)("RFID", rfid),
                            Builders(Of BsonDocument).Filter.Eq(Of String)("Username", username),
                            Builders(Of BsonDocument).Filter.Eq(Of String)("Email", email)
                        )
                        'pang double check kung merong same rfid, username, email sa db
                        Dim count As Long = adminCol.CountDocuments(filter)
                        If count > 0 Then
                            MessageBox.Show("The email, username, or RFID is already in use by another admin.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Dim pendingCollection As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("rmsAdminPendingAcc")
                            Try
                                pendingCollection.InsertOne(newAdmin)
                                hideRegPanelz()
                                Panel5.Show()
                            Catch ex As Exception
                                MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If

        ElseIf sender Is btnRegOk Then
            rmsLogin.Show()
            loadRMSLogin()
            Me.Close()
        End If
    End Sub
    Private Sub Label_Click(sender As Object, e As EventArgs) Handles panelSname.Click, panelFName.Click, panelMName.Click, panelEmail.Click,
        panelPhone.Click, panelRFID.Click, panelUsernam.Click, panelPasswor.Click, lblReg1.Click, lblReg2.Click, lblReg3.Click, lblReg4.Click,
        lblReg5.Click, lblReg6.Click, lblReg7.Click, lblReg8.Click, labelLogin.Click
        If sender Is panelSname OrElse sender Is panelFName OrElse sender Is panelMName OrElse sender Is lblReg1 OrElse sender Is lblReg2 OrElse sender Is lblReg3 Then
            hideRegPanelz()
            Panel1.Show()

        ElseIf sender Is panelEmail OrElse sender Is panelPhone OrElse sender Is panelRFID OrElse sender Is lblReg4 OrElse sender Is lblReg5 OrElse sender Is lblReg6 Then
            hideRegPanelz()
            Panel2.Show()

        ElseIf sender Is panelUsernam OrElse sender Is panelPasswor OrElse sender Is lblReg7 OrElse sender Is lblReg8 Then
            hideRegPanelz()
            Panel3.Show()

        ElseIf sender Is labelLogin Then
            Dim result As DialogResult = MessageBox.Show("Do you want to switch to login?" & vbCrLf & "Your registration will be discarded.", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                rmsLogin.Show()
                rmsLogin.Location = Me.Location
                Me.Close()
                loadRMSLogin()
                rmsLogin.tboxUsername.Focus()
            End If
        End If
    End Sub
    Private Sub Panel4_VisibleChanged(sender As Object, e As EventArgs) Handles Panel4.VisibleChanged
        panelFName.Text = regFName.Text
        panelMName.Text = regMName.Text
        panelSname.Text = regSname.Text
        panelEmail.Text = regEmail.Text
        panelPhone.Text = regPhone.Text
        panelRFID.Text = regRFID.Text
        panelUsernam.Text = regUsername.Text
        panelPasswor.Text = regPassw2.Text
    End Sub
    Private Sub Panel5_VisibleChanged(sender As Object, e As EventArgs) Handles Panel5.VisibleChanged
        lblDateTime.Text = tiempoAhora
    End Sub
    Private Sub regPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles regPhone.KeyPress
        'check if the inputted char is a number/+ sign
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub regFormTextChanged(sender As Object, e As EventArgs) Handles regEmail.TextChanged, regRFID.TextChanged, regUsername.TextChanged, regPassw.TextChanged, regPassw2.TextChanged
        If sender Is regEmail Then
            Dim cursorPos As Integer = regEmail.SelectionStart
            'para walang space na ma-input
            regEmail.Text = regEmail.Text.Replace(" ", "")
            regEmail.SelectionStart = cursorPos
            If regEmail.Text = "" Then
                lblPanel2Note.Visible = True
                regEmail.Focus()
            Else
                lblPanel2Note.Visible = False
            End If

        ElseIf sender Is regRFID Then
            Dim cursorPos As Integer = regRFID.SelectionStart
            regRFID.Text = regRFID.Text.Replace(" ", "")
            regRFID.SelectionStart = cursorPos
            If regRFID.Text = "" Then
                lblPanel2Note.Visible = True
                regRFID.Focus()
            Else
                lblPanel2Note.Visible = False
            End If

        ElseIf sender Is regUsername Then
            Dim cursorPos As Integer = regUsername.SelectionStart
            regUsername.Text = regUsername.Text.Replace(" ", "")
            regUsername.SelectionStart = cursorPos
            If regUsername.Text = "" Then
                lblPanel3Note.Visible = True
                regUsername.Focus()
            Else
                lblPanel3Note.Visible = False
            End If

        ElseIf sender Is regPassw Then
            Dim cursorPos As Integer = regPassw.SelectionStart
            regPassw.Text = regPassw.Text.Replace(" ", "")
            regPassw.SelectionStart = cursorPos
            If regPassw.Text = "" Then
                lblPanel3Note.Visible = True
                regPassw.Focus()
            Else
                lblPanel3Note.Visible = False
            End If
            If regPassw.Text.Length < 8 Then
                lblPassShort.Visible = True
            Else
                lblPassShort.Visible = False
            End If

        ElseIf sender Is regPassw2 Then
            Dim cursorPos As Integer = regPassw2.SelectionStart
            regPassw2.Text = regPassw2.Text.Replace(" ", "")
            regPassw2.SelectionStart = cursorPos
            If regPassw2.Text = "" Then
                lblPanel3Note.Visible = True
                regPassw2.Focus()
            Else
                lblPanel3Note.Visible = False
            End If
        End If
    End Sub
End Class