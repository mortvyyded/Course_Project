Public Class Form5
    Dim S1, S2, t, v1, v2 As Double
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        t = Val(textBox2.Text)
        v1 = Val(textBox1.Text)
        v2 = Val(textBox4.Text)

        S1 = v1 * t
        S2 = v2 * t

        textBox3.Text = CStr(S1)
        textBox5.Text = CStr(S2)
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class