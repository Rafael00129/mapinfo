Imports MySql.Data.MySqlClient

Public Class admindmain
    ' Connection string for your MySQL database
    Dim connString As String = "Server=Localhost;Database=mapinfo;Uid=root;Pwd=password;"

    Private Sub reload_Click(sender As Object, e As EventArgs) Handles reload.Click
        ' Create a new connection to the database
        Using conn As New MySqlConnection(connString)
            Try
                ' Open the connection
                conn.Open()

                ' Query to retrieve the data
                Dim query As String = "SELECT * FROM rooms"
                Dim cmd As New MySqlCommand(query, conn)

                ' Use a data adapter to fill the DataGridView with data
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                ' Set the DataSource of the DataGridView to the DataTable
                DataGridView1.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        edit.Show()
        Me.Hide()

    End Sub

    Private Sub admindmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
