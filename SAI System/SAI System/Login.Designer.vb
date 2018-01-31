<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.sais_login_id_textbox = New System.Windows.Forms.TextBox()
        Me.sais_login_password_textbox = New System.Windows.Forms.TextBox()
        Me.sais_login_login_button = New System.Windows.Forms.Button()
        Me.sais_login_id_textbox_label = New System.Windows.Forms.Label()
        Me.sais_login_password_textbox_label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'sais_login_id_textbox
        '
        Me.sais_login_id_textbox.Location = New System.Drawing.Point(146, 62)
        Me.sais_login_id_textbox.Name = "sais_login_id_textbox"
        Me.sais_login_id_textbox.Size = New System.Drawing.Size(182, 20)
        Me.sais_login_id_textbox.TabIndex = 0
        '
        'sais_login_password_textbox
        '
        Me.sais_login_password_textbox.Location = New System.Drawing.Point(146, 99)
        Me.sais_login_password_textbox.Name = "sais_login_password_textbox"
        Me.sais_login_password_textbox.Size = New System.Drawing.Size(182, 20)
        Me.sais_login_password_textbox.TabIndex = 1
        Me.sais_login_password_textbox.UseSystemPasswordChar = True
        '
        'sais_login_login_button
        '
        Me.sais_login_login_button.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sais_login_login_button.Location = New System.Drawing.Point(146, 142)
        Me.sais_login_login_button.Name = "sais_login_login_button"
        Me.sais_login_login_button.Size = New System.Drawing.Size(75, 23)
        Me.sais_login_login_button.TabIndex = 2
        Me.sais_login_login_button.Text = "LOGIN"
        Me.sais_login_login_button.UseVisualStyleBackColor = False
        '
        'sais_login_id_textbox_label
        '
        Me.sais_login_id_textbox_label.AutoSize = True
        Me.sais_login_id_textbox_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.sais_login_id_textbox_label.Location = New System.Drawing.Point(100, 69)
        Me.sais_login_id_textbox_label.Name = "sais_login_id_textbox_label"
        Me.sais_login_id_textbox_label.Size = New System.Drawing.Size(24, 13)
        Me.sais_login_id_textbox_label.TabIndex = 3
        Me.sais_login_id_textbox_label.Text = "ID: "
        '
        'sais_login_password_textbox_label
        '
        Me.sais_login_password_textbox_label.AutoSize = True
        Me.sais_login_password_textbox_label.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.sais_login_password_textbox_label.Location = New System.Drawing.Point(65, 106)
        Me.sais_login_password_textbox_label.Name = "sais_login_password_textbox_label"
        Me.sais_login_password_textbox_label.Size = New System.Drawing.Size(59, 13)
        Me.sais_login_password_textbox_label.TabIndex = 4
        Me.sais_login_password_textbox_label.Text = "Password: "
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(417, 261)
        Me.Controls.Add(Me.sais_login_password_textbox_label)
        Me.Controls.Add(Me.sais_login_id_textbox_label)
        Me.Controls.Add(Me.sais_login_login_button)
        Me.Controls.Add(Me.sais_login_password_textbox)
        Me.Controls.Add(Me.sais_login_id_textbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.Text = "SAIM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sais_login_id_textbox As TextBox
    Friend WithEvents sais_login_password_textbox As TextBox
    Friend WithEvents sais_login_login_button As Button
    Friend WithEvents sais_login_id_textbox_label As Label
    Friend WithEvents sais_login_password_textbox_label As Label
End Class
