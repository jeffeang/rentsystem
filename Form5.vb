Imports System.Data.SqlClient
Imports System.Data

Public Class Rapport
    Public TypeRepport

    Private Sub Rapport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connDBObject = New ConDB()
        Using con = connDBObject.connectDB()
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


    Public Function FilterRepReport()
        Dim SearchLastName = Nom.Text
        Dim SearchFirstName = Prenom.Text
        Dim SearchSn = Sn.Text
        Dim SearchInv = InvNo.Text
        Dim SqlString = "  SELECT r.[id]
      ,[sn]
      ,[inv_no]
      ,s.first_name
	  ,s.[last_name]
      ,s.[group]
      ,[problem_desc]
      ,[status_repair]
	  FROM [dbo].[Repairs] as r
	  inner join students as s on s.id = r.repairs_students_id"
        If SearchLastName IsNot "" Then
            SqlString = SqlString & " where s.[first_name] like '" & SearchLastName & "%'"
            If SearchFirstName IsNot "" Then
                SqlString = SqlString & " AND s.[last_name] like '" & SearchFirstName & "%'"
            End If
            If SearchSn IsNot "" Then
                SqlString = SqlString & " AND [sn] like '" & SearchSn & "%'"
            End If
            If SearchInv IsNot "" Then
                SqlString = SqlString & " AND [inv_no] like '" & SearchInv & "%'"
            End If

        ElseIf SearchFirstName IsNot "" Then
            SqlString = SqlString & "where s.[last_name] like '" & SearchFirstName & "%'"
            If SearchSn IsNot "" Then
                SqlString = SqlString & " AND [sn] like '" & SearchSn & "%'"
            End If
            If SearchInv IsNot "" Then
                SqlString = SqlString & " AND [inv_no] like '" & SearchInv & "%'"
            End If
        ElseIf SearchSn IsNot "" Then
            SqlString = SqlString & " AND [sn] like '" & SearchSn & "%'"
            If SearchInv IsNot "" Then
                SqlString = SqlString & " AND [inv_no] like '" & SearchInv & "%'"
            End If
        End If

        Dim connDBObject = New ConDB()
        Using con = connDBObject.connectDB()
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

    Private Sub Nom_TextChanged(sender As Object, e As EventArgs) Handles Nom.TextChanged
        Me.FilterRepReport()
    End Sub

    Private Sub Prenom_TextChanged(sender As Object, e As EventArgs) Handles Prenom.TextChanged
        Me.FilterRepReport()
    End Sub

    Private Sub Sn_TextChanged(sender As Object, e As EventArgs) Handles Sn.TextChanged
        Me.FilterRepReport()
    End Sub

    Private Sub InvNo_TextChanged(sender As Object, e As EventArgs) Handles InvNo.TextChanged
        Me.FilterRepReport()
    End Sub
End Class