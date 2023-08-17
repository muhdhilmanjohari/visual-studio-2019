Public Class ViewBook
    Private Sub ViewBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB1DataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.DB1DataSet.Book)

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()

    End Sub
End Class