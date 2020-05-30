Imports System.ComponentModel

Public Class Form1
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        'My.Settings.BeforeValue = TextBox1.Text
        'My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub Ref_Click(sender As Object, e As EventArgs) Handles Ref.Click
        Dim webAddress As String = "https://en.wikipedia.org/wiki/List_of_Unicode_characters"
        Process.Start(webAddress)
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.BeforeValue = TextBox1.Text
        My.Settings.Save()
        Form2.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call VerifyDigit()
        Call ConvertCode()
    End Sub

    Private Sub VerifyDigit()
        Dim Position As Integer, i As Integer
        Dim AscDigit As Integer
        With TextBox1
            Position = .SelectionStart
            i = 1
            While i <= .Text.Length
                AscDigit = Asc(Mid(.Text, i, 1))
                If (AscDigit < 48 Or AscDigit > 57) And (AscDigit < 65 Or AscDigit > 70) And (AscDigit < 97 Or AscDigit > 102) Then
                    Position = Math.Max(Position - 1, 0)
                    .Text = Replace(.Text, Chr(AscDigit), "")
                End If
                i = i + 1
            End While
            .Text = UCase(.Text)
            .Select(Position, 0)
        End With
    End Sub

    Private Sub ConvertCode()
        Dim Code As String, Symbol As String, AlreadyHave As Boolean
        With TextBox1
            If Len(.Text) = 4 And .Text <> "0000" Then
                Code = "U+" + .Text
                Symbol = ChrW("&H" + CStr(.Text))
                TextBox2.Text = Symbol
                Clipboard.SetText(Symbol)
                Msg.Show()
                With Form2.ListView1
                    AlreadyHave = False
                    For Each item In .Items
                        If item.SubItems(1).Text = Code Then
                            AlreadyHave = True
                        End If
                    Next
                    If Not AlreadyHave Then
                        .Items.Add("-")
                        .Items(.Items.Count - 1).SubItems.Add(Code)
                        .Items(.Items.Count - 1).SubItems.Add(Symbol)
                    End If
                End With
            End If
        End With
    End Sub

End Class
