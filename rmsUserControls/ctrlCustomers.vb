Imports MongoDB.Bson
Imports MongoDB.Driver
Public Class ctrlCustomers
    Private customerz As List(Of customerDocs)
    Public Class customerDocs
        Public Property custID As String
        Public Property firstName As String
        Public Property middleName As String
        Public Property surname As String
        Public Property phone As String
        Public Property email As String
        Public Property gender As String
        Public Property username As String
        Public Property password As String
        Public Property address As custAddress
    End Class
    Public Class custAddress
        Public Property Street As String
        Public Property Barangay As String
        Public Property MuniCity As String
        Public Property Province As String
        Public Property Country As String
    End Class
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxUpdFirname.KeyPress, tbxUpdMidname.KeyPress, tbxUpdSurname.KeyPress, tbxUpdPhone.KeyPress,
        tbxUpdStreet.KeyPress, tbxUpdBarangay.KeyPress, tbxUpdMuniCity.KeyPress, tbxUpdProvince.KeyPress, tbxUpdEmail.KeyPress, tbxUpdUsername.KeyPress, tbxUpdPassword.KeyPress, tbxSearchFir.KeyPress, tbxSearchMid.KeyPress, tbxSearchSur.KeyPress,
        tbxSearchUsername.KeyPress, tbxSearchEmail.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub clearUpdForm()
        dgvCustInfo.ClearSelection()
        dgvCustHistory.ClearSelection()
        lblUpdCustID.Text = ""
        tbxUpdUsername.Clear()
        tbxUpdPassword.Clear()
        tbxUpdFirname.Clear()
        tbxUpdMidname.Clear()
        tbxUpdSurname.Clear()
        tbxUpdPhone.Clear()
        tbxUpdEmail.Clear()
        tbxUpdStreet.Clear()
        tbxUpdBarangay.Clear()
        tbxUpdMuniCity.Clear()
        tbxUpdProvince.Clear()
        cbxUpdGender.SelectedIndex = -1
        cbxUpdCountry.SelectedIndex = -1
    End Sub
    Private Sub clearAddForm()
        dgvCustInfo.ClearSelection()
        dgvCustHistory.ClearSelection()
        tbxAddFirname.Clear()
        tbxAddMidname.Clear()
        tbxAddSurname.Clear()
        tbxAddPhone.Clear()
        tbxAddStreet.Clear()
        tbxAddBarangay.Clear()
        tbxAddMuniCity.Clear()
        tbxAddProvince.Clear()
        tbxAddEmail.Clear()
        tbxAddUsername.Clear()
        tbxAddPassword.Clear()
        cbxAddGender.SelectedIndex = -1
        cbxAddCountry.SelectedIndex = -1
    End Sub
    Public Sub resetFilter()
        tbxSearchFir.Clear()
        tbxSearchMid.Clear()
        tbxSearchSur.Clear()
        tbxSearchUsername.Clear()
        tbxSearchEmail.Clear()
        cbxSearchFilter.SelectedIndex = 0
    End Sub
    Private Sub ctrlCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshList()
        resetFilter()
        tabCustomerz.SelectedIndex = 0
        tabCustInfo.SelectedIndex = 0
    End Sub
    Private Sub refreshList()
        Dim colCustomer = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("Customer")
        Dim custDocsList As List(Of BsonDocument) = colCustomer.Find(New BsonDocument()).ToList()
        customerz = New List(Of customerDocs)()
        For Each document As BsonDocument In custDocsList
            Dim idElement = document.GetElement("_id")
            Dim custList As New customerDocs() With {
                .custID = idElement.Value.AsObjectId.ToString,
                .firstName = document("FName").ToString,
                .middleName = document("MName").ToString,
                .surname = document("Sname").ToString,
                .phone = document("Phone").ToString,
                .email = document("Email").ToString,
                .gender = document("Gender").ToString,
                .username = document("Username").ToString,
                .password = document("Password").ToString
            }
            Dim address As BsonDocument = document("Address")
            custList.address = New custAddress With {
                .Street = address("Street").ToString,
                .Barangay = address("Barangay").ToString,
                .MuniCity = address("MuniCity").ToString,
                .Province = address("Province").ToString,
                .Country = address("Country").ToString
            }
            customerz.Add(custList)
        Next
        populateCustInfo(customerz)
    End Sub
    Private Sub populateCustInfo(customers As List(Of customerDocs))
        dgvCustInfo.Rows.Clear()
        For Each cust As customerDocs In customers
            Dim row As New DataGridViewRow()
            row.CreateCells(
            dgvCustInfo, cust.custID,
            $"{cust.firstName} {cust.middleName} {cust.surname}", cust.phone,
            $"{cust.address.Street}, {cust.address.Barangay}, {cust.address.MuniCity}, {cust.address.Province}, {cust.address.Country}", cust.email
            )
            dgvCustInfo.Rows.Add(row)
            dgvCustInfo.ClearSelection()
            dgvCustHistory.ClearSelection()
            clearUpdForm()
        Next
    End Sub
    Private Sub dgvCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustInfo.CellClick
        'tabCustInfo.SelectedIndex = 0
        If e.RowIndex >= 0 Then
            If customerz IsNot Nothing AndAlso e.RowIndex < customerz.Count Then
                Dim selectedCustomer = customerz(e.RowIndex)
                lblUpdCustID.Text = selectedCustomer.custID
                tbxUpdFirname.Text = selectedCustomer.firstName
                tbxUpdMidname.Text = selectedCustomer.middleName
                tbxUpdSurname.Text = selectedCustomer.surname
                tbxUpdPhone.Text = selectedCustomer.phone
                tbxUpdEmail.Text = selectedCustomer.email
                cbxUpdGender.Text = selectedCustomer.gender
                tbxUpdUsername.Text = selectedCustomer.username
                tbxUpdPassword.Text = selectedCustomer.password
                tbxUpdStreet.Text = selectedCustomer.address.Street
                tbxUpdBarangay.Text = selectedCustomer.address.Barangay
                tbxUpdMuniCity.Text = selectedCustomer.address.MuniCity
                tbxUpdProvince.Text = selectedCustomer.address.Province
                cbxUpdCountry.Text = selectedCustomer.address.Country
            End If
        End If
    End Sub
    Private Sub customerButton_Click(sender As Object, e As EventArgs) Handles btnUpdCust.Click, btnDelCust.Click
        If sender Is btnUpdCust Then
            If dgvCustInfo.SelectedRows.Count > 0 Then
                Dim selectedRow = dgvCustInfo.SelectedRows(0)
                Dim selectedCustomer = customerz(selectedRow.Index)
                Dim custID As String = selectedCustomer.custID
                If String.IsNullOrEmpty(tbxUpdFirname.Text) OrElse String.IsNullOrEmpty(tbxUpdSurname.Text) OrElse cbxUpdGender.SelectedIndex = -1 OrElse String.IsNullOrEmpty(tbxUpdStreet.Text) OrElse String.IsNullOrEmpty(tbxUpdBarangay.Text) OrElse String.IsNullOrEmpty(tbxUpdProvince.Text) OrElse cbxUpdCountry.SelectedIndex = -1 OrElse String.IsNullOrEmpty(tbxUpdMuniCity.Text) OrElse String.IsNullOrEmpty(tbxUpdPhone.Text) OrElse String.IsNullOrEmpty(tbxUpdEmail.Text) OrElse String.IsNullOrEmpty(tbxUpdUsername.Text) OrElse String.IsNullOrEmpty(tbxUpdPassword.Text) Then
                    MessageBox.Show("Please fill in all fields to continue.")
                Else
                    Dim updConfirmation As DialogResult = MessageBox.Show("Do you want to update this info?", "Confirmation", MessageBoxButtons.YesNo)
                    If updConfirmation = DialogResult.Yes Then
                        Try
                            Dim colCustomer = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("Customer")
                            Dim objectId As ObjectId
                            If ObjectId.TryParse(custID, objectId) Then
                                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                                Dim update = Builders(Of BsonDocument).Update.Set(Of String)("FName", tbxUpdFirname.Text).
                                Set(Of String)("MName", tbxUpdMidname.Text).
                                Set(Of String)("Sname", tbxUpdSurname.Text).
                                Set(Of String)("Gender", cbxUpdGender.SelectedItem.ToString()).
                                Set(Of String)("Address.Street", tbxUpdStreet.Text).
                                Set(Of String)("Address.Barangay", tbxUpdBarangay.Text).
                                Set(Of String)("Address.Province", tbxUpdProvince.Text).
                                Set(Of String)("Address.Country", cbxUpdCountry.SelectedItem.ToString()).
                                Set(Of String)("Address.MuniCity", tbxUpdMuniCity.Text).
                                Set(Of String)("Phone", tbxUpdPhone.Text).
                                Set(Of String)("Email", tbxUpdEmail.Text).
                                Set(Of String)("Username", tbxUpdUsername.Text).
                                Set(Of String)("Password", tbxUpdPassword.Text)
                                colCustomer.UpdateOne(filter, update)
                                MessageBox.Show("Customer account updated successfully.")
                                refreshList()
                                clearUpdForm()
                            End If
                        Catch ex As Exception
                            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If
                End If
            Else
                MessageBox.Show("Please select a customer to update.")
                refreshList()
            End If

        ElseIf sender Is btnDelCust Then
            If dgvCustInfo.SelectedRows.Count > 0 Then
                Dim selectedCustomer = customerz(dgvCustInfo.SelectedRows(0).Index)
                Dim custID As String = selectedCustomer.custID
                Dim result = MessageBox.Show("Are you sure you want to archive this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                'move customer data to archive collection
                If result = DialogResult.Yes Then
                    MoveToArchive(custID)
                ElseIf result = DialogResult.No Then
                    refreshList()
                End If
            Else
                MessageBox.Show("Please select a customer to delete.")
                refreshList()
            End If

        ElseIf sender Is btnAddCust Then
            If String.IsNullOrEmpty(tbxAddFirname.Text) OrElse String.IsNullOrEmpty(tbxAddSurname.Text) OrElse cbxAddGender.SelectedIndex = -1 OrElse String.IsNullOrEmpty(tbxAddStreet.Text) OrElse String.IsNullOrEmpty(tbxAddBarangay.Text) OrElse String.IsNullOrEmpty(tbxAddProvince.Text) OrElse cbxAddCountry.SelectedIndex = -1 OrElse String.IsNullOrEmpty(tbxAddMuniCity.Text) OrElse String.IsNullOrEmpty(tbxAddPhone.Text) OrElse String.IsNullOrEmpty(tbxAddEmail.Text) OrElse String.IsNullOrEmpty(tbxAddUsername.Text) OrElse String.IsNullOrEmpty(tbxAddPassword.Text) Then
                MessageBox.Show("Please fill in all fields to continue.")
            Else
                Dim colCustomer = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("Customer")
                Try
                    Dim newCustDoc As New BsonDocument From {
                        {"FName", tbxAddFirname.Text},
                        {"MName", tbxAddMidname.Text},
                        {"Sname", tbxAddSurname.Text},
                        {"Gender", cbxAddGender.SelectedItem.ToString()},
                        {"Address", New BsonDocument From {
                            {"Street", tbxAddStreet.Text},
                            {"Barangay", tbxAddBarangay.Text},
                            {"Province", tbxAddProvince.Text},
                            {"Country", cbxAddCountry.SelectedItem.ToString()},
                            {"MuniCity", tbxAddMuniCity.Text}
                        }},
                        {"Phone", tbxAddPhone.Text},
                        {"Email", tbxAddEmail.Text},
                        {"Username", tbxAddUsername.Text},
                        {"Password", tbxAddPassword.Text}
                    }
                    colCustomer.InsertOne(newCustDoc)
                    MessageBox.Show("New customer account added successfully.")
                    refreshList()
                    clearAddForm()
                    tabCustInfo.SelectedIndex = 0
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        ElseIf sender Is btnClrCust Then
            refreshList()
            clearAddForm()
            clearUpdForm()
        End If
    End Sub
    Private Sub MoveToArchive(custID As String)
        Dim colCustomer = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("Customer")
        Try
            Dim objectId As ObjectId
            If ObjectId.TryParse(custID, objectId) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                Dim document = colCustomer.Find(filter).FirstOrDefault()
                If document IsNot Nothing Then
                    Dim archiveCollection As IMongoCollection(Of BsonDocument) = rmsSharedVar.mongoDBase.GetCollection(Of BsonDocument)("archiveCustomerInfo")
                    archiveCollection.InsertOne(document)
                    colCustomer.DeleteOne(filter)
                    MessageBox.Show("Customer account archived successfully.")
                    refreshList()
                    clearUpdForm()
                Else
                    MessageBox.Show("Customer not found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    refreshList()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            refreshList()
        End Try
    End Sub
    Private Sub tbxPhone_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tbxUpdPhone.KeyPress, tbxAddPhone.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub tabCustomerz_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabCustomerz.SelectedIndexChanged
        If tabCustomerz.SelectedIndex = 0 Then 'customer acc details tab
            panelFilter.Visible = True
            panelAddAcc.Visible = False
            tabCustInfo.Visible = True
            tabCustInfo.SelectedIndex = 0
            refreshList()
            clearAddForm()
        ElseIf tabCustomerz.SelectedIndex = 1 Then 'add new acc tab
            clearUpdForm()
            panelFilter.Visible = False
            tabCustInfo.Visible = False
            panelAddAcc.BringToFront()
            panelAddAcc.Visible = True
        End If
    End Sub
    Private Sub tabCustInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabCustInfo.SelectedIndexChanged
        If tabCustInfo.SelectedIndex = 0 Then 'update tab
            'refreshList()
            'clearAddForm()
        ElseIf tabCustInfo.SelectedIndex = 1 Then 'add tab
            'clearUpdForm()
            'refreshList()
        End If
    End Sub
    Private Sub cbxSearchFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSearchFilter.SelectedIndexChanged
        If cbxSearchFilter.SelectedIndex = 0 Then 'search using username
            tbxSearchUsername.Visible = True
            tbxSearchFir.Visible = False
            tbxSearchMid.Visible = False
            tbxSearchSur.Visible = False
            tbxSearchEmail.Visible = False
        ElseIf cbxSearchFilter.SelectedIndex = 1 Then 'search customer name
            tbxSearchUsername.Visible = False
            tbxSearchFir.Visible = True
            tbxSearchMid.Visible = True
            tbxSearchSur.Visible = True
            tbxSearchEmail.Visible = False
        ElseIf cbxSearchFilter.SelectedIndex = 2 Then 'search email
            tbxSearchUsername.Visible = False
            tbxSearchFir.Visible = False
            tbxSearchMid.Visible = False
            tbxSearchSur.Visible = False
            tbxSearchEmail.Visible = True
        Else 'default
            tbxSearchUsername.Visible = True
            tbxSearchFir.Visible = False
            tbxSearchMid.Visible = False
            tbxSearchSur.Visible = False
            tbxSearchEmail.Visible = False
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub
    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        resetFilter()
        refreshList()
        tabCustInfo.SelectedIndex = 0
    End Sub
    Private Sub ctrlCustomers_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            closeMongoConn()
            clearAddForm()
            clearUpdForm()
            resetFilter()
            tabCustomerz.SelectedIndex = 0
            tabCustInfo.SelectedIndex = 0
        End If
    End Sub
End Class