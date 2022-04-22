<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnhighlightAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockLevelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimumStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaximumStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpiredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnExpired = New System.Windows.Forms.Button()
        Me.btnUnhighlight2 = New System.Windows.Forms.Button()
        Me.btnHighlightYellow = New System.Windows.Forms.Button()
        Me.txtMaximum = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnHighlightOrange = New System.Windows.Forms.Button()
        Me.txtMinimum = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnUnhighlight3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStockIn = New System.Windows.Forms.Button()
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.txtQuantity2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSKUStock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SKUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Canteen_Stock_v_3DataSet = New ML_SAT_v._3.Canteen_Stock_v_3DataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpExpiryDate = New System.Windows.Forms.DateTimePicker()
        Me.btnUnhiglight1 = New System.Windows.Forms.Button()
        Me.txtSKU = New System.Windows.Forms.TextBox()
        Me.lblSKU = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblExpiryDate = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDESC = New System.Windows.Forms.Button()
        Me.btnASC = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtpsearch = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUnsearch = New System.Windows.Forms.Button()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Table1TableAdapter = New ML_SAT_v._3.Canteen_Stock_v_3DataSetTableAdapters.table1TableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Canteen_Stock_v_3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataEntryToolStripMenuItem, Me.UnhighlightAllToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ClearSearchToolStripMenuItem, Me.SortToolStripMenuItem, Me.StockInToolStripMenuItem, Me.StockOutToolStripMenuItem, Me.StockLevelsToolStripMenuItem, Me.SignOutToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1680, 24)
        Me.MenuStrip1.TabIndex = 100
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'DataEntryToolStripMenuItem
        '
        Me.DataEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreviousToolStripMenuItem, Me.NextToolStripMenuItem, Me.AddNewToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.DataEntryToolStripMenuItem.Name = "DataEntryToolStripMenuItem"
        Me.DataEntryToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.DataEntryToolStripMenuItem.Text = "Data Entry"
        '
        'PreviousToolStripMenuItem
        '
        Me.PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem"
        Me.PreviousToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.PreviousToolStripMenuItem.Text = "Previous"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.AddNewToolStripMenuItem.Text = "Add New"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        Me.DeleteToolStripMenuItem.Visible = False
        '
        'UnhighlightAllToolStripMenuItem
        '
        Me.UnhighlightAllToolStripMenuItem.Name = "UnhighlightAllToolStripMenuItem"
        Me.UnhighlightAllToolStripMenuItem.Size = New System.Drawing.Size(139, 20)
        Me.UnhighlightAllToolStripMenuItem.Text = "Unhighlight All"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ClearSearchToolStripMenuItem
        '
        Me.ClearSearchToolStripMenuItem.Name = "ClearSearchToolStripMenuItem"
        Me.ClearSearchToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.ClearSearchToolStripMenuItem.Text = "Clear Search"
        '
        'SortToolStripMenuItem
        '
        Me.SortToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AscendingToolStripMenuItem, Me.DescendingToolStripMenuItem})
        Me.SortToolStripMenuItem.Name = "SortToolStripMenuItem"
        Me.SortToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.SortToolStripMenuItem.Text = "Sort"
        '
        'AscendingToolStripMenuItem
        '
        Me.AscendingToolStripMenuItem.Name = "AscendingToolStripMenuItem"
        Me.AscendingToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.AscendingToolStripMenuItem.Text = "Ascending"
        '
        'DescendingToolStripMenuItem
        '
        Me.DescendingToolStripMenuItem.Name = "DescendingToolStripMenuItem"
        Me.DescendingToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.DescendingToolStripMenuItem.Text = "Descending"
        '
        'StockInToolStripMenuItem
        '
        Me.StockInToolStripMenuItem.Name = "StockInToolStripMenuItem"
        Me.StockInToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.StockInToolStripMenuItem.Text = "Stock In"
        '
        'StockOutToolStripMenuItem
        '
        Me.StockOutToolStripMenuItem.Name = "StockOutToolStripMenuItem"
        Me.StockOutToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.StockOutToolStripMenuItem.Text = "Stock Out"
        '
        'StockLevelsToolStripMenuItem
        '
        Me.StockLevelsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimumStockToolStripMenuItem, Me.MaximumStockToolStripMenuItem, Me.ExpiredToolStripMenuItem})
        Me.StockLevelsToolStripMenuItem.Name = "StockLevelsToolStripMenuItem"
        Me.StockLevelsToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.StockLevelsToolStripMenuItem.Text = "Stock Levels"
        '
        'MinimumStockToolStripMenuItem
        '
        Me.MinimumStockToolStripMenuItem.Name = "MinimumStockToolStripMenuItem"
        Me.MinimumStockToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.MinimumStockToolStripMenuItem.Text = "Minimum Stock"
        '
        'MaximumStockToolStripMenuItem
        '
        Me.MaximumStockToolStripMenuItem.Name = "MaximumStockToolStripMenuItem"
        Me.MaximumStockToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.MaximumStockToolStripMenuItem.Text = "Maximum Stock"
        '
        'ExpiredToolStripMenuItem
        '
        Me.ExpiredToolStripMenuItem.Name = "ExpiredToolStripMenuItem"
        Me.ExpiredToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.ExpiredToolStripMenuItem.Text = "Expired"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'btnSignOut
        '
        Me.btnSignOut.BackColor = System.Drawing.SystemColors.Control
        Me.btnSignOut.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.Location = New System.Drawing.Point(1432, 55)
        Me.btnSignOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(215, 61)
        Me.btnSignOut.TabIndex = 99
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnExpired)
        Me.GroupBox6.Controls.Add(Me.btnUnhighlight2)
        Me.GroupBox6.Controls.Add(Me.btnHighlightYellow)
        Me.GroupBox6.Controls.Add(Me.txtMaximum)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.btnHighlightOrange)
        Me.GroupBox6.Controls.Add(Me.txtMinimum)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(1311, 182)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(358, 344)
        Me.GroupBox6.TabIndex = 98
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Stock Levels + Expiry"
        '
        'btnExpired
        '
        Me.btnExpired.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExpired.Location = New System.Drawing.Point(22, 291)
        Me.btnExpired.Name = "btnExpired"
        Me.btnExpired.Size = New System.Drawing.Size(330, 33)
        Me.btnExpired.TabIndex = 60
        Me.btnExpired.Text = "Expired (Dark Green)"
        Me.btnExpired.UseVisualStyleBackColor = False
        '
        'btnUnhighlight2
        '
        Me.btnUnhighlight2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnUnhighlight2.Location = New System.Drawing.Point(22, 250)
        Me.btnUnhighlight2.Name = "btnUnhighlight2"
        Me.btnUnhighlight2.Size = New System.Drawing.Size(330, 35)
        Me.btnUnhighlight2.TabIndex = 59
        Me.btnUnhighlight2.Text = "Unhighlight All"
        Me.btnUnhighlight2.UseVisualStyleBackColor = False
        '
        'btnHighlightYellow
        '
        Me.btnHighlightYellow.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHighlightYellow.Location = New System.Drawing.Point(38, 188)
        Me.btnHighlightYellow.Name = "btnHighlightYellow"
        Me.btnHighlightYellow.Size = New System.Drawing.Size(242, 36)
        Me.btnHighlightYellow.TabIndex = 6
        Me.btnHighlightYellow.Text = "Highlight Yellow"
        Me.btnHighlightYellow.UseVisualStyleBackColor = False
        '
        'txtMaximum
        '
        Me.txtMaximum.Location = New System.Drawing.Point(235, 139)
        Me.txtMaximum.Name = "txtMaximum"
        Me.txtMaximum.Size = New System.Drawing.Size(100, 34)
        Me.txtMaximum.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 27)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Maximum Stock:"
        '
        'btnHighlightOrange
        '
        Me.btnHighlightOrange.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHighlightOrange.Location = New System.Drawing.Point(38, 88)
        Me.btnHighlightOrange.Name = "btnHighlightOrange"
        Me.btnHighlightOrange.Size = New System.Drawing.Size(242, 36)
        Me.btnHighlightOrange.TabIndex = 2
        Me.btnHighlightOrange.Text = "Highlight Orange"
        Me.btnHighlightOrange.UseVisualStyleBackColor = False
        '
        'txtMinimum
        '
        Me.txtMinimum.Location = New System.Drawing.Point(236, 44)
        Me.txtMinimum.Name = "txtMinimum"
        Me.txtMinimum.Size = New System.Drawing.Size(100, 34)
        Me.txtMinimum.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 27)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Minimum Stock:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(1311, 532)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(358, 342)
        Me.GroupBox7.TabIndex = 97
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Information"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(293, 216)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Use Stock in Stock Out " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and Data Entry forms to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "add, delete, edit " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and alter d" &
    "ata records" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use Sort, Search and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Minimum Maximum Forms" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to filter for infor" &
    "mation"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.btnUnhighlight3)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.btnStockIn)
        Me.GroupBox5.Controls.Add(Me.btnStockOut)
        Me.GroupBox5.Controls.Add(Me.txtQuantity2)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.txtSKUStock)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(919, 599)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(370, 275)
        Me.GroupBox5.TabIndex = 96
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Stock In Stock Out"
        '
        'btnUnhighlight3
        '
        Me.btnUnhighlight3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnUnhighlight3.Location = New System.Drawing.Point(47, 217)
        Me.btnUnhighlight3.Name = "btnUnhighlight3"
        Me.btnUnhighlight3.Size = New System.Drawing.Size(280, 35)
        Me.btnUnhighlight3.TabIndex = 58
        Me.btnUnhighlight3.Text = "Unhighlight All"
        Me.btnUnhighlight3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 27)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Quantity:"
        '
        'btnStockIn
        '
        Me.btnStockIn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnStockIn.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockIn.Location = New System.Drawing.Point(47, 165)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Size = New System.Drawing.Size(131, 43)
        Me.btnStockIn.TabIndex = 55
        Me.btnStockIn.Text = "Stock In"
        Me.btnStockIn.UseVisualStyleBackColor = False
        '
        'btnStockOut
        '
        Me.btnStockOut.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnStockOut.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockOut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStockOut.Location = New System.Drawing.Point(196, 165)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(131, 43)
        Me.btnStockOut.TabIndex = 54
        Me.btnStockOut.Text = "Stock Out"
        Me.btnStockOut.UseVisualStyleBackColor = False
        '
        'txtQuantity2
        '
        Me.txtQuantity2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity2.Location = New System.Drawing.Point(196, 109)
        Me.txtQuantity2.Name = "txtQuantity2"
        Me.txtQuantity2.Size = New System.Drawing.Size(128, 34)
        Me.txtQuantity2.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 27)
        Me.Label8.TabIndex = 55
        '
        'txtSKUStock
        '
        Me.txtSKUStock.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSKUStock.Location = New System.Drawing.Point(196, 58)
        Me.txtSKUStock.Name = "txtSKUStock"
        Me.txtSKUStock.Size = New System.Drawing.Size(128, 34)
        Me.txtSKUStock.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 27)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "SKU:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(527, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(674, 70)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "Canteen Stock System"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(193, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 94
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(539, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 412)
        Me.GroupBox2.TabIndex = 91
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Stock"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SKUDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ExpiryDateDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(48, 53)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(655, 324)
        Me.DataGridView1.TabIndex = 0
        '
        'SKUDataGridViewTextBoxColumn
        '
        Me.SKUDataGridViewTextBoxColumn.DataPropertyName = "SKU"
        Me.SKUDataGridViewTextBoxColumn.HeaderText = "SKU"
        Me.SKUDataGridViewTextBoxColumn.Name = "SKUDataGridViewTextBoxColumn"
        Me.SKUDataGridViewTextBoxColumn.ReadOnly = True
        Me.SKUDataGridViewTextBoxColumn.Width = 110
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 190
        '
        'ExpiryDateDataGridViewTextBoxColumn
        '
        Me.ExpiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate"
        Me.ExpiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate"
        Me.ExpiryDateDataGridViewTextBoxColumn.Name = "ExpiryDateDataGridViewTextBoxColumn"
        Me.ExpiryDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExpiryDateDataGridViewTextBoxColumn.Width = 180
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 135
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "table1"
        Me.Table1BindingSource.DataSource = Me.Canteen_Stock_v_3DataSet
        '
        'Canteen_Stock_v_3DataSet
        '
        Me.Canteen_Stock_v_3DataSet.DataSetName = "Canteen_Stock_v_3DataSet"
        Me.Canteen_Stock_v_3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.dtpExpiryDate)
        Me.GroupBox1.Controls.Add(Me.btnUnhiglight1)
        Me.GroupBox1.Controls.Add(Me.txtSKU)
        Me.GroupBox1.Controls.Add(Me.lblSKU)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.lblQuantity)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.txtQuantity)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.lblExpiryDate)
        Me.GroupBox1.Controls.Add(Me.txtProductName)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnAddNew)
        Me.GroupBox1.Controls.Add(Me.lblProductName)
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(58, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 412)
        Me.GroupBox1.TabIndex = 90
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Entry"
        '
        'dtpExpiryDate
        '
        Me.dtpExpiryDate.AllowDrop = True
        Me.dtpExpiryDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpExpiryDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table1BindingSource, "ExpiryDate", True))
        Me.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpiryDate.Location = New System.Drawing.Point(231, 47)
        Me.dtpExpiryDate.Name = "dtpExpiryDate"
        Me.dtpExpiryDate.ShowCheckBox = True
        Me.dtpExpiryDate.Size = New System.Drawing.Size(179, 34)
        Me.dtpExpiryDate.TabIndex = 3
        Me.dtpExpiryDate.Value = New Date(2020, 5, 23, 19, 48, 59, 0)
        '
        'btnUnhiglight1
        '
        Me.btnUnhiglight1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnUnhiglight1.Location = New System.Drawing.Point(70, 350)
        Me.btnUnhiglight1.Name = "btnUnhiglight1"
        Me.btnUnhiglight1.Size = New System.Drawing.Size(338, 35)
        Me.btnUnhiglight1.TabIndex = 7
        Me.btnUnhiglight1.Text = "Unhighlight All"
        Me.btnUnhiglight1.UseVisualStyleBackColor = False
        '
        'txtSKU
        '
        Me.txtSKU.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "SKU", True))
        Me.txtSKU.Location = New System.Drawing.Point(231, 100)
        Me.txtSKU.Name = "txtSKU"
        Me.txtSKU.Size = New System.Drawing.Size(179, 34)
        Me.txtSKU.TabIndex = 1
        '
        'lblSKU
        '
        Me.lblSKU.AutoSize = True
        Me.lblSKU.Location = New System.Drawing.Point(40, 106)
        Me.lblSKU.Name = "lblSKU"
        Me.lblSKU.Size = New System.Drawing.Size(68, 27)
        Me.lblSKU.TabIndex = 23
        Me.lblSKU.Text = "SKU:"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPrevious.Location = New System.Drawing.Point(70, 260)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(112, 41)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblQuantity.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(40, 212)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(110, 27)
        Me.lblQuantity.TabIndex = 21
        Me.lblQuantity.Text = "Quantity:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSave.Location = New System.Drawing.Point(70, 307)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(174, 37)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtQuantity
        '
        Me.txtQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Quantity", True))
        Me.txtQuantity.Location = New System.Drawing.Point(231, 206)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(179, 34)
        Me.txtQuantity.TabIndex = 4
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnDelete.CausesValidation = False
        Me.btnDelete.Location = New System.Drawing.Point(188, 307)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(121, 37)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'lblExpiryDate
        '
        Me.lblExpiryDate.AutoSize = True
        Me.lblExpiryDate.Location = New System.Drawing.Point(40, 53)
        Me.lblExpiryDate.Name = "lblExpiryDate"
        Me.lblExpiryDate.Size = New System.Drawing.Size(142, 27)
        Me.lblExpiryDate.TabIndex = 6
        Me.lblExpiryDate.Text = "Expiry Date:"
        '
        'txtProductName
        '
        Me.txtProductName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ProductName", True))
        Me.txtProductName.Location = New System.Drawing.Point(231, 153)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(179, 34)
        Me.txtProductName.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClose.CausesValidation = False
        Me.btnClose.Location = New System.Drawing.Point(252, 307)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(156, 37)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddNew.Location = New System.Drawing.Point(188, 260)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(121, 41)
        Me.btnAddNew.TabIndex = 9
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(38, 159)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(173, 27)
        Me.lblProductName.TabIndex = 4
        Me.lblProductName.Text = "Product Name:"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNext.Location = New System.Drawing.Point(315, 260)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(93, 41)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbSort)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.btnDESC)
        Me.GroupBox3.Controls.Add(Me.btnASC)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(566, 599)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(339, 275)
        Me.GroupBox3.TabIndex = 92
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sort"
        '
        'cmbSort
        '
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Items.AddRange(New Object() {"SKU", "ExpiryDate", "ProductName", "Quantity"})
        Me.cmbSort.Location = New System.Drawing.Point(154, 74)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(152, 34)
        Me.cmbSort.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 27)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Category:"
        '
        'btnDESC
        '
        Me.btnDESC.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnDESC.Location = New System.Drawing.Point(92, 163)
        Me.btnDESC.Name = "btnDESC"
        Me.btnDESC.Size = New System.Drawing.Size(166, 38)
        Me.btnDESC.TabIndex = 32
        Me.btnDESC.Text = "Descending"
        Me.btnDESC.UseVisualStyleBackColor = False
        '
        'btnASC
        '
        Me.btnASC.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnASC.Location = New System.Drawing.Point(92, 119)
        Me.btnASC.Name = "btnASC"
        Me.btnASC.Size = New System.Drawing.Size(166, 38)
        Me.btnASC.TabIndex = 31
        Me.btnASC.Text = "Ascending"
        Me.btnASC.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dtpsearch)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.btnUnsearch)
        Me.GroupBox4.Controls.Add(Me.cmbSearch)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtSearch)
        Me.GroupBox4.Controls.Add(Me.btnSearch)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(58, 599)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(502, 275)
        Me.GroupBox4.TabIndex = 93
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Search"
        '
        'dtpsearch
        '
        Me.dtpsearch.Checked = False
        Me.dtpsearch.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpsearch.Location = New System.Drawing.Point(252, 163)
        Me.dtpsearch.Name = "dtpsearch"
        Me.dtpsearch.ShowCheckBox = True
        Me.dtpsearch.Size = New System.Drawing.Size(178, 34)
        Me.dtpsearch.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 27)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "or"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 27)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Date:"
        '
        'btnUnsearch
        '
        Me.btnUnsearch.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnUnsearch.Location = New System.Drawing.Point(267, 217)
        Me.btnUnsearch.Name = "btnUnsearch"
        Me.btnUnsearch.Size = New System.Drawing.Size(195, 34)
        Me.btnUnsearch.TabIndex = 29
        Me.btnUnsearch.Text = "Clear Search"
        Me.btnUnsearch.UseVisualStyleBackColor = False
        '
        'cmbSearch
        '
        Me.cmbSearch.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"SKU", "ProductName", "ExpiryDate", "Quantity"})
        Me.cmbSearch.Location = New System.Drawing.Point(252, 44)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(178, 34)
        Me.cmbSearch.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 27)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Category:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(87, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 27)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Looking for:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(252, 88)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(178, 34)
        Me.txtSearch.TabIndex = 25
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSearch.Location = New System.Drawing.Point(41, 217)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(203, 34)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1680, 939)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Canteen_Stock_v_3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreviousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnhighlightAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AscendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockLevelsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimumStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaximumStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSignOut As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnUnhighlight2 As Button
    Friend WithEvents btnHighlightYellow As Button
    Friend WithEvents txtMaximum As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnHighlightOrange As Button
    Friend WithEvents txtMinimum As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnUnhighlight3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStockIn As Button
    Friend WithEvents btnStockOut As Button
    Friend WithEvents txtQuantity2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSKUStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpExpiryDate As DateTimePicker
    Friend WithEvents btnUnhiglight1 As Button
    Friend WithEvents txtSKU As TextBox
    Friend WithEvents lblSKU As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblQuantity As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblExpiryDate As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents lblProductName As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbSort As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDESC As Button
    Friend WithEvents btnASC As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dtpsearch As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUnsearch As Button
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Canteen_Stock_v_3DataSet As Canteen_Stock_v_3DataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As Canteen_Stock_v_3DataSetTableAdapters.table1TableAdapter
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents SKUDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpiryDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnExpired As Button
    Friend WithEvents ExpiredToolStripMenuItem As ToolStripMenuItem
End Class
