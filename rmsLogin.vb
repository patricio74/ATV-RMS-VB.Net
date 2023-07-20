Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class rmsLogin
    Private Sub rmsLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelRFIDLogin.Hide()
        panelPassLogin.Show()
        labelPassSwitch.Hide()
        labelRFIDSwitch.Show()
        checkShow.Checked = False
        tboxUsername.Focus()
    End Sub
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub labelRFID_Click(sender As Object, e As EventArgs) Handles labelRFIDSwitch.Click
        panelRFIDLogin.Show()
        panelPassLogin.Hide()
        labelPassSwitch.Show()
        labelRFIDSwitch.Hide()
        tboxPassword.Clear()
        checkShow.Checked = False
    End Sub
    Private Sub labelPassSwitch_Click(sender As Object, e As EventArgs) Handles labelPassSwitch.Click
        panelRFIDLogin.Hide()
        panelPassLogin.Show()
        labelPassSwitch.Hide()
        labelRFIDSwitch.Show()
        tboxRFID.Clear()
        checkShow.Checked = False
        tboxUsername.Focus()
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
            tboxPassword.Focus()
        Else
            tboxPassword.UseSystemPasswordChar = True
            tboxPassword.Focus()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'insert code dito para sa db, check kung tama cred
        Dim username As String = tboxUsername.Text
        Dim password As String = tboxPassword.Text
        Dim connectionString As String = "mongodb+srv://atvrms:atvrms@atvrms.nwojtse.mongodb.net/?retryWrites=true&w=majority"

        Try
            Dim client As MongoClient = New MongoClient(connectionString)
            Dim database As IMongoDatabase = client.GetDatabase("ATVRMS")
            Dim collection As IMongoCollection(Of BsonDocument) = database.GetCollection(Of BsonDocument)("rmsAdmin")
            Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("username", username)
            Dim userDocument As BsonDocument = collection.Find(filter).FirstOrDefault()
            If panelPassLogin.Visible Then
                If tboxUsername.Text = "" Then
                    MessageBox.Show("Username cannot be empty.", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tboxUsername.Focus()
                ElseIf tboxPassword.Text = "" Then
                    MessageBox.Show("Password cannot be empty.", "Blank password!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tboxPassword.Focus()
                Else
                    If userDocument IsNot Nothing Then
                        Dim storedPassword As String = userDocument("password").ToString()
                        If password = storedPassword Then
                            MessageBox.Show("Login success!", "ATV-RMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            rmsDashboard.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Incorrect password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    Else
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            ElseIf panelRFIDLogin.Visible Then
                If tboxRFID.Text = "" Then
                    MessageBox.Show("Username cannot be empty.", "Blank username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tboxRFID.Focus()
                Else
                    MessageBox.Show("wala pa po ako code dito", "ATV-RMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBox.Show("Mag login ka muna gamit passwod:>", "ATV-RMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub rmsLogin_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        tboxUsername.Focus()
    End Sub

    Private Sub panelRFIDLogin_Paint(sender As Object, e As PaintEventArgs) Handles panelRFIDLogin.Paint
        If panelRFIDLogin.Visible = True Then
            tboxRFID.Focus()
        End If
    End Sub
End Class