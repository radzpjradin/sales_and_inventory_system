Public Class Employee
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub sais_manager_logout_button_Click(sender As Object, e As EventArgs) Handles sais_manager_logout_button.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub sais_manager_st_page_button_Click(sender As Object, e As EventArgs) Handles sais_manager_st_page_button.Click
        Sales_Transaction.Show()
        Sales_Transaction.stp_user.Text = "Employee"
        Me.Close()
    End Sub
End Class