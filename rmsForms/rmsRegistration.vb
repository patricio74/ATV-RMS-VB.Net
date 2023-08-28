Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class rmsRegistration

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

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnNext1.Click, btnNext2.Click, btnNext3.Click, btnRet1.Click, btnRet2.Click
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
                lblHello.Text = "HELLO, " + regSname.Text + "!"
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
                'proceed to panel3 if there's no dup..
                hideRegPanelz()
                Panel3.Show()
            Catch ex As Exception

            End Try

        ElseIf sender Is btnNext3 Then
            'check username for duplicate
            'check pw for both textboxes, show label if pw didn't match
            'enable next button if username does not exist in db, password match
            hideRegPanelz()
            Panel4.Show()

        ElseIf sender Is btnReg Then
            If regFName.Text = "" Or regMName.Text = "" Or regEmail.Text = "" Or regPhone.Text = "" Or regUsername.Text = "" Or regPassw.Text = "" Or regRFID.Text = "" Then
                MessageBox.Show("Fill out all the fields to continue.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    Dim firstName As String = regFName.Text()
                    Dim midName As String = regMName.Text()
                    Dim surname As String = regSname.Text()
                    Dim email As String = regEmail.Text.Trim()
                    Dim phone As String = regPhone.Text.Trim()
                    Dim username As String = regUsername.Text.Trim()
                    Dim password As String = regPassw.Text.Trim()
                    Dim rfid As String = regRFID.Text.Trim()

                    Dim newAdmin As New BsonDocument From {
                        {"First Name", firstName},
                        {"Middle Name", midName},
                        {"Surname", surname},
                        {"Email", email},
                        {"Phone", phone},
                        {"Username", username},
                        {"Password", password},
                        {"RFID", rfid}
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
                        collection.InsertOne(newAdmin)
                        MessageBox.Show("You may now login to ATV-RMS.", "Successfully registered!", MessageBoxButtons.OK, MessageBoxIcon.None)
                        rmsLogin.Show()
                        clearRegForm()
                        Me.Close()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles panelSname.Click, panelFName.Click, panelMName.Click, panelEmail.Click, panelPhone.Click, panelRFID.Click, panelUsernam.Click, panelPasswor.Click
        If sender Is panelSname OrElse sender Is panelFName OrElse sender Is panelMName Then
            hideRegPanelz()
            Panel1.Show()
        ElseIf sender Is panelEmail OrElse sender Is panelPhone OrElse sender Is panelRFID Then
            hideRegPanelz()
            Panel2.Show()
        ElseIf sender Is panelUsernam OrElse sender Is panelPasswor Then
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

    Private Sub labelLogin_Click(sender As Object, e As EventArgs) Handles labelLogin.Click
        rmsLogin.Show()
        rmsLogin.Location = Me.Location
        clearRegForm()
        Me.Close()
    End Sub

    Private Sub regEmail_TextChanged(sender As Object, e As EventArgs) Handles regEmail.TextChanged
        'email@email.com format
        'add code to check db for duplicates
    End Sub

    Private Sub regPhone_TextChanged(sender As Object, e As EventArgs) Handles regPhone.TextChanged
        '09xxxxx | +639xxxx
    End Sub

    Private Sub regRFID_TextChanged(sender As Object, e As EventArgs) Handles regRFID.TextChanged
        'if length >13 check sa db kung may duplicate
    End Sub

    Private Sub regUsername_TextChanged(sender As Object, e As EventArgs) Handles regUsername.TextChanged
        If regUsername.TextLength < 8 Then
            lblUsernameErr.Visible = True
            lblUsernameErr.Text = "Username too short."
        ElseIf regUsername.TextLength >= 8 Then
            'check if there's existing username in the db
            'if true-> show label
            lblUsernameErr.Visible = True
            lblUsernameErr.Text = "Username already exist."
        Else
            lblUsernameErr.Visible = False
        End If
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        'add confirmation dialog
        'insert to db
        'success message
        'send sms if registration is successful
    End Sub
End Class