Public Class Late


    Private Sub LateReturnFinesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles LateReturnFinesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LateReturnFinesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text = " " Then
            Exit Sub
        Else
            Dim strCantFind As String = txtSearch.Text
            LateReturnFinesBindingSource.Filter = "(BorrowerName Like '" & txtSearch.Text & "' )"
            If LateReturnFinesBindingSource.Count <> 0 Then
                MsgBox("Found")
                txtName.Text = txtSearch.Text
            Else
                MsgBox("-->" & strCantFind & "not exist")
            End If

        End If
    End Sub


    Private Sub Late_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB1DataSet.DataTable3' table. You can move, or remove it, as needed.
        Me.DataTable3TableAdapter.Fill(Me.DB1DataSet.DataTable3)
        'TODO: This line of code loads data into the 'DB1DataSet.LateReturnFines' table. You can move, or remove it, as needed.
        Me.LateReturnFinesTableAdapter.Fill(Me.DB1DataSet.LateReturnFines)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        LateReturnFinesBindingSource.RemoveCurrent()
        LateReturnFinesTableAdapter.Update(DB1DataSet.LateReturnFines)
        MsgBox("Payment Accepted")
    End Sub
End Class