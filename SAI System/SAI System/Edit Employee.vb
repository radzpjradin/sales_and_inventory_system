Imports MySql.Data.MySqlClient

Public Class Edit_Employee

    Dim emp_edit_button_ispressed As Boolean = False 'This is used to determine whether the Edit Button has been pressed or not
    Dim emp_add_button_ispressed As Boolean = False 'This is used to determine whether the Add Button has been pressed or not
    Dim emp_pressed_datagrid_row_num As Integer = -1 'This is used to identify the row number of the selected data in the Data Grid named 'prod_datagrid'


    'START: Database Connection Variables and its associates
    Dim cs As String = "host=127.0.0.1; user=root; database=sais"

    Dim conn As New MySqlConnection(cs)

    Dim stm As String
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    'END: Database Connection Variables and its associates

    Private Sub Edit_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'START: Connect to the Database named 'sais' and fill the Data Grid

        Try
            stm = "SELECT * FROM employeedb WHERE employee_status='available'"
            conn.Open()
            ds = New DataSet
            da = New MySqlDataAdapter(stm, conn)
            da.Fill(ds, "employeedb")

            emp_datagrid.DataSource = ds.Tables("employeedb")

        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try
        'END: Database Connection Variables and its associates

        'START: Disable Form Textboxes and Buttons
        emp_firstname_textbox.Enabled = False
        emp_lastname_textbox.Enabled = False
        emp_email_textbox.Enabled = False
        emp_password_textbox.Enabled = False
        emp_gender_combobox.Enabled = False
        emp_position_combobox.Enabled = False

        emp_save_button.Enabled = False
        emp_delete_button.Enabled = False
        emp_cancel_button.Enabled = False
        emp_clear_button.Enabled = False
        'END: Disable Form Textboxes and Buttons

    End Sub

    Private Sub emp_search_textbox_TextChanged(sender As Object, e As EventArgs) Handles emp_search_textbox.TextChanged
        'START: Update the Data Grid

        If emp_search_textbox.Text = "" Then
            stm = "SELECT * FROM employeedb WHERE employee_status='available'"
        Else
            stm = "SELECT * FROM employeedb WHERE (
            (employee_id LIKE '" & emp_search_textbox.Text & "%') OR
            (employee_firstname LIKE '" & emp_search_textbox.Text & "%') OR
            (employee_lastname LIKE '" & emp_search_textbox.Text & "%') OR
            (employee_email LIKE '" & emp_search_textbox.Text & "%') OR
            (employee_gender LIKE '" & emp_search_textbox.Text & "%') OR
            (employee_position LIKE '" & emp_search_textbox.Text & "%')) AND
            (employee_status='available')"
        End If

        ds = New DataSet

        Try
            conn.Open()
            da = New MySqlDataAdapter(stm, conn)
            da.Fill(ds, "employeedb")

            emp_datagrid.DataSource = ds.Tables("employeedb")

        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try
        'END: Update the Data Grid
    End Sub

    Private Sub emp_search_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles emp_search_textbox.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub emp_firstname_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles emp_firstname_textbox.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub emp_lastname_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles emp_lastname_textbox.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub emp_add_button_Click(sender As Object, e As EventArgs) Handles emp_add_button.Click
        If (emp_edit_button_ispressed = False) Then
            'START: Enable Form Textboxes and Buttons
            emp_firstname_textbox.Enabled = True
            emp_lastname_textbox.Enabled = True
            emp_email_textbox.Enabled = True
            emp_password_textbox.Enabled = True

            emp_position_combobox.Enabled = True
            emp_gender_combobox.Enabled = True

            emp_save_button.Enabled = True
            emp_cancel_button.Enabled = True
            emp_clear_button.Enabled = True

            emp_gender_combobox.DropDownStyle = ComboBoxStyle.DropDownList
            emp_position_combobox.DropDownStyle = ComboBoxStyle.DropDownList
            'END: Enable Form Textboxes and Buttons

            emp_add_button_ispressed = True

            Label1.Text = "ADD EMPLOYEE"
        End If
    End Sub

    Private Sub emp_clear_button_Click(sender As Object, e As EventArgs) Handles emp_clear_button.Click
        'START: Empty the contents of the Form Textboxes
        emp_firstname_textbox.Text = ""
        emp_lastname_textbox.Text = ""
        emp_email_textbox.Text = ""
        emp_password_textbox.Text = ""
        'END: Empty the contents of the Form Textboxes


        If (emp_edit_button_ispressed = True) Then
            emp_pressed_datagrid_row_num = -1
        End If
    End Sub

    Private Sub emp_edit_button_Click(sender As Object, e As EventArgs) Handles emp_edit_button.Click
        If (emp_add_button_ispressed = False) Then

            'START: Enable Form Buttons
            emp_save_button.Enabled = True
            emp_delete_button.Enabled = True
            emp_cancel_button.Enabled = True
            emp_clear_button.Enabled = True

            emp_edit_button_ispressed = True

            Label1.Text = "EDIT EMPLOYEE"
            'END: Enable Form Buttons'
        End If
    End Sub

    Private Sub emp_cancel_button_Click(sender As Object, e As EventArgs) Handles emp_cancel_button.Click
        If (emp_add_button_ispressed = True) Then
            emp_add_button_ispressed = False
            Label1.Text = "EMPLOYEE MANAGEMENT"
        ElseIf (emp_edit_button_ispressed = True) Then
            emp_edit_button_ispressed = False
            Label1.Text = "EMPLOYEE MANAGEMENT"
        End If

        'START: Disable Form Textboxes and Buttons
        emp_firstname_textbox.Enabled = False
        emp_lastname_textbox.Enabled = False
        emp_email_textbox.Enabled = False
        emp_password_textbox.Enabled = False

        emp_save_button.Enabled = False
        emp_delete_button.Enabled = False
        emp_cancel_button.Enabled = False
        emp_clear_button.Enabled = False

        emp_position_combobox.Enabled = False
        emp_gender_combobox.Enabled = False

        'START: Empty the contents of the Form Textboxes
        emp_firstname_textbox.Text = ""
        emp_lastname_textbox.Text = ""
        emp_password_textbox.Text = ""
        emp_email_textbox.Text = ""
        'END: Empty the contents of the Form Textboxes
        'END: Disable Fom Textboxes and Buttons
    End Sub

    Private Sub emp_save_button_Click(sender As Object, e As EventArgs) Handles emp_save_button.Click
        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand
        'START: Check if one or more textboxes have empty contents
        If (emp_firstname_textbox.Text = "" Or emp_lastname_textbox.Text = "" Or emp_email_textbox.Text = "" Or emp_password_textbox.Text = "" Or emp_gender_combobox.Text = "" Or emp_position_combobox.Text = "") Then
            MsgBox("Please fill up the entire form")
            Return
            'END: Check if one or more textboxes have empty contents
        Else
            'START: Add Product data to the Database named 'SAIS', Table named 'productdb'
            If (emp_add_button_ispressed = True) Then

                Dim i As Integer
                Try
                    stm = "SELECT * FROM employeedb"
                    conn.Open()
                    ds = New DataSet
                    da = New MySqlDataAdapter(stm, conn)
                    da.Fill(ds, "employeedb")

                    emp_datagrid.DataSource = ds.Tables("employeedb")

                Catch ex As MySqlException
                    Console.WriteLine("Error: " & ex.ToString())
                Finally
                    conn.Close()
                End Try
                i = emp_datagrid.RowCount - 1 'Get the total number of rows in the Data Grid
                Try
                    conn.Open()
                    stm = "insert into employeedb (employee_id,employee_firstname,employee_lastname,employee_gender, employee_email, employee_password,employee_position,employee_status) values ('" & "EMP0000" & i.ToString() & "', '" & emp_firstname_textbox.Text & "','" & emp_lastname_textbox.Text & "','" & emp_gender_combobox.Text & "','" & emp_email_textbox.Text & "','" & emp_password_textbox.Text & "','" & emp_position_combobox.Text & "', 'available')"
                    Command = New MySqlCommand(stm, conn)
                    READER = Command.ExecuteReader

                    conn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Dispose()
                End Try
                'END: Add Porudcct data to the Database named 'SAIS', Table named 'productdb'

            ElseIf (emp_edit_button_ispressed = True) Then
                'START: Check if data have been selected from the Data Grid
                If (emp_pressed_datagrid_row_num = -1) Then
                    MsgBox("Please select a product in the data grid")
                    Return
                    'END: Check if data have been selected from the Data Grid
                End If
                'START: Update Selected Product information to the Database named 'SAIS', Table named 'productdb'
                Try
                    Dim i As Integer = emp_datagrid.CurrentRow.Index
                    conn.Open()
                    stm = "UPDATE employeedb Set employee_firstname= '" & emp_firstname_textbox.Text & "', employee_lastname= '" & emp_lastname_textbox.Text & "', employee_gender= '" & emp_gender_combobox.Text & "', employee_email= '" & emp_email_textbox.Text & "', employee_password= '" & emp_password_textbox.Text & "', employee_position= '" & emp_position_combobox.Text & "' WHERE e_id='" & emp_datagrid.Item(0, i).Value & "'; "
                    Command = New MySqlCommand(stm, conn)
                    READER = Command.ExecuteReader

                    conn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Dispose()
                End Try
                'END: Update Selected Product information to the Database named 'SAIS', Table named 'productdb'
            End If
        End If
        'START: Empty Form Textboxes' Contents
        emp_firstname_textbox.Text = ""
        emp_lastname_textbox.Text = ""
        emp_email_textbox.Text = ""
        emp_password_textbox.Text = ""
        'END: Empty Form Textboxes' Contents

        'START: Update information in the Data Grid
        ds = New DataSet
        stm = "SELECT * FROM employeedb WHERE employee_status='available'"

        Try
            conn.Open()
            da = New MySqlDataAdapter(stm, conn)
            da.Fill(ds, "employeedb")

            emp_datagrid.DataSource = ds.Tables("employeedb")

            MessageBox.Show("Data Saved")
        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try
        'END: Update information in the Data Grid
    End Sub

    Private Sub emp_delete_button_Click(sender As Object, e As EventArgs) Handles emp_delete_button.Click
        If (emp_pressed_datagrid_row_num <> -1) Then
            'START: Delete product in the Database name 'SAIS', Table name 'productdb'
            Dim cmd As New MySqlCommand()
            Try
                Dim i As Integer = emp_datagrid.CurrentRow.Index
                conn.Open()

                cmd.Connection = conn

                cmd.CommandText = "UPDATE employeedb SET employee_status='deleted' WHERE e_id='" & emp_datagrid.Item(0, i).Value & "'; "
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                conn.Close()
            Catch ex As Exception
                Console.WriteLine("Error: " & ex.ToString())
            End Try

            'END: Delete product in the Database name 'SAIS', Table name 'productdb'

            'START: Empty Form Textboxes' Contents
            emp_firstname_textbox.Text = ""
            emp_lastname_textbox.Text = ""
            emp_email_textbox.Text = ""
            emp_password_textbox.Text = ""
            'END: Empty Form Textboxes' Contents

            'START: Update information in the Data Grid
            ds = New DataSet
            stm = "SELECT * FROM employeedb WHERE employee_status='available'"

            Try
                conn.Open()
                da = New MySqlDataAdapter(stm, conn)
                da.Fill(ds, "employeedb")

                emp_datagrid.DataSource = ds.Tables("employeedb")

            Catch ex As MySqlException
                Console.WriteLine("Error: " & ex.ToString())
            Finally
                conn.Close()
            End Try
            'END: Update information in the Data Grid
        Else
            MsgBox("Select employee first before deleting")
        End If

    End Sub

    Private Sub emp_datagrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles emp_datagrid.CellClick
        If (emp_edit_button_ispressed = True) Then
            Dim i As Integer = emp_datagrid.CurrentRow.Index
            emp_firstname_textbox.Text = emp_datagrid.Item(2, i).Value
            emp_lastname_textbox.Text = emp_datagrid.Item(3, i).Value
            emp_gender_combobox.Text = emp_datagrid.Item(4, i).Value
            emp_email_textbox.Text = emp_datagrid.Item(5, i).Value
            emp_password_textbox.Text = emp_datagrid.Item(6, i).Value
            emp_position_combobox.Text = emp_datagrid.Item(7, i).Value
            emp_pressed_datagrid_row_num = i

            'START: Enable to use the Form Textboxes 
            emp_firstname_textbox.Enabled = True
            emp_lastname_textbox.Enabled = True
            emp_email_textbox.Enabled = True
            emp_password_textbox.Enabled = True
            emp_gender_combobox.Enabled = True
            emp_position_combobox.Enabled = True
            emp_gender_combobox.DropDownStyle = ComboBoxStyle.DropDownList
            emp_position_combobox.DropDownStyle = ComboBoxStyle.DropDownList

            'END: Enable to use the Form Textboxes
        End If
    End Sub

    Private Sub emp_exit_button_Click(sender As Object, e As EventArgs) Handles emp_exit_button.Click
        Manager.Show()
        Me.Close()
    End Sub

    Private Sub emp_firstname_textbox_TextChanged(sender As Object, e As EventArgs) Handles emp_firstname_textbox.TextChanged

    End Sub
End Class