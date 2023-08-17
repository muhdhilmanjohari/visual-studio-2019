Public Class BookReturn
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = " " Then
            Exit Sub
        Else
            Dim strCantFind As String = txtSearch.Text
            DataTable2BindingSource.Filter = "(BorrowerName Like '" & txtSearch.Text & "')"
            If DataTable2BindingSource.Count <> 0 Then
                MsgBox("Found")
                txtName.Text = txtSearch.Text
            Else
                MsgBox("-->" & strCantFind & "not exist")
            End If

        End If
    End Sub

    Private Sub LateReturnStatusCheckBox_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        DataTable2BindingSource.MoveFirst()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        DataTable2BindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        DataTable2BindingSource.MovePrevious()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        DataTable2BindingSource.MoveLast()
    End Sub

    Private Sub chkReturn_CheckedChanged(sender As Object, e As EventArgs) Handles chkReturn.CheckedChanged
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub BookReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'DB1DataSet.DataTable2' table. You can move, or remove it, as needed.
    Me.DataTable2TableAdapter.Fill(Me.DB1DataSet.DataTable2)

End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        MenuList.Show()
        Me.Close()

    End Sub
End Class