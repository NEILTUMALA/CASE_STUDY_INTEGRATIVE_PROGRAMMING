Imports MySql.Data.MySqlClient

Module dbConnect

    Public cn As New MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public sql As String

    Public Sub connection()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.ConnectionString = "server=localhost;port=3307;user=root;password=;database=student_db"
        MsgBox("Connection Success", MsgBoxStyle.Information)
        cn.Open()
    End Sub

End Module