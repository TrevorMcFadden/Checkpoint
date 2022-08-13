Public NotInheritable Class MainPage
    Inherits Page
    ''CheckpointCommandBar subroutines
    Private Sub RefreshButton_Click(sender As Object, e As RoutedEventArgs) Handles RefreshButton.Click
        Navi.Refresh()
        RefreshButton.Visibility = 1
        StopButton.Visibility = 0
    End Sub
    Private Sub StopButton_Click(sender As Object, e As RoutedEventArgs) Handles StopButton.Click
        Navi.Refresh()
        RefreshButton.Visibility = 0
        StopButton.Visibility = 1
    End Sub
    ''Navi subroutines
    Private Sub Navi_NavigationCompleted(sender As Object, e As WebViewNavigationCompletedEventArgs) Handles Navi.NavigationCompleted
        RefreshButton.Visibility = 0
        StopButton.Visibility = 1
        RefreshButton.IsEnabled = True
    End Sub
End Class
