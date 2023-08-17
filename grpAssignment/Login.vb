Imports System.Data.OleDb


Public Class Login
    Dim con As New OleDbConnection
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Hilman Joe\Downloads\DB1.accdb"
        con.Open()
        Dim logincmd As OleDbCommand = New OleDbCommand("select * from Users where [Username]='" & txtUsername.Text & "'and [Password]='" &
                                                        txtPassword.Text & "'", con)
        Dim loginrd As OleDbDataReader = logincmd.ExecuteReader
        If (loginrd.Read() = True) Then

            Me.Hide()
            MsgBox("Login Successful" & vbNewLine & " Login User: " & txtUsername.Text, MsgBoxStyle.Information)
            MenuList.Show()
        Else
            MsgBox("Login Failed", MsgBoxStyle.Critical)
            txtUsername.Clear()
            txtPassword.Clear()
        End If

    End Sub



    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()

    End Sub


End Class