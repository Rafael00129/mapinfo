Imports MySql.Data.MySqlClient

Public Class edit
    Dim sqlQuery As String
    Dim dt As DataTable



    Private Sub edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            ' Validate that Room ID, Room Name, and Room Info are not empty
            If String.IsNullOrWhiteSpace(txtID.Text) OrElse
           String.IsNullOrWhiteSpace(txtNAME.Text) OrElse
           String.IsNullOrWhiteSpace(txtINFO.Text) Then

                MessageBox.Show("Please fill in Room ID, Room Name, and Room Info.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' SQL query to update only room_name and room_info where room_id matches
            Dim sqlQuery As String = "UPDATE rooms SET roomNAME = @roomname, roomINFO = @roominfo WHERE roomID = @roomid"

            ' Initialize the MySQL command
            Using cmd As New MySqlCommand(sqlQuery, conn)
                ' Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@roomid", txtID.Text)
                cmd.Parameters.AddWithValue("@roomname", txtNAME.Text)
                cmd.Parameters.AddWithValue("@roominfo", txtINFO.Text)

                ' Open the connection if not already open
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                ' Execute the update command
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if any row was updated
                If rowsAffected > 0 Then
                    MessageBox.Show("Room information updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Optionally refresh the DataGridView to reflect changes
                    btnsearch.PerformClick()
                Else
                    MessageBox.Show("No matching Room ID found. Update failed.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

        Catch ex As Exception
            ' Display an error message in case of issues
            MessageBox.Show("An error occurred while updating: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection to avoid leaving it open
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            ' Ensure roomid is not empty
            If String.IsNullOrWhiteSpace(txtID.Text) Then
                MessageBox.Show("Please enter a Room ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' SQL query to fetch room information based on the entered Room ID
            sqlQuery = "SELECT roomNAME, roomINFO FROM rooms WHERE roomID = @roomid"

            ' Initialize the DataTable to hold results
            dt = New DataTable

            ' Initialize the MySQL command
            Using cmd As New MySqlCommand(sqlQuery, conn)
                ' Add parameter to prevent SQL injection
                cmd.Parameters.AddWithValue("@roomid", txtID.Text)

                ' Open the connection if not already open
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                ' Execute the query and fill the DataTable
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            ' Check if any results were returned
            If dt.Rows.Count > 0 Then
                ' Bind the data to the DataGridView
                DATAGRIDVIEW.DataSource = dt
            Else
                ' Show a message if no room was found
                MessageBox.Show("No room found with the provided ID.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DATAGRIDVIEW.DataSource = Nothing ' Clear the DataGridView
            End If

        Catch ex As Exception
            ' Display an error message in case of any issues
            MessageBox.Show("An error occurred while searching: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection to avoid leaving it open
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub balik_Click(sender As Object, e As EventArgs) Handles balik.Click
        admindmain.Show()
        Me.Hide()

    End Sub
End Class