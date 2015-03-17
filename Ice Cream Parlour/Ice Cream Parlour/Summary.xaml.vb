Partial Public Class Summary
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub TextBlock_Loaded(sender As Object, e As RoutedEventArgs)
        lblTotalDaySales.Text = TotalDaySales
    End Sub

    Private Sub VanillaQuant_Loaded(sender As Object, e As RoutedEventArgs) Handles VanillaQuant.Loaded
        VanillaQuant.Text = VanillaCounter
    End Sub

    Private Sub ChocolateBtn_Loaded(sender As Object, e As RoutedEventArgs) Handles ChocolateBtn.Loaded
        ChocolateQuant.Text = ChocolateCounter
    End Sub

    Private Sub StrawberryBtn_Loaded(sender As Object, e As RoutedEventArgs) Handles StrawberryBtn.Loaded
        StrawberryQuant.Text = StrawberryCounter
    End Sub

    Private Sub LemonCheesecakeBtn_Loaded(sender As Object, e As RoutedEventArgs) Handles LemonCheesecakeBtn.Loaded
        LemonCheesecakeQuant.Text = LemonCheesecakeCounter
    End Sub

    Private Sub BananaBtn_Loaded(sender As Object, e As RoutedEventArgs) Handles BananaBtn.Loaded
        BananaQuant.Text = BananaCounter
    End Sub

    Private Sub MintBtn_Loaded(sender As Object, e As RoutedEventArgs) Handles MintBtn.Loaded
        MintQuant.Text = MintCounter
    End Sub

    Private Sub BeerBtn_Loaded(sender As Object, e As RoutedEventArgs) Handles BeerBtn.Loaded
        BeerQuant.Text = BeerCounter
    End Sub

    Private Sub CurryBtn_Loaded(sender As Object, e As RoutedEventArgs) Handles CurryBtn.Loaded
        CurryQuant.Text = CurryCounter
    End Sub

    Private Sub EggBtn_Loaded(sender As Object, e As RoutedEventArgs) Handles EggBtn.Loaded
        EggQuant.Text = EggCounter
    End Sub

    Private Sub lblAvgSalePrice_Loaded(sender As Object, e As RoutedEventArgs) Handles lblAvgSalePrice.Loaded
        lblAvgSalePrice.Text = AvgDaySales
    End Sub

    Private Sub lblTotalCustomers_Loaded(sender As Object, e As RoutedEventArgs) Handles lblTotalCustomers.Loaded
        lblTotalCustomers.Text = TotalCustomers
    End Sub

    Private Sub lblTotalMembers_Loaded(sender As Object, e As RoutedEventArgs) Handles lblTotalMembers.Loaded
        lblTotalMembers.Text = TotalMembers
    End Sub

    Private Sub ExportBtn_Tap(sender As Object, e As GestureEventArgs) Handles ExportBtn.Tap
        
    End Sub
End Class
