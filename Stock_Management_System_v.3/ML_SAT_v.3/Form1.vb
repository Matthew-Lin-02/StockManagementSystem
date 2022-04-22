Imports System.ComponentModel
Imports System.Drawing.Printing
'Software Developer: Matthew Lin
'Project Start Date: 12/04/2020
'Project Final Date: 14/08/2020
'Purpose: Main Form, Primary user interface for all functions where user can go to other forms
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Canteen_Stock_v_3DataSet.table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Canteen_Stock_v_3DataSet.table1)
        dtpExpiryDate.ShowCheckBox() = True
        'Setting the dimensions of the form. May need to be altered according to the platform the program is being run on. 
        Me.Height = 850
        Me.Width = 1300
    End Sub
    'Function for exiting the form and returning to initial login form
    Public Shared Sub SignOut()
        Dim ans As String
        ans = MsgBox("Continue Sign Out?", vbYesNo + vbQuestion, "Confirmation")
        'If user confirms yes code runs
        If ans = vbYes Then
            loginform.Show()
            Form1.Close()
        End If
    End Sub
    'Calling subroutine for signing out
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        SignOut()
    End Sub
    'Selects record above currently selected record
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Try
            Table1BindingSource.MovePrevious()
            ExpiryDateExistence()
        Catch ex As Exception
            MessageBox.Show("Please enter a unique SKU value in the current row")
        End Try
        'select previous record in the database. The record above is selected
    End Sub
    'Adds a blank record to the datagridview which can be used to input data
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Try
            Table1BindingSource.AddNew()
            dtpExpiryDate.Checked = False 'This is to show the user that they have not entered a date yet. Needed to resolve a bug that appeared. 
        Catch
            MessageBox.Show("Please enter a unique SKU value in the current row")
        End Try
        'Adds a new record into the database with empty values read for data to be inputed
    End Sub
    ''Selects record below currently selected record
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            Table1BindingSource.MoveNext()
            ExpiryDateExistence()
        Catch
            MessageBox.Show("Please enter a unique SKU value in the current row")
        End Try
        'Select next record in the database. The record below is selected
    End Sub
    Private Sub Save()
        'Makes sure that all the data currently inside the Data Entry Groupbox is valid _
        'and if it isn't then it does not allow the save to go through
        If Not ValidateChildren() Then
            Exit Sub
        End If
        'If the data is valid, the data is saved and the user is informed that the records are saved _ 
        'else it is not saved and the user is informed of the possible errors
        If ValidateDataGrid() = True Then
            On Error GoTo SaveErr 'In case there is an error go to Saverr which will exit the sub 
            Me.Validate()
            Table1BindingSource.EndEdit()
            Table1TableAdapter.Update(Canteen_Stock_v_3DataSet.table1)
            'Canteen_StockDataSet.Table1.AcceptChanges()
            MessageBox.Show("Records Saved.")
