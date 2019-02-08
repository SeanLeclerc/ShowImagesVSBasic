Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                PictureBox1.Image = Image.FromFile("C:\Users\Sean's PC\Desktop\Exeercise03\computer.bmp")

            Case 1
                PictureBox1.Image = Image.FromFile("C:\Users\Sean's PC\Desktop\Exeercise03\calculette.bmp")

            Case 2
                PictureBox1.Image = Image.FromFile("C:\Users\Sean's PC\Desktop\Exeercise03\harddisk.bmp")
        End Select

    End Sub


End Class
