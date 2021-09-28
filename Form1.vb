Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub LoginBt_Click(sender As Object, e As EventArgs) Handles LoginBt.Click
        Dim User = UserInput.Text
        Dim Paswd = PwdInput.Text

        Using con As SqlConnection = New SqlConnection("Data Source=DELL-XIAOMING\SQLEXPRESS;Initial Catalog=rentsystem;Integrated Security=Tru")
            con.Open()
            Dim commande As New SqlCommand("select count(*) as rows from admin_user where user_name =@username and password=@pwd ", con)
            commande.Parameters.AddWithValue("@username", User)
            commande.Parameters.AddWithValue("@pwd", Paswd)
            Using reader As SqlDataReader = commande.ExecuteReader
                If reader.Read Then
                    Dim row = reader.GetValue("rows").ToString
                    If (row > 0) Then

                    End If
                End If
            End Using
        End Using


    End Sub
End Class
