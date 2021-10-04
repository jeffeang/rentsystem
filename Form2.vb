Imports rentsystem.LoginForm
Imports rentsystem.ReparationForm

Public Class MenuPage
    Public AdminUserName

    Private Sub ReparationBt_Click(sender As Object, e As EventArgs) Handles ReparationBt.Click
        Me.Hide()
        Dim RepPage = New ReparationForm()
        RepPage.Show()
    End Sub
End Class