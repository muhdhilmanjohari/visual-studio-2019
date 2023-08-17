Public Class BookList
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BookList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB1DataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.DB1DataSet.Book)

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        MenuList.Show()
        If MenuList.Visible Then
            Me.Hide()
        End If
    End Sub
End Class