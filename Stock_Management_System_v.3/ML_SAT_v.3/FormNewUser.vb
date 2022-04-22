'Software Developer: Matthew Lin
'Project Start Date: 12/04/2020
'Project Final Date: 14/08/2020
'Purpose: Sub Form, Used to create a new user account
Public Class FormNewUser
    Private usernamepassword As String = Application.StartupPath & "\userpass.txt"
    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        'e.KeyChar is the keypress event that activated the private sub by 'equaling' it to Chr(Keys.Enter) 
        'Thus the code within the if statement is run when the keypress event is an 'Enter'
        If e.KeyChar = Chr(Keys.Enter) Then
            txtPass.Focus()
        End If
    End Sub
    'Detects 'enter' key when txtpass is selected and creates a new user if appropriate
    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            CreateNewUser()
        End If
    End Sub
    'private subroutine for creating a new user
    Private Sub CreateNewUser()
        'Defining variables
        Dim Username As String
        Dim Password As String
        Dim FileNum As Integer = FreeFile()
        Dim Found As Boolean = False
        'Opens UsernamePassword.txt file in debug folder
        FileOpen(FileNum, "userpass.txt", OpenMode.Input)
        'runs untile file has ended or username has been found
        Do Until EOF(FileNum) Or Found
            Username = LineInput(FileNum)
            Password = LineInput(FileNum)
            Found = (txtUser.Text = Username)
        Loop
        FileClose(FileNum)
        'If username was found then the user is informed that the username is taken and the sub is exited
        If Found = True Then
            MsgBox("Username is taken alraeady", vbCritical, "Error")
            Exit Sub
        ElseIf ValidateUserPass() = False Then 'Makes sure that user has entered something into both fields
            Exit Sub
        Else
            'All validation checks have been made so the username and password is added to the text file
            'Dim objwriter As New System.IO.StreamWriter("C:\Users\43318\Desktop\ML_Unit_3_Outcome1_Folio_3\Energy_Costs\bin\DebugUsernamePassword.txt", True)
            Dim objwriter As New System.IO.StreamWriter(usernamepassword, True)
            Dim aryText(2) As String
            aryText(1) = (txtUser.Text)
            aryText(2) = (txtPass.Text)
            objwriter.WriteLine(aryText(1))
            objwriter.WriteLine(aryText(2))
            objwriter.Close()
            MessageBox.Show("saved")
            txtUser.Clear()
            txtPass.Clear()
        End If
    End Sub
    'Private function for making sure that user has not left textboxes empty
    Private Function ValidateUserPass() As Boolean
        Dim valid As Boolean = True
        If Trim(txtPass.Text) = "" Or Trim(txtUser.Text) = "" Then
            MsgBox("Please enter username and password", vbCritical, "Error")
            valid = False
            Return valid
        End If
        Return valid
    End Function
    'Allows user to return to login screen
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        loginform.Show()
        Me.Close()
    End Sub
    'Calls the subroutine createnew user
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        CreateNewUser()
    End Sub
    'Returns to login form
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        loginform.Show()
        Me.Close()
    End Sub
    'Attempts to create new account
    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        CreateNewUser()
    End Sub
    'Closes program
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        loginform.Close()
    End Sub
End Class