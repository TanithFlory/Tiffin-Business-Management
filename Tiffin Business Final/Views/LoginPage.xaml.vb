
Class LoginPage
    Private Sub loginbtn_Click(sender As Object, e As RoutedEventArgs) Handles loginbtn.Click
        Dim username_txt As String = username.Text
        Dim password_txt As String = password.Password
        Dim pwtxtbox_txt As String = pwtxtbox.Text

        If (username_txt.Equals("admin") And (password_txt.Equals("admin") Or pwtxtbox_txt.Equals("admin"))) Then
            Me.NavigationService.Navigate(New Uri("\ViewModel\HomePage.xaml", UriKind.RelativeOrAbsolute))
        Else
            MessageBox.Show("Incorrect Credentials! ", "Error! ", MessageBoxButton.OK)
        End If
    End Sub

    Private Sub Eye_img_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Eye_img.MouseLeftButtonDown
        pwtxtbox.Text = password.Password
        password.Visibility = Visibility.Hidden
        pwtxtbox.Visibility = Visibility.Visible
        Eye_img.Visibility = Visibility.Hidden
        EyeBlock_img.Visibility = Visibility.Visible
    End Sub

    Private Sub EyeBlock_img_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles EyeBlock_img.MouseLeftButtonDown
        password.Password = pwtxtbox.Text
        pwtxtbox.Visibility = Visibility.Collapsed
        password.Visibility = Visibility.Visible
        Eye_img.Visibility = Visibility.Visible
        EyeBlock_img.Visibility = Visibility.Hidden
    End Sub

    Private Sub ChangePass_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Contact Administrator  ", "~_~ ", MessageBoxButton.OK)

    End Sub
End Class
