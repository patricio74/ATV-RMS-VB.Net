Imports System.Globalization
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class rmsRegistration

    Dim tiempoAhora As String = DateTime.Now.ToString("MMM d, yyyy hh:mm tt")

    Private Sub clearRegForm()
        regFName.Clear()
        regMName.Clear()
        regSname.Clear()
        regEmail.Clear()
        regPhone.Clear()
        regUsername.Clear()
        regPassw.Clear()
        regPassw2.Clear()
        regRFID.Clear()
    End Sub

    Private Sub hideRegPanelz()
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
        Panel5.Hide()
    End Sub

    Private Sub rmsRegistration_Load(sender As Object, e As EventArgs) Handles Me.Load
        connectToMongo()
        initializeDraggablePanel(panelTop)
        hideRegPanelz()
        Panel1.Show()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        rmsLogin.Show()
        rmsLogin.Location = Me.Location
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnNext1.Click, btnNext2.Click, btnNext3.Click,
        btnReg.Click, btnRegOk.Click, btnRet1.Click, btnRet2.Click
        If sender Is btnRet1 Then
            hideRegPanelz()
            Panel1.Show()

        ElseIf sender Is btnNext1 Or sender Is btnRet2 Then
            regFName.Text.Trim()
            regSname.Text.Trim()
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
                lblHello.Text = "Hi, " + regFName.Text + "!"
            End If

        ElseIf sender Is btnNext2 Then
            If String.IsNullOrWhiteSpace(regEmail.Text) Or String.IsNullOrWhiteSpace(regPhone.Text) Or String.IsNullOrWhiteSpace(regRFID.Text) Then
                lblPanel2Note.Visible = True
            Else
                lblPanel2Note.Visible = False
            End If
            Try
                'add code for textbox proper phone format(+639xxxx, 09xxxxx)
                'check db for duplicates
                'if email already in use: show label for email
                'proceed to panel3 if there's no dup..
                hideRegPanelz()
                Panel3.Show()
            Catch ex As Exception

            End Try

        ElseIf sender Is btnNext3 Then
            'check username for duplicate
            'username length >4 : show label
            'check pw for both textboxes, show label if pw didn't match
            'enable next button if username does not exist in db, password match
            If regPassw.Text = "" Or regPassw2.Text <> regPassw.Text Then
                lblPanel3Note.Visible = True
            Else
                lblPanel3Note.Visible = False
            End If
            hideRegPanelz()
            Panel4.Show()

        ElseIf sender Is btnReg Then
            'add confirmation dialog
            'insert to pendingAdminCollection
            If regFName.Text = "" Or regSname.Text = "" Or regEmail.Text = "" Or regPhone.Text = "" Or regRFID.Text = "" Or regUsername.Text = "" Or regPassw2.Text = "" Then
                'replace msgbox with label
                MessageBox.Show("Fill out all the fields to continue.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim result As DialogResult = MessageBox.Show("Do you want to submit your registration?", "Confirmation", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Try
                        Dim firstName As String = regFName.Text()
                        Dim midName As String = regMName.Text()
                        Dim surname As String = regSname.Text()
                        Dim email As String = regEmail.Text.Trim()
                        Dim phone As String = regPhone.Text.Trim()
                        Dim username As String = regUsername.Text.Trim()
                        Dim password As String = regPassw.Text.Trim()
                        Dim rfid As String = regRFID.Text.Trim()
                        Dim role As String = "admin"

                        Dim newAdmin As New BsonDocument From {
                    {"First Name", firstName},
                    {"Middle Name", midName},
                    {"Surname", surname},
                    {"Email", email},
                    {"Phone", phone},
                    {"Username", username},
                    {"Password", password},
                    {"RFID", rfid},
                    {"role", role}
                }
                        Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("rmsAdmin")
                        Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Or(
                    Builders(Of BsonDocument).Filter.Eq(Of String)("RFID", rfid),
                    Builders(Of BsonDocument).Filter.Eq(Of String)("Username", username),
                    Builders(Of BsonDocument).Filter.Eq(Of String)("Email", email)
                )
                        'check if there's a same rfid, username, email sa db
                        Dim count As Long = collection.CountDocuments(filter)
                        If count > 0 Then
                            MessageBox.Show("The email, username, or RFID is already in use by another admin.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Dim pendingCollection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("rmsAdminPendingAcc")
                            Try
                                pendingCollection.InsertOne(newAdmin)
                                'MessageBox.Show("Your registration is waiting for admin approval. We will notify you through SMS once your registration is approved.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.None)
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
            'success message
            'msgbx wait for admin
            'send sms if registration is successful

        ElseIf sender Is btnRegOk Then
            'add msgbox for confirmation
            rmsLogin.Show()
            loadRMSLogin()
            clearRegForm()
            Me.Close()
        End If
    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles panelSname.Click, panelFName.Click, panelMName.Click, panelEmail.Click, panelPhone.Click, panelRFID.Click, panelUsernam.Click, panelPasswor.Click,
            lblReg1.Click, lblReg2.Click, lblReg3.Click, lblReg4.Click, lblReg5.Click, lblReg6.Click, lblReg7.Click, lblReg8.Click
        If sender Is panelSname OrElse sender Is panelFName OrElse sender Is panelMName OrElse sender Is lblReg1 OrElse sender Is lblReg2 OrElse sender Is lblReg3 Then
            hideRegPanelz()
            Panel1.Show()
        ElseIf sender Is panelEmail OrElse sender Is panelPhone OrElse sender Is panelRFID OrElse sender Is lblReg4 OrElse sender Is lblReg5 OrElse sender Is lblReg6 Then
            hideRegPanelz()
            Panel2.Show()
        ElseIf sender Is panelUsernam OrElse sender Is panelPasswor OrElse sender Is lblReg7 OrElse sender Is lblReg8 Then
            hideRegPanelz()
            Panel3.Show()
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

    Private Sub labelLogin_Click(sender As Object, e As EventArgs) Handles labelLogin.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to switch to login? Your registration will be discarded.", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            rmsLogin.Show()
            rmsLogin.Location = Me.Location
            Me.Close()
            clearRegForm()
            loadRMSLogin()
            rmsLogin.tboxUsername.Focus()
        End If
    End Sub

    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles regFName.KeyPress, regMName.KeyPress, regSname.KeyPress,
        regEmail.KeyPress, regPhone.KeyPress, regRFID.KeyPress, regUsername.KeyPress, regPassw.KeyPress, regPassw2.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub regEmail_TextChanged(sender As Object, e As EventArgs) Handles regEmail.TextChanged
        Dim cursorPos As Integer = regEmail.SelectionStart
        regEmail.Text = regEmail.Text.Replace(" ", "")
        regEmail.SelectionStart = cursorPos
        If regEmail.Text = "" Then
            lblUsernameUsed.Visible = True
        Else
            lblUsernameUsed.Visible = False
        End If
        'email@email.com format
        'add code to check db for duplicates
    End Sub

    Private Sub regPhone_TextChanged(sender As Object, e As EventArgs) Handles regPhone.TextChanged
        'regPhone.Text = regPhone.Text.Replace(" ", "")
    End Sub

    Private Sub regPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles regPhone.KeyPress
        'check if the inputted char is a number/+ sign
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "+" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub regRFID_TextChanged(sender As Object, e As EventArgs) Handles regRFID.TextChanged
        'if length >=13 check sa db kung may duplicate
        regRFID.Text = regRFID.Text.Replace(" ", "")
    End Sub

    Private Sub regPassw_TextChanged(sender As Object, e As EventArgs) Handles regPassw.TextChanged
        regPassw.Text = regPassw.Text.Replace(" ", "")
        If regPassw.TextLength < 8 Then
            lblPassShort.Visible = True
        Else
            lblPassShort.Visible = False
        End If
    End Sub

    Private Sub regPassw2_TextChanged(sender As Object, e As EventArgs) Handles regPassw2.TextChanged
        regPassw2.Text = regPassw2.Text.Replace(" ", "")
        If regPassw2.Text <> regPassw.Text Then
            lblPassError.Visible = True
        Else
            lblPassError.Visible = False
        End If
    End Sub

    Private Sub regUsername_TextChanged(sender As Object, e As EventArgs) Handles regUsername.TextChanged
        regUsername.Text = regUsername.Text.Replace(" ", "")
        If regUsername.TextLength < 8 Then
            lblUsernameErr.Visible = True
            lblUsernameErr.Text = "Username too short."
        ElseIf regUsername.TextLength >= 8 Then
            'check if there's existing username in the db
            'if true-> show label
            lblUsernameErr.Visible = True
            lblUsernameErr.Text = "Username already in use."
        Else
            lblUsernameErr.Visible = False
            lblUsernameAvailable.Visible = True
        End If
    End Sub


End Class