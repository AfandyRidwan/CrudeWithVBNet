<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItem
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NoItemTxt = New System.Windows.Forms.TextBox()
        Me.NmItemTxt = New System.Windows.Forms.TextBox()
        Me.CategoryTxt = New System.Windows.Forms.TextBox()
        Me.UnitTxt = New System.Windows.Forms.TextBox()
        Me.StockTxt = New System.Windows.Forms.TextBox()
        Me.NameRb = New System.Windows.Forms.RadioButton()
        Me.CategoryRb = New System.Windows.Forms.RadioButton()
        Me.UnitRb = New System.Windows.Forms.RadioButton()
        Me.FindTxt = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DGItem = New System.Windows.Forms.DataGridView()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        CType(Me.DGItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock"
        '
        'NoItemTxt
        '
        Me.NoItemTxt.Location = New System.Drawing.Point(103, 13)
        Me.NoItemTxt.Name = "NoItemTxt"
        Me.NoItemTxt.Size = New System.Drawing.Size(100, 20)
        Me.NoItemTxt.TabIndex = 5
        '
        'NmItemTxt
        '
        Me.NmItemTxt.Location = New System.Drawing.Point(103, 44)
        Me.NmItemTxt.Name = "NmItemTxt"
        Me.NmItemTxt.Size = New System.Drawing.Size(100, 20)
        Me.NmItemTxt.TabIndex = 6
        '
        'CategoryTxt
        '
        Me.CategoryTxt.Location = New System.Drawing.Point(103, 69)
        Me.CategoryTxt.Name = "CategoryTxt"
        Me.CategoryTxt.Size = New System.Drawing.Size(100, 20)
        Me.CategoryTxt.TabIndex = 7
        '
        'UnitTxt
        '
        Me.UnitTxt.Location = New System.Drawing.Point(103, 105)
        Me.UnitTxt.Name = "UnitTxt"
        Me.UnitTxt.Size = New System.Drawing.Size(100, 20)
        Me.UnitTxt.TabIndex = 8
        '
        'StockTxt
        '
        Me.StockTxt.Location = New System.Drawing.Point(103, 141)
        Me.StockTxt.Name = "StockTxt"
        Me.StockTxt.Size = New System.Drawing.Size(100, 20)
        Me.StockTxt.TabIndex = 9
        '
        'NameRb
        '
        Me.NameRb.AutoSize = True
        Me.NameRb.Location = New System.Drawing.Point(103, 201)
        Me.NameRb.Name = "NameRb"
        Me.NameRb.Size = New System.Drawing.Size(76, 17)
        Me.NameRb.TabIndex = 10
        Me.NameRb.TabStop = True
        Me.NameRb.Text = "Item Name"
        Me.NameRb.UseVisualStyleBackColor = True
        '
        'CategoryRb
        '
        Me.CategoryRb.AutoSize = True
        Me.CategoryRb.Location = New System.Drawing.Point(232, 201)
        Me.CategoryRb.Name = "CategoryRb"
        Me.CategoryRb.Size = New System.Drawing.Size(67, 17)
        Me.CategoryRb.TabIndex = 11
        Me.CategoryRb.TabStop = True
        Me.CategoryRb.Text = "Category"
        Me.CategoryRb.UseVisualStyleBackColor = True
        '
        'UnitRb
        '
        Me.UnitRb.AutoSize = True
        Me.UnitRb.Location = New System.Drawing.Point(362, 201)
        Me.UnitRb.Name = "UnitRb"
        Me.UnitRb.Size = New System.Drawing.Size(44, 17)
        Me.UnitRb.TabIndex = 12
        Me.UnitRb.TabStop = True
        Me.UnitRb.Text = "Unit"
        Me.UnitRb.UseVisualStyleBackColor = True
        '
        'FindTxt
        '
        Me.FindTxt.AutoSize = True
        Me.FindTxt.Location = New System.Drawing.Point(16, 237)
        Me.FindTxt.Name = "FindTxt"
        Me.FindTxt.Size = New System.Drawing.Size(27, 13)
        Me.FindTxt.TabIndex = 13
        Me.FindTxt.Text = "Find"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(103, 237)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 14
        '
        'DGItem
        '
        Me.DGItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGItem.Location = New System.Drawing.Point(103, 282)
        Me.DGItem.Name = "DGItem"
        Me.DGItem.Size = New System.Drawing.Size(578, 150)
        Me.DGItem.TabIndex = 15
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(103, 441)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn.TabIndex = 16
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Location = New System.Drawing.Point(197, 441)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(75, 23)
        Me.EditBtn.TabIndex = 17
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(292, 441)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteBtn.TabIndex = 18
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(394, 441)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 19
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'FrmItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 476)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.DGItem)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.FindTxt)
        Me.Controls.Add(Me.UnitRb)
        Me.Controls.Add(Me.CategoryRb)
        Me.Controls.Add(Me.NameRb)
        Me.Controls.Add(Me.StockTxt)
        Me.Controls.Add(Me.UnitTxt)
        Me.Controls.Add(Me.CategoryTxt)
        Me.Controls.Add(Me.NmItemTxt)
        Me.Controls.Add(Me.NoItemTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FrmItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Item"
        CType(Me.DGItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NoItemTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmItemTxt As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTxt As System.Windows.Forms.TextBox
    Friend WithEvents UnitTxt As System.Windows.Forms.TextBox
    Friend WithEvents StockTxt As System.Windows.Forms.TextBox
    Friend WithEvents NameRb As System.Windows.Forms.RadioButton
    Friend WithEvents CategoryRb As System.Windows.Forms.RadioButton
    Friend WithEvents UnitRb As System.Windows.Forms.RadioButton
    Friend WithEvents FindTxt As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents DGItem As System.Windows.Forms.DataGridView
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
End Class
