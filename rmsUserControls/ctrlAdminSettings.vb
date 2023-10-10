Public Class ctrlAdminSettings

    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxFName.KeyPress, tbxMName.KeyPress, tbxSName.KeyPress,
    tbxPhone.KeyPress, tbxRFID.KeyPress, tbxEmail.KeyPress, tbxUsername.KeyPress, tbxPword.KeyPress, tbxPword2.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'white forecolor
        'enable btnUpdate and btnCancel if tbox data <> userdoc
        'set btnUpdate bgcolor to 255, 192, 72 on textcahge
    End Sub
End Class
