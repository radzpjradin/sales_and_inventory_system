<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales_Transaction
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
        Me.stp_vchange_label = New System.Windows.Forms.Label()
        Me.stp_tprice_label = New System.Windows.Forms.Label()
        Me.stp_cash_textbox_label = New System.Windows.Forms.Label()
        Me.stp_cash_textbox = New System.Windows.Forms.TextBox()
        Me.stp_change_label = New System.Windows.Forms.Label()
        Me.stp_total_price_label = New System.Windows.Forms.Label()
        Me.stp_discount_combobox_label = New System.Windows.Forms.Label()
        Me.stp_back_button = New System.Windows.Forms.Button()
        Me.stp_exit_button = New System.Windows.Forms.Button()
        Me.stp_void_button = New System.Windows.Forms.Button()
        Me.stp_delete_button = New System.Windows.Forms.Button()
        Me.stp_next_button = New System.Windows.Forms.Button()
        Me.stp_discount_combobox = New System.Windows.Forms.ComboBox()
        Me.stp_done_button = New System.Windows.Forms.Button()
        Me.stp_datagrid_flist = New System.Windows.Forms.DataGridView()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stp_datagrid_fsearch = New System.Windows.Forms.DataGridView()
        Me.stp_search_textbox = New System.Windows.Forms.TextBox()
        Me.stp_search_textbox_label = New System.Windows.Forms.Label()
        Me.stp_user = New System.Windows.Forms.Label()
        CType(Me.stp_datagrid_flist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stp_datagrid_fsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stp_vchange_label
        '
        Me.stp_vchange_label.AutoSize = True
        Me.stp_vchange_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_vchange_label.Location = New System.Drawing.Point(537, 359)
        Me.stp_vchange_label.Name = "stp_vchange_label"
        Me.stp_vchange_label.Size = New System.Drawing.Size(13, 13)
        Me.stp_vchange_label.TabIndex = 35
        Me.stp_vchange_label.Text = "0"
        '
        'stp_tprice_label
        '
        Me.stp_tprice_label.AutoSize = True
        Me.stp_tprice_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_tprice_label.Location = New System.Drawing.Point(540, 333)
        Me.stp_tprice_label.Name = "stp_tprice_label"
        Me.stp_tprice_label.Size = New System.Drawing.Size(13, 13)
        Me.stp_tprice_label.TabIndex = 34
        Me.stp_tprice_label.Text = "0"
        '
        'stp_cash_textbox_label
        '
        Me.stp_cash_textbox_label.AutoSize = True
        Me.stp_cash_textbox_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_cash_textbox_label.Location = New System.Drawing.Point(385, 293)
        Me.stp_cash_textbox_label.Name = "stp_cash_textbox_label"
        Me.stp_cash_textbox_label.Size = New System.Drawing.Size(37, 13)
        Me.stp_cash_textbox_label.TabIndex = 33
        Me.stp_cash_textbox_label.Text = "Cash: "
        '
        'stp_cash_textbox
        '
        Me.stp_cash_textbox.Location = New System.Drawing.Point(431, 290)
        Me.stp_cash_textbox.Name = "stp_cash_textbox"
        Me.stp_cash_textbox.Size = New System.Drawing.Size(121, 20)
        Me.stp_cash_textbox.TabIndex = 32
        '
        'stp_change_label
        '
        Me.stp_change_label.AutoSize = True
        Me.stp_change_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_change_label.Location = New System.Drawing.Point(479, 359)
        Me.stp_change_label.Name = "stp_change_label"
        Me.stp_change_label.Size = New System.Drawing.Size(55, 13)
        Me.stp_change_label.TabIndex = 31
        Me.stp_change_label.Text = "CHANGE:"
        '
        'stp_total_price_label
        '
        Me.stp_total_price_label.AutoSize = True
        Me.stp_total_price_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_total_price_label.Location = New System.Drawing.Point(454, 333)
        Me.stp_total_price_label.Name = "stp_total_price_label"
        Me.stp_total_price_label.Size = New System.Drawing.Size(80, 13)
        Me.stp_total_price_label.TabIndex = 30
        Me.stp_total_price_label.Text = "TOTAL PRICE:"
        '
        'stp_discount_combobox_label
        '
        Me.stp_discount_combobox_label.AutoSize = True
        Me.stp_discount_combobox_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_discount_combobox_label.Location = New System.Drawing.Point(370, 266)
        Me.stp_discount_combobox_label.Name = "stp_discount_combobox_label"
        Me.stp_discount_combobox_label.Size = New System.Drawing.Size(55, 13)
        Me.stp_discount_combobox_label.TabIndex = 29
        Me.stp_discount_combobox_label.Text = "Discount: "
        '
        'stp_back_button
        '
        Me.stp_back_button.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_back_button.Location = New System.Drawing.Point(477, 220)
        Me.stp_back_button.Name = "stp_back_button"
        Me.stp_back_button.Size = New System.Drawing.Size(75, 23)
        Me.stp_back_button.TabIndex = 28
        Me.stp_back_button.Text = "BACK"
        Me.stp_back_button.UseVisualStyleBackColor = False
        '
        'stp_exit_button
        '
        Me.stp_exit_button.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_exit_button.Location = New System.Drawing.Point(558, 10)
        Me.stp_exit_button.Name = "stp_exit_button"
        Me.stp_exit_button.Size = New System.Drawing.Size(75, 23)
        Me.stp_exit_button.TabIndex = 27
        Me.stp_exit_button.Text = "EXIT"
        Me.stp_exit_button.UseVisualStyleBackColor = False
        '
        'stp_void_button
        '
        Me.stp_void_button.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_void_button.Location = New System.Drawing.Point(112, 191)
        Me.stp_void_button.Name = "stp_void_button"
        Me.stp_void_button.Size = New System.Drawing.Size(75, 23)
        Me.stp_void_button.TabIndex = 26
        Me.stp_void_button.Text = "VOID"
        Me.stp_void_button.UseVisualStyleBackColor = False
        '
        'stp_delete_button
        '
        Me.stp_delete_button.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_delete_button.Location = New System.Drawing.Point(24, 191)
        Me.stp_delete_button.Name = "stp_delete_button"
        Me.stp_delete_button.Size = New System.Drawing.Size(75, 23)
        Me.stp_delete_button.TabIndex = 25
        Me.stp_delete_button.Text = "DELETE"
        Me.stp_delete_button.UseVisualStyleBackColor = False
        '
        'stp_next_button
        '
        Me.stp_next_button.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_next_button.Location = New System.Drawing.Point(373, 333)
        Me.stp_next_button.Name = "stp_next_button"
        Me.stp_next_button.Size = New System.Drawing.Size(75, 23)
        Me.stp_next_button.TabIndex = 24
        Me.stp_next_button.Text = "Next"
        Me.stp_next_button.UseVisualStyleBackColor = False
        '
        'stp_discount_combobox
        '
        Me.stp_discount_combobox.FormattingEnabled = True
        Me.stp_discount_combobox.Items.AddRange(New Object() {"0%", "10%", "25%", "50%"})
        Me.stp_discount_combobox.Location = New System.Drawing.Point(431, 263)
        Me.stp_discount_combobox.Name = "stp_discount_combobox"
        Me.stp_discount_combobox.Size = New System.Drawing.Size(121, 21)
        Me.stp_discount_combobox.TabIndex = 23
        '
        'stp_done_button
        '
        Me.stp_done_button.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_done_button.Location = New System.Drawing.Point(373, 220)
        Me.stp_done_button.Name = "stp_done_button"
        Me.stp_done_button.Size = New System.Drawing.Size(75, 23)
        Me.stp_done_button.TabIndex = 22
        Me.stp_done_button.Text = "DONE"
        Me.stp_done_button.UseVisualStyleBackColor = False
        '
        'stp_datagrid_flist
        '
        Me.stp_datagrid_flist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stp_datagrid_flist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_Name, Me.Product_Price, Me.Product_Quantity})
        Me.stp_datagrid_flist.Location = New System.Drawing.Point(24, 220)
        Me.stp_datagrid_flist.Name = "stp_datagrid_flist"
        Me.stp_datagrid_flist.Size = New System.Drawing.Size(343, 268)
        Me.stp_datagrid_flist.TabIndex = 21
        '
        'Product_Name
        '
        Me.Product_Name.HeaderText = "Product_Name"
        Me.Product_Name.Name = "Product_Name"
        '
        'Product_Price
        '
        Me.Product_Price.HeaderText = "Product_Price"
        Me.Product_Price.Name = "Product_Price"
        '
        'Product_Quantity
        '
        Me.Product_Quantity.HeaderText = "Product_Quantity"
        Me.Product_Quantity.Name = "Product_Quantity"
        '
        'stp_datagrid_fsearch
        '
        Me.stp_datagrid_fsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stp_datagrid_fsearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.stp_datagrid_fsearch.Location = New System.Drawing.Point(12, 46)
        Me.stp_datagrid_fsearch.Name = "stp_datagrid_fsearch"
        Me.stp_datagrid_fsearch.Size = New System.Drawing.Size(531, 137)
        Me.stp_datagrid_fsearch.TabIndex = 20
        '
        'stp_search_textbox
        '
        Me.stp_search_textbox.Location = New System.Drawing.Point(65, 13)
        Me.stp_search_textbox.Name = "stp_search_textbox"
        Me.stp_search_textbox.Size = New System.Drawing.Size(270, 20)
        Me.stp_search_textbox.TabIndex = 19
        '
        'stp_search_textbox_label
        '
        Me.stp_search_textbox_label.AutoSize = True
        Me.stp_search_textbox_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_search_textbox_label.Location = New System.Drawing.Point(12, 16)
        Me.stp_search_textbox_label.Name = "stp_search_textbox_label"
        Me.stp_search_textbox_label.Size = New System.Drawing.Size(47, 13)
        Me.stp_search_textbox_label.TabIndex = 18
        Me.stp_search_textbox_label.Text = "Search: "
        '
        'stp_user
        '
        Me.stp_user.AutoSize = True
        Me.stp_user.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.stp_user.Location = New System.Drawing.Point(345, 13)
        Me.stp_user.Name = "stp_user"
        Me.stp_user.Size = New System.Drawing.Size(31, 13)
        Me.stp_user.TabIndex = 36
        Me.stp_user.Text = "OOO"
        '
        'Sales_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(645, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.stp_user)
        Me.Controls.Add(Me.stp_vchange_label)
        Me.Controls.Add(Me.stp_tprice_label)
        Me.Controls.Add(Me.stp_cash_textbox_label)
        Me.Controls.Add(Me.stp_cash_textbox)
        Me.Controls.Add(Me.stp_change_label)
        Me.Controls.Add(Me.stp_total_price_label)
        Me.Controls.Add(Me.stp_discount_combobox_label)
        Me.Controls.Add(Me.stp_back_button)
        Me.Controls.Add(Me.stp_exit_button)
        Me.Controls.Add(Me.stp_void_button)
        Me.Controls.Add(Me.stp_delete_button)
        Me.Controls.Add(Me.stp_next_button)
        Me.Controls.Add(Me.stp_discount_combobox)
        Me.Controls.Add(Me.stp_done_button)
        Me.Controls.Add(Me.stp_datagrid_flist)
        Me.Controls.Add(Me.stp_datagrid_fsearch)
        Me.Controls.Add(Me.stp_search_textbox)
        Me.Controls.Add(Me.stp_search_textbox_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Sales_Transaction"
        Me.Text = "Sales Transaction"
        CType(Me.stp_datagrid_flist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stp_datagrid_fsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents stp_vchange_label As Label
    Friend WithEvents stp_tprice_label As Label
    Friend WithEvents stp_cash_textbox_label As Label
    Friend WithEvents stp_cash_textbox As TextBox
    Friend WithEvents stp_change_label As Label
    Friend WithEvents stp_total_price_label As Label
    Friend WithEvents stp_discount_combobox_label As Label
    Friend WithEvents stp_back_button As Button
    Friend WithEvents stp_exit_button As Button
    Friend WithEvents stp_void_button As Button
    Friend WithEvents stp_delete_button As Button
    Friend WithEvents stp_next_button As Button
    Friend WithEvents stp_discount_combobox As ComboBox
    Friend WithEvents stp_done_button As Button
    Friend WithEvents stp_datagrid_flist As DataGridView
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents Product_Price As DataGridViewTextBoxColumn
    Friend WithEvents Product_Quantity As DataGridViewTextBoxColumn
    Friend WithEvents stp_datagrid_fsearch As DataGridView
    Friend WithEvents stp_search_textbox As TextBox
    Friend WithEvents stp_search_textbox_label As Label
    Friend WithEvents stp_user As Label
End Class
