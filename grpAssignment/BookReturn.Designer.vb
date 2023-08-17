<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookReturn
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
        Dim BorrowerNameLabel As System.Windows.Forms.Label
        Dim ICLabel As System.Windows.Forms.Label
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim YearPublicationLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim PublisherLabel As System.Windows.Forms.Label
        Dim IssueDateLabel As System.Windows.Forms.Label
        Dim DueDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookReturn))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ICTextBox = New System.Windows.Forms.TextBox()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB1DataSet = New grpAssignment.DB1DataSet()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.DataTable2TableAdapter = New grpAssignment.DB1DataSetTableAdapters.DataTable2TableAdapter()
        Me.TableAdapterManager = New grpAssignment.DB1DataSetTableAdapters.TableAdapterManager()
        Me.DataTable2BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DataTable2BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IssueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.chkReturn = New System.Windows.Forms.CheckBox()
        Me.PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.YearPublicationTextBox = New System.Windows.Forms.TextBox()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        BorrowerNameLabel = New System.Windows.Forms.Label()
        ICLabel = New System.Windows.Forms.Label()
        ISBNLabel = New System.Windows.Forms.Label()
        YearPublicationLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        PublisherLabel = New System.Windows.Forms.Label()
        IssueDateLabel = New System.Windows.Forms.Label()
        DueDateLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataTable2BindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BorrowerNameLabel
        '
        BorrowerNameLabel.AutoSize = True
        BorrowerNameLabel.Location = New System.Drawing.Point(108, 40)
        BorrowerNameLabel.Name = "BorrowerNameLabel"
        BorrowerNameLabel.Size = New System.Drawing.Size(83, 13)
        BorrowerNameLabel.TabIndex = 0
        BorrowerNameLabel.Text = "Borrower Name:"
        '
        'ICLabel
        '
        ICLabel.AutoSize = True
        ICLabel.Location = New System.Drawing.Point(171, 66)
        ICLabel.Name = "ICLabel"
        ICLabel.Size = New System.Drawing.Size(20, 13)
        ICLabel.TabIndex = 2
        ICLabel.Text = "IC:"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(30, 49)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 0
        ISBNLabel.Text = "ISBN:"
        '
        'YearPublicationLabel
        '
        YearPublicationLabel.AutoSize = True
        YearPublicationLabel.Location = New System.Drawing.Point(186, 49)
        YearPublicationLabel.Name = "YearPublicationLabel"
        YearPublicationLabel.Size = New System.Drawing.Size(87, 13)
        YearPublicationLabel.TabIndex = 2
        YearPublicationLabel.Text = "Year Publication:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(398, 49)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 4
        TitleLabel.Text = "Title:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(555, 49)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(41, 13)
        AuthorLabel.TabIndex = 6
        AuthorLabel.Text = "Author:"
        '
        'PublisherLabel
        '
        PublisherLabel.AutoSize = True
        PublisherLabel.Location = New System.Drawing.Point(715, 49)
        PublisherLabel.Name = "PublisherLabel"
        PublisherLabel.Size = New System.Drawing.Size(53, 13)
        PublisherLabel.TabIndex = 8
        PublisherLabel.Text = "Publisher:"
        '
        'IssueDateLabel
        '
        IssueDateLabel.AutoSize = True
        IssueDateLabel.Location = New System.Drawing.Point(37, 110)
        IssueDateLabel.Name = "IssueDateLabel"
        IssueDateLabel.Size = New System.Drawing.Size(61, 13)
        IssueDateLabel.TabIndex = 11
        IssueDateLabel.Text = "Issue Date:"
        '
        'DueDateLabel
        '
        DueDateLabel.AutoSize = True
        DueDateLabel.Location = New System.Drawing.Point(359, 108)
        DueDateLabel.Name = "DueDateLabel"
        DueDateLabel.Size = New System.Drawing.Size(56, 13)
        DueDateLabel.TabIndex = 13
        DueDateLabel.Text = "Due Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLast)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnFirst)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(ICLabel)
        Me.GroupBox1.Controls.Add(Me.ICTextBox)
        Me.GroupBox1.Controls.Add(BorrowerNameLabel)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Location = New System.Drawing.Point(180, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 272)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(354, 231)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(100, 23)
        Me.btnLast.TabIndex = 9
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(248, 231)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(100, 23)
        Me.btnPrevious.TabIndex = 8
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(142, 231)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 23)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(36, 231)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(100, 23)
        Me.btnFirst.TabIndex = 6
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(197, 177)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search Name"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(197, 151)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 4
        '
        'ICTextBox
        '
        Me.ICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable2BindingSource, "IC", True))
        Me.ICTextBox.Location = New System.Drawing.Point(197, 63)
        Me.ICTextBox.Name = "ICTextBox"
        Me.ICTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ICTextBox.TabIndex = 3
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.DB1DataSet
        '
        'DB1DataSet
        '
        Me.DB1DataSet.DataSetName = "DB1DataSet"
        Me.DB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable2BindingSource, "BorrowerName", True))
        Me.txtName.Location = New System.Drawing.Point(197, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.BorrowerTableAdapter = Nothing
        Me.TableAdapterManager.BorrowTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.LateReturnFinesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = grpAssignment.DB1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'DataTable2BindingNavigator
        '
        Me.DataTable2BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DataTable2BindingNavigator.BindingSource = Me.DataTable2BindingSource
        Me.DataTable2BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DataTable2BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DataTable2BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DataTable2BindingNavigatorSaveItem})
        Me.DataTable2BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DataTable2BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DataTable2BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DataTable2BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DataTable2BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DataTable2BindingNavigator.Name = "DataTable2BindingNavigator"
        Me.DataTable2BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DataTable2BindingNavigator.Size = New System.Drawing.Size(1082, 25)
        Me.DataTable2BindingNavigator.TabIndex = 1
        Me.DataTable2BindingNavigator.Text = "BindingNavigator1"
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
        'DataTable2BindingNavigatorSaveItem
        '
        Me.DataTable2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DataTable2BindingNavigatorSaveItem.Enabled = False
        Me.DataTable2BindingNavigatorSaveItem.Image = CType(resources.GetObject("DataTable2BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DataTable2BindingNavigatorSaveItem.Name = "DataTable2BindingNavigatorSaveItem"
        Me.DataTable2BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DataTable2BindingNavigatorSaveItem.Text = "Save Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(DueDateLabel)
        Me.GroupBox2.Controls.Add(Me.DueDateDateTimePicker)
        Me.GroupBox2.Controls.Add(IssueDateLabel)
        Me.GroupBox2.Controls.Add(Me.IssueDateDateTimePicker)
        Me.GroupBox2.Controls.Add(Me.chkReturn)
        Me.GroupBox2.Controls.Add(PublisherLabel)
        Me.GroupBox2.Controls.Add(Me.PublisherTextBox)
        Me.GroupBox2.Controls.Add(AuthorLabel)
        Me.GroupBox2.Controls.Add(Me.AuthorTextBox)
        Me.GroupBox2.Controls.Add(TitleLabel)
        Me.GroupBox2.Controls.Add(Me.TitleTextBox)
        Me.GroupBox2.Controls.Add(YearPublicationLabel)
        Me.GroupBox2.Controls.Add(Me.YearPublicationTextBox)
        Me.GroupBox2.Controls.Add(ISBNLabel)
        Me.GroupBox2.Controls.Add(Me.ISBNTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1004, 171)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DueDateDateTimePicker
        '
        Me.DueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataTable2BindingSource, "DueDate", True))
        Me.DueDateDateTimePicker.Location = New System.Drawing.Point(421, 104)
        Me.DueDateDateTimePicker.Name = "DueDateDateTimePicker"
        Me.DueDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DueDateDateTimePicker.TabIndex = 14
        '
        'IssueDateDateTimePicker
        '
        Me.IssueDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DataTable2BindingSource, "IssueDate", True))
        Me.IssueDateDateTimePicker.Location = New System.Drawing.Point(104, 106)
        Me.IssueDateDateTimePicker.Name = "IssueDateDateTimePicker"
        Me.IssueDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.IssueDateDateTimePicker.TabIndex = 12
        '
        'chkReturn
        '
        Me.chkReturn.AutoSize = True
        Me.chkReturn.Location = New System.Drawing.Point(903, 45)
        Me.chkReturn.Name = "chkReturn"
        Me.chkReturn.Size = New System.Drawing.Size(74, 17)
        Me.chkReturn.TabIndex = 10
        Me.chkReturn.Text = "To Return"
        Me.chkReturn.UseVisualStyleBackColor = True
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable2BindingSource, "Publisher", True))
        Me.PublisherTextBox.Location = New System.Drawing.Point(774, 46)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PublisherTextBox.TabIndex = 9
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable2BindingSource, "Author", True))
        Me.AuthorTextBox.Location = New System.Drawing.Point(602, 46)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorTextBox.TabIndex = 7
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable2BindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(434, 46)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitleTextBox.TabIndex = 5
        '
        'YearPublicationTextBox
        '
        Me.YearPublicationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable2BindingSource, "YearPublication", True))
        Me.YearPublicationTextBox.Location = New System.Drawing.Point(279, 46)
        Me.YearPublicationTextBox.Name = "YearPublicationTextBox"
        Me.YearPublicationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YearPublicationTextBox.TabIndex = 3
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable2BindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(71, 46)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ISBNTextBox.TabIndex = 1
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(484, 495)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 23)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'BookReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 530)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataTable2BindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "BookReturn"
        Me.Text = "BookReturn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataTable2BindingNavigator.ResumeLayout(False)
        Me.DataTable2BindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DB1DataSet As DB1DataSet
    Friend WithEvents DataTable2BindingSource As BindingSource
    Friend WithEvents DataTable2TableAdapter As DB1DataSetTableAdapters.DataTable2TableAdapter
    Friend WithEvents TableAdapterManager As DB1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataTable2BindingNavigator As BindingNavigator
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
    Friend WithEvents DataTable2BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnLast As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ICTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DueDateDateTimePicker As DateTimePicker
    Friend WithEvents IssueDateDateTimePicker As DateTimePicker
    Friend WithEvents chkReturn As CheckBox
    Friend WithEvents PublisherTextBox As TextBox
    Friend WithEvents AuthorTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents YearPublicationTextBox As TextBox
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents btnReturn As Button
End Class
