Imports System.Text.RegularExpressions
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ctrlCustomers

    Public Sub refreshList()
        populateList()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub clearCustForm()
        tbxCustID.Clear()
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

    Private Sub ctrlCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectToMongo()
        refreshList()
    End Sub

    Private Sub ctrlCustomers_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        refreshList()
    End Sub

    Private Sub populateList()
        Dim collection As IMongoCollection(Of BsonDocument) = connectToMongo.GetCollection(Of BsonDocument)("Customer")
        Dim documents As List(Of BsonDocument) = collection.Find(New BsonDocument()).ToList()
        DataGridView1.Rows.Clear()
        For Each document As BsonDocument In documents
            Dim row As New DataGridViewRow()
            Dim username As String = document("Username").ToString
            Dim fname As String = document("First Name").ToString()
            Dim mname As String = document("Middle Name").ToString
            Dim sname As String = document("Surname").ToString()
            Dim phone As String = document("Phone").ToString
            Dim email As String = document("Email").ToString
            Dim address As String = document("Address").ToString

            Dim fullName As String = fname + " " + mname + " " + sname

            row.CreateCells(DataGridView1, fullName, email, phone, address, username)
            DataGridView1.Rows.Add(row)
        Next
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 3 Then
            Dim addressJson As String = e.Value.ToString()
            Dim streetMatch As Match = Regex.Match(addressJson, """Street""\s*:\s*""([^""]*)""")
            Dim barangayMatch As Match = Regex.Match(addressJson, """Barangay""\s*:\s*""([^""]*)""")
            Dim municityMatch As Match = Regex.Match(addressJson, """Municipality/City""\s*:\s*""([^""]*)""")
            Dim provinceMatch As Match = Regex.Match(addressJson, """Province""\s*:\s*""([^""]*)""")
            Dim countryMatch As Match = Regex.Match(addressJson, """Country""\s*:\s*""([^""]*)""")
            Dim fullAddressParts As New List(Of String)()

            If streetMatch.Success Then
                fullAddressParts.Add(streetMatch.Groups(1).Value)
            End If
            If barangayMatch.Success Then
                fullAddressParts.Add(barangayMatch.Groups(1).Value)
            End If
            If municityMatch.Success Then
                fullAddressParts.Add(municityMatch.Groups(1).Value)
            End If
            If provinceMatch.Success AndAlso Not String.IsNullOrWhiteSpace(provinceMatch.Groups(1).Value) Then
                fullAddressParts.Add(provinceMatch.Groups(1).Value)
            End If
            If countryMatch.Success Then
                fullAddressParts.Add(countryMatch.Groups(1).Value)
            End If

            Dim fullAddress As String = String.Join(", ", fullAddressParts)

            e.Value = fullAddress
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click

    End Sub

    Private Sub btnUpdCust_Click(sender As Object, e As EventArgs) Handles btnUpdCust.Click

    End Sub

    Private Sub btnDelCust_Click(sender As Object, e As EventArgs) Handles btnDelCust.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearCustForm()
        refreshList()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    End Sub
End Class
