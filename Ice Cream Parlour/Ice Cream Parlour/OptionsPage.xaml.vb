Partial Public Class OptionsPage
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        NavigationService.Navigate(New Uri("/Order.xaml", UriKind.Relative))
    End Sub

    Private Sub SalesBtn_Click(sender As Object, e As RoutedEventArgs) Handles SalesBtn.Click
        NavigationService.Navigate(New Uri("/Summary.xaml", UriKind.Relative))
    End Sub
End Class
