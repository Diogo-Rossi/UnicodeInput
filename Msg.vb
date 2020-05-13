Public Class Msg
    Dim Tempo As Double = 500
    Dim Decrescimo As Double

    Private Sub Msg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = Form2.Left + Form2.Width / 2 - Me.Width / 2
        Me.Top = Form2.Top + Form2.Height / 2 - Me.Height / 2
        Decrescimo = Timer1.Interval / Tempo
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity - Decrescimo
        If Me.Opacity <= 0 Then
            Me.Close()
        End If
    End Sub

End Class