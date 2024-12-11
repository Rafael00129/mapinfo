Imports MySql.Data.MySqlClient

Public Class admin
    ' Declare connection object globally
    Private conn As MySqlConnection

    ' This method will be called when the form loads
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
    End Sub

    ' Establish connection to the database
    Private Sub DbConnect()
        ' Define your connection string (replace with your actual values)
        Dim connectionString As String = "Server=Localhost;Database=mapinfo;Uid=root;Pwd=password;"

        ' Initialize the MySqlConnection object
        conn = New MySqlConnection(connectionString)
    End Sub

    ' Button click to navigate to Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    ' TextChanged event for email textbox (currently not used)
    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged
        ' You can add logic here if needed
    End Sub

    ' TextChanged event for password textbox (currently not used)
    Private Sub txtpwd_TextChanged(sender As Object, e As EventArgs) Handles txtpwd.TextChanged
        ' You can add logic here if needed
    End Sub

    ' Button click to perform login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        ' Retrieve email and password from textboxes
        Dim email As String = txtemail.Text.Trim()
        Dim password As String = txtpwd.Text.Trim()

        ' Check if fields are empty
        If email = "" Or password = "" Then
            MessageBox.Show("Please enter both email and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            ' Ensure connection is open
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            ' SQL query to verify the email and password
            Dim query As String = "SELECT * FROM editor WHERE editorName = @Email AND editorPassword = @Password"
            Dim cmd As New MySqlCommand(query, conn)

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@Email", email)
            cmd.Parameters.AddWithValue("@Password", password)

            ' Execute query
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Check if the user exists
            If reader.HasRows Then
                reader.Close()
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
                admindmain.Show()  ' Show the admin form
                Me.Hide()     ' Hide the current form
            Else
                reader.Close()
                MessageBox.Show("Wrong email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection after use
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class
