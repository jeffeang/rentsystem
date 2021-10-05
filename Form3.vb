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
        Me.Hide()

    End Sub

    Private Sub ReparationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LastName.Text = StudentLastName
        FirstName.Text = StudentFirstName
        Groupe.Text = StudentGroupe
    End Sub


End Class