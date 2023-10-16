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
    Private Sub ctrlCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshList()
    End Sub
    Private Sub refreshList()
        populateList()
        clearCustForm()
    End Sub
    Private Sub populateList()
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
        DataGridView1.Rows.Clear()
        For Each cust As customerDocs In customers
            Dim row As New DataGridViewRow()
            row.CreateCells(
            DataGridView1, cust.custID,
            $"{cust.firstName} {cust.middleName} {cust.surname}", cust.phone,
            $"{cust.address.Street}, {cust.address.Barangay}, {cust.address.MuniCity}, {cust.address.Province}, {cust.address.Country}", cust.email
            )
            DataGridView1.Rows.Add(row)
        Next
    End Sub
    Private Sub clearCustForm()
        DataGridView1.ClearSelection()
        tbxCustID.Clear()
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
    'suppress enter key sound sa mga textboxes
    Private Sub suppressKeyPre(sender As Object, e As KeyPressEventArgs) Handles tbxUpdUsername.KeyPress, tbxUpdPassword.KeyPress, tbxUpdPhone.KeyPress,
    tbxUpdEmail.KeyPress, tbxUpdFirname.KeyPress, tbxUpdMidname.KeyPress, tbxUpdSurname.KeyPress, tbxUpdStreet.KeyPress, tbxUpdBarangay.KeyPress, tbxUpdMuniCity.KeyPress, tbxUpdProvince.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            If customerz IsNot Nothing AndAlso DataGridView1.SelectedRows(0).Index < customerz.Count Then
                Dim selectedCustomer = customerz(DataGridView1.SelectedRows(0).Index)
                tbxCustID.Text = selectedCustomer.custID
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
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        refreshList()
    End Sub
    Private Sub btnUpdCust_Click(sender As Object, e As EventArgs) Handles btnUpdCust.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow = DataGridView1.SelectedRows(0)
            Dim selectedCustomer = customerz(selectedRow.Index)
            Dim custID As String = selectedCustomer.custID

            ' Check if any required fields are empty
            If String.IsNullOrEmpty(tbxUpdFirname.Text) OrElse String.IsNullOrEmpty(tbxUpdSurname.Text) OrElse cbxUpdGender.SelectedIndex = -1 OrElse String.IsNullOrEmpty(tbxUpdStreet.Text) OrElse String.IsNullOrEmpty(tbxUpdBarangay.Text) OrElse String.IsNullOrEmpty(tbxUpdProvince.Text) OrElse cbxUpdCountry.SelectedIndex = -1 OrElse String.IsNullOrEmpty(tbxUpdMuniCity.Text) OrElse String.IsNullOrEmpty(tbxUpdPhone.Text) OrElse String.IsNullOrEmpty(tbxUpdEmail.Text) OrElse String.IsNullOrEmpty(tbxUpdUsername.Text) OrElse String.IsNullOrEmpty(tbxUpdPassword.Text) Then
                MessageBox.Show("Please fill in all fields to continue.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim updConfirmation As DialogResult = MessageBox.Show("Do you want to update this info?", "Confirmation", MessageBoxButtons.YesNo)
                If updConfirmation = DialogResult.Yes Then
                    ' Update the selected customer's document in MongoDB
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
                            MessageBox.Show("Customer data updated successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            refreshList()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        Else
            MessageBox.Show("Please select a customer to update.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            refreshList()
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
                    MessageBox.Show("Data archived successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    refreshList()
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
    Private Sub btnDelCust_Click(sender As Object, e As EventArgs) Handles btnDelCust.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedCustomer = customerz(DataGridView1.SelectedRows(0).Index)
            Dim custID As String = selectedCustomer.custID
            Dim result = MessageBox.Show("Are you sure you want to archive this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'move customer data to archive collection
            If result = DialogResult.Yes Then
                MoveToArchive(custID)
            ElseIf result = DialogResult.No Then
                refreshList()
            End If
        Else
            MessageBox.Show("Please select a customer to delete.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            refreshList()
        End If
    End Sub
    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        If String.IsNullOrEmpty(tbxAddFirname.Text) OrElse String.IsNullOrEmpty(tbxAddSurname.Text) OrElse cbxAddGender.SelectedIndex = -1 OrElse String.IsNullOrEmpty(tbxAddStreet.Text) OrElse String.IsNullOrEmpty(tbxAddBarangay.Text) OrElse String.IsNullOrEmpty(tbxAddProvince.Text) OrElse cbxAddCountry.SelectedIndex = -1 OrElse String.IsNullOrEmpty(tbxAddMuniCity.Text) OrElse String.IsNullOrEmpty(tbxAddPhone.Text) OrElse String.IsNullOrEmpty(tbxAddEmail.Text) OrElse String.IsNullOrEmpty(tbxAddUsername.Text) OrElse String.IsNullOrEmpty(tbxAddPassword.Text) Then
            MessageBox.Show("Please fill in all fields to continue.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                MessageBox.Show("New customer data inserted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                refreshList()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClrCust.Click
        refreshList()
    End Sub
    Private Sub ctrlCustomers_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible = False Then
            closeMongoConn()
        End If
    End Sub
    Private Sub tbxPhone_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tbxUpdPhone.KeyPress, tbxAddPhone.KeyPress
        'check if the inputted char is a number,backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
