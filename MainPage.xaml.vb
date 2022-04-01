Public NotInheritable Class MainPage
    Inherits Page
    Private Sub RefreshButton_Click(sender As Object, e As RoutedEventArgs) Handles RefreshButton.Click
        Navi.Refresh()
    End Sub
    Private Sub StopButton_Click(sender As Object, e As RoutedEventArgs) Handles RefreshButton.Click
        Navi.Stop()
    End Sub
    Private Sub BackButton_Click(sender As Object, e As RoutedEventArgs) Handles BackButton.Click
        Navi.GoBack()
    End Sub
    Private Sub ForwardButton_Click(sender As Object, e As RoutedEventArgs) Handles ForwardButton.Click
        Navi.GoForward()
    End Sub
    Private Sub Navi_LoadCompleted(sender As Object, e As NavigationEventArgs) Handles Navi.LoadCompleted
        If Navi.CanGoBack = True Then
            BackButton.IsEnabled = True
        Else
            BackButton.IsEnabled = False
        End If
        If Navi.CanGoForward = True Then
            ForwardButton.IsEnabled = True
        Else
            ForwardButton.IsEnabled = False
        End If
    End Sub
End Class
