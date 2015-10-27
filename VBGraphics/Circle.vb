Public Class Circle

    'public Property Form As Form
Public Sub DrawCircle(xd As Integer, yd As Integer, r As integer, color As Color, form As Form)


    'form.ForeColor = color
    Dim x As Integer
    Dim y As Integer
    
    Dim th As Double
    
    For i = 1 To 200
    
        th = i * 3.14 / 100
        'Print th
        
        
        x = Math.Sin(th) * r
        y = Math.cos(th) * r

            Dim g = form.CreateGraphics()

            'g.DrawLine(
            'New Pen(color, 1), 
            'xd + x, yd + y, 
            'xd + x+1, yd + y)

            g.DrawEllipse(New Pen(color), xd + x, yd + y, 1, 1)

            'g.DrawEllipse(            
            '    New Pen(color, 1), 
            '    xd + x, yd + y, 
            '    xd + x, yd + y)

        'Debug.Print(x.ToString())
        
    Next i

End Sub
End Class
