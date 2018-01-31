<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Employee
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
        Me.emp_search_textbox = New System.Windows.Forms.TextBox()
        Me.emp_search_textbox_label = New System.Windows.Forms.Label()
        Me.emp_cancel_button = New System.Windows.Forms.Button()
        Me.emp_clear_button = New System.Windows.Forms.Button()
        Me.emp_delete_button = New System.Windows.Forms.Button()
        Me.emp_save_button = New System.Windows.Forms.Button()
        Me.emp_exit_button = New System.Windows.Forms.Button()
        Me.emp_edit_button = New System.Windows.Forms.Button()
        Me.emp_add_button = New System.Windows.Forms.Button()
        Me.emp_position_combobox = New System.Windows.Forms.ComboBox()
        Me.emp_gender_combobox = New System.Windows.Forms.ComboBox()
        Me.emp_position_label = New System.Windows.Forms.Label()
        Me.emp_gender_label = New System.Windows.Forms.Label()
        Me.emp_datagrid = New System.Windows.Forms.DataGridView()
        Me.emp_password_label = New System.Windows.Forms.Label()
        Me.emp_email_label = New System.Windows.Forms.Label()
        Me.emp_lastname_label = New System.Windows.Forms.Label()
        Me.emp_firstname_label = New System.Windows.Forms.Label()
        Me.emp_password_textbox = New System.Windows.Forms.TextBox()
        Me.emp_email_textbox = New System.Windows.Forms.TextBox()
        Me.emp_lastname_textbox = New System.Windows.Forms.TextBox()
        Me.emp_firstname_textbox = New System.Windows.Forms.TextBox()
        CType(Me.emp_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(24, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "EMPLOYEE MANAGEMENT"
        '
        'emp_search_textbox
        '
        Me.emp_search_textbox.Location = New System.Drawing.Point(56, 10)
        Me.emp_search_textbox.Name = "emp_search_textbox"
        Me.emp_search_textbox.Size = New System.Drawing.Size(223, 20)
        Me.emp_search_textbox.TabIndex = 44
        '
        'emp_search_textbox_label
        '
        Me.emp_search_textbox_label.AutoSize = True
        Me.emp_search_textbox_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.emp_search_textbox_label.Location = New System.Drawing.Point(12, 13)
        Me.emp_search_textbox_label.Name = "emp_search_textbox_label"
        Me.emp_search_textbox_label.Size = New System.Drawing.Size(47, 13)
        Me.emp_search_textbox_label.TabIndex = 43
        Me.emp_search_textbox_label.Text = "Search: "
        '
        'emp_cancel_button
        '
        Me.emp_cancel_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.emp_cancel_button.Location = New System.Drawing.Point(169, 314)
        Me.emp_cancel_button.Name = "emp_cancel_button"
        Me.emp_cancel_button.Size = New System.Drawing.Size(75, 23)
        Me.emp_cancel_button.TabIndex = 42
        Me.emp_cancel_button.Text = "CANCEL"
        Me.emp_cancel_button.UseVisualStyleBackColor = False
        '
        'emp_clear_button
        '
        Me.emp_clear_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.emp_clear_button.Location = New System.Drawing.Point(12, 314)
        Me.emp_clear_button.Name = "emp_clear_button"
        Me.emp_clear_button.Size = New System.Drawing.Size(75, 23)
        Me.emp_clear_button.TabIndex = 41
        Me.emp_clear_button.Text = "CLEAR"
        Me.emp_clear_button.UseVisualStyleBackColor = False
        '
        'emp_delete_button
        '
        Me.emp_delete_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.emp_delete_button.Location = New System.Drawing.Point(169, 285)
        Me.emp_delete_button.Name = "emp_delete_button"
        Me.emp_delete_button.Size = New System.Drawing.Size(75, 23)
        Me.emp_delete_button.TabIndex = 40
        Me.emp_delete_button.Text = "DELETE"
        Me.emp_delete_button.UseVisualStyleBackColor = False
        '
        'emp_save_button
        '
        Me.emp_save_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.emp_save_button.Location = New System.Drawing.Point(12, 285)
        Me.emp_save_button.Name = "emp_save_button"
        Me.emp_save_button.Size = New System.Drawing.Size(75, 23)
        Me.emp_save_button.TabIndex = 39
        Me.emp_save_button.Text = "SAVE"
        Me.emp_save_button.UseVisualStyleBackColor = False
        '
        'emp_exit_button
        '
        Me.emp_exit_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.emp_exit_button.Location = New System.Drawing.Point(519, 214)
        Me.emp_exit_button.Name = "emp_exit_button"
        Me.emp_exit_button.Size = New System.Drawing.Size(75, 23)
        Me.emp_exit_button.TabIndex = 38
        Me.emp_exit_button.Text = "EXIT"
        Me.emp_exit_button.UseVisualStyleBackColor = False
        '
        'emp_edit_button
        '
        Me.emp_edit_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.emp_edit_button.Location = New System.Drawing.Point(438, 214)
        Me.emp_edit_button.Name = "emp_edit_button"
        Me.emp_edit_button.Size = New System.Drawing.Size(75, 23)
        Me.emp_edit_button.TabIndex = 37
        Me.emp_edit_button.Text = "EDIT"
        Me.emp_edit_button.UseVisualStyleBackColor = False
        '
        'emp_add_button
        '
        Me.emp_add_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.emp_add_button.Location = New System.Drawing.Point(357, 214)
        Me.emp_add_button.Name = "emp_add_button"
        Me.emp_add_button.Size = New System.Drawing.Size(75, 23)
        Me.emp_add_button.TabIndex = 36
        Me.emp_add_button.Text = "ADD"
        Me.emp_add_button.UseVisualStyleBackColor = False
        '
        'emp_position_combobox
        '
        Me.emp_position_combobox.FormattingEnabled = True
        Me.emp_position_combobox.Items.AddRange(New Object() {"Employee", "Manager"})
        Me.emp_position_combobox.Location = New System.Drawing.Point(123, 229)
        Me.emp_position_combobox.Name = "emp_position_combobox"
        Me.emp_position_combobox.Size = New System.Drawing.Size(121, 21)
        Me.emp_position_combobox.TabIndex = 35
        Me.emp_position_combobox.Text = "Manager"
        '
        'emp_gender_combobox
        '
        Me.emp_gender_combobox.FormattingEnabled = True
        Me.emp_gender_combobox.Items.AddRange(New Object() {"Male", "Female"})
        Me.emp_gender_combobox.Location = New System.Drawing.Point(123, 196)
        Me.emp_gender_combobox.Name = "emp_gender_combobox"
        Me.emp_gender_combobox.Size = New System.Drawing.Size(121, 21)
        Me.emp_gender_combobox.TabIndex = 34
        Me.emp_gender_combobox.Text = "Male"
        '
        'emp_position_label
        '
        Me.emp_position_label.AutoSize = True
        Me.emp_position_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.emp_position_label.Location = New System.Drawing.Point(23, 237)
        Me.emp_position_label.Name = "emp_position_label"
        Me.emp_position_label.Size = New System.Drawing.Size(50, 13)
        Me.emp_position_label.TabIndex = 33
        Me.emp_position_label.Text = "Position: "
        '
        'emp_gender_label
        '
        Me.emp_gender_label.AutoSize = True
        Me.emp_gender_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.emp_gender_label.Location = New System.Drawing.Point(23, 204)
        Me.emp_gender_label.Name = "emp_gender_label"
        Me.emp_gender_label.Size = New System.Drawing.Size(48, 13)
        Me.emp_gender_label.TabIndex = 32
        Me.emp_gender_label.Text = "Gender: "
        '
        'emp_datagrid
        '
        Me.emp_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.emp_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.emp_datagrid.Location = New System.Drawing.Point(315, 10)
        Me.emp_datagrid.Name = "emp_datagrid"
        Me.emp_datagrid.Size = New System.Drawing.Size(519, 150)
        Me.emp_datagrid.TabIndex = 31
        '
        'emp_password_label
        '
        Me.emp_password_label.AutoSize = True
        Me.emp_password_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.emp_password_label.Location = New System.Drawing.Point(23, 163)
        Me.emp_password_label.Name = "emp_password_label"
        Me.emp_password_label.Size = New System.Drawing.Size(59, 13)
        Me.emp_password_label.TabIndex = 30
        Me.emp_password_label.Text = "Password: "
        '
        'emp_email_label
        '
        Me.emp_email_label.AutoSize = True
        Me.emp_email_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.emp_email_label.Location = New System.Drawing.Point(24, 133)
        Me.emp_email_label.Name = "emp_email_label"
        Me.emp_email_label.Size = New System.Drawing.Size(37, 13)
        Me.emp_email_label.TabIndex = 29
        Me.emp_email_label.Text = "email: "
        '
        'emp_lastname_label
        '
        Me.emp_lastname_label.AutoSize = True
        Me.emp_lastname_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.emp_lastname_label.Location = New System.Drawing.Point(23, 107)
        Me.emp_lastname_label.Name = "emp_lastname_label"
        Me.emp_lastname_label.Size = New System.Drawing.Size(64, 13)
        Me.emp_lastname_label.TabIndex = 28
        Me.emp_lastname_label.Text = "Last Name: "
        '
        'emp_firstname_label
        '
        Me.emp_firstname_label.AutoSize = True
        Me.emp_firstname_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.emp_firstname_label.Location = New System.Drawing.Point(23, 81)
        Me.emp_firstname_label.Name = "emp_firstname_label"
        Me.emp_firstname_label.Size = New System.Drawing.Size(63, 13)
        Me.emp_firstname_label.TabIndex = 27
        Me.emp_firstname_label.Text = "First Name: "
        '
        'emp_password_textbox
        '
        Me.emp_password_textbox.Location = New System.Drawing.Point(123, 156)
        Me.emp_password_textbox.Name = "emp_password_textbox"
        Me.emp_password_textbox.Size = New System.Drawing.Size(156, 20)
        Me.emp_password_textbox.TabIndex = 26
        Me.emp_password_textbox.UseSystemPasswordChar = True
        '
        'emp_email_textbox
        '
        Me.emp_email_textbox.Location = New System.Drawing.Point(123, 130)
        Me.emp_email_textbox.Name = "emp_email_textbox"
        Me.emp_email_textbox.Size = New System.Drawing.Size(156, 20)
        Me.emp_email_textbox.TabIndex = 25
        '
        'emp_lastname_textbox
        '
        Me.emp_lastname_textbox.Location = New System.Drawing.Point(123, 104)
        Me.emp_lastname_textbox.Name = "emp_lastname_textbox"
        Me.emp_lastname_textbox.Size = New System.Drawing.Size(156, 20)
        Me.emp_lastname_textbox.TabIndex = 24
        '
        'emp_firstname_textbox
        '
        Me.emp_firstname_textbox.Location = New System.Drawing.Point(123, 78)
        Me.emp_firstname_textbox.Name = "emp_firstname_textbox"
        Me.emp_firstname_textbox.Size = New System.Drawing.Size(156, 20)
        Me.emp_firstname_textbox.TabIndex = 23
        '
        'Edit_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(846, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.emp_search_textbox)
        Me.Controls.Add(Me.emp_search_textbox_label)
        Me.Controls.Add(Me.emp_cancel_button)
        Me.Controls.Add(Me.emp_clear_button)
        Me.Controls.Add(Me.emp_delete_button)
        Me.Controls.Add(Me.emp_save_button)
        Me.Controls.Add(Me.emp_exit_button)
        Me.Controls.Add(Me.emp_edit_button)
        Me.Controls.Add(Me.emp_add_button)
        Me.Controls.Add(Me.emp_position_combobox)
        Me.Controls.Add(Me.emp_gender_combobox)
        Me.Controls.Add(Me.emp_position_label)
        Me.Controls.Add(Me.emp_gender_label)
        Me.Controls.Add(Me.emp_datagrid)
        Me.Controls.Add(Me.emp_password_label)
        Me.Controls.Add(Me.emp_email_label)
        Me.Controls.Add(Me.emp_lastname_label)
        Me.Controls.Add(Me.emp_firstname_label)
        Me.Controls.Add(Me.emp_password_textbox)
        Me.Controls.Add(Me.emp_email_textbox)
        Me.Controls.Add(Me.emp_lastname_textbox)
        Me.Controls.Add(Me.emp_firstname_textbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Edit_Employee"
        Me.Text = "Employee Management"
        CType(Me.emp_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents emp_search_textbox As TextBox
    Friend WithEvents emp_search_textbox_label As Label
    Friend WithEvents emp_cancel_button As Button
    Friend WithEvents emp_clear_button As Button
    Friend WithEvents emp_delete_button As Button
    Friend WithEvents emp_save_button As Button
    Friend WithEvents emp_exit_button As Button
    Friend WithEvents emp_edit_button As Button
    Friend WithEvents emp_add_button As Button
    Friend WithEvents emp_position_combobox As ComboBox
    Friend WithEvents emp_gender_combobox As ComboBox
    Friend WithEvents emp_position_label As Label
    Friend WithEvents emp_gender_label As Label
    Friend WithEvents emp_datagrid As DataGridView
    Friend WithEvents emp_password_label As Label
    Friend WithEvents emp_email_label As Label
    Friend WithEvents emp_lastname_label As Label
    Friend WithEvents emp_firstname_label As Label
    Friend WithEvents emp_password_textbox As TextBox
    Friend WithEvents emp_email_textbox As TextBox
    Friend WithEvents emp_lastname_textbox As TextBox
    Friend WithEvents emp_firstname_textbox As TextBox
End Class
