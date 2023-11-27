Public Class ctrlNotif
    Private Sub ctrlNotif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxRole.SelectedIndex = 0 'default yung admi nsa selection
        If rmsSharedVar.role = "admin" Then
            lblPendingAdmin.Visible = False
            gboxPendingAdmin.Visible = False
        ElseIf rmsSharedVar.role = "root" Then
            lblPendingAdmin.Visible = True
            gboxPendingAdmin.Visible = True
        Else
            lblPendingAdmin.Visible = False
            gboxPendingAdmin.Visible = False
        End If
    End Sub
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxDate.KeyPress, tbxName.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub smsLabel_Click(sender As Object, e As EventArgs) Handles lblSend.Click, lblReply.Click
        If sender Is lblSend Then
            gboxSend.Visible = True
            gboxReply.Visible = False
        ElseIf sender Is lblReply Then
            gboxSend.Visible = False
            gboxReply.Visible = True
        Else
            gboxSend.Visible = True
            gboxReply.Visible = False
        End If
    End Sub
    Private Sub pendingLabel_Click(sender As Object, e As EventArgs) Handles lblPendingAdmin.Click, lblPendingResume.Click
        If sender Is lblPendingResume Then
            'gboxPendingResume.Visible = True
            'gboxPendingAdmin.Visible = False
            gboxPendingResume.BringToFront()
            gboxPendingAdmin.SendToBack()
        ElseIf sender Is lblPendingAdmin Then
            'gboxPendingResume.Visible = False
            'gboxPendingAdmin.Visible = True
            gboxPendingResume.SendToBack()
            gboxPendingAdmin.BringToFront()
        Else
            gboxPendingResume.BringToFront()
            gboxPendingAdmin.SendToBack()
        End If
    End Sub

    Private Sub ctrlNotif_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            closeMongoConn()
            gboxPendingAdmin.SendToBack()
        End If
    End Sub
End Class