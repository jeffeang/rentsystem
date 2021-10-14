Imports System.Data.SqlClient
Imports System.Data

Public Class Rapport
    Public TypeRepport

    Private Sub Rapport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As SqlConnection = New SqlConnection("Data Source=DELL-XIAOMING\SQLEXPRESS;Initial Catalog=rentsystem;Integrated Security=True")
            Using cmd As New SqlCommand("
        SELECT r.[id]
      ,[sn]
      ,[inv_no]
      ,s.first_name
	  ,s.[last_name]
      ,s.[group]
      ,[problem_desc]
      ,[status_repair]
	  FROM [dbo].[Repairs] as r
	  inner join students as s on s.id = r.repairs_students_id")
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