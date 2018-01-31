Public Class Manager
    Private Sub sais_manager_logout_button_Click(sender As Object, e As EventArgs) Handles sais_manager_logout_button.Click
        Login.Show()
        Login.sais_login_id_textbox.Text = ""
        Login.sais_login_password_textbox.Text = ""
        Me.Close()
    End Sub

    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub sais_manager_ed_page_button_Click(sender As Object, e As EventArgs) Handles sais_manager_ed_page_button.Click

        Edit_Product.Show()
        Me.Close()

    End Sub

    Private Sub sais_manager_ee_page_button_Click(sender As Object, e As EventArgs) Handles sais_manager_ee_page_button.Click
        Edit_Employee.Show()
        Me.Close()
    End Sub

    Private Sub sais_manager_st_page_button_Click(sender As Object, e As EventArgs) Handles sais_manager_st_page_button.Click
        Sales_Transaction.Show()
        Sales_Transaction.stp_user.Text = "Manager"
        Me.Close()
    End Sub
End Class