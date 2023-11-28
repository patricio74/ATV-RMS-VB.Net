Public Class ctrlTourGuides
    Private tGuidez As List(Of empDoc)
    Public Class empDoc
        Public Property empID As String
        Public Property empFname As String '
        Public Property empMname As String
        Public Property empSname As String
        Public Property empGender As String

        Public Property empPhone As String
        Public Property empEmail As String
    End Class
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxUpdEmpFname.KeyPress, tbxUpdEmpMname.KeyPress, tbxUpdEmpSname.KeyPress,
    tbxUpdEmpRFID.KeyPress, tbxUpdEmpPhone.KeyPress, tbxUpdEmpEmail.KeyPress, tbxAddEmpFname.KeyPress, tbxAddEmpMname.KeyPress, tbxAddEmpSname.KeyPress,
    tbxAddEmpRFID.KeyPress, tbxAddEmpPhone.KeyPress, tbxAddEmpEmail.KeyPress, tbxSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxContNum_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tbxUpdEmpPhone.KeyPress, tbxAddEmpPhone.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub ctrlTourGuides_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            closeMongoConn()
            'clear form
            'reset tab index
        End If
    End Sub
End Class
