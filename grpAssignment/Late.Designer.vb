<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Late
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
        Dim BorrowIDLabel As System.Windows.Forms.Label
        Dim FinesLabel As System.Windows.Forms.Label
        Dim PaymentLabel As System.Windows.Forms.Label
        Dim BorrowerNameLabel As System.Windows.Forms.Label
        Dim PaymentDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Late))
        Me.DB1DataSet = New grpAssignment.DB1DataSet()
        Me.LateReturnFinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LateReturnFinesTableAdapter = New grpAssignment.DB1DataSetTableAdapters.LateReturnFinesTableAdapter()
        Me.TableAdapterManager = New grpAssignment.DB1DataSetTableAdapters.TableAdapterManager()
        Me.LateReturnFinesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LateReturnFinesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BorrowIDTextBox = New System.Windows.Forms.TextBox()
        Me.FinesTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.PaymentDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearPublicationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ICDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable3TableAdapter = New grpAssignment.DB1DataSetTableAdapters.DataTable3TableAdapter()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        BorrowIDLabel = New System.Windows.Forms.Label()
        FinesLabel = New System.Windows.Forms.Label()
        PaymentLabel = New System.Windows.Forms.Label()
        BorrowerNameLabel = New System.Windows.Forms.Label()
        PaymentDateLabel = New System.Windows.Forms.Label()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LateReturnFinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LateReturnFinesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LateReturnFinesBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BorrowIDLabel
        '
        BorrowIDLabel.AutoSize = True
        BorrowIDLabel.Location = New System.Drawing.Point(328, 57)
        BorrowIDLabel.Name = "BorrowIDLabel"
        BorrowIDLabel.Size = New System.Drawing.Size(57, 13)
        BorrowIDLabel.TabIndex = 1
        BorrowIDLabel.Text = "Borrow ID:"
        '
        'FinesLabel
        '
        FinesLabel.AutoSize = True
        FinesLabel.Location = New System.Drawing.Point(349, 83)
        FinesLabel.Name = "FinesLabel"
        FinesLabel.Size = New System.Drawing.Size(35, 13)
        FinesLabel.TabIndex = 3
        FinesLabel.Text = "Fines:"
        '
        'PaymentLabel
        '
        PaymentLabel.AutoSize = True
        PaymentLabel.Location = New System.Drawing.Point(333, 109)
        PaymentLabel.Name = "PaymentLabel"
        PaymentLabel.Size = New System.Drawing.Size(51, 13)
        PaymentLabel.TabIndex = 5
        PaymentLabel.Text = "Payment:"
        '
        'BorrowerNameLabel
        '
        BorrowerNameLabel.AutoSize = True
        BorrowerNameLabel.Location = New System.Drawing.Point(301, 135)
        BorrowerNameLabel.Name = "BorrowerNameLabel"
        BorrowerNameLabel.Size = New System.Drawing.Size(83, 13)
        BorrowerNameLabel.TabIndex = 7
        BorrowerNameLabel.Text = "Borrower Name:"
        '
        'PaymentDateLabel
        '
        PaymentDateLabel.AutoSize = True
        PaymentDateLabel.Location = New System.Drawing.Point(307, 162)
        PaymentDateLabel.Name = "PaymentDateLabel"
        PaymentDateLabel.Size = New System.Drawing.Size(77, 13)
        PaymentDateLabel.TabIndex = 9
        PaymentDateLabel.Text = "Payment Date:"
        '
        'DB1DataSet
        '
        Me.DB1DataSet.DataSetName = "DB1DataSet"
        Me.DB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LateReturnFinesBindingSource
        '
        Me.LateReturnFinesBindingSource.DataMember = "LateReturnFines"
        Me.LateReturnFinesBindingSource.DataSource = Me.DB1DataSet
        '
        'LateReturnFinesTableAdapter
        '
        Me.LateReturnFinesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.BorrowerTableAdapter = Nothing
        Me.TableAdapterManager.BorrowTableAdapter = Nothing
        Me.TableAdapterManager.LateReturnFinesTableAdapter = Me.LateReturnFinesTableAdapter
        Me.TableAdapterManager.UpdateOrder = grpAssignment.DB1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'LateReturnFinesBindingNavigator
        '
        Me.LateReturnFinesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LateReturnFinesBindingNavigator.BindingSource = Me.LateReturnFinesBindingSource
        Me.LateReturnFinesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LateReturnFinesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LateReturnFinesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LateReturnFinesBindingNavigatorSaveItem})
        Me.LateReturnFinesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LateReturnFinesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LateReturnFinesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LateReturnFinesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LateReturnFinesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LateReturnFinesBindingNavigator.Name = "LateReturnFinesBindingNavigator"
        Me.LateReturnFinesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LateReturnFinesBindingNavigator.Size = New System.Drawing.Size(1172, 25)
        Me.LateReturnFinesBindingNavigator.TabIndex = 0
        Me.LateReturnFinesBindingNavigator.Text = "BindingNavigator1"
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
        'LateReturnFinesBindingNavigatorSaveItem
        '
        Me.LateReturnFinesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LateReturnFinesBindingNavigatorSaveItem.Image = CType(resources.GetObject("LateReturnFinesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LateReturnFinesBindingNavigatorSaveItem.Name = "LateReturnFinesBindingNavigatorSaveItem"
        Me.LateReturnFinesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LateReturnFinesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BorrowIDTextBox
        '
        Me.BorrowIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LateReturnFinesBindingSource, "BorrowID", True))
        Me.BorrowIDTextBox.Location = New System.Drawing.Point(390, 54)
        Me.BorrowIDTextBox.Name = "BorrowIDTextBox"
        Me.BorrowIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BorrowIDTextBox.TabIndex = 2
        '
        'FinesTextBox
        '
        Me.FinesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LateReturnFinesBindingSource, "Fines", True))
        Me.FinesTextBox.Location = New System.Drawing.Point(390, 80)
        Me.FinesTextBox.Name = "FinesTextBox"
        Me.FinesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FinesTextBox.TabIndex = 4
        '
        'PaymentTextBox
        '
        Me.PaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LateReturnFinesBindingSource, "Payment", True))
        Me.PaymentTextBox.Location = New System.Drawing.Point(390, 106)
        Me.PaymentTextBox.Name = "PaymentTextBox"
        Me.PaymentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PaymentTextBox.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LateReturnFinesBindingSource, "BorrowerName", True))
        Me.txtName.Location = New System.Drawing.Point(390, 132)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 8
        '
        'PaymentDateDateTimePicker
        '
        Me.PaymentDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LateReturnFinesBindingSource, "PaymentDate", True))
        Me.PaymentDateDateTimePicker.Location = New System.Drawing.Point(390, 158)
        Me.PaymentDateDateTimePicker.Name = "PaymentDateDateTimePicker"
        Me.PaymentDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.PaymentDateDateTimePicker.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.YearPublicationDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.PublisherDataGridViewTextBoxColumn, Me.IssueDateDataGridViewTextBoxColumn, Me.FinesDataGridViewTextBoxColumn, Me.BorrowerNameDataGridViewTextBoxColumn, Me.ICDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DueDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataTable3BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 294)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1145, 150)
        Me.DataGridView1.TabIndex = 11
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        '
        'YearPublicationDataGridViewTextBoxColumn
        '
        Me.YearPublicationDataGridViewTextBoxColumn.DataPropertyName = "YearPublication"
        Me.YearPublicationDataGridViewTextBoxColumn.HeaderText = "YearPublication"
        Me.YearPublicationDataGridViewTextBoxColumn.Name = "YearPublicationDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        '
        'PublisherDataGridViewTextBoxColumn
        '
        Me.PublisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.Name = "PublisherDataGridViewTextBoxColumn"
        '
        'IssueDateDataGridViewTextBoxColumn
        '
        Me.IssueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate"
        Me.IssueDateDataGridViewTextBoxColumn.Name = "IssueDateDataGridViewTextBoxColumn"
        '
        'FinesDataGridViewTextBoxColumn
        '
        Me.FinesDataGridViewTextBoxColumn.DataPropertyName = "Fines"
        Me.FinesDataGridViewTextBoxColumn.HeaderText = "Fines"
        Me.FinesDataGridViewTextBoxColumn.Name = "FinesDataGridViewTextBoxColumn"
        '
        'BorrowerNameDataGridViewTextBoxColumn
        '
        Me.BorrowerNameDataGridViewTextBoxColumn.DataPropertyName = "BorrowerName"
        Me.BorrowerNameDataGridViewTextBoxColumn.HeaderText = "BorrowerName"
        Me.BorrowerNameDataGridViewTextBoxColumn.Name = "BorrowerNameDataGridViewTextBoxColumn"
        '
        'ICDataGridViewTextBoxColumn
        '
        Me.ICDataGridViewTextBoxColumn.DataPropertyName = "IC"
        Me.ICDataGridViewTextBoxColumn.HeaderText = "IC"
        Me.ICDataGridViewTextBoxColumn.Name = "ICDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'DueDateDataGridViewTextBoxColumn
        '
        Me.DueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate"
        Me.DueDateDataGridViewTextBoxColumn.HeaderText = "DueDate"
        Me.DueDateDataGridViewTextBoxColumn.Name = "DueDateDataGridViewTextBoxColumn"
        '
        'DataTable3BindingSource
        '
        Me.DataTable3BindingSource.DataMember = "DataTable3"
        Me.DataTable3BindingSource.DataSource = Me.DB1DataSet
        '
        'DataTable3TableAdapter
        '
        Me.DataTable3TableAdapter.ClearBeforeFill = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(309, 226)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(390, 226)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 14
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(545, 223)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 15
        Me.btnPay.Text = "Pay Fine"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'Late
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 450)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(PaymentDateLabel)
        Me.Controls.Add(Me.PaymentDateDateTimePicker)
        Me.Controls.Add(BorrowerNameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(PaymentLabel)
        Me.Controls.Add(Me.PaymentTextBox)
        Me.Controls.Add(FinesLabel)
        Me.Controls.Add(Me.FinesTextBox)
        Me.Controls.Add(BorrowIDLabel)
        Me.Controls.Add(Me.BorrowIDTextBox)
        Me.Controls.Add(Me.LateReturnFinesBindingNavigator)
        Me.Name = "Late"
        Me.Text = "Late"
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LateReturnFinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LateReturnFinesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LateReturnFinesBindingNavigator.ResumeLayout(False)
        Me.LateReturnFinesBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DB1DataSet As DB1DataSet
    Friend WithEvents LateReturnFinesBindingSource As BindingSource
    Friend WithEvents LateReturnFinesTableAdapter As DB1DataSetTableAdapters.LateReturnFinesTableAdapter
    Friend WithEvents TableAdapterManager As DB1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents LateReturnFinesBindingNavigator As BindingNavigator
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
    Friend WithEvents LateReturnFinesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BorrowIDTextBox As TextBox
    Friend WithEvents FinesTextBox As TextBox
    Friend WithEvents PaymentTextBox As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents PaymentDateDateTimePicker As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataTable3BindingSource As BindingSource
    Friend WithEvents DataTable3TableAdapter As DB1DataSetTableAdapters.DataTable3TableAdapter
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearPublicationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FinesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorrowerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ICDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnPay As Button
End Class
