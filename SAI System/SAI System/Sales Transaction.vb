Imports MySql.Data.MySqlClient

Public Class Sales_Transaction

    Dim stp_edit_button_ispressed As Boolean = False 'This is used to determine whether the Edit Button has been pressed or not
    Dim stp_add_button_ispressed As Boolean = False 'This is used to determine whether the Add Button has been pressed or not
    Dim stp_pressed_datagrid_row_num As Integer = -1 'This is used to identify the row number of the selected data in the Data Grid named 'prod_datagrid'
    Dim stp_flist_item_num As Integer = 0
    Dim stp_done_button_ispressed As Integer = False
    Dim tprice As Double = 0
    Dim change As Double = 0
    Dim b As Boolean = True

    'START: Database Connection Variables and its associates
    Dim cs As String = "host=127.0.0.1; user=root; database=sais"

    Dim conn As New MySqlConnection(cs)

    Dim stm As String
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    'END: Database Connection Variables and its associates

    Private Sub Sales_Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        stp_datagrid_flist.AllowUserToAddRows = False
        'START: Connect to the Database named 'sais' and fill the Data Grid

        Try
            stm = "SELECT product_id, product_name, product_owner, product_quantity, product_price FROM productdb WHERE product_status='available'"
            conn.Open()
            ds = New DataSet
            da = New MySqlDataAdapter(stm, conn)
            da.Fill(ds, "productdb")

            stp_datagrid_fsearch.DataSource = ds.Tables("productdb")

        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try
        'END: Database Connection Variables and its associates

        'START: Disable and set components
        stp_discount_combobox.Enabled = False
        stp_next_button.Enabled = False
        stp_back_button.Enabled = False
        stp_cash_textbox.Enabled = False

        stp_discount_combobox.Text = "0%"
        stp_discount_combobox.DropDownStyle = ComboBoxStyle.DropDownList
        'END: Disable and set components

    End Sub

    Private Sub stp_datagrid_fsearch_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles stp_datagrid_fsearch.CellClick
        Dim p As Integer = 0 'Variable for holding product price
        Dim q As Double = 0 'Variable for percentage coefficient

        'START: Add product information to the list if the "DONE" button isn't pressed
        If (stp_done_button_ispressed = False) Then

            stp_datagrid_flist.AllowUserToAddRows = True

            Dim i As Integer = stp_datagrid_fsearch.CurrentRow.Index

            If (stp_datagrid_fsearch.Item(3, i).Value > 0) Then 'Check if product is still available
                'START: Check if product is already in the list
                For a As Integer = 0 To stp_flist_item_num
                    If (stp_datagrid_fsearch.Item(1, i).Value = stp_datagrid_flist.Item(0, a).Value) Then
                        stp_datagrid_flist.Item(2, a).Value += 1
                        stp_datagrid_fsearch.Item(3, i).Value -= 1
                        p = stp_datagrid_fsearch.Item(4, i).Value
                        tprice += p

                        If (stp_discount_combobox.Text = "10%") Then
                            q = 0.1
                            Dim temp = tprice - (tprice * q)
                            stp_tprice_label.Text = temp.ToString
                        ElseIf (stp_discount_combobox.Text = "25%") Then
                            q = 0.25
                            Dim temp = tprice - (tprice * q)
                            stp_tprice_label.Text = temp.ToString
                        ElseIf (stp_discount_combobox.Text = "50%") Then
                            q = 0.5
                            Dim temp = tprice - (tprice * q)
                            stp_tprice_label.Text = temp.ToString
                        Else
                            stp_tprice_label.Text = tprice.ToString

                        End If
                        stp_datagrid_flist.AllowUserToAddRows = False


                        If (stp_cash_textbox.Text.Length <> 0) Then
                            change = Val(stp_cash_textbox.Text) - Val(stp_tprice_label.Text)
                            stp_vchange_label.Text = change.ToString
                        Else
                            change = 0
                            stp_vchange_label.Text = change.ToString
                        End If

                        Return
                    End If
                    'END: Check if product is already in the list

                Next
                'START: Add product to the list
                stp_datagrid_flist.RowCount += 1
                stp_datagrid_flist.Item(0, stp_flist_item_num).Value = stp_datagrid_fsearch.Item(1, i).Value
                stp_datagrid_flist.Item(1, stp_flist_item_num).Value = stp_datagrid_fsearch.Item(4, i).Value
                stp_datagrid_flist.Item(2, stp_flist_item_num).Value = 1
                stp_flist_item_num += 1
                stp_datagrid_fsearch.Item(3, i).Value -= 1

                stp_datagrid_flist.AllowUserToAddRows = False
                p = stp_datagrid_fsearch.Item(4, i).Value
                tprice += p

                If (stp_discount_combobox.Text = "10%") Then
                    q = 0.1
                    Dim temp = tprice - (tprice * q)
                    stp_tprice_label.Text = temp.ToString
                ElseIf (stp_discount_combobox.Text = "25%") Then
                    q = 0.25
                    Dim temp = tprice - (tprice * q)
                    stp_tprice_label.Text = temp.ToString
                ElseIf (stp_discount_combobox.Text = "50%") Then
                    q = 0.5
                    Dim temp = tprice - (tprice * q)
                    stp_tprice_label.Text = temp.ToString
                Else
                    stp_tprice_label.Text = tprice.ToString

                End If


                If (stp_cash_textbox.Text.Length <> 0) Then
                    change = Val(stp_cash_textbox.Text) - Val(stp_tprice_label.Text)
                    stp_vchange_label.Text = change.ToString
                Else
                    change = 0
                    stp_vchange_label.Text = change.ToString
                End If
                'END: Add product to the list
            End If
        Else 'Product is not in the list
            MsgBox("Product is not available")
            Return
        End If
        'END: Add product information to the list if the "DONE" button isn't pressed
    End Sub

    Private Sub stp_search_textbox_TextChanged(sender As Object, e As EventArgs) Handles stp_search_textbox.TextChanged
        'START: Update the Data Grid

        If stp_search_textbox.Text = "" Then
            stm = "SELECT product_id, product_name, product_owner, product_quantity, product_price FROM productdb WHERE product_status='available'"
        Else
            stm = "SELECT product_id, product_name, product_owner, product_quantity, product_price FROM productdb WHERE (
            (product_id LIKE '" & stp_search_textbox.Text & "%') OR
            (product_name LIKE '" & stp_search_textbox.Text & "%') OR
            (product_owner LIKE '" & stp_search_textbox.Text & "%')) AND
            (product_status='available')"
        End If

        ds = New DataSet

        Try
            conn.Open()
            da = New MySqlDataAdapter(stm, conn)
            da.Fill(ds, "productdb")

            stp_datagrid_fsearch.DataSource = ds.Tables("productdb")

        Catch ex As MySqlException
            Console.WriteLine("Error: " & ex.ToString())
        Finally
            conn.Close()
        End Try
        'END: Update the Data Grid
    End Sub

    Private Sub stp_void_button_Click(sender As Object, e As EventArgs) Handles stp_void_button.Click
        For j As Integer = 0 To (stp_datagrid_flist.RowCount - 1)
            For i As Integer = 0 To (stp_datagrid_fsearch.RowCount - 2)
                If (stp_datagrid_fsearch.Item(1, i).Value = stp_datagrid_flist.Item(0, j).Value) Then
                    stp_datagrid_fsearch.Item(3, i).Value += stp_datagrid_flist.Item(2, j).Value
                End If
            Next
        Next

        stp_datagrid_flist.Rows.Clear()
        stp_flist_item_num = 0
        tprice = 0
        stp_tprice_label.Text = tprice.ToString


        If (stp_cash_textbox.Text.Length <> 0) Then
            change = Val(stp_cash_textbox.Text) - Val(stp_tprice_label.Text)
            stp_vchange_label.Text = change.ToString
        Else
            change = 0
            stp_vchange_label.Text = change.ToString
        End If

    End Sub

    Private Sub stp_datagrid_flist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles stp_datagrid_flist.CellClick
    End Sub

    Private Sub stp_delete_button_Click(sender As Object, e As EventArgs) Handles stp_delete_button.Click
        For Each row As DataGridViewRow In stp_datagrid_flist.SelectedRows
            stp_datagrid_flist.Rows.Remove(row)
            stp_flist_item_num -= 1
            Dim a = row.Cells.Item(1).Value
            Dim b = row.Cells.Item(2).Value
            Dim c = a * b
            tprice -= c

            For i As Integer = 0 To (stp_datagrid_fsearch.RowCount - 2)
                If (stp_datagrid_fsearch.Item(1, i).Value = row.Cells.Item(0).Value) Then
                    stp_datagrid_fsearch.Item(3, i).Value += b
                End If
            Next

            If (stp_discount_combobox.Text = "10%") Then
                Dim q = 0.1
                Dim temp = tprice - (tprice * q)
                stp_tprice_label.Text = temp.ToString
            ElseIf (stp_discount_combobox.Text = "25%") Then
                Dim q = 0.25
                Dim temp = tprice - (tprice * q)
                stp_tprice_label.Text = temp.ToString
            ElseIf (stp_discount_combobox.Text = "50%") Then
                Dim q = 0.5
                Dim temp = tprice - (tprice * q)
                stp_tprice_label.Text = temp.ToString
            Else
                Dim temp = tprice
                stp_tprice_label.Text = temp.ToString
            End If


            If (stp_cash_textbox.Text.Length <> 0) Then
                change = Val(stp_cash_textbox.Text) - Val(stp_tprice_label.Text)
                stp_vchange_label.Text = change.ToString
            Else
                change = 0
                stp_vchange_label.Text = change.ToString
            End If

        Next
    End Sub

    Private Sub stp_done_button_Click(sender As Object, e As EventArgs) Handles stp_done_button.Click
        If (stp_flist_item_num > 0) Then
            stp_delete_button.Enabled = False
            stp_void_button.Enabled = False
            stp_discount_combobox.Enabled = True
            stp_next_button.Enabled = True
            stp_back_button.Enabled = True
            stp_done_button.Enabled = False
            stp_done_button_ispressed = True
            stp_cash_textbox.Enabled = True
        End If
    End Sub

    Private Sub stp_back_button_Click(sender As Object, e As EventArgs) Handles stp_back_button.Click
        stp_delete_button.Enabled = True
        stp_void_button.Enabled = True
        stp_discount_combobox.Enabled = False
        stp_next_button.Enabled = False
        stp_back_button.Enabled = False
        stp_done_button.Enabled = True
        stp_done_button_ispressed = False
        stp_cash_textbox.Enabled = False

    End Sub

    Private Sub stp_next_button_Click(sender As Object, e As EventArgs) Handles stp_next_button.Click
        If (change <= 0) Then 'Check if the cash textbox has been filled up
            MsgBox("Insufficient Cash")
            Return
        Else 'If there is cash, execute THISSS
            Dim READER As MySqlDataReader
            Dim Command As MySqlCommand
            Dim tnum As Integer = 0
            stm = "SELECT MAX(stp_id) FROM transactdb"
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
            If IsDBNull(cmd.ExecuteScalar) Then
                tnum = 1
            Else
                tnum = cmd.ExecuteScalar + 1
            End If
            cmd.Dispose()
            conn.Close()
            'START: Update the Database
            For i As Integer = 0 To (stp_datagrid_flist.RowCount - 1)
                conn.Open()
                stm = "INSERT INTO salestrandb (salestran_id, salestran_prodname, salestran_price, salestran_quantity) VALUES ('TRANS0000" & tnum.ToString & "', '" & stp_datagrid_flist.Item(0, i).Value & "', '" & stp_datagrid_flist.Item(1, i).Value & "', '" & stp_datagrid_flist.Item(2, i).Value.ToString & "')"
                Command = New MySqlCommand(stm, conn)
                READER = Command.ExecuteReader

                conn.Close()
            Next

            conn.Open()
            stm = "INSERT INTO transactdb (transact_id, transact_tprice, transact_change) VALUES ('TRANS0000" & tnum.ToString & "', '" & stp_tprice_label.Text & "', '" & stp_vchange_label.Text & "')"
            Command = New MySqlCommand(stm, conn)
            READER = Command.ExecuteReader
            conn.Close()
            For i As Integer = 0 To (stp_datagrid_flist.RowCount - 1)
                Dim k As String = 0

                For j As Integer = 0 To (stp_datagrid_fsearch.RowCount - 2)
                    If (stp_datagrid_fsearch.Item(1, j).Value = stp_datagrid_flist.Item(0, i).Value) Then
                        k = stp_datagrid_fsearch.Item(3, j).Value
                    End If
                Next

                conn.Open()
                stm = "UPDATE productdb SET product_quantity='" & k & "' WHERE product_name='" & stp_datagrid_flist.Item(0, i).Value.ToString & "'"
                Command = New MySqlCommand(stm, conn)
                READER = Command.ExecuteReader

                conn.Close()
            Next
            'END: Update the Database

            MessageBox.Show("Data Saved")

            'START: Reset components
            stp_datagrid_flist.Rows.Clear()
            stp_flist_item_num = 0
            tprice = 0
            stp_tprice_label.Text = tprice.ToString

            stp_delete_button.Enabled = True
            stp_void_button.Enabled = True
            stp_discount_combobox.Enabled = False
            stp_next_button.Enabled = False
            stp_back_button.Enabled = False
            stp_done_button.Enabled = True
            stp_done_button_ispressed = False
            stp_cash_textbox.Enabled = False
            'END: Reset components
        End If
    End Sub

    Private Sub stp_cash_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stp_cash_textbox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (e.KeyChar = "." And b And stp_cash_textbox.Text.Length <> 0) Then
                b = False
            ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        Else
            If (stp_cash_textbox.Text.IndexOf(".") = (stp_cash_textbox.Text.Length - 1)) Then
                b = True
            End If
        End If
    End Sub

    Private Sub stp_discount_combobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stp_discount_combobox.SelectedIndexChanged
        If (stp_discount_combobox.Text = "10%") Then
            Dim q = 0.1
            Dim temp = tprice - (tprice * q)
            stp_tprice_label.Text = temp.ToString
        ElseIf (stp_discount_combobox.Text = "25%") Then
            Dim q = 0.25
            Dim temp = tprice - (tprice * q)
            stp_tprice_label.Text = temp.ToString
        ElseIf (stp_discount_combobox.Text = "50%") Then
            Dim q = 0.5
            Dim temp = tprice - (tprice * q)
            stp_tprice_label.Text = temp.ToString
        Else
            Dim temp = tprice
            stp_tprice_label.Text = temp.ToString
        End If


        If (stp_cash_textbox.Text.Length <> 0) Then
            change = Val(stp_cash_textbox.Text) - Val(stp_tprice_label.Text)
            stp_vchange_label.Text = change.ToString
        Else
            change = 0
            stp_vchange_label.Text = change.ToString
        End If
    End Sub

    Private Sub stp_cash_textbox_TextChanged(sender As Object, e As EventArgs) Handles stp_cash_textbox.TextChanged
        If (stp_cash_textbox.Text.Length = 0) Then
            change = 0
            stp_vchange_label.Text = change.ToString
        Else
            change = Val(stp_cash_textbox.Text) - Val(stp_tprice_label.Text)
            stp_vchange_label.Text = change.ToString
        End If
    End Sub

    Private Sub stp_exit_button_Click(sender As Object, e As EventArgs) Handles stp_exit_button.Click
        If (stp_user.Text = "Manager") Then
            Manager.Show()
            Me.Close()
        Else
            Employee.Show()
            Me.Close()
        End If
    End Sub
End Class