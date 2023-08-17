Public Class LogInfo



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB1DataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DB1DataSet.Users)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbldate.Text = DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtSearch.Text = " " Then
            Exit Sub
        Else
            Dim strCantFind As String = txtSearch.Text
            UsersBindingSource.Filter = "(StaffID Like '" & txtSearch.Text & "' )"
            If UsersBindingSource.Count <> 0 Then
                MsgBox("Found")
                txtName.Text = txtSearch.Text
            Else
                MsgBox("-->" & strCantFind & "not exist")
            End If

        End If
        Me.UsersTableAdapter.Fill(Me.DB1DataSet.Users)
    End Sub
End Class