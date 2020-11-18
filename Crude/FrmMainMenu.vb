Public Class FrmMainMenu

    Private Sub ItemToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ItemToolStripMenuItem.Click
        FrmItem.MdiParent = Me
        FrmItem.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim Tanya = MessageBox.Show("Are you sure to exit the program?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Tanya = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub AboutAppToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutAppToolStripMenuItem.Click
        FrmAbout.MdiParent = Me
        FrmAbout.Show()
    End Sub
End Class
