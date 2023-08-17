<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookIssue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookIssue))
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim BorrowerNameLabel As System.Windows.Forms.Label
        Dim DueDateLabel As System.Windows.Forms.Label
        Dim ISBNLabel1 As System.Windows.Forms.Label
        Dim BorrowIDLabel As System.Windows.Forms.Label
        Dim BookIDLabel As System.Windows.Forms.Label
        Me.BorrowBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BorrowBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IssueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnBookSearch = New System.Windows.Forms.Button()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.btnBorrowerSearch = New System.Windows.Forms.Button()
        Me.txtBookSearch = New System.Windows.Forms.TextBox()
        Me.txtBorrowerSearch = New System.Windows.Forms.TextBox()
        Me.DueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.BorrowIDTextBox = New System.Windows.Forms.TextBox()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.BorrowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB1DataSet = New grpAssignment.DB1DataSet()
        Me.BorrowerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BorrowTableAdapter = New grpAssignment.DB1DataSetTableAdapters.BorrowTableAdapter()
        Me.TableAdapterManager = New grpAssignment.DB1DataSetTableAdapters.TableAdapterManager()
        Me.BookTableAdapter = New grpAssignment.DB1DataSetTableAdapters.BookTableAdapter()
        Me.BorrowerTableAdapter = New grpAssignment.DB1DataSetTableAdapters.BorrowerTableAdapter()
        Me.btnReturn = New System.Windows.Forms.Button()
        IssueDateLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        BorrowerNameLabel = New System.Windows.Forms.Label()
        DueDateLabel = New System.Windows.Forms.Label()
        ISBNLabel1 = New System.Windows.Forms.Label()
        BorrowIDLabel = New System.Windows.Forms.Label()
        BookIDLabel = New System.Windows.Forms.Label()
        CType(Me.BorrowBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BorrowBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BorrowBindingNavigator.Size = New System.Drawing.Size(936, 25)
        Me.BorrowBindingNavigator.TabIndex = 0
        Me.BorrowBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BorrowBindingNavigatorSaveItem
        '
        Me.BorrowBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BorrowBindingNavigatorSaveItem.Image = CType(resources.GetObject("BorrowBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BorrowBindingNavigatorSaveItem.Name = "BorrowBindingNavigatorSaveItem"
        Me.BorrowBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BorrowBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IssueDateLabel
        '
        IssueDateLabel.AutoSize = True
        IssueDateLabel.Location = New System.Drawing.Point(607, 181)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Size = New System.Drawing.Size(61, 13)
        IssueDateLabel.TabIndex = 1
        IssueDateLabel.Text = "Issue Date:"
        '
        'IssueDateDateTimePicker
        '
        Me.IssueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BorrowBindingSource, "IssueDate", True))
        Me.IssueDateDateTimePicker.Location = New System.Drawing.Point(674, 177)
        Me.IssueDateDateTimePicker.Name = "IssueDateDateTimePicker"
        Me.IssueDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.IssueDateDateTimePicker.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(763, 261)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBookSearch)
        Me.GroupBox1.Controls.Add(Me.btnBookSearch)
        Me.GroupBox1.Controls.Add(TitleLabel)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Controls.Add(ISBNLabel)
        Me.GroupBox1.Controls.Add(Me.txtISBN)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 232)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BOOK SEARCH"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBorrowerSearch)
        Me.GroupBox2.Controls.Add(Me.btnAdd1)
        Me.GroupBox2.Controls.Add(Me.btnBorrowerSearch)
        Me.GroupBox2.Controls.Add(BorrowerNameLabel)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Location = New System.Drawing.Point(285, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 232)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BORROWER SEARCH"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(44, 51)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 0
        ISBNLabel.Text = "ISBN:"
        '
        'txtISBN
        '
        Me.txtISBN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "ISBN", True))
        Me.txtISBN.Location = New System.Drawing.Point(85, 48)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(100, 20)
        Me.txtISBN.TabIndex = 1
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(49, 77)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 2
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(85, 74)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitleTextBox.TabIndex = 3
        '
        'BorrowerNameLabel
        '
        BorrowerNameLabel.AutoSize = True
        BorrowerNameLabel.Location = New System.Drawing.Point(16, 51)
        BorrowerNameLabel.Name = "BorrowerNameLabel"
        BorrowerNameLabel.Size = New System.Drawing.Size(83, 13)
        BorrowerNameLabel.TabIndex = 0
        BorrowerNameLabel.Text = "Borrower Name:"
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowerBindingSource, "BorrowerName", True))
        Me.txtName.Location = New System.Drawing.Point(105, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'btnBookSearch
        '
        Me.btnBookSearch.Location = New System.Drawing.Point(135, 155)
        Me.btnBookSearch.Name = "btnBookSearch"
        Me.btnBookSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnBookSearch.TabIndex = 4
        Me.btnBookSearch.Text = "SEARCH"
        Me.btnBookSearch.UseVisualStyleBackColor = True
        '
        'btnAdd1
        '
        Me.btnAdd1.Location = New System.Drawing.Point(79, 194)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd1.TabIndex = 5
        Me.btnAdd1.Text = "ADD"
        Me.btnAdd1.UseVisualStyleBackColor = True
        '
        'btnBorrowerSearch
        '
        Me.btnBorrowerSearch.Location = New System.Drawing.Point(130, 152)
        Me.btnBorrowerSearch.Name = "btnBorrowerSearch"
        Me.btnBorrowerSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrowerSearch.TabIndex = 6
        Me.btnBorrowerSearch.Text = "SEARCH"
        Me.btnBorrowerSearch.UseVisualStyleBackColor = True
        '
        'txtBookSearch
        '
        Me.txtBookSearch.Location = New System.Drawing.Point(29, 158)
        Me.txtBookSearch.Name = "txtBookSearch"
        Me.txtBookSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtBookSearch.TabIndex = 5
        '
        'txtBorrowerSearch
        '
        Me.txtBorrowerSearch.Location = New System.Drawing.Point(19, 155)
        Me.txtBorrowerSearch.Name = "txtBorrowerSearch"
        Me.txtBorrowerSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtBorrowerSearch.TabIndex = 6
        '
        'DueDateLabel
        '
        DueDateLabel.AutoSize = True
        DueDateLabel.Location = New System.Drawing.Point(612, 210)
        DueDateLabel.Name = "DueDateLabel"
        DueDateLabel.Size = New System.Drawing.Size(56, 13)
        DueDateLabel.TabIndex = 6
        DueDateLabel.Text = "Due Date:"
        '
        'DueDateDateTimePicker
        '
        Me.DueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BorrowBindingSource, "DueDate", True))
        Me.DueDateDateTimePicker.Location = New System.Drawing.Point(674, 206)
        Me.DueDateDateTimePicker.Name = "DueDateDateTimePicker"
        Me.DueDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DueDateDateTimePicker.TabIndex = 7
        '
        'ISBNLabel1
        '
        ISBNLabel1.AutoSize = True
        ISBNLabel1.Location = New System.Drawing.Point(633, 154)
        ISBNLabel1.Name = "ISBNLabel1"
        ISBNLabel1.Size = New System.Drawing.Size(35, 13)
        ISBNLabel1.TabIndex = 8
        ISBNLabel1.Text = "ISBN:"
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(674, 151)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ISBNTextBox.TabIndex = 9
        '
        'BorrowIDLabel
        '
        BorrowIDLabel.AutoSize = True
        BorrowIDLabel.Location = New System.Drawing.Point(611, 124)
        BorrowIDLabel.Name = "BorrowIDLabel"
        BorrowIDLabel.Size = New System.Drawing.Size(57, 13)
        BorrowIDLabel.TabIndex = 10
        BorrowIDLabel.Text = "Borrow ID:"
        '
        'BorrowIDTextBox
        '
        Me.BorrowIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "BorrowID", True))
        Me.BorrowIDTextBox.Location = New System.Drawing.Point(674, 121)
        Me.BorrowIDTextBox.Name = "BorrowIDTextBox"
        Me.BorrowIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BorrowIDTextBox.TabIndex = 11
        '
        'BookIDLabel
        '
        BookIDLabel.AutoSize = True
        BookIDLabel.Location = New System.Drawing.Point(619, 98)
        BookIDLabel.Name = "BookIDLabel"
        BookIDLabel.Size = New System.Drawing.Size(49, 13)
        BookIDLabel.TabIndex = 12
        BookIDLabel.Text = "Book ID:"
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BorrowBindingSource, "BookID", True))
        Me.BookIDTextBox.Location = New System.Drawing.Point(674, 95)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookIDTextBox.TabIndex = 13
        '
        'btnAdd2
        '
        Me.btnAdd2.Location = New System.Drawing.Point(674, 261)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd2.TabIndex = 14
        Me.btnAdd2.Text = "ADD"
        Me.btnAdd2.UseVisualStyleBackColor = True
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
        'BorrowerBindingSource
        '
        Me.BorrowerBindingSource.DataMember = "Borrower"
        Me.BorrowerBindingSource.DataSource = Me.DB1DataSet
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.DB1DataSet
        '
        'BorrowTableAdapter
        '
        Me.BorrowTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Me.BookTableAdapter
        Me.TableAdapterManager.BorrowerTableAdapter = Me.BorrowerTableAdapter
        Me.TableAdapterManager.BorrowTableAdapter = Me.BorrowTableAdapter
        Me.TableAdapterManager.LateReturnFinesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = grpAssignment.DB1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'BorrowerTableAdapter
        '
        Me.BorrowerTableAdapter.ClearBeforeFill = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(415, 368)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 15
        Me.btnReturn.Text = "RETURN"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'BookIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 450)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnAdd2)
        Me.Controls.Add(BookIDLabel)
        Me.Controls.Add(Me.BookIDTextBox)
        Me.Controls.Add(BorrowIDLabel)
        Me.Controls.Add(Me.BorrowIDTextBox)
        Me.Controls.Add(ISBNLabel1)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(DueDateLabel)
        Me.Controls.Add(Me.DueDateDateTimePicker)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(IssueDateLabel)
        Me.Controls.Add(Me.IssueDateDateTimePicker)
        Me.Controls.Add(Me.BorrowBindingNavigator)
        Me.Name = "BookIssue"
        Me.Text = "BookIssue"
        CType(Me.BorrowBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BorrowBindingNavigator.ResumeLayout(False)
        Me.BorrowBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BorrowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrowerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents IssueDateDateTimePicker As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents BookTableAdapter As DB1DataSetTableAdapters.BookTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BorrowerTableAdapter As DB1DataSetTableAdapters.BorrowerTableAdapter
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents BorrowerBindingSource As BindingSource
    Friend WithEvents txtBookSearch As TextBox
    Friend WithEvents btnBookSearch As Button
    Friend WithEvents txtBorrowerSearch As TextBox
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents btnBorrowerSearch As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents DueDateDateTimePicker As DateTimePicker
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents BorrowIDTextBox As TextBox
    Friend WithEvents BookIDTextBox As TextBox
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents btnReturn As Button
End Class
