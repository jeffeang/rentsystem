Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub LoginBt_Click(sender As Object, e As EventArgs) Handles LoginBt.Click
        Dim User = UserInput.Text
        Dim Paswd = PwdInput.Text

        Using con As SqlConnection = New SqlConnection("Data Source=DELL-XIAOMING\SQLEXPRESS;Initial Catalog=rentsystem;Integrated Security=Tru")
            con.Open()
            Dim commande As New SqlCommand("select * from admin_user where user_name =@username and password=@pwd ", con)
        End Using


    End Sub
End Class
