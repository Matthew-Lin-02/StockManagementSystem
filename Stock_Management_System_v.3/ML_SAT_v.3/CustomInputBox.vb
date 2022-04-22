Public Class CustomInputBox
    Private Sub txtadminpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtadminpass.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If txtadminpass.Text = "adminpassword" Then
                FormNewUser.Show()
                Me.Close()
            Else
                MsgBox("The password you have entered is incorrect", MsgBoxStyle.Information, "Password error")
                txtadminpass.Text = ""
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtadminpass.Text = "adminpassword" Then
            FormNewUser.Show()
            Me.Close()
        Else
            MsgBox("The password you have entered is incorrect", MsgBoxStyle.Information, "Password error")
            txtadminpass.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginform.Show()
        Me.Close()
    End Sub
End Class