Imports rentsystem.MenuPage
Imports rentsystem.StudentList

Public Class ReparationForm
    Public StudentID
    Public StudentFirstName
    Public StudentLastName
    Public StudentGroupe

    Private Sub StudentSearchBt_Click(sender As Object, e As EventArgs) Handles StudentSearchBt.Click
        Dim studPage = New StudentList()
        studPage.Show()
    End Sub
End Class