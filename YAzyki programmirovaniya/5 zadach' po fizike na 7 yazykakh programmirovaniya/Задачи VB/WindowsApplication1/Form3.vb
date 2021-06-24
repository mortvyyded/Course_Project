Public Class Form3
    Dim t, S, v As Double
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        S = Val(textBox2.Text)
        v = Val(textBox3.Text)

        t = S / v

        textBox1.Text = CStr(t)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class