Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GajiPokok.Enabled = False
    End Sub

    Private Sub HitungGaji_Click(sender As Object, e As EventArgs) Handles HitungGaji.Click
        If Nama.Text = "" Or Jabatan.text = "" Or LamaBekerja.Text = "" Then
            MsgBox("Mohon Masukan Nama, Jabatan, Dan Lama Bekerja saudara/i")
        Else
            GajiPokok.Text = Val(LamaBekerja.Text) * 200000
            Lembur.Text = Val(Lembur.Text) * 20000
            TotalGaji.Text = Val(GajiPokok.Text) + Val(Tunjangan.Text) + Val(Lembur.Text) + Val(Thr.Text)
            MsgBox("Selamat " + Nama.Text + " Dengan Jabatan " + Jabatan.Text + " Mendapatkan Gaji " + TotalGaji.Text)

        End If

    End Sub
End Class
