Imports System.Drawing.Drawing2D
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim imag As Bitmap = New Bitmap(OpenFileDialog1.FileName)
            Dim i, j As Integer
            Dim col As Color
            For i = 0 To imag.Width - 1
                For j = 0 To imag.Height - 1
                    col = imag.GetPixel(i, j)
                    imag.SetPixel(i, j, Color.FromArgb(col.R, col.G, col.B))

                Next

            Next
            PictureBox1.Image = imag
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        SaveFileDialog1.Filter = "bitmab file |*.png;*.bmp;*.jpeg"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image.Save(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)


        End If
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "bitmab file |*.png;*.bmp;*.jpeg"
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox2.Image.Save(SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub GreyScileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyScileToolStripMenuItem.Click
        Dim picture As New Bitmap(PictureBox1.Image)
        Dim i, j As Integer
        Dim r, g, b, c As Integer
        PictureBox2.Image = picture
        For i = 0 To picture.Width - 1
            For j = 0 To picture.Height - 1
                r = picture.GetPixel(i, j).R
                g = picture.GetPixel(i, j).G
                b = picture.GetPixel(i, j).B
                c = CInt((r + g + b) / 3)
                picture.SetPixel(i, j, Color.FromArgb(c, c, c))
            Next
        Next
        PictureBox2.Refresh()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

  
    Private Sub BluescalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BluescalToolStripMenuItem.Click
        Dim picture As New Bitmap(PictureBox1.Image)
        Dim i, j, b As Integer
        PictureBox2.Image = picture

        For i = 0 To picture.Width - 1
            For j = 0 To picture.Height - 1
                b = picture.GetPixel(i, j).B
                picture.SetPixel(i, j, Color.FromArgb(0, 0, b))
            Next
        Next

    End Sub

    Private Sub GreenscaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenscaleToolStripMenuItem.Click
        Dim picture As New Bitmap(PictureBox1.Image)
        Dim i, j, g As Integer
        PictureBox2.Image = picture

        For i = 0 To picture.Width - 1
            For j = 0 To picture.Height - 1
                g = picture.GetPixel(i, j).G
                picture.SetPixel(i, j, Color.FromArgb(0, g, 0))
            Next
        Next
    End Sub

    Private Sub RedscaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedscaleToolStripMenuItem.Click
        Dim picture As New Bitmap(PictureBox1.Image)
        Dim i, j, r As Integer
        PictureBox2.Image = picture

        For i = 0 To picture.Width - 1
            For j = 0 To picture.Height - 1
                r = picture.GetPixel(i, j).R
                picture.SetPixel(i, j, Color.FromArgb(r, 0, 0))
            Next
        Next
    End Sub

    
    Private Sub BinaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinaryToolStripMenuItem.Click
        Dim picture As New Bitmap(PictureBox1.Image)
        Dim i, j As Integer
        Dim r, g, b, c As Integer
        PictureBox2.Image = picture
        For i = 0 To picture.Width - 1
            For j = 0 To picture.Height - 1
                r = picture.GetPixel(i, j).R
                g = picture.GetPixel(i, j).G
                b = picture.GetPixel(i, j).B
                c = CInt((r + g + b) / 3)
                If c <= 127 Then
                    c = 0
                Else
                    c = 255
                End If

                picture.SetPixel(i, j, Color.FromArgb(c, c, c))
            Next
        Next
        PictureBox2.Refresh()
    End Sub

    Private Sub NagativToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NagativToolStripMenuItem.Click
        Dim picture As New Bitmap(PictureBox1.Image)
        Dim i, j As Integer
        Dim r, g, b, c As Integer
        PictureBox2.Image = picture
        For i = 0 To picture.Width - 1
            For j = 0 To picture.Height - 1
                r = picture.GetPixel(i, j).R
                g = picture.GetPixel(i, j).G
                b = picture.GetPixel(i, j).B
                c = CInt((r + g + b) / 3)
                c = 255 - c

                If c < 0 Then
                    c = 0
                End If

                picture.SetPixel(i, j, Color.FromArgb(c, c, c))
            Next
        Next
        PictureBox2.Refresh()
    End Sub

    Private Sub BrigtnessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrigtnessToolStripMenuItem.Click
        Dim br As Integer
        br = InputBox("inter the value")
        Dim picture As New Bitmap(PictureBox1.Image)
        Dim i, j As Integer
        Dim r, g, b, c As Integer
        PictureBox2.Image = picture
        For i = 0 To picture.Width - 1
            For j = 0 To picture.Height - 1
                r = picture.GetPixel(i, j).R
                g = picture.GetPixel(i, j).G
                b = picture.GetPixel(i, j).B
                c = (CInt((r + g + b) / 3) + br)

                If c > 255 Then
                    c = 255
                ElseIf c < 0 Then
                    c = 0
                End If
                picture.SetPixel(i, j, Color.FromArgb(c, c, c))
            Next
        Next
        PictureBox2.Refresh()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
