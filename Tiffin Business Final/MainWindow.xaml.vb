Class MainWindow
    Private Sub NavigationUIDisabler_Initialized(sender As Object, e As EventArgs) Handles NavigationUIDisabler.Initialized
        NavigationUIDisabler.NavigationUIVisibility = NavigationUIVisibility.Hidden
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As RoutedEventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As RoutedEventArgs) Handles MinimizeButton.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Window_MouseDown(sender As Object, e As MouseButtonEventArgs)
        If (e.LeftButton = MouseButtonState.Pressed) Then
            DragMove()
        End If
    End Sub
End Class
