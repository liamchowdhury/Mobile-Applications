﻿#ExternalChecksum("C:\Users\Liam\Documents\Visual Studio 2012\Projects\Ice Cream Parlour\Ice Cream Parlour\Quantity.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","BD4E1B1623A6B10EF5D751B004360755")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Microsoft.Phone.Controls
Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Ice_Cream_Page
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents VanillaBtn As System.Windows.Controls.Button
    
    Friend WithEvents ChocolateBtn As System.Windows.Controls.Button
    
    Friend WithEvents StrawberryBtn As System.Windows.Controls.Button
    
    Friend WithEvents LemonCheesecakeBtn As System.Windows.Controls.Button
    
    Friend WithEvents BananaBtn As System.Windows.Controls.Button
    
    Friend WithEvents MintBtn As System.Windows.Controls.Button
    
    Friend WithEvents BeerBtn As System.Windows.Controls.Button
    
    Friend WithEvents CurryBtn As System.Windows.Controls.Button
    
    Friend WithEvents EggBtn As System.Windows.Controls.Button
    
    Friend WithEvents BasketBtn As System.Windows.Controls.Button
    
    Friend WithEvents ExitQuantity As System.Windows.Controls.Button
    
    Friend WithEvents OKBtn As System.Windows.Controls.Button
    
    Friend WithEvents IceCreamNameTxt As System.Windows.Controls.TextBlock
    
    Friend WithEvents QuantityNumber As System.Windows.Controls.TextBlock
    
    Friend WithEvents UpArrowBtn As System.Windows.Controls.Button
    
    Friend WithEvents DownArrowBtn As System.Windows.Controls.Button
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        System.Windows.Application.LoadComponent(Me, New System.Uri("/Ice%20Cream%20Parlour;component/Quantity.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.VanillaBtn = CType(Me.FindName("VanillaBtn"),System.Windows.Controls.Button)
        Me.ChocolateBtn = CType(Me.FindName("ChocolateBtn"),System.Windows.Controls.Button)
        Me.StrawberryBtn = CType(Me.FindName("StrawberryBtn"),System.Windows.Controls.Button)
        Me.LemonCheesecakeBtn = CType(Me.FindName("LemonCheesecakeBtn"),System.Windows.Controls.Button)
        Me.BananaBtn = CType(Me.FindName("BananaBtn"),System.Windows.Controls.Button)
        Me.MintBtn = CType(Me.FindName("MintBtn"),System.Windows.Controls.Button)
        Me.BeerBtn = CType(Me.FindName("BeerBtn"),System.Windows.Controls.Button)
        Me.CurryBtn = CType(Me.FindName("CurryBtn"),System.Windows.Controls.Button)
        Me.EggBtn = CType(Me.FindName("EggBtn"),System.Windows.Controls.Button)
        Me.BasketBtn = CType(Me.FindName("BasketBtn"),System.Windows.Controls.Button)
        Me.ExitQuantity = CType(Me.FindName("ExitQuantity"),System.Windows.Controls.Button)
        Me.OKBtn = CType(Me.FindName("OKBtn"),System.Windows.Controls.Button)
        Me.IceCreamNameTxt = CType(Me.FindName("IceCreamNameTxt"),System.Windows.Controls.TextBlock)
        Me.QuantityNumber = CType(Me.FindName("QuantityNumber"),System.Windows.Controls.TextBlock)
        Me.UpArrowBtn = CType(Me.FindName("UpArrowBtn"),System.Windows.Controls.Button)
        Me.DownArrowBtn = CType(Me.FindName("DownArrowBtn"),System.Windows.Controls.Button)
    End Sub
End Class
