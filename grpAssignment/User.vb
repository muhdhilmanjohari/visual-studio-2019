Public Class User
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB1DataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DB1DataSet.Users)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        UsersBindingSource.AddNew()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UsersBindingSource.EndEdit()
        UsersTableAdapter.Update(DB1DataSet.Users)
        MsgBox("Data Saved")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        UsersBindingSource.RemoveCurrent()
        UsersTableAdapter.Update(DB1DataSet.Users)
        MsgBox("Data Deleted")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        MenuList.Show()
        Me.Close()

    End Sub

    Private Sub btnUserList_Click(sender As Object, e As EventArgs) Handles btnUserList.Click
        UserList.Show()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = " " Then
            Exit Sub
        Else
            Dim strCantFind As String = txtSearch.Text
            UsersBindingSource.Filter = "(Username Like '" & txtSearch.Text & "')"
            If UsersBindingSource.Count <> 0 Then
                MsgBox("Found")
                txtUsername.Text = txtSearch.Text
            Else
                MsgBox("-->" & strCantFind & "not exist")
            End If

        End If
        Me.UsersTableAdapter.Fill(Me.DB1DataSet.Users)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Clear()

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        UsersBindingSource.MoveFirst()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        UsersBindingSource.MoveNext()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        UsersBindingSource.MovePrevious()

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        UsersBindingSource.MoveLast()

    End Sub
End Class