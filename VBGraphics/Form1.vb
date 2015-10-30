Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        dim c as new Circle

        c.DrawCircle(200, 200, 100, Color.Green, Me)

        c.DrawCircle(200, 300, 100, Color.Red, Me)

        c.DrawCircle(300, 200, 100, Color.Blue, Me)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Refresh()
    End Sub
End Class
