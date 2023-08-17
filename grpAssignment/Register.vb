Imports System.Data.OleDb
Imports System.Data
Public Class Register
    Dim pwd As String
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        pwd = txtPassword.Text
        Dim len As Integer
        len = pwd.Length

        If txtName.Text = "" Or txtPassword.Text = "" Or txtPhone.Text = "" Or txtStaffID.Text = "" Or txtUsername.Text = "" Then
            MsgBox("please fill the info", MsgBoxStyle.Critical)
        ElseIf len > 12 Then
            MsgBox("password length must be between 8-12", MsgBoxStyle.Critical)


        Else
            Try
                Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Hilman Joe\Downloads\DB1.accdb")
                Dim insert As String = "insert into [Users]([Username],[FullName],[StaffID],[Phone],[Password]) Values ('" & txtUsername.Text & "','" & txtName.Text & "','" & txtStaffID.Text & "','" & txtPhone.Text & "','" & txtPassword.Text & "')"
                Dim cmd As New OleDbCommand(insert, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("create success")
                Me.Close()
            Catch ex As Exception
                MsgBox("error")
            End Try
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Close()

    End Sub
End Class