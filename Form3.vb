Imports rentsystem.MenuPage
Imports rentsystem.StudentList
Imports System.Data.SqlClient

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

    Private Sub SaveBt_Click(sender As Object, e As EventArgs) Handles SaveBt.Click
        Dim SerialNumber = Sn.Text
        Dim InvNumber = InvNo.Text
        Dim DesCause = Desc.Text
        Dim query As String = String.Empty

        query &= "INSERT INTO [dbo].[Repairs]
           ([problem_desc]
           ,[rent_id]
           ,[repairs_students_id]
           ,[status_repair]
           ,[sn]
           ,[inv_no])  "

        query &= "VALUES
           (@problem_desc
           ,@rent_id
           ,@repairs_students_id
           ,@status_repair 
           ,@sn
           ,@inv_no)"

        Using con As SqlConnection = New SqlConnection("Data Source=DELL-XIAOMING\SQLEXPRESS;Initial Catalog=rentsystem;Integrated Security=True")
            Using comm As New SqlCommand()
                With comm
                    .Connection = con
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@problem_desc", DesCause)
                    .Parameters.AddWithValue("@rent_id", "")
                    .Parameters.AddWithValue("@repairs_students_id", StudentID)
                    .Parameters.AddWithValue("@status_repair", "")
                    .Parameters.AddWithValue("@sn", SerialNumber)
                    .Parameters.AddWithValue("@inv_no", InvNumber)

                End With
                Try
                    con.Open()
                    comm.ExecuteNonQuery()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using

            con.Close()
        End Using

    End Sub
End Class