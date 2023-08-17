Public Class Form2
    Private Sub BorrowBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BorrowBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BorrowBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        BorrowBindingSource.EndEdit()
        BorrowTableAdapter.Update(DB1DataSet.Borrow)
        MsgBox("Data Saved")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        BorrowBindingSource.MoveFirst()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BorrowBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        BorrowBindingSource.MovePrevious()

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        BorrowBindingSource.MoveLast()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB1DataSet.Borrow' table. You can move, or remove it, as needed.
        Me.BorrowTableAdapter.Fill(Me.DB1DataSet.Borrow)

    End Sub

    Private Sub chkLate_CheckedChanged(sender As Object, e As EventArgs) Handles chkLate.CheckedChanged
        Late.Show()
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class