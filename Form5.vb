Imports System.Data.SqlClient
Imports System.Data

Public Class Rapport
    Public TypeRepport

    Private Sub Rapport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As SqlConnection = New SqlConnection("Data Source=DELL-XIAOMING\SQLEXPRESS;Initial Catalog=rentsystem;Integrated Security=True")
            Using cmd As New SqlCommand("SELECT [id] 
      ,[problem_desc]
      ,[rent_id]
      ,[repairs_students_id]
      ,[status_repair]
      ,[sn]
      ,[inv_no]
  FROM [Repairs]")
                Using sda As New SqlDataAdapter()
                    cmd.Connection = con
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.DataSource = dt

                    End Using
                End Using
            End Using
            con.Close()
        End Using
    End Sub
End Class