Imports System.Data.SqlClient
Imports System.Data
Imports rentsystem.ReparationForm
Public Class StudentList

    Private Sub StudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using con As SqlConnection = New SqlConnection("Data Source=DELL-XIAOMING\SQLEXPRESS;Initial Catalog=rentsystem;Integrated Security=True")
            Using cmd As New SqlCommand("SELECT [ID],[first_name] ,[last_name],[group] FROM [Students]")
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

    Private Sub SelectBt_Click(sender As Object, e As EventArgs) Handles SelectBt.Click
        Dim Reparform = New ReparationForm()
        Reparform.StudentID = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Reparform.StudentFirstName = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Reparform.StudentLastName = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Reparform.StudentGroupe = DataGridView1.CurrentRow.Cells(3).Value.ToString()



    End Sub

    Private Sub LastNameInpt_TextChanged(sender As Object, e As EventArgs) Handles LastNameInpt.TextChanged
        Me.SearchFilter()
    End Sub


    Private Function SearchFilter()
        Dim SearchLastName = LastNameInpt.Text
        Dim SearchFirstName = FirstNameInpt.Text
        Dim SearchGroup = GroupInpt.Text
        Dim SqlString = "ELECT [ID],[first_name] ,[last_name],[group] FROM [Students]"
        If SearchLastName IsNot "" Then
            SqlString = SqlString & "where [first_name] like '" & SearchLastName & "%'"


        End If



        Using con As SqlConnection = New SqlConnection("Data Source=DELL-XIAOMING\SQLEXPRESS;Initial Catalog=rentsystem;Integrated Security=True")
            Using cmd As New SqlCommand(SqlString)
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
    End Function
End Class