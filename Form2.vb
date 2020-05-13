Imports System.ComponentModel

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 0 To My.Settings.ListCode.Count - 1
            Me.ListView1.Items.Add("-")
            Me.ListView1.Items(i).SubItems.Add(My.Settings.ListCode.Item(i))
            Me.ListView1.Items(i).SubItems.Add(My.Settings.ListSymbol.Item(i))
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged, ListView1.Click
        With Me.ListView1
            If .SelectedItems.Count > 0 Then
                Clipboard.SetText(.SelectedItems(0).SubItems(2).Text)
                Msg.Show()
            End If
        End With
    End Sub

    Private Sub NewSymbol_Click(sender As Object, e As EventArgs) Handles NewSymbol.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        With My.Settings
            For i = .ListCode.Count - 1 To 0 Step -1
                .ListCode.Remove(.ListCode.Item(i))
                .ListSymbol.Remove(.ListSymbol.Item(i))
            Next
            For i = 0 To Me.ListView1.Items.Count - 1
                .ListCode.Add(Me.ListView1.Items(i).SubItems(1).Text)
                .ListSymbol.Add(Me.ListView1.Items(i).SubItems(2).Text)
            Next
        End With
    End Sub

    Private Sub DelSymbol_Click(sender As Object, e As EventArgs) Handles DelSymbol.Click

        With Me.ListView1
            If .SelectedIndices.Count > 0 Then
                .Items.Remove(.Items(.SelectedIndices.Item(0)))
            End If
        End With
    End Sub
End Class