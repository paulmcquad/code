Public Class Form1

    Private Sub ComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim userEntry As String

        userEntry = ComboBox1.Text
        userEntry = LCase(userEntry)

        If userEntry = "arbiter" Then
            'PictureBox1.Load("Z:\Finished VB Exercises\Halo\Halo\Resources\arbiter.png")
            PictureBox1.Image = My.Resources.Arbiter
        ElseIf userEntry = "cortana" Then
            'PictureBox1.Load("Z:\Finished VB Exercises\Halo\Halo\Resources\cortana.png")
            PictureBox1.Image = My.Resources.Cortana
        ElseIf userEntry = "masterchief" Then
            'PictureBox1.Load("Z:\Finished VB Exercises\Halo\Halo\Resources\masterchief.png")
            PictureBox1.Image = My.Resources.MasterChief
        Else
            MsgBox("Enter a proper character")
        End If
    End Sub
End Class
