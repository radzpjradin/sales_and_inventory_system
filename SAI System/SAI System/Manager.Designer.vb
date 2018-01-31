<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager
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
        Me.sais_manager_st_page_button = New System.Windows.Forms.Button()
        Me.sais_manager_ed_page_button = New System.Windows.Forms.Button()
        Me.sais_manager_ee_page_button = New System.Windows.Forms.Button()
        Me.sais_manager_logout_button = New System.Windows.Forms.Button()
        Me.sais_manager_page_label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'sais_manager_st_page_button
        '
        Me.sais_manager_st_page_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sais_manager_st_page_button.Location = New System.Drawing.Point(41, 89)
        Me.sais_manager_st_page_button.Name = "sais_manager_st_page_button"
        Me.sais_manager_st_page_button.Size = New System.Drawing.Size(105, 63)
        Me.sais_manager_st_page_button.TabIndex = 0
        Me.sais_manager_st_page_button.Text = "SALES TRANSACTION"
        Me.sais_manager_st_page_button.UseVisualStyleBackColor = False
        '
        'sais_manager_ed_page_button
        '
        Me.sais_manager_ed_page_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sais_manager_ed_page_button.Location = New System.Drawing.Point(41, 158)
        Me.sais_manager_ed_page_button.Name = "sais_manager_ed_page_button"
        Me.sais_manager_ed_page_button.Size = New System.Drawing.Size(105, 63)
        Me.sais_manager_ed_page_button.TabIndex = 1
        Me.sais_manager_ed_page_button.Text = "EDIT PRODUCT"
        Me.sais_manager_ed_page_button.UseVisualStyleBackColor = False
        '
        'sais_manager_ee_page_button
        '
        Me.sais_manager_ee_page_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sais_manager_ee_page_button.Location = New System.Drawing.Point(152, 89)
        Me.sais_manager_ee_page_button.Name = "sais_manager_ee_page_button"
        Me.sais_manager_ee_page_button.Size = New System.Drawing.Size(105, 63)
        Me.sais_manager_ee_page_button.TabIndex = 2
        Me.sais_manager_ee_page_button.Text = "EDIT EMPLOYEE"
        Me.sais_manager_ee_page_button.UseVisualStyleBackColor = False
        '
        'sais_manager_logout_button
        '
        Me.sais_manager_logout_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sais_manager_logout_button.Location = New System.Drawing.Point(152, 158)
        Me.sais_manager_logout_button.Name = "sais_manager_logout_button"
        Me.sais_manager_logout_button.Size = New System.Drawing.Size(105, 63)
        Me.sais_manager_logout_button.TabIndex = 3
        Me.sais_manager_logout_button.Text = "LOGOUT"
        Me.sais_manager_logout_button.UseVisualStyleBackColor = False
        '
        'sais_manager_page_label
        '
        Me.sais_manager_page_label.AutoSize = True
        Me.sais_manager_page_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.sais_manager_page_label.Location = New System.Drawing.Point(38, 29)
        Me.sais_manager_page_label.Name = "sais_manager_page_label"
        Me.sais_manager_page_label.Size = New System.Drawing.Size(93, 13)
        Me.sais_manager_page_label.TabIndex = 4
        Me.sais_manager_page_label.Text = "MANAGER PAGE"
        '
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(309, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.sais_manager_page_label)
        Me.Controls.Add(Me.sais_manager_logout_button)
        Me.Controls.Add(Me.sais_manager_ee_page_button)
        Me.Controls.Add(Me.sais_manager_ed_page_button)
        Me.Controls.Add(Me.sais_manager_st_page_button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Manager"
        Me.Text = "Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sais_manager_st_page_button As Button
    Friend WithEvents sais_manager_ed_page_button As Button
    Friend WithEvents sais_manager_ee_page_button As Button
    Friend WithEvents sais_manager_logout_button As Button
    Friend WithEvents sais_manager_page_label As Label
End Class
