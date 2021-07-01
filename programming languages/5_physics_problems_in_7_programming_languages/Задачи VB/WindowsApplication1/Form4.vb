Public Class Form4
    Dim S, v, t As Double
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        t = Val(textBox2.Text)
        v = Val(textBox3.Text)

        S = v * t


        textBox4.Text = CStr(S)
    End Sub

    Private Sub label6_Click(sender As Object, e As EventArgs) Handles label6.Click

    End Sub

    Private Sub textBox4_TextChanged(sender As Object, e As EventArgs) Handles textBox4.TextChanged

    End Sub

    Private Sub textBox3_TextChanged(sender As Object, e As EventArgs) Handles textBox3.TextChanged

    End Sub

    Private Sub textBox2_TextChanged(sender As Object, e As EventArgs) Handles textBox2.TextChanged

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub label5_Click(sender As Object, e As EventArgs) Handles label5.Click

    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click

    End Sub

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click

    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class