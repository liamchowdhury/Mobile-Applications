Imports System.Windows.Media.Imaging

Partial Public Class Quantity
    Inherits PhoneApplicationPage

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub VanillaBtn_Tap(sender As Object, e As GestureEventArgs) Handles VanillaBtn.Tap
        Dim quantUpdate As Integer
        Dim currentQuant As Integer

        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If
    End Sub

    Private Sub ChocolateBtn_Tap(sender As Object, e As GestureEventArgs) Handles ChocolateBtn.Tap
        Dim quantUpdate As Integer
        Dim currentQuant As Integer

        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If
    End Sub

    Private Sub StrawberryBtn_Tap(sender As Object, e As GestureEventArgs) Handles StrawberryBtn.Tap
        Dim quantUpdate As Integer
        Dim currentQuant As Integer

        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If
    End Sub

    Private Sub LemonCheesecakeBtn_Tap(sender As Object, e As GestureEventArgs) Handles LemonCheesecakeBtn.Tap
        Dim quantUpdate As Integer
        Dim currentQuant As Integer

        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If
    End Sub

    Private Sub BananaBtn_Tap(sender As Object, e As GestureEventArgs) Handles BananaBtn.Tap
        Dim quantUpdate As Integer
        Dim currentQuant As Integer

        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If
    End Sub

    Private Sub MintBtn_Tap(sender As Object, e As GestureEventArgs) Handles MintBtn.Tap
        Dim quantUpdate As Integer
        Dim currentQuant As Integer

        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If
    End Sub

    Private Sub BeerBtn_Tap(sender As Object, e As GestureEventArgs) Handles BeerBtn.Tap
        Dim quantUpdate As Integer
        Dim currentQuant As Integer

        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If
    End Sub

    Private Sub CurryBtn_Tap(sender As Object, e As GestureEventArgs) Handles CurryBtn.Tap
        Dim quantUpdate As Integer
        Dim currentQuant As Integer

        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If
    End Sub

    Private Sub EggBtn_Tap(sender As Object, e As GestureEventArgs) Handles EggBtn.Tap
        Dim quantUpdate As Integer
        Dim currentQuant As Integer

        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If
    End Sub

    Private Sub BasketBtn_Click(sender As Object, e As RoutedEventArgs) Handles BasketBtn.Click
        NavigationService.Navigate(New Uri("/Order.xaml", UriKind.Relative))
    End Sub
End Class
