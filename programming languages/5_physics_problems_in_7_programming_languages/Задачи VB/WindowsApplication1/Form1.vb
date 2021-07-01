Public Class Form1
    Dim v, S, t As Double

    Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click
        t = Val(textBox2.Text)
        S = Val(textBox3.Text)

        v = S / t

        textBox1.Text = CStr(v)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)


    End Sub



End Class
