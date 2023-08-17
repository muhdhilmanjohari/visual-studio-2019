Public Class Borrower
    Private Sub BorrowerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BorrowerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BorrowerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub Borrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB1DataSet.Borrower' table. You can move, or remove it, as needed.
        Me.BorrowerTableAdapter.Fill(Me.DB1DataSet.Borrower)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BorrowerBindingSource.AddNew()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        BorrowerBindingSource.EndEdit()
        BorrowerTableAdapter.Update(DB1DataSet.Borrower)
        MsgBox("Data Saved")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        BorrowerBindingSource.RemoveCurrent()
        BorrowerTableAdapter.Update(DB1DataSet.Borrower)
        MsgBox("Data Deleted")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        MenuList.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = " " Then
            Exit Sub
        Else
            Dim strCantFind As String = txtSearch.Text
            BorrowerBindingSource.Filter = "(BorrowerName Like '" & txtSearch.Text & "')"
            If BorrowerBindingSource.Count <> 0 Then
                MsgBox("Found")
                txtName.Text = txtSearch.Text
            Else
                MsgBox("-->" & strCantFind & "not exist")
            End If

        End If
        Me.BorrowerTableAdapter.Fill(Me.DB1DataSet.Borrower)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Clear()

    End Sub

    Private Sub btnBorrowed_Click(sender As Object, e As EventArgs) Handles btnBorrowed.Click
        BookList.Show()

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        BorrowerBindingSource.MoveFirst()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BorrowerBindingSource.MoveNext()

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        BorrowerBindingSource.MoveLast()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        BorrowerBindingSource.MovePrevious()

    End Sub
End Class