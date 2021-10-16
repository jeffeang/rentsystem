Imports System
Imports rentsystem.ConDB
Imports System.Data.SqlClient
Imports rentsystem.MenuPage

Public Class LoginForm

    Private Sub LoginBt_Click(sender As Object, e As EventArgs) Handles LoginBt.Click
        Dim User = UserInput.Text
        Dim Paswd = PwdInput.Text
        LoginMessage.Visible = False
        Dim connDBObject = New ConDB()
        Using con = connDBObject.connectDB()
            con.Open()
            Dim commande As New SqlCommand("select count(*) as rows from admin_user where user_name =@username and password=@pwd ", con)
            commande.Parameters.AddWithValue("@username", User)
            commande.Parameters.AddWithValue("@pwd", Paswd)
            Using reader As SqlDataReader = commande.ExecuteReader
                If reader.Read Then
                    Dim row = reader.GetValue("rows").ToString
                    If (row > 0) Then
                        Dim Form2Objet = New MenuPage()
                        Me.Hide()
                        Form2Objet.Show()
                        Form2Objet.AdminUserName = User

                    Else
                        LoginMessage.Visible = True
                        LoginMessage.Text = "Votre mot de passe ou nom d'utilisateur n'est pas correct!"
                    End If

                End If
            End Using
            con.Close()

        End Using


    End Sub

End Class
