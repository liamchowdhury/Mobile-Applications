Imports System.IO.IsolatedStorage
Imports System.Text
Imports System.IO

Partial Public Class Order
    Inherits PhoneApplicationPage
    Dim quantUpdate As Integer
    Dim currentQuant As Integer
    Dim currentPrice As Double
    Dim newPrice As Double
    Public Shared total As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub VanillaBtn_Tap(sender As Object, e As GestureEventArgs) Handles VanillaBtn.Tap
        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If

        IceCreamList.Items.Add("Vanilla                                             £1.00")

        currentPrice = Convert.ToDouble(TotalPrice.Text)
        newPrice = currentPrice + 1
        TotalPrice.Text = newPrice
    End Sub

    Private Sub ChocolateBtn_Tap(sender As Object, e As GestureEventArgs) Handles ChocolateBtn.Tap
        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If

        IceCreamList.Items.Add("Chocolate                                       £1.25")

        currentPrice = Convert.ToDouble(TotalPrice.Text)
        newPrice = currentPrice + 1.25
        TotalPrice.Text = newPrice
    End Sub

    Private Sub StrawberryBtn_Tap(sender As Object, e As GestureEventArgs) Handles StrawberryBtn.Tap
        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If

        IceCreamList.Items.Add("Strawberry                                      £1.25")
        'IceCreamPriceList.Items.Add("£1.25")

        currentPrice = Convert.ToDouble(TotalPrice.Text)
        newPrice = currentPrice + 1.25
        TotalPrice.Text = newPrice
    End Sub

    Private Sub LemonCheesecakeBtn_Tap(sender As Object, e As GestureEventArgs) Handles LemonCheesecakeBtn.Tap
        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If

        IceCreamList.Items.Add("Lemon Cheesecake                         £1.50")
        ' IceCreamPriceList.Items.Add("£1.50")

        currentPrice = Convert.ToDouble(TotalPrice.Text)
        newPrice = currentPrice + 1.5
        TotalPrice.Text = newPrice
    End Sub

    Private Sub BananaBtn_Tap(sender As Object, e As GestureEventArgs) Handles BananaBtn.Tap
        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If

        IceCreamList.Items.Add("Banana                                            £1.50")

        currentPrice = Convert.ToDouble(TotalPrice.Text)
        newPrice = currentPrice + 1.5
        TotalPrice.Text = newPrice
    End Sub

    Private Sub MintBtn_Tap(sender As Object, e As GestureEventArgs) Handles MintBtn.Tap
        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If

        IceCreamList.Items.Add("Mint                                                £1.75")
        ' IceCreamPriceList.Items.Add("£1.75")

        currentPrice = Convert.ToDouble(TotalPrice.Text)
        newPrice = currentPrice + 1.75
        TotalPrice.Text = newPrice
    End Sub

    Private Sub BeerBtn_Tap(sender As Object, e As GestureEventArgs) Handles BeerBtn.Tap
        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If

        IceCreamList.Items.Add("Beer                                                £2.25")

        currentPrice = Convert.ToDouble(TotalPrice.Text)
        newPrice = currentPrice + 2.25
        TotalPrice.Text = newPrice
    End Sub

    Private Sub CurryBtn_Tap(sender As Object, e As GestureEventArgs) Handles CurryBtn.Tap
        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If

        IceCreamList.Items.Add("Curry                                               £2.25")

        currentPrice = Convert.ToDouble(TotalPrice.Text)
        newPrice = currentPrice + 2.25
        TotalPrice.Text = newPrice
    End Sub

    Private Sub EggBtn_Tap(sender As Object, e As GestureEventArgs) Handles EggBtn.Tap
        basketQuantity.Visibility = Windows.Visibility.Visible
        quantityCircle.Visibility = Windows.Visibility.Visible

        If (basketQuantity.Text >= 1) Then
            currentQuant = Convert.ToInt32(basketQuantity.Text)
            quantUpdate = currentQuant + 1
            basketQuantity.Text = quantUpdate
        Else
            basketQuantity.Text = 1
        End If

        IceCreamList.Items.Add("Egg                                                 £2.50")

        currentPrice = Convert.ToDouble(TotalPrice.Text)
        newPrice = currentPrice + 2.5
        TotalPrice.Text = newPrice
    End Sub

    Private Sub MemberChkBox_Checked(sender As Object, e As RoutedEventArgs) Handles MemberChkBox.Checked
        currentPrice = Convert.ToDouble(TotalPrice.Text)
        newPrice = currentPrice - (currentPrice * 0.1)
        TotalPrice.Text = newPrice
    End Sub

    Private Sub MemberChkBox_Unchecked(sender As Object, e As RoutedEventArgs) Handles MemberChkBox.Unchecked
        currentPrice = Convert.ToDouble(TotalPrice.Text)
        newPrice = currentPrice + (currentPrice * 0.1)
        TotalPrice.Text = newPrice
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub FinishBtn_Tap(sender As Object, e As GestureEventArgs) Handles FinishBtn.Tap
        TotalDaySales = TotalDaySales + TotalPrice.Text
        NavigationService.Navigate(New Uri("/OptionsPage.xaml", UriKind.Relative))
        TotalCustomers = TotalCustomers + 1
        AvgDaySales = TotalDaySales / TotalCustomers

        If (MemberChkBox.IsChecked = True) Then
            TotalMembers = TotalMembers + 1
        End If

        Dim Vanilla As String = "Vanilla                                             £1.00"
        Dim Chocolate As String = "Chocolate                                       £1.25"
        Dim Strawberry As String = "Strawberry                                      £1.25"
        Dim LemonCheesecake As String = "Lemon Cheesecake                         £1.50"
        Dim Banana As String = "Banana                                            £1.50"
        Dim Mint As String = "Mint                                                £1.75"
        Dim Beer As String = "Beer                                                £2.25"
        Dim Curry As String = "Curry                                               £2.25"
        Dim Egg As String = "Egg                                                 £2.50"

        For Each item As Object In IceCreamList.Items
            If Vanilla.Contains(item.ToString) Then
                VanillaCounter = VanillaCounter + 1
            End If

            If Chocolate.Contains(item.ToString) Then
                ChocolateCounter = ChocolateCounter + 1
            End If

            If Strawberry.Contains(item.ToString) Then
                StrawberryCounter = StrawberryCounter + 1
            End If

            If LemonCheesecake.Contains(item.ToString) Then
                LemonCheesecakeCounter = LemonCheesecakeCounter + 1
            End If

            If Banana.Contains(item.ToString) Then
                BananaCounter = BananaCounter + 1
            End If

            If Mint.Contains(item.ToString) Then
                MintCounter = MintCounter + 1
            End If

            If Beer.Contains(item.ToString) Then
                BeerCounter = BeerCounter + 1
            End If

            If Curry.Contains(item.ToString) Then
                CurryCounter = CurryCounter + 1
            End If

            If Egg.Contains(item.ToString) Then
                EggCounter = EggCounter + 1
            End If
        Next
    End Sub

    Private Sub ClearOrderBtn_Tap(sender As Object, e As GestureEventArgs) Handles ClearOrderBtn.Tap
        IceCreamList.Items.Clear()
        basketQuantity.Text = "0"
        TotalPrice.Text = "0"
        basketQuantity.Visibility = Windows.Visibility.Collapsed
        quantityCircle.Visibility = Windows.Visibility.Collapsed
    End Sub
End Class