'Software Developer: Matthew Lin
'Project Start Date: 12/04/2020
'Project Final Date: 14/08/2020
'Purpose: Sub Form, used to display the sorted datagridview
Public Class FormSort
    'Sort variable used to determined which case to pick
    Public Property Sort As String
    Private Sub FormSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dat As New DataSet
        Me.Height = 800
        Me.Width = 800
        'Needs to load datagridview with the dataset so that it can be mainpulated later 
        Dim dat As DataTable = Form1.Canteen_Stock_v_3DataSet.table1
        Me.DataGridView1.DataSource = dat
        Me.DataGridView1.Refresh()
        DataGridView1.Columns(1).Width = 165
        DataGridView1.Columns(2).Width = 155
        DataGridView1.Columns(3).Width = 115

        'Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(0).Cells(0)
        Dim curRow As Integer = Form1.DataGridView1.CurrentCell.RowIndex
        'The cases below are as one would think, each function sorts a particular column in either ascending or descending order
        Select Case Sort
            Case "SKU ASC"
                Integer_ASC(0)
            Case "Quantity ASC"
                Integer_ASC(3)
            Case "SKU DESC"
                Integer_DESC(0)
            Case "Quantity DESC"
                Integer_DESC(3)
            Case "ProductName ASC"
                ProductName_ASC(1)
            Case "ProductName DESC"
                ProductName_DESC(1)
            Case "ExpiryDate ASC"
                ExpiryDate_ASC(2)
            Case "ExpiryDate DESC"
                ExpiryDate_DESC(2)
        End Select
    End Sub
    'Function for sorting integers in ascending order
    Private Sub Integer_ASC(ByVal a As Integer)
        Dim dat As DataTable = Form1.Canteen_Stock_v_3DataSet.table1
        Me.DataGridView1.DataSource = dat
        dat.PrimaryKey = Nothing
        For introw2 = 0 To DataGridView1.RowCount - 2
            For introw = 0 To DataGridView1.RowCount - 2
                If DataGridView1.Rows(introw).Cells(a).Value > DataGridView1.Rows(introw + 1).Cells(a).Value Then
                    Dim newRow As DataRow = dat.NewRow
                    'Shifts row down
                    For i As Integer = 0 To Me.DataGridView1.ColumnCount - 1
                        newRow.Item(i) = Me.DataGridView1(i, introw).Value
                    Next

                    dat.Rows.InsertAt(newRow, introw + 2)
                    dat.Rows.RemoveAt(introw)
                    'Shift row selected down
                    'Links datagridview to the datatable created
                    Me.DataGridView1.DataSource = dat
                    'For future programmers; uncomment out the next line of code to see how the bubble sort works.
                    'Me.DataGridView1.Refresh() 
                End If
            Next
        Next
        Me.DataGridView1.Refresh()
        Me.DataGridView1.DataSource = dat
    End Sub
    Private Sub Integer_DESC(ByVal a As Integer)
        Dim dat As DataTable = Form1.Canteen_Stock_v_3DataSet.table1
        dat.PrimaryKey = Nothing
        For introw2 = 0 To DataGridView1.RowCount - 2
            For introw = 0 To DataGridView1.RowCount - 2
                If DataGridView1.Rows(introw).Cells(a).Value < DataGridView1.Rows(introw + 1).Cells(a).Value Then
                    Dim newRow As DataRow = dat.NewRow
                    'Shifts row down
                    For i As Integer = 0 To Me.DataGridView1.ColumnCount - 1
                        newRow.Item(i) = Me.DataGridView1(i, introw).Value
                    Next

                    dat.Rows.InsertAt(newRow, introw + 2)
                    dat.Rows.RemoveAt(introw)
                    'Shift row selected down
                    'Links datagridview to the datatable created
                    Me.DataGridView1.DataSource = dat
                    'For future programmers; uncomment out the next line of code to see how the bubble sort works.
                    'Me.DataGridView1.Refresh() 
                End If
            Next
        Next
        Me.DataGridView1.Refresh()
        Me.DataGridView1.DataSource = dat
    End Sub
    Private Sub ProductName_ASC(ByVal a As Integer)
        Dim dat As DataTable = Form1.Canteen_Stock_v_3DataSet.table1
        dat.PrimaryKey = Nothing
        For introw2 = 0 To DataGridView1.RowCount - 2
            For introw = 0 To DataGridView1.RowCount - 2
                If String.Compare(DataGridView1.Rows(introw).Cells(a).Value, DataGridView1.Rows(introw + 1).Cells(a).Value) = 1 Then
                    Dim newRow As DataRow = dat.NewRow
                    'Shifts row down
                    For i As Integer = 0 To Me.DataGridView1.ColumnCount - 1
                        newRow.Item(i) = Me.DataGridView1(i, introw).Value
                    Next

                    dat.Rows.InsertAt(newRow, introw + 2)
                    dat.Rows.RemoveAt(introw)
                    'Shift row selected down
                    'Links datagridview to the datatable created
                    Me.DataGridView1.DataSource = dat
                    'For future programmers; uncomment out the next line of code to see how the bubble sort works.
                    'Me.DataGridView1.Refresh() 
                End If
            Next
        Next
        Me.DataGridView1.Refresh()
        Me.DataGridView1.DataSource = dat
    End Sub
    Private Sub ProductName_DESC(ByVal a As Integer)
        Dim dat As DataTable = Form1.Canteen_Stock_v_3DataSet.table1
        dat.PrimaryKey = Nothing
        For introw2 = 0 To DataGridView1.RowCount - 2
            For introw = 0 To DataGridView1.RowCount - 2
                If String.Compare(DataGridView1.Rows(introw).Cells(a).Value, DataGridView1.Rows(introw + 1).Cells(a).Value) = -1 Then
                    Dim newRow As DataRow = dat.NewRow
                    'Shifts row down
                    For i As Integer = 0 To Me.DataGridView1.ColumnCount - 1
                        newRow.Item(i) = Me.DataGridView1(i, introw).Value
                    Next

                    dat.Rows.InsertAt(newRow, introw + 2)
                    dat.Rows.RemoveAt(introw)
                    'Shift row selected down
                    'Links datagridview to the datatable created
                    Me.DataGridView1.DataSource = dat
                    'For future programmers; uncomment out the next line of code to see how the bubble sort works.
                    'Me.DataGridView1.Refresh() 
                End If
            Next
        Next
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub ExpiryDate_ASC(ByVal a As Integer)
        Dim dat As DataTable = Form1.Canteen_Stock_v_3DataSet.table1
        dat.PrimaryKey = Nothing
        For introw2 = 0 To DataGridView1.RowCount - 2
            For introw = 0 To DataGridView1.RowCount - 2
                If DateTime.Compare(DataGridView1.Rows(introw).Cells(a).Value, DataGridView1.Rows(introw + 1).Cells(a).Value) = 1 Then
                    Dim newRow As DataRow = dat.NewRow
                    'Shifts row down
                    For i As Integer = 0 To Me.DataGridView1.ColumnCount - 1
                        newRow.Item(i) = Me.DataGridView1(i, introw).Value
                    Next

                    dat.Rows.InsertAt(newRow, introw + 2)
                    dat.Rows.RemoveAt(introw)
                    'Shift row selected down
                    'Links datagridview to the datatable created
                    Me.DataGridView1.DataSource = dat
                    'For future programmers; uncomment out the next line of code to see how the bubble sort works.
                    'Me.DataGridView1.Refresh() 
                End If
            Next
        Next
        Me.DataGridView1.Refresh()
    End Sub
    Private Sub ExpiryDate_DESC(ByVal a As Integer)
        Dim dat As DataTable = Form1.Canteen_Stock_v_3DataSet.table1
        dat.PrimaryKey = Nothing
        For introw2 = 0 To DataGridView1.RowCount - 2
            For introw = 0 To DataGridView1.RowCount - 2
                If DateTime.Compare(DataGridView1.Rows(introw).Cells(a).Value, DataGridView1.Rows(introw + 1).Cells(a).Value) = -1 Then
                    Dim newRow As DataRow = dat.NewRow
                    'Shifts row down
                    For i As Integer = 0 To Me.DataGridView1.ColumnCount - 1
                        newRow.Item(i) = Me.DataGridView1(i, introw).Value
                    Next

                    dat.Rows.InsertAt(newRow, introw + 2)
                    dat.Rows.RemoveAt(introw)
                    'Shift row selected down
                    'Links datagridview to the datatable created
                    Me.DataGridView1.DataSource = dat
                    'For future programmers; uncomment out the next line of code to see how the bubble sort works.
                    'Me.DataGridView1.Refresh() 
                End If
            Next
        Next
        Me.DataGridView1.Refresh()
    End Sub
    Private Sub SignOut()
        Dim ans As String
        ans = MsgBox("Continue Sign Out?", vbYesNo + vbQuestion, "Confirmation")
        'If user confirms yess code runs
        If ans = vbYes Then
            loginform.Show()
            Form1.Close()
            Me.Close()
        End If
    End Sub
    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        SignOut()
    End Sub
    'Establis bitmap as the bitmap class responsible for containing the pixel data for the print document displayed
    Private bitmap As Bitmap
    Private Sub iPrint()
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = height
        'Calculate dimensions needed for print and displays what is going to be printed
    End Sub
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        iPrint()
    End Sub
    'Is used inside the iPrint subroutine to print the datagridview
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub
    'The below lines simply replicate the buttons, adding user functionality
    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        SignOut()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub Ascend()
        Dim stock As String
        stock = cmbSort.Text
        Select Case stock 'A sort based on the contents of the variable stock in this case the different fields ProductName, ExpiryDate and Quantity
            Case "SKU"
                Integer_ASC(0)
            Case "ProductName"
                ProductName_ASC(1)
            Case "ExpiryDate"
                ExpiryDate_ASC(2)
            Case "Quantity"
                Integer_ASC(3)
        End Select
        'Allows users to sort fields in ascending order
    End Sub
    Private Sub Descend()
        Dim stock As String
        stock = cmbSort.Text
        Select Case stock 'A sort based on the contents of the variable stock in this case the different fields ProductName, ExpiryDate and Quantity
            Case "SKU"
                Integer_DESC(0)
            Case "ProductName"
                ProductName_DESC(1)
            Case "ExpiryDate"
                ExpiryDate_DESC(2)
            Case "Quantity"
                Integer_DESC(3)
        End Select
        'Allows users to sort fields in ascending order
    End Sub

    Private Sub btnASC_Click(sender As Object, e As EventArgs) Handles btnASC.Click
        Ascend()
    End Sub

    Private Sub btnDESC_Click(sender As Object, e As EventArgs) Handles btnDESC.Click
        Descend()
    End Sub
End Class