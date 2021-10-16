Imports System.Data.SqlClient

Public Class ConDB
    Private db1 = "Data Source=DELL-XIAOMING\SQLEXPRESS;Initial Catalog=rentsystem;Integrated Security=True"

    Public Function connectDB()
        Dim con As SqlConnection = New SqlConnection(Me.db1)
        Return con
    End Function

End Class
