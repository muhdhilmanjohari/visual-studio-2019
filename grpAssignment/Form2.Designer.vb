<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim BookIDLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim LateReturnStatusLabel As System.Windows.Forms.Label
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim ReturnDateLabel As System.Windows.Forms.Label
        Dim DueDateLabel As System.Windows.Forms.Label
        Dim BorrowIDLabel As System.Windows.Forms.Label
        Dim BorrowerNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.BorrowerNameTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB1DataSet = New grpAssignment.DB1DataSet()
        Me.BorrowIDTextBox = New System.Windows.Forms.TextBox()
        Me.DueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReturnDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IssueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.chkLate = New System.Windows.Forms.CheckBox()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowTableAdapter = New grpAssignment.DB1DataSetTableAdapters.BorrowTableAdapter()
        Me.TableAdapterManager = New grpAssignment.DB1DataSetTableAdapters.TableAdapterManager()
        Me.BorrowBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BorrowBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        BookIDLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        LateReturnStatusLabel = New System.Windows.Forms.Label()
        IssueDateLabel = New System.Windows.Forms.Label()
        ReturnDateLabel = New System.Windows.Forms.Label()
        DueDateLabel = New System.Windows.Forms.Label()
        BorrowIDLabel = New System.Windows.Forms.Label()
        BorrowerNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BorrowBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BookIDLabel
        '
        BookIDLabel.AutoSize = True
        BookIDLabel.Location = New System.Drawing.Point(43, 59)
        BookIDLabel.Name = "BookIDLabel"
        BookIDLabel.Size = New System.Drawing.Size(49, 13)
        BookIDLabel.TabIndex = 0
        BookIDLabel.Text = "Book ID:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(263, 59)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 2
        ISBNLabel.Text = "ISBN:"
        '
        'LateReturnStatusLabel
        '
        LateReturnStatusLabel.AutoSize = True
        LateReturnStatusLabel.Location = New System.Drawing.Point(462, 59)
        LateReturnStatusLabel.Name = "LateReturnStatusLabel"
        LateReturnStatusLabel.Size = New System.Drawing.Size(99, 13)
        LateReturnStatusLabel.TabIndex = 4
        LateReturnStatusLabel.Text = "Late Return Status:"
        '
        'IssueDateLabel
        '
        IssueDateLabel.AutoSize = True
        IssueDateLabel.Location = New System.Drawing.Point(31, 126)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Size = New System.Drawing.Size(61, 13)
        IssueDateLabel.TabIndex = 6
        IssueDateLabel.Text = "Issue Date:"
        '
        'ReturnDateLabel
        '
        ReturnDateLabel.AutoSize = True
        ReturnDateLabel.Location = New System.Drawing.Point(24, 171)
        ReturnDateLabel.Name = "ReturnDateLabel"
        ReturnDateLabel.Size = New System.Drawing.Size(68, 13)
        ReturnDateLabel.TabIndex = 8
        ReturnDateLabel.Text = "Return Date:"
        '
        'DueDateLabel
        '
        DueDateLabel.AutoSize = True
        DueDateLabel.Location = New System.Drawing.Point(323, 126)
        DueDateLabel.Name = "DueDateLabel"
        DueDateLabel.Size = New System.Drawing.Size(56, 13)
        DueDateLabel.TabIndex = 10
        DueDateLabel.Text = "Due Date:"
        '
        'BorrowIDLabel
        '
        BorrowIDLabel.AutoSize = True
        BorrowIDLabel.Location = New System.Drawing.Point(35, 239)
        BorrowIDLabel.Name = "BorrowIDLabel"
        BorrowIDLabel.Size = New System.Drawing.Size(57, 13)
        BorrowIDLabel.TabIndex = 12
        BorrowIDLabel.Text = "Borrow ID:"
        '
        'BorrowerNameLabel
        '
        BorrowerNameLabel.AutoSize = True
        BorrowerNameLabel.Location = New System.Drawing.Point(215, 236)
        BorrowerNameLabel.Name = "BorrowerNameLabel"
        BorrowerNameLabel.Size = New System.Drawing.Size(83, 13)
        BorrowerNameLabel.TabIndex = 14
        BorrowerNameLabel.Text = "Borrower Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLast)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Controls.Add(BorrowerNameLabel)
        Me.GroupBox1.Controls.Add(Me.BorrowerNameTextBox)
        Me.GroupBox1.Controls.Add(BorrowIDLabel)
        Me.GroupBox1.Controls.Add(Me.BorrowIDTextBox)
        Me.GroupBox1.Controls.Add(DueDateLabel)
        Me.GroupBox1.Controls.Add(Me.DueDateDateTimePicker)
        Me.GroupBox1.Controls.Add(ReturnDateLabel)
        Me.GroupBox1.Controls.Add(Me.ReturnDateDateTimePicker)
        Me.GroupBox1.Controls.Add(IssueDateLabel)
        Me.GroupBox1.Controls.Add(Me.IssueDateDateTimePicker)
        Me.GroupBox1.Controls.Add(LateReturnStatusLabel)
        Me.GroupBox1.Controls.Add(Me.chkLate)
        Me.GroupBox1.Controls.Add(ISBNLabel)
        Me.GroupBox1.Controls.Add(Me.ISBNTextBox)
        Me.GroupBox1.Controls.Add(BookIDLabel)
        Me.GroupBox1.Controls.Add(Me.BookIDTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(66, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(772, 415)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(450, 317)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(100, 23)
        Me.btnLast.TabIndex = 19
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(344, 317)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(100, 23)
        Me.btnPrevious.TabIndex = 18
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(238, 317)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 23)
        Me.btnNext.TabIndex = 17
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(132, 317)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(100, 23)
        Me.btnFirst.TabIndex = 16
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'BorrowerNameTextBox
        '
        Me.BorrowerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "BorrowerName", True))
        Me.BorrowerNameTextBox.Location = New System.Drawing.Point(304, 233)
        Me.BorrowerNameTextBox.Name = "BorrowerNameTextBox"
        Me.BorrowerNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BorrowerNameTextBox.TabIndex = 15
        '
        'BorrowBindingSource
        '
        Me.BorrowBindingSource.DataMember = "Borrow"
        Me.BorrowBindingSource.DataSource = Me.DB1DataSet
        '
        'DB1DataSet
        '
        Me.DB1DataSet.DataSetName = "DB1DataSet"
        Me.DB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BorrowIDTextBox
        '
        Me.BorrowIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "BorrowID", True))
        Me.BorrowIDTextBox.Location = New System.Drawing.Point(98, 236)
        Me.BorrowIDTextBox.Name = "BorrowIDTextBox"
        Me.BorrowIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BorrowIDTextBox.TabIndex = 13
        '
        'DueDateDateTimePicker
        '
        Me.DueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BorrowBindingSource, "DueDate", True))
        Me.DueDateDateTimePicker.Location = New System.Drawing.Point(385, 122)
        Me.DueDateDateTimePicker.Name = "DueDateDateTimePicker"
        Me.DueDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DueDateDateTimePicker.TabIndex = 11
        '
        'ReturnDateDateTimePicker
        '
        Me.ReturnDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BorrowBindingSource, "ReturnDate", True))
        Me.ReturnDateDateTimePicker.Location = New System.Drawing.Point(98, 167)
        Me.ReturnDateDateTimePicker.Name = "ReturnDateDateTimePicker"
        Me.ReturnDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ReturnDateDateTimePicker.TabIndex = 9
        '
        'IssueDateDateTimePicker
        '
        Me.IssueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BorrowBindingSource, "IssueDate", True))
        Me.IssueDateDateTimePicker.Location = New System.Drawing.Point(98, 122)
        Me.IssueDateDateTimePicker.Name = "IssueDateDateTimePicker"
        Me.IssueDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.IssueDateDateTimePicker.TabIndex = 7
        '
        'chkLate
        '
        Me.chkLate.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BorrowBindingSource, "LateReturnStatus", True))
        Me.chkLate.Location = New System.Drawing.Point(567, 54)
        Me.chkLate.Name = "chkLate"
        Me.chkLate.Size = New System.Drawing.Size(104, 24)
        Me.chkLate.TabIndex = 5
        Me.chkLate.UseVisualStyleBackColor = True
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(304, 56)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ISBNTextBox.TabIndex = 3
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "BookID", True))
        Me.BookIDTextBox.Location = New System.Drawing.Point(98, 56)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookIDTextBox.TabIndex = 1
        '
        'BorrowTableAdapter
        '
        Me.BorrowTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.BorrowerTableAdapter = Nothing
        Me.TableAdapterManager.BorrowTableAdapter = Me.BorrowTableAdapter
        Me.TableAdapterManager.LateReturnFinesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = grpAssignment.DB1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'BorrowBindingNavigator
        '
        Me.BorrowBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BorrowBindingNavigator.BindingSource = Me.BorrowBindingSource
        Me.BorrowBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BorrowBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BorrowBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BorrowBindingNavigatorSaveItem})
        Me.BorrowBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BorrowBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BorrowBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BorrowBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BorrowBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BorrowBindingNavigator.Name = "BorrowBindingNavigator"
        Me.BorrowBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BorrowBindingNavigator.Size = New System.Drawing.Size(926, 25)
        Me.BorrowBindingNavigator.TabIndex = 1
        Me.BorrowBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BorrowBindingNavigatorSaveItem
        '
        Me.BorrowBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BorrowBindingNavigatorSaveItem.Image = CType(resources.GetObject("BorrowBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BorrowBindingNavigatorSaveItem.Name = "BorrowBindingNavigatorSaveItem"
        Me.BorrowBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BorrowBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(222, 455)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(541, 455)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 492)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.BorrowBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BorrowBindingNavigator.ResumeLayout(False)
        Me.BorrowBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DB1DataSet As DB1DataSet
    Friend WithEvents BorrowBindingSource As BindingSource
    Friend WithEvents BorrowTableAdapter As DB1DataSetTableAdapters.BorrowTableAdapter
    Friend WithEvents TableAdapterManager As DB1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BorrowBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BorrowBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BookIDTextBox As TextBox
    Friend WithEvents BorrowerNameTextBox As TextBox
    Friend WithEvents BorrowIDTextBox As TextBox
    Friend WithEvents DueDateDateTimePicker As DateTimePicker
    Friend WithEvents ReturnDateDateTimePicker As DateTimePicker
    Friend WithEvents IssueDateDateTimePicker As DateTimePicker
    Friend WithEvents chkLate As CheckBox
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClose As Button
End Class
