Imports MySql.Data.MySqlClient


Public Class cr
    Dim conn As MySqlConnection

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim connectionString As String = "Server=Localhost;Database=mapinfo;Uid=root;Pwd=password;"
        conn = New MySqlConnection(connectionString)
    End Sub
    Private Sub cr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchRoomInfo()
        FetchRoomName()
    End Sub
    Private Sub cr_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        FetchRoomInfo()
        FetchRoomName()
    End Sub
    Private Sub FetchRoomInfo()
        Try
            ' Ensure the connection is open
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Query to select roomINFO for room_id = 1 from roominfo table
            Dim query As String = "SELECT roomINFO FROM rooms WHERE roomID = 1;"

            ' Create the MySqlCommand object
            Dim command As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Set the label's text to the fetched room_info
            If reader.Read() Then
                Label2.Text = reader("roomINFO").ToString()
            Else
                ' If no data is found, show a default message
                Label2.Text = "No room information found."
            End If

            reader.Close() ' Always close the reader after use
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FetchRoomName()
        Try
            ' Ensure the connection is open
            If conn.State = ConnectionState.Closed Then conn.Open()

            ' Query to select room_name for room_id = 1 from roominfo table
            Dim query As String = "SELECT roomNAME FROM rooms WHERE roomID = 1;"
            ' Create the MySqlCommand object
            Dim command As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                ' Set the label's text to the fetched room_name
                Label1.Text = reader("roomNAME").ToString()
            Else
                ' If no data is found, show a default message
                Label1.Text = "No room name found."
            End If

            reader.Close() ' Always close the reader after use
        Catch ex As MySqlException
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        map.Show()
        Me.Hide()

    End Sub
End Class