Public Class Form1
    Dim vNama As String = "Agus"
    Dim vGajiPokok As Single = 5000000
    Dim vGaji As Single
    Dim vPajak As Single

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Label1.Text = "Nama Anda : " & vNama
        Label2.Text = "Gaji Pokok : " & vGajiPokok
        vPajak = vGajiPokok * 0.1
        vGaji = vGajiPokok - vPajak
        Label3.Text = "Pajak Penghasilan : " & vPajak
        Label4.Text = "Gaji Bersih : " & vGaji
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nama As String
        Nama = InputBox("Masukan Nama : ", "Input Nama")
        Label5.Text = ("Nama Anda : " & Nama)
    End Sub

End Class
