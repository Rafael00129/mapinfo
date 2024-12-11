Imports MySql.Data.MySqlClient

Module Module1
    ' Connection object declared as Public for accessibility across the project
    Public conn As New MySqlConnection


    Public Sub DbConnect()
            Dim dbname As String = "mapinfo"
            Dim username As String = "root"
            Dim password As String = "password" ' Password for your SQL account
            Dim server As String = "Localhost" ' MySQL server address

            ' If connection is not initialized or closed, create a new connection
            If conn.State <> ConnectionState.Open Then
                conn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & dbname & ""
                Try
                    conn.Open() ' Open the connection
                    MsgBox("Connection established successfully!")
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                End Try
            End If
        End Sub
    End Module
