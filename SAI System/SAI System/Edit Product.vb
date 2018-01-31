Imports MySql.Data.MySqlClient

Public Class Edit_Product

    Dim prod_edit_button_ispressed As Boolean = False 'This is used to determine whether the Edit Button has been pressed or not
    Dim prod_add_button_ispressed As Boolean = False 'This is used to determine whether the Add Button has been pressed or not
    Dim prod_pressed_datagrid_row_num As Integer = -1 'This is used to identify the row number of the selected data in the Data Grid named 'prod_datagrid'

    'START: Database Connection Variables and its associates
    Dim cs As String = "host=127.0.0.1; user=root; database=sais"

    Dim conn As New MySqlConnection(cs)

    Dim stm As String
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    'END: Database Connection Variables and its associates

    Private Sub Edit_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'START: Connect to the Database named 'sais' and fill the Data Grid

        Try
            stm = "SELECT * FROM productdb WHERE product_status='available'"
            conn.Open()
            ds = New DataSet
            da = New MySqlDataAdapter(stm, conn)
            da.Fill(ds, "productdb")

            prod_datagrid.DataSource = ds.Tables("productdb")

        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try
        'END:  Connect to the Database named 'sais' and fill the Data Grid

        'START: Disable Form Textboxes and Buttons
        prod_name_textbox.Enabled = False
        prod_descr_textbox.Enabled = False
        prod_owner_textbox.Enabled = False
        prod_price_textbox.Enabled = False
        prod_quantity_textbox.Enabled = False

        prod_save_button.Enabled = False
        prod_delete_button.Enabled = False
        prod_cancel_button.Enabled = False
        prod_clear_button.Enabled = False
        'END: Disable Form Textboxes and Buttons
    End Sub

    Private Sub prod_add_button_Click(sender As Object, e As EventArgs) Handles prod_add_button.Click
        If (prod_edit_button_ispressed = False) Then
            'START: Enable Form Textboxes and Buttons
            prod_name_textbox.Enabled = True
            prod_descr_textbox.Enabled = True
            prod_owner_textbox.Enabled = True
            prod_price_textbox.Enabled = True
            prod_quantity_textbox.Enabled = True

            prod_save_button.Enabled = True
            prod_cancel_button.Enabled = True
            prod_clear_button.Enabled = True
            'END: Enable Form Textboxes and Buttons

            prod_add_button_ispressed = True

            Label1.Text = "ADD PRODUCT"
        End If

    End Sub

    Private Sub prod_search_textbox_TextChanged(sender As Object, e As EventArgs) Handles prod_search_textbox.TextChanged

        'START: Update the Data Grid

        If prod_search_textbox.Text = "" Then
            stm = "SELECT * FROM productdb WHERE product_status='available'"
        Else
            stm = "SELECT * FROM productdb WHERE (
            (product_id LIKE '" & prod_search_textbox.Text & "%') OR
            (product_name LIKE '" & prod_search_textbox.Text & "%') OR
            (product_descr LIKE '" & prod_search_textbox.Text & "%') OR
            (product_owner LIKE '" & prod_search_textbox.Text & "%'))
            AND product_status='available'"
        End If

        ds = New DataSet

        Try
            conn.Open()
            da = New MySqlDataAdapter(stm, conn)
            da.Fill(ds, "productdb")

            prod_datagrid.DataSource = ds.Tables("productdb")

        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try
        'END: Update the Data Grid

    End Sub

    Private Sub prod_edit_button_Click(sender As Object, e As EventArgs) Handles prod_edit_button.Click

        If (prod_add_button_ispressed = False) Then

            'START: Enable Form Buttons
            prod_save_button.Enabled = True
            prod_delete_button.Enabled = True
            prod_cancel_button.Enabled = True
            prod_clear_button.Enabled = True

            prod_edit_button_ispressed = True

            Label1.Text = "EDIT PRODUCT"
            'END: Enable Form Buttons'
        End If

    End Sub

    Private Sub prod_cancel_button_Click(sender As Object, e As EventArgs) Handles prod_cancel_button.Click

        If (prod_add_button_ispressed = True) Then
            prod_add_button_ispressed = False
            Label1.Text = "PRODUCT MANAGEMENT"
        ElseIf (prod_edit_button_ispressed = True) Then
            prod_edit_button_ispressed = False
            Label1.Text = "PRODUCT MANAGEMENT"
        End If

        'START: Disable Form Textboxes and Buttons
        prod_name_textbox.Enabled = False
        prod_descr_textbox.Enabled = False
        prod_owner_textbox.Enabled = False
        prod_price_textbox.Enabled = False
        prod_quantity_textbox.Enabled = False

        prod_save_button.Enabled = False
        prod_delete_button.Enabled = False
        prod_cancel_button.Enabled = False
        prod_clear_button.Enabled = False

        'START: Empty the contents of the Form Textboxes
        prod_name_textbox.Text = ""
        prod_descr_textbox.Text = ""
        prod_owner_textbox.Text = ""
        prod_price_textbox.Text = ""
        prod_quantity_textbox.Text = ""
        'END: Empty the contents of the Form Textboxes
        'END: Disable Fom Textboxes and Buttons

    End Sub

    Private Sub prod_clear_button_Click(sender As Object, e As EventArgs) Handles prod_clear_button.Click

        'START: Empty the contents of the Form Textboxes
        prod_name_textbox.Text = ""
        prod_descr_textbox.Text = ""
        prod_owner_textbox.Text = ""
        prod_price_textbox.Text = ""
        prod_quantity_textbox.Text = ""
        'END: Empty the contents of the Form Textboxes


        If (prod_edit_button_ispressed = True) Then
            prod_pressed_datagrid_row_num = -1
        End If

    End Sub

    Private Sub prod_save_button_Click(sender As Object, e As EventArgs) Handles prod_save_button.Click

        Dim READER As MySqlDataReader
        Dim Command As MySqlCommand
        'START: Check if one or more textboxes have empty contents
        If (prod_name_textbox.Text = "" Or prod_descr_textbox.Text = "" Or prod_owner_textbox.Text = "" Or prod_price_textbox.Text = "" Or prod_quantity_textbox.Text = "") Then
            MsgBox("Please fill up the entire form")
            Return
            'END: Check if one or more textboxes have empty contents
        Else
            'START: Add Product data to the Database named 'SAIS', Table named 'productdb'
            If (prod_add_button_ispressed = True) Then

                Dim i As Integer
                Try
                    stm = "SELECT * FROM productdb"
                    conn.Open()
                    ds = New DataSet
                    da = New MySqlDataAdapter(stm, conn)
                    da.Fill(ds, "productdb")

                    prod_datagrid.DataSource = ds.Tables("productdb")

                Catch ex As MySqlException
                    Console.WriteLine("Error: " & ex.ToString())
                Finally
                    conn.Close()
                End Try
                i = prod_datagrid.RowCount - 1 'Get the total number of rows in the Data Grid
                Try
                    conn.Open()
                    stm = "insert into productdb (product_id,product_name,product_descr,product_price, product_quantity, product_owner,product_status) values ('" & "PR0000" & i.ToString() & "', '" & prod_name_textbox.Text & "','" & prod_descr_textbox.Text & "','" & prod_price_textbox.Text & "','" & prod_quantity_textbox.Text & "','" & prod_owner_textbox.Text & "', 'available')"
                    Command = New MySqlCommand(stm, conn)
                    READER = Command.ExecuteReader

                    MessageBox.Show("Data Saved")
                    conn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    conn.Dispose()
                End Try
                'END: Add Porudcct data to the Database named 'SAIS', Table named 'productdb'

            ElseIf (prod_edit_button_ispressed = True) Then
                'START: Check if data have been selected from the Data Grid
                If (prod_pressed_datagrid_row_num = -1) Then
                    MsgBox("Please select a product in the data grid")
                    Return
                    'END: Check if data have been selected from the Data Grid
                End If
                'START: Update Selected Product information to the Database named 'SAIS', Table named 'productdb'
                Try
                    Dim i As Integer = prod_datagrid.CurrentRow.Index
                    conn.Open()
                    stm = "UPDATE productdb Set product_name= '" & prod_name_textbox.Text & "', product_descr= '" & prod_descr_textbox.Text & "', product_price= '" & prod_price_textbox.Text & "', product_quantity= '" & prod_quantity_textbox.Text & "', product_owner= '" & prod_owner_textbox.Text & "' WHERE p_id='" & prod_datagrid.Item(0, i).Value & "'; "
                    Command = New MySqlCommand(stm, conn)
                    READER = Command.ExecuteReader

                    MessageBox.Show("Data Saved: edited")
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
        prod_name_textbox.Text = ""
        prod_descr_textbox.Text = ""
        prod_owner_textbox.Text = ""
        prod_price_textbox.Text = ""
        prod_quantity_textbox.Text = ""
        'END: Empty Form Textboxes' Contents

        'START: Update information in the Data Grid
        ds = New DataSet
        stm = "SELECT * FROM productdb WHERE product_status='available'"

        Try
            conn.Open()
            da = New MySqlDataAdapter(stm, conn)
            da.Fill(ds, "productdb")

            prod_datagrid.DataSource = ds.Tables("productdb")

        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try
        'END: Update information in the Data Grid

    End Sub

    Private Sub prod_datagrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles prod_datagrid.CellClick

        If (prod_edit_button_ispressed = True) Then
            Dim i As Integer = prod_datagrid.CurrentRow.Index
            prod_name_textbox.Text = prod_datagrid.Item(2, i).Value
            prod_descr_textbox.Text = prod_datagrid.Item(3, i).Value
            prod_price_textbox.Text = prod_datagrid.Item(4, i).Value
            prod_quantity_textbox.Text = prod_datagrid.Item(5, i).Value
            prod_owner_textbox.Text = prod_datagrid.Item(6, i).Value
            prod_pressed_datagrid_row_num = i

            'START: Enable to use the Form Textboxes 
            prod_name_textbox.Enabled = True
            prod_descr_textbox.Enabled = True
            prod_owner_textbox.Enabled = True
            prod_price_textbox.Enabled = True
            prod_quantity_textbox.Enabled = True
            'END: Enable to use the Form Textboxes
        End If

    End Sub

    Private Sub prod_price_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles prod_price_textbox.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub prod_quantity_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles prod_quantity_textbox.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub prod_name_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles prod_name_textbox.KeyPress

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub prod_owner_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles prod_owner_textbox.KeyPress

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub prod_descr_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles prod_descr_textbox.KeyPress

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub prod_search_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles prod_search_textbox.KeyPress

        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 32 Then
            If (Asc(e.KeyChar) > 47 And Asc(e.KeyChar) < 58) Or (Asc(e.KeyChar) > 64 And Asc(e.KeyChar) < 91) Or (Asc(e.KeyChar) > 96 And Asc(e.KeyChar) < 123) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub prod_delete_button_Click(sender As Object, e As EventArgs) Handles prod_delete_button.Click

        If (prod_pressed_datagrid_row_num <> -1) Then
            'START: Delete product in the Database name 'SAIS', Table name 'productdb'
            Dim cmd As New MySqlCommand()
            Try
                Dim i As Integer = prod_datagrid.CurrentRow.Index
                conn.Open()

                cmd.Connection = conn

                cmd.CommandText = "UPDATE productdb SET product_status='deleted' WHERE p_id='" & prod_datagrid.Item(0, i).Value & "'; "
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                conn.Close()
            Catch ex As Exception
                Console.WriteLine("Error: " & ex.ToString())
            End Try

            'END: Delete product in the Database name 'SAIS', Table name 'productdb'

            'START: Empty Form Textboxes' Contents
            prod_name_textbox.Text = ""
            prod_descr_textbox.Text = ""
            prod_owner_textbox.Text = ""
            prod_price_textbox.Text = ""
            prod_quantity_textbox.Text = ""
            'END: Empty Form Textboxes' Contents

            'START: Update information in the Data Grid
            ds = New DataSet
            stm = "SELECT * FROM productdb WHERE product_status='available'"

            Try
                conn.Open()
                da = New MySqlDataAdapter(stm, conn)
                da.Fill(ds, "productdb")

                prod_datagrid.DataSource = ds.Tables("productdb")

            Catch ex As MySqlException
                Console.WriteLine("Error: " & ex.ToString())
            Finally
                conn.Close()
            End Try
            'END: Update information in the Data Grid
        Else
            MsgBox("Select product first before deleting")
        End If

    End Sub

    Private Sub prod_exit_button_Click(sender As Object, e As EventArgs) Handles prod_exit_button.Click

        Manager.Show()
        Me.Close()

    End Sub
End Class