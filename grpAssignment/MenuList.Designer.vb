<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuList))
        Me.btnLate = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnBorrow = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnIssue = New System.Windows.Forms.Button()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLate
        '
        Me.btnLate.Location = New System.Drawing.Point(90, 379)
        Me.btnLate.Name = "btnLate"
        Me.btnLate.Size = New System.Drawing.Size(115, 41)
        Me.btnLate.TabIndex = 26
        Me.btnLate.Text = "Late Return"
        Me.btnLate.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.Location = New System.Drawing.Point(246, 379)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(115, 41)
        Me.btnUser.TabIndex = 25
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnBorrow
        '
        Me.btnBorrow.Location = New System.Drawing.Point(246, 302)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(115, 41)
        Me.btnBorrow.TabIndex = 24
        Me.btnBorrow.Text = "Borrowers"
        Me.btnBorrow.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(401, 379)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(115, 41)
        Me.btnLogin.TabIndex = 23
        Me.btnLogin.Text = "Login Information"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(563, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 41)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(563, 302)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(115, 41)
        Me.btnReturn.TabIndex = 21
        Me.btnReturn.Text = "Book Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnIssue
        '
        Me.btnIssue.Location = New System.Drawing.Point(401, 302)
        Me.btnIssue.Name = "btnIssue"
        Me.btnIssue.Size = New System.Drawing.Size(115, 41)
        Me.btnIssue.TabIndex = 20
        Me.btnIssue.Text = "Books Issue"
        Me.btnIssue.UseVisualStyleBackColor = True
        '
        'btnDetail
        '
        Me.btnDetail.Location = New System.Drawing.Point(90, 302)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(115, 41)
        Me.btnDetail.TabIndex = 19
        Me.btnDetail.Text = "Books Detail"
        Me.btnDetail.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 129)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'MenuList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLate)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnIssue)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MenuList"
        Me.Text = "MenuList"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLate As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents btnBorrow As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnIssue As Button
    Friend WithEvents btnDetail As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
