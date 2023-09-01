Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ctrlCustomers

    Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("Customer")
    Private customers As List(Of Customer)

    Public Class Customer
        Public Property custID As String
        Public Property firstName As String
        Public Property middleName As String
        Public Property surname As String
        Public Property phone As String
        Public Property email As String
        Public Property gender As String
        Public Property username As String
        Public Property password As String
        Public Property address As Address
    End Class

    Public Class Address
        Public Property Street As String
        Public Property Barangay As String
        Public Property MuniCity As String
        Public Property Province As String
        Public Property Country As String
    End Class

    Private Sub ctrlCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectToMongo()
        refreshList()
    End Sub

    Private Sub ctrlCustomers_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        refreshList()
    End Sub

    Private Sub refreshList()
        populateList()
        clearCustForm()
    End Sub

    Private Sub clearCustForm()
        DataGridView1.ClearSelection()
        tbxCustID.Clear()
        tbxUsername.Clear()
        tbxPassword.Clear()
        tbxFirname.Clear()
        tbxMidname.Clear()
        tbxSurname.Clear()
        tbxPhone.Clear()
        tbxEmail.Clear()
        tbxStreet.Clear()
        tbxBarangay.Clear()
        tbxMuniCity.Clear()
        tbxProvince.Clear()
        cmbGender.SelectedIndex = -1
        cmbCountry.SelectedIndex = -1
        PictureBox1.BackgroundImage = Nothing
    End Sub

    Private Sub populateList()
        Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
        customers = New List(Of Customer)()
        For Each document As BsonDocument In documents
            Dim idElement = document.GetElement("_id")
            Dim customer As New Customer() With {
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
            customer.address = New Address With {
            .Street = address("Street").ToString,
            .Barangay = address("Barangay").ToString,
            .MuniCity = address("MuniCity").ToString,
            .Province = address("Province").ToString,
            .Country = address("Country").ToString
        }
            customers.Add(customer)
        Next
        populateCustInfo(Customers)
    End Sub
    Private Sub populateCustInfo(customers As List(Of Customer))
        DataGridView1.Rows.Clear()
        For Each cust As Customer In customers
            Dim row As New DataGridViewRow()
            row.CreateCells(
            DataGridView1, cust.custID,
            $"{cust.firstName} {cust.middleName} {cust.surname}", cust.phone,
            $"{cust.address.Street}, {cust.address.Barangay}, {cust.address.MuniCity},
            {cust.address.Province}, {cust.address.Country}", cust.email
            )
            DataGridView1.Rows.Add(row)
        Next
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            If Customers IsNot Nothing AndAlso DataGridView1.SelectedRows(0).Index < Customers.Count Then
                Dim selectedCustomer = Customers(DataGridView1.SelectedRows(0).Index)
                tbxCustID.Text = selectedCustomer.custID
                tbxFirname.Text = selectedCustomer.firstName
                tbxMidname.Text = selectedCustomer.middleName
                tbxSurname.Text = selectedCustomer.surname
                tbxPhone.Text = selectedCustomer.phone
                tbxEmail.Text = selectedCustomer.email
                cmbGender.Text = selectedCustomer.gender
                tbxUsername.Text = selectedCustomer.username
                tbxPassword.Text = selectedCustomer.password
                tbxStreet.Text = selectedCustomer.address.Street
                tbxBarangay.Text = selectedCustomer.address.Barangay
                tbxMuniCity.Text = selectedCustomer.address.MuniCity
                tbxProvince.Text = selectedCustomer.address.Province
                cmbCountry.Text = selectedCustomer.address.Country
            End If
        End If
    End Sub

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        Try
            Dim document As New BsonDocument From {
                {"FName", tbxFirname.Text},
                {"MName", tbxMidname.Text},
                {"Sname", tbxSurname.Text},
                {"Gender", cmbGender.SelectedItem.ToString()},
                {"Address", New BsonDocument From {
                    {"Street", tbxStreet.Text},
                    {"Barangay", tbxBarangay.Text},
                    {"Province", tbxProvince.Text},
                    {"Country", cmbCountry.SelectedItem.ToString()},
                    {"MuniCity", tbxMuniCity.Text}
                }},
                {"Phone", tbxPhone.Text},
                {"Email", tbxEmail.Text},
                {"Username", tbxUsername.Text},
                {"Password", tbxPassword.Text}
            }

            collection.InsertOne(document)

            MessageBox.Show("Data inserted successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            refreshList()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MoveToArchive(custID As String)
        Try
            Dim objectId As ObjectId
            If ObjectId.TryParse(custID, objectId) Then
                Dim filter = Builders(Of BsonDocument).Filter.Eq(Function(doc) doc("_id"), objectId)
                Dim document = collection.Find(filter).FirstOrDefault()

                If document IsNot Nothing Then
                    Dim archiveCollection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("archiveCustomerInfo")
                    archiveCollection.InsertOne(document)
                    collection.DeleteOne(filter)
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
            Dim selectedCustomer = Customers(DataGridView1.SelectedRows(0).Index)
            Dim custID As String = selectedCustomer.custID
            Dim result = MessageBox.Show("Are you sure you want to archive this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClrCust.Click
        refreshList()
    End Sub

End Class
