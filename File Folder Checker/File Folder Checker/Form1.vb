Imports System.IO

Public Class formBrowseFiles

    Private Sub formBrowseFiles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        For Each dr As DriveInfo In DriveInfo.GetDrives()
            lstDrives.Items.Add(dr)

        Next

    End Sub

    Private Sub lstDrives_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstDrives.SelectedIndexChanged

        lstFloders.Items.Clear()

        Try

            Dim drive As DriveInfo = DirectCast(lstDrives.SelectedItem, DriveInfo)

            For Each dirinfo As DirectoryInfo In drive.RootDirectory.GetDirectories()
                lstFloders.Items.Add(dirinfo)

            Next

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub lstFloders_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstFloders.SelectedIndexChanged

        lstFiles.Items.Clear()

        Dim dir As DirectoryInfo = DirectCast(lstFloders.SelectedItem, DirectoryInfo)
        For Each fi As FileInfo In dir.GetFiles()
            lstFiles.Items.Add(fi)
        Next

    End Sub
End Class
