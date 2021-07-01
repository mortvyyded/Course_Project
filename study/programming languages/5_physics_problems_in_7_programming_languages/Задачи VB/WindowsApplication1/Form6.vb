Public Class Form6
    Dim F, a, m, v0, vк, t As Double
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        v0 = Val(textBox2.Text)
        vк = Val(textBox3.Text)
        t = Val(textBox4.Text)
        m = Val(textBox6.Text)

        a = (vк - v0) / t
        F = m * a

        textBox1.Text = CStr(F)
        textBox5.Text = CStr(a)
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class