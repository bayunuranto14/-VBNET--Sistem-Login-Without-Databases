Public Class Dashboard

   
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text = ""
        GroupBox2.Text = ""
        GroupBox3.Text = ""

        Label1.Text = "Selamat Datang, Administrator! "
        Button1.Text = "DASHBOARD"
        Button2.Text = "PROFILE"
        Button3.Text = "KALENDER"
        Button4.Text = "PENGATURAN"
        Button5.Text = "KELUAR"
        Label2.Text = ""
        Label4.Text = "Bayu Afif Nuranto | 2020230903 | Teknologi Informasi | UNIVERSITAS DARMA PERSADA"
        MonthCalendar1.Hide()
        Call SembunyikanPengaturan()
    End Sub

    Sub SembunyikanPengaturan()
        Label3.Hide()
        GroupBox3.Hide()
        RadioButton1.Hide()
        RadioButton2.Hide()
        RadioButton3.Hide()
        RadioButton4.Hide()
    End Sub

    Sub MunculkanPengaturan()
        Label3.Show()
        GroupBox3.Show()
        RadioButton1.Show()
        RadioButton2.Show()
        RadioButton3.Show()
        RadioButton4.Show()
    End Sub

    Sub MunculkanKalender()
        MonthCalendar1.Show()
    End Sub

    Sub SembunyikanKalender()
        MonthCalendar1.Hide()
    End Sub


    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        launcher_MyTugas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call SembunyikanPengaturan()
        Call SembunyikanKalender()
        Label2.Text = "Selamat Datang! Administrator"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "KALENDER 2021"
        Call MunculkanKalender()
        Call SembunyikanPengaturan()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Apakah Anda Ingin Logout dari Halaman Page ini? ?", MessageBoxButtons.OKCancel)
        Me.Hide()
        launcher_MyTugas.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = "PENGATURAN"
        Label3.Text = "Themes Style"
        RadioButton1.Text = "Merah"
        RadioButton2.Text = "Biru"
        RadioButton3.Text = "Hijau"
        RadioButton4.Text = "Ungu"
        RadioButton5.Text = "Default"
        Call SembunyikanKalender()
        Call MunculkanPengaturan()
    End Sub


    Sub warnamerah()
        GroupBox1.ForeColor = Color.Aqua
        Label1.ForeColor = Color.Red
        Button1.ForeColor = Color.Red
        Button2.ForeColor = Color.Red
        Button3.ForeColor = Color.Red
        Button4.ForeColor = Color.Red
        Button5.ForeColor = Color.Red
    End Sub
    Sub warnabiru()
        Label1.ForeColor = Color.Blue
        Button1.ForeColor = Color.Blue
        Button2.ForeColor = Color.Blue
        Button3.ForeColor = Color.Blue
        Button4.ForeColor = Color.Blue
        Button5.ForeColor = Color.Blue
    End Sub
    Sub warnahijau()
        Label1.ForeColor = Color.Green
        Button1.ForeColor = Color.Green
        Button2.ForeColor = Color.Green
        Button3.ForeColor = Color.Green
        Button4.ForeColor = Color.Green
        Button5.ForeColor = Color.Green
    End Sub
    Sub warnaungu()
        Label1.ForeColor = Color.Purple
        Button1.ForeColor = Color.Purple
        Button2.ForeColor = Color.Purple
        Button3.ForeColor = Color.Purple
        Button4.ForeColor = Color.Purple
        Button5.ForeColor = Color.Purple
    End Sub
    Sub colordefault()
        Label1.ForeColor = Color.White
        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.Black
        Button5.ForeColor = Color.Black
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Call warnamerah()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Call warnabiru()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Call warnahijau()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Call warnaungu()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Comming Soon!")
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Call colordefault()
    End Sub
End Class