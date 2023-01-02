Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Data
Imports Google.Protobuf.WellKnownTypes
Imports Mysqlx.XDevAPI.Relational
Imports System.Threading

Class DashBoard
    Dim connectionString As String = "SERVER=localhost;DATABASE=;UID=root;PASSWORD=123123!Aa;database=tiffinbusiness"
    Dim Con As MySqlConnection = New MySqlConnection(connectionString)
    Dim Cmd As MySqlCommand = New MySqlCommand
    Dim Reader As MySqlDataReader
    Dim checkboxContent0 As String
    Dim checkboxContent1 As String

    Public Function CheckBox0Checked() As String

        If NonVegCheckBox1.IsChecked = True Then
            checkboxContent0 = CStr(NonVegCheckBox1.Content)
        ElseIf NonVegCheckBox0.IsChecked = True Then
            checkboxContent0 = CStr(NonVegCheckBox0.Content)
        End If
        Return checkboxContent0
    End Function
    Public Function CheckBox1Checked() As String

        If RotiCheckBox0.IsChecked = True Then
            checkboxContent1 = CStr(RotiCheckBox0.Content)
        ElseIf RotiCheckBox1.IsChecked = True Then
            checkboxContent1 = CStr(RotiCheckBox1.Content)
        End If
        Return checkboxContent1
    End Function
    Public Sub tableupdate()
        Dim Dt As DataTable = New DataTable("customerdetails")
        Dim Da As MySqlDataAdapter = New MySqlDataAdapter(Cmd)
        Con.Open()
        Cmd.CommandText = "SELECT * From tiffinbusiness.customerdetails"
        Cmd.Connection = Con
        Dt.Load(Cmd.ExecuteReader())
        Con.Close()
        DashBoardDataGrid.ItemsSource = Dt.DefaultView
    End Sub
    Private Sub Page_Initialized(sender As Object, e As EventArgs)
        Try
            Call tableupdate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Add_Button_Click(sender As Object, e As RoutedEventArgs)
        checkboxContent0 = CheckBox0Checked()
        checkboxContent1 = CheckBox1Checked()
        If FirstNameBox.Text <> Nothing And AddressBox.Text <> Nothing And EmailIDBox.Text <> Nothing And PhoneNumberBox.Text <>
                Nothing And RiceBox.Text <> Nothing And ExtraInfoBox.Text <> Nothing Then
            Try
                Con.Open()
                Dim mysqlinsert As String = "insert into
                                               tiffinbusiness.customerdetails (
                                                    name,
                                                    phone_number,
                                                    non_veg,
                                                    roti,
                                                    rice_type,
                                                    address,
                                                    additional_info,
                                                    Email_ID
                                                )
                                            values
                                                (
                                                    '" & FirstNameBox.Text & "',
                                                    '" & PhoneNumberBox.Text & "',
                                                    '" & checkboxContent0 & "',
                                                    '" & checkboxContent1 & "',
                                                    '" &
                                                                   RiceBox.Text & "',
                                                    '" & AddressBox.Text & "',
                                                    '" & ExtraInfoBox.Text & "',
                                                    '" & EmailIDBox.Text & "'
                                                )"

                Cmd = New MySqlCommand(mysqlinsert, Con)
                Reader = Cmd.ExecuteReader
                MessageBox.Show("Data Added! ", " ", MessageBoxButton.OK, vbInformation)
                Con.Close()
                Call tableupdate()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Con.Dispose()
            End Try
        ElseIf MessageBox.Show("All the information above is mandatory. ", "", MessageBoxButton.OK, vbInformation) Then
        End If


    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Me.NavigationService.Navigate(New Uri("/Views/Page1.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub FirstNameBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles FirstNameBox.TextChanged
        FirstNameBox.Tag = ""
    End Sub

    Private Sub FirstNameBox_LostFocus(sender As Object, e As RoutedEventArgs) Handles FirstNameBox.LostFocus
        If (FirstNameBox.Text = "") Then
            FirstNameBox.Tag = "FirstName"
        End If
    End Sub

    Private Sub SecondNameBox_LostFocus(sender As Object, e As RoutedEventArgs) Handles SecondNameBox.LostFocus
        If (SecondNameBox.Text = "") Then
            SecondNameBox.Tag = "SecondName"
        End If
    End Sub

    Private Sub SecondNameBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles SecondNameBox.TextChanged
        SecondNameBox.Tag = ""
    End Sub

    Private Sub PhoneNumberBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles PhoneNumberBox.TextChanged
        PhoneNumberBox.Tag = ""
    End Sub

    Private Sub AddressBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles AddressBox.TextChanged
        AddressBox.Tag = ""
    End Sub

    Private Sub RiceBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles RiceBox.TextChanged
        RiceBox.Tag = ""
    End Sub

    Private Sub ExtraInfoBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles ExtraInfoBox.TextChanged
        ExtraInfoBox.Tag = ""
    End Sub
    Private Sub EmailIDBox_TextChanged(sender As Object, e As TextChangedEventArgs) Handles EmailIDBox.TextChanged
        EmailIDBox.Tag = ""
    End Sub

    Private Sub PhoneNumberBox_LostFocus(sender As Object, e As RoutedEventArgs) Handles PhoneNumberBox.LostFocus
        If (PhoneNumberBox.Text = "") Then
            PhoneNumberBox.Tag = "PhoneNumber"
        End If
    End Sub

    Private Sub AddressBox_LostFocus(sender As Object, e As RoutedEventArgs) Handles AddressBox.LostFocus
        If (AddressBox.Text = "") Then
            AddressBox.Tag = "Address"
        End If
    End Sub

    Private Sub RiceBox_LostFocus(sender As Object, e As RoutedEventArgs) Handles RiceBox.LostFocus
        If (RiceBox.Text = "") Then
            RiceBox.Tag = "White/Brown Rice"
        End If
    End Sub

    Private Sub ExtraInfoBox_LostFocus(sender As Object, e As RoutedEventArgs) Handles ExtraInfoBox.LostFocus
        If (ExtraInfoBox.Text = "") Then
            ExtraInfoBox.Tag = "Extra Information"
        End If
    End Sub
    Private Sub EmailIDBox_LostFocus(sender As Object, e As RoutedEventArgs) Handles EmailIDBox.LostFocus
        If (EmailIDBox.Text = "") Then
            EmailIDBox.Tag = "Email ID"
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs)
        FirstNameBox.Text = ""
        SecondNameBox.Text = ""
        AddressBox.Text = ""
        RiceBox.Text = ""
        ExtraInfoBox.Text = ""
        PhoneNumberBox.Text = ""
        EmailIDBox.Text = ""
        NonVegCheckBox0.IsChecked = False
        NonVegCheckBox1.IsChecked = False
        RotiCheckBox0.IsChecked = False
        RotiCheckBox1.IsChecked = False
        FirstNameBox.Tag = "FirstName"
        SecondNameBox.Tag = "SecondName"
        AddressBox.Tag = "Address"
        PhoneNumberBox.Tag = "PhoneNumber"
        RiceBox.Tag = "White/Brown Rice"
        ExtraInfoBox.Tag = "Extra Information"
        EmailIDBox.Tag = "Email ID"
    End Sub

    Private Sub BackButton_Click(sender As Object, e As RoutedEventArgs)
        Me.NavigationService.Navigate(New Uri("/ViewModel/HomePage.xaml", UriKind.RelativeOrAbsolute))
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As RoutedEventArgs)
        Dim selectedItem As DataRowView = DashBoardDataGrid.SelectedItem
        If (selectedItem IsNot Nothing) Then
            Try
                Con.Open()
                Dim deletename As String = selectedItem("name")
                selectedItem.Row.Delete()

                Dim mysqlDelete As String = "DELETE FROM
                                               tiffinbusiness.customerdetails WHERE name = '" & selectedItem("name") & "'"
                Cmd = New MySqlCommand(mysqlDelete, Con)
                Cmd.ExecuteNonQuery()
                Con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class
