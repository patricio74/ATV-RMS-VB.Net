Public Class ctrlTourGuides
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxFrstname.KeyPress, tbxMidname.KeyPress, tbxSurname.KeyPress,
    tbxEmpNo.KeyPress, tbxContNum.KeyPress, tbxEmail.KeyPress, tbxSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxContNum_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tbxContNum.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
