Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        openConn()
        rs.Open("select * from tbl_user where username='" & TxtUsername.Text & "' and password='" & TxtPassword.Text & "' and status='1'", conn, 3, 2)
        If Not rs.EOF Then
            Dashboard.Show()
        Else
            MsgBox("Username dan Password Salah", vbInformation, "Informasi")
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            TxtUsername.Focus()
        End If
        closeConn()
    End Sub
End Class
