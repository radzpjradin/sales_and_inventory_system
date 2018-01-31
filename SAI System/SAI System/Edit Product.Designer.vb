<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Product
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
        Me.prod_clear_button = New System.Windows.Forms.Button()
        Me.prod_descr_textbox = New System.Windows.Forms.TextBox()
        Me.prod_delete_button = New System.Windows.Forms.Button()
        Me.prod_cancel_button = New System.Windows.Forms.Button()
        Me.prod_save_button = New System.Windows.Forms.Button()
        Me.prod_price_textbox_label = New System.Windows.Forms.Label()
        Me.prod_owner_textbox_label = New System.Windows.Forms.Label()
        Me.prod_quantity_textbox_label = New System.Windows.Forms.Label()
        Me.prod_descr_textbox_label = New System.Windows.Forms.Label()
        Me.prod_name_textbox_label = New System.Windows.Forms.Label()
        Me.prod_search_button_label = New System.Windows.Forms.Label()
        Me.prod_search_textbox = New System.Windows.Forms.TextBox()
        Me.prod_quantity_textbox = New System.Windows.Forms.TextBox()
        Me.prod_price_textbox = New System.Windows.Forms.TextBox()
        Me.prod_owner_textbox = New System.Windows.Forms.TextBox()
        Me.prod_name_textbox = New System.Windows.Forms.TextBox()
        Me.prod_exit_button = New System.Windows.Forms.Button()
        Me.prod_edit_button = New System.Windows.Forms.Button()
        Me.prod_add_button = New System.Windows.Forms.Button()
        Me.prod_datagrid = New System.Windows.Forms.DataGridView()
        CType(Me.prod_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(16, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "PRODUCT MANAGEMENT"
        '
        'prod_clear_button
        '
        Me.prod_clear_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prod_clear_button.Location = New System.Drawing.Point(19, 317)
        Me.prod_clear_button.Name = "prod_clear_button"
        Me.prod_clear_button.Size = New System.Drawing.Size(75, 23)
        Me.prod_clear_button.TabIndex = 44
        Me.prod_clear_button.Text = "CLEAR"
        Me.prod_clear_button.UseVisualStyleBackColor = False
        '
        'prod_descr_textbox
        '
        Me.prod_descr_textbox.Location = New System.Drawing.Point(110, 119)
        Me.prod_descr_textbox.Multiline = True
        Me.prod_descr_textbox.Name = "prod_descr_textbox"
        Me.prod_descr_textbox.Size = New System.Drawing.Size(159, 67)
        Me.prod_descr_textbox.TabIndex = 43
        '
        'prod_delete_button
        '
        Me.prod_delete_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prod_delete_button.Location = New System.Drawing.Point(194, 288)
        Me.prod_delete_button.Name = "prod_delete_button"
        Me.prod_delete_button.Size = New System.Drawing.Size(75, 23)
        Me.prod_delete_button.TabIndex = 42
        Me.prod_delete_button.Text = "DELETE"
        Me.prod_delete_button.UseVisualStyleBackColor = False
        '
        'prod_cancel_button
        '
        Me.prod_cancel_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prod_cancel_button.Location = New System.Drawing.Point(194, 317)
        Me.prod_cancel_button.Name = "prod_cancel_button"
        Me.prod_cancel_button.Size = New System.Drawing.Size(75, 23)
        Me.prod_cancel_button.TabIndex = 41
        Me.prod_cancel_button.Text = "CANCEL"
        Me.prod_cancel_button.UseVisualStyleBackColor = False
        '
        'prod_save_button
        '
        Me.prod_save_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prod_save_button.Location = New System.Drawing.Point(19, 288)
        Me.prod_save_button.Name = "prod_save_button"
        Me.prod_save_button.Size = New System.Drawing.Size(75, 23)
        Me.prod_save_button.TabIndex = 40
        Me.prod_save_button.Text = "SAVE"
        Me.prod_save_button.UseVisualStyleBackColor = False
        '
        'prod_price_textbox_label
        '
        Me.prod_price_textbox_label.AutoSize = True
        Me.prod_price_textbox_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.prod_price_textbox_label.Location = New System.Drawing.Point(16, 221)
        Me.prod_price_textbox_label.Name = "prod_price_textbox_label"
        Me.prod_price_textbox_label.Size = New System.Drawing.Size(37, 13)
        Me.prod_price_textbox_label.TabIndex = 39
        Me.prod_price_textbox_label.Text = "Price: "
        '
        'prod_owner_textbox_label
        '
        Me.prod_owner_textbox_label.AutoSize = True
        Me.prod_owner_textbox_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.prod_owner_textbox_label.Location = New System.Drawing.Point(16, 195)
        Me.prod_owner_textbox_label.Name = "prod_owner_textbox_label"
        Me.prod_owner_textbox_label.Size = New System.Drawing.Size(44, 13)
        Me.prod_owner_textbox_label.TabIndex = 38
        Me.prod_owner_textbox_label.Text = "Owner: "
        '
        'prod_quantity_textbox_label
        '
        Me.prod_quantity_textbox_label.AutoSize = True
        Me.prod_quantity_textbox_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.prod_quantity_textbox_label.Location = New System.Drawing.Point(16, 251)
        Me.prod_quantity_textbox_label.Name = "prod_quantity_textbox_label"
        Me.prod_quantity_textbox_label.Size = New System.Drawing.Size(52, 13)
        Me.prod_quantity_textbox_label.TabIndex = 37
        Me.prod_quantity_textbox_label.Text = "Quantity: "
        '
        'prod_descr_textbox_label
        '
        Me.prod_descr_textbox_label.AutoSize = True
        Me.prod_descr_textbox_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.prod_descr_textbox_label.Location = New System.Drawing.Point(16, 122)
        Me.prod_descr_textbox_label.Name = "prod_descr_textbox_label"
        Me.prod_descr_textbox_label.Size = New System.Drawing.Size(66, 13)
        Me.prod_descr_textbox_label.TabIndex = 36
        Me.prod_descr_textbox_label.Text = "Description: "
        '
        'prod_name_textbox_label
        '
        Me.prod_name_textbox_label.AutoSize = True
        Me.prod_name_textbox_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.prod_name_textbox_label.Location = New System.Drawing.Point(16, 96)
        Me.prod_name_textbox_label.Name = "prod_name_textbox_label"
        Me.prod_name_textbox_label.Size = New System.Drawing.Size(41, 13)
        Me.prod_name_textbox_label.TabIndex = 35
        Me.prod_name_textbox_label.Text = "Name: "
        '
        'prod_search_button_label
        '
        Me.prod_search_button_label.AutoSize = True
        Me.prod_search_button_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.prod_search_button_label.Location = New System.Drawing.Point(16, 15)
        Me.prod_search_button_label.Name = "prod_search_button_label"
        Me.prod_search_button_label.Size = New System.Drawing.Size(41, 13)
        Me.prod_search_button_label.TabIndex = 34
        Me.prod_search_button_label.Text = "Search"
        '
        'prod_search_textbox
        '
        Me.prod_search_textbox.Location = New System.Drawing.Point(63, 12)
        Me.prod_search_textbox.Name = "prod_search_textbox"
        Me.prod_search_textbox.Size = New System.Drawing.Size(206, 20)
        Me.prod_search_textbox.TabIndex = 33
        '
        'prod_quantity_textbox
        '
        Me.prod_quantity_textbox.Location = New System.Drawing.Point(110, 244)
        Me.prod_quantity_textbox.Name = "prod_quantity_textbox"
        Me.prod_quantity_textbox.Size = New System.Drawing.Size(159, 20)
        Me.prod_quantity_textbox.TabIndex = 32
        '
        'prod_price_textbox
        '
        Me.prod_price_textbox.Location = New System.Drawing.Point(110, 218)
        Me.prod_price_textbox.Name = "prod_price_textbox"
        Me.prod_price_textbox.Size = New System.Drawing.Size(159, 20)
        Me.prod_price_textbox.TabIndex = 31
        '
        'prod_owner_textbox
        '
        Me.prod_owner_textbox.Location = New System.Drawing.Point(110, 192)
        Me.prod_owner_textbox.Name = "prod_owner_textbox"
        Me.prod_owner_textbox.Size = New System.Drawing.Size(159, 20)
        Me.prod_owner_textbox.TabIndex = 30
        '
        'prod_name_textbox
        '
        Me.prod_name_textbox.Location = New System.Drawing.Point(110, 93)
        Me.prod_name_textbox.Name = "prod_name_textbox"
        Me.prod_name_textbox.Size = New System.Drawing.Size(159, 20)
        Me.prod_name_textbox.TabIndex = 29
        '
        'prod_exit_button
        '
        Me.prod_exit_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prod_exit_button.Location = New System.Drawing.Point(455, 210)
        Me.prod_exit_button.Name = "prod_exit_button"
        Me.prod_exit_button.Size = New System.Drawing.Size(75, 23)
        Me.prod_exit_button.TabIndex = 28
        Me.prod_exit_button.Text = "EXIT"
        Me.prod_exit_button.UseVisualStyleBackColor = False
        '
        'prod_edit_button
        '
        Me.prod_edit_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prod_edit_button.Location = New System.Drawing.Point(374, 210)
        Me.prod_edit_button.Name = "prod_edit_button"
        Me.prod_edit_button.Size = New System.Drawing.Size(75, 23)
        Me.prod_edit_button.TabIndex = 27
        Me.prod_edit_button.Text = "EDIT"
        Me.prod_edit_button.UseVisualStyleBackColor = False
        '
        'prod_add_button
        '
        Me.prod_add_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prod_add_button.Location = New System.Drawing.Point(293, 210)
        Me.prod_add_button.Name = "prod_add_button"
        Me.prod_add_button.Size = New System.Drawing.Size(75, 23)
        Me.prod_add_button.TabIndex = 26
        Me.prod_add_button.Text = "ADD"
        Me.prod_add_button.UseVisualStyleBackColor = False
        '
        'prod_datagrid
        '
        Me.prod_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.prod_datagrid.Location = New System.Drawing.Point(275, 12)
        Me.prod_datagrid.Name = "prod_datagrid"
        Me.prod_datagrid.Size = New System.Drawing.Size(560, 165)
        Me.prod_datagrid.TabIndex = 25
        '
        'Edit_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(846, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prod_clear_button)
        Me.Controls.Add(Me.prod_descr_textbox)
        Me.Controls.Add(Me.prod_delete_button)
        Me.Controls.Add(Me.prod_cancel_button)
        Me.Controls.Add(Me.prod_save_button)
        Me.Controls.Add(Me.prod_price_textbox_label)
        Me.Controls.Add(Me.prod_owner_textbox_label)
        Me.Controls.Add(Me.prod_quantity_textbox_label)
        Me.Controls.Add(Me.prod_descr_textbox_label)
        Me.Controls.Add(Me.prod_name_textbox_label)
        Me.Controls.Add(Me.prod_search_button_label)
        Me.Controls.Add(Me.prod_search_textbox)
        Me.Controls.Add(Me.prod_quantity_textbox)
        Me.Controls.Add(Me.prod_price_textbox)
        Me.Controls.Add(Me.prod_owner_textbox)
        Me.Controls.Add(Me.prod_name_textbox)
        Me.Controls.Add(Me.prod_exit_button)
        Me.Controls.Add(Me.prod_edit_button)
        Me.Controls.Add(Me.prod_add_button)
        Me.Controls.Add(Me.prod_datagrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Edit_Product"
        Me.Text = "Product Management"
        CType(Me.prod_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents prod_clear_button As Button
    Friend WithEvents prod_descr_textbox As TextBox
    Friend WithEvents prod_delete_button As Button
    Friend WithEvents prod_cancel_button As Button
    Friend WithEvents prod_save_button As Button
    Friend WithEvents prod_price_textbox_label As Label
    Friend WithEvents prod_owner_textbox_label As Label
    Friend WithEvents prod_quantity_textbox_label As Label
    Friend WithEvents prod_descr_textbox_label As Label
    Friend WithEvents prod_name_textbox_label As Label
    Friend WithEvents prod_search_button_label As Label
    Friend WithEvents prod_search_textbox As TextBox
    Friend WithEvents prod_quantity_textbox As TextBox
    Friend WithEvents prod_price_textbox As TextBox
    Friend WithEvents prod_owner_textbox As TextBox
    Friend WithEvents prod_name_textbox As TextBox
    Friend WithEvents prod_exit_button As Button
    Friend WithEvents prod_edit_button As Button
    Friend WithEvents prod_add_button As Button
    Friend WithEvents prod_datagrid As DataGridView
End Class