SaveErr:
            'Below code is used to check for errors comment out when not needed
            'MessageBox.Show("" & ErrorToString())
            Exit Sub
        Else
            'Inform the users of possible data errors
            Dim msg As String = "All errors have been highlighted in red, please ckeck that the below Is true before saving:"
            Dim title As String = "IsDataCompleteAndAccurate"
            MsgBox(msg & vbNewLine & vbNewLine & "No data fields are empty" & vbNewLine _
            & "The SKU fields holds integer values between 100 And 100000 (inclusive)" & vbNewLine _
            & "The ProductName field does Not contain any numbers" & vbNewLine _
            & "The Quantity field holds integer values bigger than 0" _
            , MsgBoxStyle.Critical, title)
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Calls the save subroutine to attempt a data save
        Save()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Deletes the selected record
        Table1BindingSource.RemoveCurrent()
        ExpiryDateExistence()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Exit application
        Me.Close()
    End Sub
    'Subroutine for searching strings within datagridview column, used for productname
    Private Sub SearchStr(ByVal a As Object, ByVal b As Integer)
        Dim intRow As Integer
        For intRow = 0 To DataGridView1.Rows.Count - 1
            Try
                'If a.text is not found withing the corresponding cell, the row becomes invisible thus only leaving rows with a.text in the corresponding cell.
                If Not DataGridView1.Rows(intRow).Cells(b).Value.IndexOf(a.text) > -1 Then
                    DataGridView1.CurrentCell = Nothing
                    DataGridView1.Rows.Item(intRow).Visible = False
                End If
            Catch

            End Try
        Next
    End Sub
    'Subroutine for searching integers and dates, therefore used for SKU, Quantity and expiry date
    Private Sub Search(ByVal a As Object, ByVal b As Integer)
        Dim intRow As Integer
        'Iterates through all rows
        For intRow = 0 To DataGridView1.Rows.Count - 1
            Try
                'Tests whether what is searched for exists in the cell if it does not then the row of the cell becomes invisible
                If Not DataGridView1.Rows(intRow).Cells(b).Value = a.Text Then
                    DataGridView1.CurrentCell = Nothing
                    DataGridView1.Rows.Item(intRow).Visible = False
                End If
            Catch

            End Try
        Next
    End Sub
    'Resets all previous searches by making all rows visible again
    Private Sub ClearSearch()
        Dim intRow As Integer
        For intRow = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.CurrentCell = Nothing
            DataGridView1.Rows.Item(intRow).Visible = True
        Next
    End Sub
    Private Sub AllSearch()
        Dim stock As String
        Dim msg As String = "Please check that the below Is true:"
        Dim title As String = "IsDataCompleteAndAccurate"
        'Stores the category that the user has selected through the combobox into variable stock
        stock = cmbSearch.Text
        'A search based on the contents of the variable stock in this case the different fields ProductName, ExpiryDate and Quantity
        Select Case stock
            Case "SKU"
                'Validation of search contents based on the constraints of the field SKU
                If ValidateSKU(txtSearch.Text) = False Then
                    MessageBox.Show("Please ensrue that the SKU Is an integer values between 100 And 100000 (inclusive)" _
                                , "Important message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                'Me.Table1BindingSource1.Filter = "SKU = '" & txtSearch.Text & "'"
                ClearSearch()
                Search(txtSearch, 0)
            Case "ProductName"
                'Validation of search contents based on the constraints of the field ProductName
                If ValdiateProductName(txtSearch.Text) = False Then
                    MessageBox.Show("Please ensure the following is true:" & vbNewLine & vbNewLine &
                                "The ProductName field does not contain any numbers" & vbNewLine &
                                "The ProductName field is not empty",
                                "Important message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                ClearSearch()
                SearchStr(txtSearch, 1)
                'Filters for whatever the user searches for within the ProductName field
                'Me.Table1BindingSource1.Filter = "ProductName = '" & txtSearch.Text & "'"
            Case "ExpiryDate"
                'Validation of search contents based on the constraints of the field ExpiryDate
                If ValidateExpiryDate(dtpsearch) = False Then
                    MessageBox.Show("Please ensure that a date has been selected", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                'Filters for whatever the user searches for within the ExpiryDate field
                'Me.Table1BindingSource1.Filter = "ExpiryDate = '" & dtpsearch.Text & "'" 'Filters for whatever the user searches for inside the ExpiryDate field
                ClearSearch()
                Search(dtpsearch, 2)
            Case "Quantity"
                'Validation of search contents based on the constraints of the field Quantity
                If ValidateQuantity(txtSearch.Text) = False Then
                    MessageBox.Show("Please ensure that the quantity is an integer value bigger than 0" _
                                , "Important message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                'Filters for whatever the user searches for within the Quantiy field
                ' Me.Table1BindingSource1.Filter = "Quantity = '" & txtSearch.Text & "'"
                ClearSearch()
                Search(txtSearch, 3)
        End Select
    End Sub
    'A search subroutine activated by the button btnSearch being clicked
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        AllSearch()
    End Sub
    'Function for validates data intended to go into the SKU field
    Private Function ValidateSKU(ByVal a As String) As Boolean
        'Valid is defined as True, as if we cannot pick up any errors the data should be valid
        Dim valid As Boolean = True
        Try
            'If the string entered can't be converted to an integer an error occurs _
            'and it is picked up by the Try...Catch...End Try statement
            Convert.ToInt32(a)
            'SKU needs to be between 100 and 100000 inclusive as such if the integer is not, it is invalid
            If a < 100 Or a > 100000 Then
                valid = False
                Return valid
                Exit Function
            End If
        Catch
            'Invalid input causes valid to be defined as false
            valid = False
            Return valid
            Exit Function
        End Try
        'If all checks are good, valid is still true
        Return valid
    End Function
    'Function for validating data intended to go into the ProductName field
    Private Function ValdiateProductName(ByVal a As String) As Boolean
        Dim valid As Boolean = True
        Const numbers = "0123456789"
        Try
            'Checks if string is empty
            If a = String.Empty Then
                valid = False
                Return valid
                Exit Function
                'Checks if there are any numbers inside, because the string.IndexofAny method _
                'returns the first instance of any character within the specified array in this 0,9
                'the lowest index it could return at would be 0 which would still be captured as it is bigger than -1
            ElseIf a.IndexOfAny(numbers.ToArray) > -1 Then
                valid = False
                Return valid
                Exit Function
            End If
        Catch
            'Any errors are caught
            valid = False
            Return valid
            Exit Function
        End Try
        'Valid is true as when it was first define as long as data is valid
        Return valid
    End Function
    'Function for validating data intended to go into the Quantity field
    Private Function ValidateQuantity(ByVal a As String) As Boolean
        Dim valid As Boolean = True
        Try
            'Makes sure that the data isn't a decimal as if it is an error will occurr and be caught by the catch statement
            Convert.ToInt32(a)
            'Makes sure that data isn't less than or equal to zero because entering negative stock or 0 stock makes no sense
            If a <= 0 Then
                valid = False
                Return valid
                Exit Function
            End If
        Catch
            valid = False
            Return valid
            Exit Function
        End Try
        'Valid returns as True if data is appropriate for the field
        Return valid
    End Function
    'A function designed to validate the existence of data within the ExpiryDate date time picker
    Private Function ValidateExpiryDate(ByVal a As Object) As Boolean
        Dim valid As Boolean = True
        If Not a.Checked() Then
            valid = False
            Return valid
            Exit Function
        End If
        Return valid
    End Function
    Private Sub Ascend()
        'OBJ is needed to send values to FormSort in order to decide which sorting function to activate
        Dim OBJ As New FormSort
        Dim stock As String
        'Cases are determined by the combobox; this makes for easy validation
        stock = cmbSort.Text

        Select Case stock 'A sort based on the contents of the variable stock in this case the different fields ProductName, ExpiryDate and Quantity
            Case "SKU"
                OBJ.Sort = "SKU ASC"
                OBJ.Show()
                Me.Hide()
            Case "ProductName"
                OBJ.Sort = "ProductName ASC"
                OBJ.Show()
                Me.Hide()
            Case "ExpiryDate"
                OBJ.Sort = "ExpiryDate ASC"
                OBJ.Show()
                Me.Hide()
            Case "Quantity"
                OBJ.Sort = "Quantity ASC"
                OBJ.Show()
                Me.Hide()
                'Above the lines OBJ.Sort = "..." and OBJ.Show() are both needed in conjunction to allow the FormSort form to access the crucial OBJ varibale
        End Select
        'Allows users to sort fields in ascending order
    End Sub
    'Calling subroutine above
    Private Sub btnASC_Click(sender As Object, e As EventArgs) Handles btnASC.Click
        Ascend()
    End Sub
    'Private subroutine that helps sorts columns in descending order in another form
    Private Sub Descend()
        Dim OBJ As New FormSort
        Dim stock As String
        stock = cmbSort.Text
        'The select case stock works similar to an if then statement
        Select Case stock
            'The code below is the same as the code in subroutine Ascend() but different variables are 'Sent' to the formsort
            Case "SKU"
                OBJ.Sort = "SKU DESC"
                OBJ.Show()
                Me.Hide()
            Case "ProductName"
                OBJ.Sort = "ProductName DESC"
                OBJ.Show()
                Me.Hide()
            Case "ExpiryDate"
                OBJ.Sort = "ExpiryDate DESC"
                OBJ.Show()
                Me.Hide()
            Case "Quantity"
                OBJ.Sort = "Quantity DESC"
                OBJ.Show()
                Me.Hide()
        End Select
        'allows users to sort field in descending order
    End Sub
    Private Sub btnDESC_Click(sender As Object, e As EventArgs) Handles btnDESC.Click
        Descend()
    End Sub
    'Is used inside the iPrint subroutine to print the datagridview
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub
    'Establis bitmap as the bitmap class responsible for containing the pixel data for the print document displayed
    Private bitmap As Bitmap
    Private Sub iPrint()
        Dim height As Integer = DataGridView1.Height
        'Below line of code not needed
        'DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = height
        'Calculate dimensions needed for print and displays what is going to be printed
    End Sub

    Private Sub btnUnsearch_Click(sender As Object, e As EventArgs) Handles btnUnsearch.Click
        ClearSearch()
    End Sub
    Private Sub StockOut()
        Dim exist As Boolean = False
        'Calls the subroutine ValidateQuantity and ValidateSKU from earlier to check that user input is appropriate
        If ValidateQuantity(txtQuantity2.Text) = False Or ValidateSKU(txtSKUStock.Text) = False Then
            MessageBox.Show("Please ensure that the following is true:" & vbNewLine & vbNewLine _
                        & "The SKU fields holds integer values between 100 and 100000 (inclusive)" & vbNewLine _
                        & "The Quantity field holds integer values bigger than 0" _
                        , "Important message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Cycles through the stock out proccess without commiting anything to the datagridview to see if any calculations _
        'would result in a negative quantity in which case the user is alerted to the error and the subroutine exited
        Dim intRow As Integer
        For intRow = 0 To DataGridView1.Rows.Count - 1
            If txtSKUStock.Text = Me.DataGridView1.Rows(intRow).Cells(0).Value Then
                exist = True
                If CDbl(Me.DataGridView1.Rows(intRow).Cells(3).Value) - CDbl(txtQuantity2.Text) < 0 Then
                    MessageBox.Show("The resulting level of stock cannot be less than 0",
                "Important information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If
        Next
        'Checks if the SKU which the user is attempting to add stock to exists within the datagridview
        For intRow = 0 To DataGridView1.Rows.Count - 1
            If txtSKUStock.Text = Me.DataGridView1.Rows(intRow).Cells(0).Value Then
                exist = True
            End If
        Next
        'If it doesn't exist, the user is informed and subroutine exited
        If exist = False Then
            MessageBox.Show("Please ensure that the SKU entered exists within the datagrid",
                        "Important information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Performs the Stock Out to the desired SKU record/s by taking the txtQuantity2.Text from the neccessary cell/s inside the quantity field
        For intRow = 0 To DataGridView1.Rows.Count - 1
            Try
                If txtSKUStock.Text = Me.DataGridView1.Rows(intRow).Cells(0).Value Then
                    Me.DataGridView1.Rows(intRow).Cells(3).Value = CDbl(Me.DataGridView1.Rows(intRow).Cells(3).Value) - CDbl(txtQuantity2.Text)
                    Me.DataGridView1.Rows(intRow).Cells(3).Style.BackColor = Color.LightSkyBlue
                Else

                End If
            Catch

            End Try
        Next
    End Sub
    'Minuses stock quantity from a record according to the SKU selected
    Private Sub btnStockOut_Click(sender As Object, e As EventArgs) Handles btnStockOut.Click
        StockOut()
    End Sub
    'Adds stock quantity to a record according to the SKU selected
    Private Sub StockIn()
        Dim exist As Boolean = False
        Dim intRow As Integer
        'Makes sure that both quantity entered and SKU is valid
        'If invalid the user is informed and the subroutine exited
        If ValidateQuantity(txtQuantity2.Text) = False Or ValidateSKU(txtSKUStock.Text) = False Then
            MessageBox.Show("Please ensure that the following is true:" & vbNewLine & vbNewLine _
                            & "The SKU fields holds integer values between 100 and 100000 (inclusive)" & vbNewLine _
                            & "The Quantity field holds integer values bigger than 0" _
                            , "Important message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'Chekcs if the desired SKU exists within the SKU field
        For intRow = 0 To DataGridView1.Rows.Count - 1
            If txtSKUStock.Text = Me.DataGridView1.Rows(intRow).Cells(0).Value Then
                exist = True
            End If
        Next
        'If it does not exist user is informed and the subroutine is exited
        If exist = False Then
            MessageBox.Show("Please ensure that the SKU entered exists within the datagrid",
                            "Important information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        ''Performs the Stock Out to the desired SKU record/s by add the txtQuantity2.Text from the neccessary cell/s inside the quantity field
        For intRow = 0 To DataGridView1.Rows.Count - 1
            Try
                If txtSKUStock.Text = Me.DataGridView1.Rows(intRow).Cells(0).Value Then
                    Me.DataGridView1.Rows(intRow).Cells(3).Value = CDbl(Me.DataGridView1.Rows(intRow).Cells(3).Value) + CDbl(txtQuantity2.Text)
                    Me.DataGridView1.Rows(intRow).Cells(3).Style.BackColor = Color.LightGreen
                End If
            Catch

            End Try
        Next
    End Sub
    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        StockIn()
    End Sub
    'Calls the iPrint subroutine to print off data
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        iPrint()
    End Sub
    'Calls the save subroutine to attempt at saving the data
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Save()
    End Sub
    Private Sub HighlightOrange()
        Try
            Convert.ToInt32(txtMinimum.Text.Trim())
            Dim minimum As Integer
            minimum = txtMinimum.Text.Trim()
            If minimum <= 0 Then 'Validates the minimum value to see if it is appropriate
                MessageBox.Show("Please enter a positive integer value for minimum stock")
                Exit Sub
            End If
            'Cycles through each row's quantity field of the datagridview to check if the quantity is below the minimum value
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("QuantityDataGridViewTextBoxColumn").Value < minimum Then
                    row.Cells("QuantityDataGridViewTextBoxColumn").Style.BackColor = Color.Orange
                End If
            Next
        Catch
            'Catches any errors such as if the minimum textbox has letters in it or if it has been left blank
            MessageBox.Show("Please enter a positive integer value for minimum stock")
        End Try
    End Sub
    'Highlights orange the quantities of stock below the minimum stock level
    Private Sub btnHighlightOrange_Click(sender As Object, e As EventArgs) Handles btnHighlightOrange.Click
        HighlightOrange()
        txtMaximum.Focus()
        txtMinimum.Text = ""
    End Sub
    'Calls the UnhighlightAll subroutine to
    Private Sub btnUnhighlight_Click(sender As Object, e As EventArgs)
        UnhighlightAll()
    End Sub
    Private Sub HighlightYellow()
        Try
            Convert.ToInt32(txtMaximum.Text.Trim())
            Dim maximum As Integer
            maximum = txtMaximum.Text.Trim()
            If maximum <= 0 Then 'Validates the maximum value to see if it is appropriate
                MessageBox.Show("Please enter a positive integer value for minimum stock")
                Exit Sub
            End If
            'Cycles through each row's quantity field of the datagridview to check if the quantity is above the maximum value
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("QuantityDataGridViewTextBoxColumn").Value > maximum Then
                    row.Cells("QuantityDataGridViewTextBoxColumn").Style.BackColor = Color.Yellow
                End If
            Next
        Catch
            'Catches any errors such as if the maximum textbox has letters in it or if it has been left blank
            MessageBox.Show("Please enter a positive integer value for minimum stock")
        End Try
    End Sub
    'Highlights yellow the quantities of stock above the maximum stock level
    Private Sub btnHighlightYellow_Click(sender As Object, e As EventArgs) Handles btnHighlightYellow.Click
        HighlightYellow()
        txtMaximum.Text = ""
    End Sub
    'Validating event for object txtSKU
    Private Sub txtSKU_Validating(sender As Object, e As CancelEventArgs) Handles txtSKU.Validating
        'Error provider is reset to an empty string from previous errors
        ErrorProvider1.SetError(txtSKU, "")
        Try
            With txtSKU
                'Validates txtSKU to see if data entered is appropriate and cancels the event that prompted the validation if data is invalid
                'Since the form has been set to EnableAllowFocusChange, it means that the event is not cancelled, however its purpose is _
                'to determine whether validatechildren() is true or not. 
                If .Text = String.Empty Then 'Validates whether anything has been entered
                    e.Cancel = True
                    'Sets the error provider to txtSKU and displayes required field when hovered over
                    ErrorProvider1.SetError(txtSKU, "Required Field")
                    lblSKU.ForeColor = Color.Red
                ElseIf .Text < 100 Or .Text > 100000 Then 'Validates SKU value
                    e.Cancel = True
                    'Sets the error provider to txtSKU and displayes Enter integer value between 100 and 100000
                    ErrorProvider1.SetError(txtSKU, "Enter integer value between 100 and 100000")
                    lblSKU.ForeColor = Color.Red
                Else
                    lblSKU.ForeColor = Color.Black
                End If
            End With
        Catch
            e.Cancel = True
            lblSKU.ForeColor = Color.Red
            ErrorProvider1.SetError(txtSKU, "Enter integer value between 100 and 100000")
        End Try
    End Sub
    ''Validating event for object txtProductName
    Private Sub txtProductName_Validating(sender As Object, e As CancelEventArgs) Handles txtProductName.Validating
        Const numbers = "0123456789"
        ErrorProvider1.SetError(txtProductName, "")
        With txtProductName
            If .Text = String.Empty Then 'Determines whether the textbox is empty
                'Sets the error provider to txtProductName and displays ProductName cannot have any numbers when hovered over
                ErrorProvider1.SetError(txtProductName, "Required Field")
                lblProductName.ForeColor = Color.Red
                e.Cancel = True
            ElseIf .Text.IndexOfAny(numbers.ToArray) > -1 Then 'Determines whether the string contains any numbers 
                'Sets the error provider to txtProductName and displays ProductName cannot have any numbers when hovered over
                ErrorProvider1.SetError(txtProductName, "ProductName cannot have any numbers")
                lblProductName.ForeColor = Color.Red
                e.Cancel = True
            Else
                lblProductName.ForeColor = Color.Black
            End If
        End With
    End Sub
    'The function highlights all errors within the datagridview in red, _
    'and returns boolean variable valid which determines if whether errors have been made or not
    Private Function ValidateDataGrid() As Boolean
        Dim valid As Boolean = True
        Dim intRow As Integer
        Dim copys As Integer = 0
        Const numbers = "0123456789"
        'For...to...next loop uses to cycle through each record 
        For intRow = 0 To DataGridView1.Rows.Count - 1
            'Validating the SKU field
            Try
                If Convert.ToInt32(DataGridView1.Rows(intRow).Cells(0).Value) < 100 Or Convert.ToInt32(DataGridView1.Rows(intRow).Cells(0).Value) > 100000 Then
                    valid = False
                    DataGridView1.Rows(intRow).Cells(0).Style.BackColor = Color.Red
                End If

            Catch
                valid = False
                DataGridView1.Rows(intRow).Cells(0).Style.BackColor = Color.Red

            End Try
            'Checking if expiryDate is empty
            Try
                If String.IsNullOrEmpty(DataGridView1.Rows(intRow).Cells(2).Value) Then
                    valid = False
                    DataGridView1.Rows(intRow).Cells(2).Style.BackColor = Color.Red
                End If
            Catch
                valid = False
                DataGridView1.Rows(intRow).Cells(2).Style.BackColor = Color.Red
            End Try
            'Validating the ProductName field for empty or null cells
            Try
                If String.IsNullOrEmpty(DataGridView1.Rows(intRow).Cells(1).Value) Then
                    valid = False
                    DataGridView1.Rows(intRow).Cells(1).Style.BackColor = Color.Red
                End If
            Catch ex As Exception
                valid = False
            End Try
            'Validating the ProductName field for any cells with numbers in them
            Try
                If DataGridView1.Rows(intRow).Cells(1).Value.IndexOfAny(numbers.ToArray) > -1 Then
                    valid = False
                    DataGridView1.Rows(intRow).Cells(1).Style.BackColor = Color.Red
                End If
            Catch ex As Exception
                valid = False
                DataGridView1.Rows(intRow).Cells(2).Style.BackColor = Color.Red
            End Try
            'Validates the quantity field
            Try
                If Convert.ToInt32(DataGridView1.Rows(intRow).Cells(3).Value) < 0 Then
                    valid = False
                    DataGridView1.Rows(intRow).Cells(3).Style.BackColor = Color.Red
                End If
            Catch ex As Exception
                valid = False
                DataGridView1.Rows(intRow).Cells(3).Style.BackColor = Color.Red
            End Try
        Next
        Return valid
    End Function
    'Validating event for the date time picker binded to the ExpiryDate field of the data source
    Private Sub dtpExpiryDate_Validating(sender As Object, e As CancelEventArgs) Handles dtpExpiryDate.Validating
        'Clearing any errors from before
        ErrorProvider1.SetError(dtpExpiryDate, "")
        With dtpExpiryDate
            'Determines whether the date has been entered and sets the errorprovider to the date time picker if it hasn't been selected
            If Not dtpExpiryDate.Checked() Then
                ErrorProvider1.SetError(dtpExpiryDate, "Required Field")
                lblExpiryDate.ForeColor = Color.Red
                e.Cancel = True
            Else
                lblExpiryDate.ForeColor = Color.Black
            End If
        End With
    End Sub

    Private Sub txtQuantity_Validating(sender As Object, e As CancelEventArgs) Handles txtQuantity.Validating
        'Clearing any errors from before
        ErrorProvider1.SetError(txtQuantity, "")
        Try
            With txtQuantity
                'Determines whether the field is empty
                'sets the errorprovider to the textbox if the data is not valid
                If String.IsNullOrEmpty(.Text) Then
                    e.Cancel = True
                    ErrorProvider1.SetError(txtQuantity, "Required Field")
                    lblQuantity.ForeColor = Color.Red
                ElseIf .Text <= 0 Then 'Validates whether the quantity entered is less than zero
                    e.Cancel = True
                    ErrorProvider1.SetError(txtQuantity, "Enter an integer value bigger than 0")
                    lblQuantity.ForeColor = Color.Red
                Else
                    lblQuantity.ForeColor = Color.Black
                End If
            End With
        Catch
            'Any errors means poor user input
            e.Cancel = True
            ErrorProvider1.SetError(txtQuantity, "Enter integer value bigger than 0")
            lblQuantity.ForeColor = Color.Red
        End Try
    End Sub

    'Allow form to close even if input errors exist
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = False
    End Sub
    'Subroutine to unhighlight the datagridview
    Private Sub UnhighlightAll()
        'It unhighlights by cycling through each row and changing the backcolor of each cell to white
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("QuantityDataGridViewTextBoxColumn").Style.BackColor = Color.White
            row.Cells("SKUDataGridViewTextBoxColumn").Style.BackColor = Color.White
            row.Cells("ExpiryDateDataGridViewTextBoxColumn").Style.BackColor = Color.White
            row.Cells("ProductNameDataGridViewTextBoxColumn").Style.BackColor = Color.White
        Next
    End Sub
    'Calls the unhighlight subroutine upon being clicked
    Private Sub btnUnhiglight1_Click(sender As Object, e As EventArgs) Handles btnUnhiglight1.Click
        UnhighlightAll()
    End Sub
    'Calls the unhighlight subroutine upon being clicked
    Private Sub btnUnhighlight2_Click(sender As Object, e As EventArgs) Handles btnUnhighlight2.Click
        UnhighlightAll()
    End Sub
    'Calls the unhighlight subroutine upon being clicked
    Private Sub btnUnhighlight3_Click(sender As Object, e As EventArgs) Handles btnUnhighlight3.Click
        UnhighlightAll()
    End Sub
    'When the insertion point is inside the txtSKU textbox and enter is pressed _
    'the insertion point is placed inside the textbox below
    Private Sub txtSKU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSKU.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtProductName.Focus()
        End If
    End Sub
    'When the dropdown menu of the dtpExpiryDate is closed the insertion point is placed in the textbox below
    Private Sub dtpExpiryDate_CloseUp(sender As Object, e As EventArgs) Handles dtpExpiryDate.CloseUp
        txtSKU.Focus()
    End Sub
    'Private subroutine for the keypress event when the quantity textbox is selected
    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'to remove the cursor from the textbox without causing _
            ' Validating event to setoff if the data Is valid else it doesn't matter because it would have setoff anyway
            dtpExpiryDate.Select()
            'a new record is added, as this is the last textbox _
            'makes it easier to enter data in busy scenarios
            Table1BindingSource.AddNew()
            ExpiryDateExistence()
        End If
    End Sub
    'Calls the ExpiryDateExistence() subroutine when the datagridview is clicked
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ExpiryDateExistence()
    End Sub
    'Calls a subroutine which sets the dtpExpiryDate.checked value based on the existence of data inside the ExpiryDate field within the current record
    Private Sub ExpiryDateExistence()
        'If there exists no data within the cell in the ExpiryDate field of the current record then dtpExpiryDate.Checked is set to false
        If IsDBNull(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value) Then
            dtpExpiryDate.Checked = False
        End If
        'Else it is set to true
        If Not IsDBNull(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value) Then
            dtpExpiryDate.Checked = True
        End If
    End Sub
    'When the insertion point is inside the txtProductName textbox and enter is pressed _
    'the insertion point is placed inside the textbox below
    Private Sub txtProductName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProductName.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtQuantity.Focus()
        End If
    End Sub

    Private Sub btnMoveup_Click(sender As Object, e As EventArgs)
        'Dim dat As New DataSet
        FormSort.Show()
        Me.Hide()
    End Sub

    Private Sub PreviousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviousToolStripMenuItem.Click
        Try
            Table1BindingSource.MovePrevious()
            ExpiryDateExistence()
        Catch ex As Exception
            MessageBox.Show("Please enter a unique SKU value in the current row")
        End Try
        'select previous record in the database. The record above is selected
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Try
            Table1BindingSource.MoveNext()
            ExpiryDateExistence()
        Catch
            MessageBox.Show("Please enter a unique SKU value in the current row")
        End Try
        'Select next record in the database. The record below is selected
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        'Deletes the selected record
        Table1BindingSource.RemoveCurrent()
        ExpiryDateExistence()
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        Try
            Table1BindingSource.AddNew()
            dtpExpiryDate.Checked = False 'This is to show the user that they have not entered a date yet. Needed to resolve a bug that appeared. 
        Catch
            MessageBox.Show("Please enter a unique SKU value in the current row")
        End Try
        ExpiryDateExistence()
        'select previous record in the database. The record above is selected
    End Sub

    Private Sub UnhighlightAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnhighlightAllToolStripMenuItem.Click
        UnhighlightAll()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        'Exit application
        Me.Close()
    End Sub
    'Calling sign out subroutine from before to return to login screen
    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        SignOut()
    End Sub
    'Calling AllSearch() subroutine a subroutine that uses subroutines to search
    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        AllSearch()
    End Sub
    'Clears all search result by making all records visible
    Private Sub ClearSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSearchToolStripMenuItem.Click
        ClearSearch()
    End Sub
    'Calling ascend() subroutine to sort a particular column in ascending order based on what user selects through combobox
    Private Sub AscendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AscendingToolStripMenuItem.Click
        Ascend()
    End Sub
    'Calling descend() subroutine to sort a particular column in descending order based on what user selects through combobox
    Private Sub DescendingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescendingToolStripMenuItem.Click
        Descend()
    End Sub
    'Adds quantity to selected SKU
    Private Sub StockInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockInToolStripMenuItem.Click
        StockIn()
    End Sub
    'Removes quantity from selected quantity
    Private Sub StockOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockOutToolStripMenuItem.Click
        StockOut()
    End Sub
    'Highlights stock with quantity below minimum in orange
    Private Sub MinimumStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimumStockToolStripMenuItem.Click
        HighlightOrange()
        txtMaximum.Focus()
        txtMinimum.Text = ""
    End Sub
    'Highlights stock with quantity above maximum in yellow
    Private Sub MaximumStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximumStockToolStripMenuItem.Click
        HighlightYellow()
        txtMaximum.Text = ""
    End Sub
    'Handles an error by the user when the user forgets to complete the SKU of a newly addded record before clicking on a row other then the current row in the datagridview
    Private Sub datagridview1_dataerror(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        e.ThrowException = False
        MsgBox("A unique SKU value is required as it is the primary key:" & vbNewLine & vbNewLine & "Remember to input an SKU value for new records", MsgBoxStyle.Exclamation, "Data Error")
    End Sub
    'Determines whether a stock is expired or not by comparing todays date with each stocks' expiry date
    Private Sub ExpiredOrNot()
        Dim expired As String = ""
        Dim expiredexist As Boolean = False
        Dim tempstr As String
        'Iterate through datagrid's row
        For introw = 0 To DataGridView1.RowCount - 1
            'Datetime.compare(x,y) with x and y being dates will return -1 if x is earlier than y
            If DateTime.Compare(DataGridView1.Rows(introw).Cells(2).Value, Today) = -1 Then
                'Therefore it is expired and the row is highlighted in rotten green color
                DataGridView1.Rows(introw).DefaultCellStyle.BackColor = Color.DarkGreen
                'The tempstr holds values before getting 'absorbed' by the expired variable into a big string
                tempstr = DataGridView1.Rows(introw).Cells(0).Value
                expired += tempstr + ", "
                expiredexist = True
            End If
        Next
        'Identifies and displays the stocks which need desposing using SKU values
        If expiredexist Then
            MsgBox("SKU items: " & expired & "are all expired and have been highlighted in dark green" & vbNewLine _
                   & vbNewLine & "Please dispose of the expired stock immediately in order to avoid health hazards 
                   and delete these records from the Stock Management System",
                   MsgBoxStyle.Critical, "Expired Food")
        End If
    End Sub
    'Calling subroutine ExpiredOrNot(), checks for expired food
    'This code needs to be done after form shown, not loaded as loaded runs the code before the form is shown, making information unintelligible
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer1.Start()
        Timer1.Interval = 1000
        '2 second delay leaves user time to proccess the loading of the screen without ebign bombarded by messageboxes
        Task.Delay(2000)
        ExpiredOrNot()
        Timer1.Stop()
    End Sub
    'Calls expiredOrNot subroutine, checks for expired stocks
    Private Sub btnExpired_Click(sender As Object, e As EventArgs) Handles btnExpired.Click
        ExpiredOrNot()
    End Sub
    'Calls expiredOrNot subroutine, checks for expired stocks
    Private Sub ExpiredToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpiredToolStripMenuItem.Click
        ExpiredOrNot()
    End Sub

    Private Sub txtMinimum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimum.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            HighlightOrange()
            txtMaximum.Focus()
            txtMinimum.Text = ""
        End If
    End Sub

    Private Sub txtMaximum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaximum.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            HighlightYellow()
            txtMaximum.Text = ""
        End If
    End Sub

    Private Sub txtSKUStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSKUStock.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtQuantity2.Focus()
        End If
    End Sub
End Class
