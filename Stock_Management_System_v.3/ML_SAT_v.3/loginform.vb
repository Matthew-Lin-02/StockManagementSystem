'Software Developer: Matthew Lin
'Project Start Date: 12/04/2020
'Project Final Date: 14/08/2020
'Purpose: Sub Form, initial startup form used as login screen so that users can access the main form
Public Class loginform
    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Focus()
    End Sub
    'when enter is pressed within the username box, the cursor is placed inside the password textbox
    Private Sub txtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUser.KeyPress
        'e.KeyChar refers to the event that caused the private sub to run,
        'in this case the enter key being pressed the equals chr(keys.Enter) confirms this
        If e.KeyChar = Chr(Keys.Enter) Then
            txtPass.Focus()
        End If
    End Sub
    'Close Login Screen when button click
    Private Sub BtnCan_Click(sender As Object, e As EventArgs) Handles BtnCan.Click
        Close()
    End Sub
    'Occurs when key is pressed and cursor is placed inside txtpass control
    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        ' 'main code' activates when the event that triggered the subroutine was an enter key
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim Username As String
            Dim Password As String
            Dim FileNum As Integer = FreeFile()
            Dim Found As Boolean = False
            'Opens userpass.txt in debug folder
            FileOpen(FileNum, "userpass.txt", OpenMode.Input)
            Do Until EOF(FileNum) Or Found
                'odd lines go to username, even lines go to password
                Username = LineInput(FileNum)
                Password = LineInput(FileNum)
                'if it is the Francis, the manager, deleting permissions are given
                If txtUser.Text = "Francis" And txtPass.Text = "password" Then
                    Form1.btnDelete.Visible = True
                    Form1.DeleteToolStripMenuItem.Visible = True
                    Form1.btnSave.Width = 85
                    Form1.btnClose.Width = 70
                    Form1.btnClose.Left = 235
                End If
                'If the username and password match up with one of the combinations in the text file, the user is granted access into the main form
                If Username = txtUser.Text And Password = txtPass.Text Then
                    Form1.Show()
                    txtPass.Clear()
                    txtUser.Clear()
                    txtUser.Focus()
                    Me.Hide()
                    Found = True
                End If
            Loop
            'if user details were incorrect, they are informed through a msgbox
            If Found = False Then
                MessageBox.Show("Wrong username and password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUser.Clear()
                txtPass.Clear()
                txtUser.Focus()
                FileClose(FileNum)
            End If
            FileClose(FileNum)
        End If
    End Sub

    Private Sub Link_N_User_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_N_User.LinkClicked
        'Although inputbox is possible to use for this, it is not as good as separate form due to customisation and being able to keep password hidden
        CustomInputBox.Show()
        Me.Hide()
    End Sub
    'Closes application
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
    'Closes application
    Private Sub CancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub NewUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewUserToolStripMenuItem.Click
        'Although inputbox is possible to use for this, it is not as good as separate form due to customisation and being able to keep password hidden
        CustomInputBox.Show()
        Me.Hide()
    End Sub
End Class