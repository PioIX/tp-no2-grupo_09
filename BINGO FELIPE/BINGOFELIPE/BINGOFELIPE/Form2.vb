Public Class Form2

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.C Then
            Form1.Show()
            Me.Hide()
        ElseIf e.KeyData = Keys.L Then
            Form1.Show()
            Me.Hide()
        ElseIf e.KeyData = Keys.B Then
            Form1.Show()
            Me.Hide()
        ElseIf e.KeyData = Keys.V Then
            Form1.Show()
            Me.Hide()
        ElseIf Module1.dou = 4 And e.KeyData = Keys.Z Then
            End
        End If
    End Sub

    Private Sub Form2_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Module1.dou = 1 Then
            txtCarttel.Text = "Línea"
        ElseIf Module1.dou = 2 Then
            txtCarttel.Text = "Bingo"
        ElseIf Module1.dou = 3 Then
            txtCarttel.Text = "Venta de cartones"
        ElseIf Module1.dou = 4 Then
            txtCarttel.Text = "Quiere salir?"
        End If
    End Sub
End Class