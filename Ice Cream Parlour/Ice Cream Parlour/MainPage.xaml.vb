Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Private Sub EnterButton_Click(sender As Object, e As RoutedEventArgs) Handles EnterButton.Click
        NavigationService.Navigate(New Uri("/OptionsPage.xaml", UriKind.Relative))
    End Sub
End Class
