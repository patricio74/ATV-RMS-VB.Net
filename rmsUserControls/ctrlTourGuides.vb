Public Class ctrlTourGuides

    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxFrstname.KeyPress, tbxMidname.KeyPress, tbxSurname.KeyPress,
    tbxEmpNo.KeyPress, tbxContNum.KeyPress, tbxemail.KeyPress, tbxSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub

End Class
