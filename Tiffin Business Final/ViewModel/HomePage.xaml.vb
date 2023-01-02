Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports System.Data

Class HomePage
    Dim connectionString As String = "SERVER=localhost;DATABASE=;UID=root;PASSWORD=root;database=tiffinbusiness"
    Dim Con As MySqlConnection = New MySqlConnection(connectionString)
    Dim Cmd As MySqlCommand = New MySqlCommand
    Private Sub Dashboardbtn_Click(sender As Object, e As RoutedEventArgs)
        Me.NavigationService.Navigate(New Uri("ViewModel/DashBoard.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As RoutedEventArgs)
        Select Case MsgBox("Do you want to Logout? ", MsgBoxStyle.YesNo, "Confirm ")
            Case MsgBoxResult.Yes
                Me.NavigationService.Navigate(New Uri("Views/LoginPage.xaml", UriKind.RelativeOrAbsolute))
        End Select

    End Sub

    Private Sub tableupdate()
        Dim Dt As DataTable = New DataTable("customerdetails")
        Dim Da As MySqlDataAdapter = New MySqlDataAdapter(Cmd)
        Con.Open()
        Cmd.CommandText = "SELECT * From tiffinbusiness.customerdetails"
        Cmd.Connection = Con
        Dt.Load(Cmd.ExecuteReader())
        Con.Close()
        DashBoardDataGrid1.ItemsSource = Dt.DefaultView
    End Sub
    Private Sub Page_Initialized(sender As Object, e As EventArgs)
        Dim connectionString As String = "SERVER=localhost;DATABASE=;UID=root;PASSWORD=123123!Aa;database=tiffinbusiness"
        Dim Con As MySqlConnection = New MySqlConnection(connectionString)
        Dim Cmd As MySqlCommand = New MySqlCommand
        Dim Dt As DataTable = New DataTable("customerdetails")
        Dim Da As MySqlDataAdapter = New MySqlDataAdapter(Cmd)
        Try
            Con.Open()
            Cmd.CommandText = "SELECT * From tiffinbusiness.customerdetails"
            Cmd.Connection = Con
            Dt.Load(Cmd.ExecuteReader())
            Con.Close()
            DashBoardDataGrid1.ItemsSource = Dt.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DeleteAll_Click(sender As Object, e As RoutedEventArgs)
        Select Case MsgBox("Are you Sure? ", MsgBoxStyle.YesNoCancel, "Confirm ")
            Case MsgBoxResult.Yes
                Try
                    Con.Open()
                    Dim mysqlDelete As String = "truncate table customerdetails"
                    Cmd = New MySqlCommand(mysqlDelete, Con)
                    Cmd.ExecuteNonQuery()
                    Con.Close()
                    MessageBox.Show("Data Deleted! ", " ", MessageBoxButton.OK, vbInformation)
                    Call tableupdate()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
        End Select

    End Sub

End Class
