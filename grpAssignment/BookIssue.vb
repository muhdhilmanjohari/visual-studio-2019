Public Class BookIssue
    Private Sub BorrowBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BorrowBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BorrowBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub BookIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB1DataSet.Borrower' table. You can move, or remove it, as needed.
        Me.BorrowerTableAdapter.Fill(Me.DB1DataSet.Borrower)
        'TODO: This line of code loads data into the 'DB1DataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.DB1DataSet.Book)
        'TODO: This line of code loads data into the 'DB1DataSet.Borrow' table. You can move, or remove it, as needed.
        Me.BorrowTableAdapter.Fill(Me.DB1DataSet.Borrow)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        BorrowBindingSource.EndEdit()
        BorrowTableAdapter.Update(DB1DataSet.Borrow)
        MsgBox("Data Saved")
    End Sub

    Private Sub btnBookSearch_Click(sender As Object, e As EventArgs) Handles btnBookSearch.Click
        If txtBookSearch.Text = " " Then
            Exit Sub
        Else
            Dim strCantFind As String = txtBookSearch.Text
            BookBindingSource.Filter = "(ISBN Like '" & txtBookSearch.Text & "')"
            If BookBindingSource.Count <> 0 Then
                MsgBox("Found")
                txtISBN.Text = txtBookSearch.Text
            Else
                MsgBox("-->" & strCantFind & "not exist")
            End If

        End If
        Me.BookTableAdapter.Fill(Me.DB1DataSet.Book)
    End Sub

    Private Sub btnBorrowerSearch_Click(sender As Object, e As EventArgs) Handles btnBorrowerSearch.Click
        If txtBorrowerSearch.Text = " " Then
            Exit Sub
        Else
            Dim strCantFind As String = txtBorrowerSearch.Text
            BorrowerBindingSource.Filter = "(BorrowerName Like '" & txtBorrowerSearch.Text & "')"
            If BorrowerBindingSource.Count <> 0 Then
                MsgBox("Found")
                txtName.Text = txtBorrowerSearch.Text
            Else
                MsgBox("-->" & strCantFind & "not exist")
            End If

        End If
        Me.BorrowerTableAdapter.Fill(Me.DB1DataSet.Borrower)
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        BorrowBindingSource.AddNew()

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        MenuList.Show()
        Me.Close()

    End Sub
End Class