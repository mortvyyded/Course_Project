Public Class Form2
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Form1.Show()

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Form5.Show()

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Form4.Show()

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Form3.Show()

    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Form6.Show()

    End Sub

    Private Sub menuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub выходToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class