
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging


Public Class formSetDesktopBackground

    Inherits System.Windows.Forms.Form
    Public Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal l As Integer, ByVal m As Integer, ByVal n As String, ByVal o As Integer) As Integer
    Private Const wallpaper = 20
    Private Const ad = &H1

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click

        Dim ld As OpenFileDialog = New OpenFileDialog
        ld.Filter = "Image Files (  *.bmp  *.png *.jpg)| *.bmp ;*.png; *.gif ; *.jpg ;  *.jpg ;"
        ld.Title = "Preview"
        ld.ShowDialog()
        PictureBox.Image = Image.FromFile(ld.FileName)

    End Sub

    Private Sub btnChanger_Click(sender As System.Object, e As System.EventArgs) Handles btnChanger.Click

        Dim imagePath As String = Application.StartupPath & "\new Wallpaper.Bmp"
        PictureBox.Image.Save(imagePath, ImageFormat.Jpeg)
        SystemParametersInfo(wallpaper, 0, imagePath, ad)

    End Sub
End Class
