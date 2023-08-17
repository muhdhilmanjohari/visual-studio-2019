Public Class BookDetail
    Private Sub BookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BookBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub BookDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB1DataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.DB1DataSet.Book)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BookBindingSource.AddNew()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        BookBindingSource.RemoveCurrent()
        BookTableAdapter.Update(DB1DataSet.Book)
        MsgBox("Data Deleted")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        BookBindingSource.EndEdit()
        BookTableAdapter.Update(DB1DataSet.Book)
        MsgBox("Data Saved")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        MenuList.Show()
        If MenuList.Visible Then
            Me.Hide()
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = "" Then
            Exit Sub
        Else
            Dim strCantFind As String = txtSearch.Text
            BookBindingSource.Filter = "(Author Like'" & txtSearch.Text & "' OR Title Like'" & txtSearch.Text & "' ) "
            If BookBindingSource.Count <> 0 Then
                MsgBox("Found")
                txtAuthor.Text = txtSearch.Text
            ElseIf BookBindingSource.Count <> 0 Then
                MsgBox("Found")
                txtTitle.Text = txtSearch.Text
            Else
                MsgBox("-->" & strCantFind & "not exist")

            End If
        End If
        Me.BookTableAdapter.Fill(Me.DB1DataSet.Book)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Clear()

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        ViewBook.Show()

    End Sub
End Class