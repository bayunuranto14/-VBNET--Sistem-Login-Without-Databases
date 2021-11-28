Public Class launcher_MyTugas
    

    Private Sub launcher_MyTugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text = "UNIVERSITAS DARMA PERSADA"
        Label1.Text = "Username"
        Label2.Text = "Password"
        Button1.Text = "Login"
        Button2.Text = "Exit"
        Button3.Text = "INFORMASI LOGIN"
        CheckBox1.Text = "Munculkan Password"
        TextBox2.UseSystemPasswordChar = True

    End Sub


    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        MsgBox("Anda Akan Keluar Aplikasi ?")
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = "admin"
        Dim Password As String = "admin"
        username = TextBox1.Text
        Password = TextBox2.Text

        For counter As Integer = 1 To 10
            If username = "admin" And Password = "admin" Then
                username = TextBox1.Text()
                Me.Hide()
                Dashboard.Show()
                MessageBox.Show("Login Sukses!")
                Exit For
            Else
                MessageBox.Show("Login Gagal, Silahkan Coba Lagi!", "Login")
                counter += 10
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()
            End If
        Next counter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Username : admin;  |   Password : admin;")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
