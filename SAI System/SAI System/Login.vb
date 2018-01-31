Imports MySql.Data.MySqlClient

Public Class Login
    Dim us As String = ""
    Dim ps As String = ""

    'START: Database Connection Variables and its associates
    Dim cs As String = "host=127.0.0.1; user=root; database=sais"

    Dim conn As New MySqlConnection(cs)

    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim stm As String
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    'END: Database Connection Variables and its associates
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub sais_login_login_button_Click(sender As Object, e As EventArgs) Handles sais_login_login_button.Click
        If (sais_login_id_textbox.Text = "" Or sais_login_password_textbox.Text = "") Then
            MsgBox("Invalid Username or Password")
            Return
        Else
            conn.Open()
            stm = "SELECT * FROM employeedb WHERE employee_id = '" & sais_login_id_textbox.Text & "' AND employee_password = '" & sais_login_password_textbox.Text & "' AND employee_status='available' "
            cmd = New MySqlCommand(stm, conn)
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                If dr.GetString("employee_position") = "Manager" Then
                    Manager.Show()
                    us = sais_login_id_textbox.Text
                    ps = sais_login_password_textbox.Text
                    sais_login_id_textbox.Text = ""
                    sais_login_password_textbox.Text = ""
                    Me.Hide()
                    conn.Close()
                    Return
                Else
                    Employee.Show()
                    us = sais_login_id_textbox.Text
                    ps = sais_login_password_textbox.Text
                    sais_login_id_textbox.Text = ""
                    sais_login_password_textbox.Text = ""
                    Me.Hide()
                    conn.Close()
                End If
            Else
                MsgBox("Invalid Username or Password")
                conn.Close()
            End If

        End If

    End Sub
End Class
