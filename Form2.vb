Imports rentsystem.LoginForm
Imports rentsystem.ReparationForm
Imports rentsystem.Rapport

Public Class MenuPage
    Public AdminUserName

    Private Sub ReparationBt_Click(sender As Object, e As EventArgs) Handles ReparationBt.Click
        Me.Hide()
        Dim RepPage = New ReparationForm()
        RepPage.Show()
    End Sub

    Private Sub ReportRepBt_Click(sender As Object, e As EventArgs) Handles ReportRepBt.Click
        Me.Hide()
        Dim RepFormPage = New Rapport()
        RepFormPage.Show()
        RepFormPage.TypeRepport = "repair"
    End Sub
End Class