﻿

#ExternalChecksum("E:\Downloads\Windows8RTSReader\SplitPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "0DEF7AB45EFBA3C2DF4C7CC7CA88161F")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


Namespace Global.WindowsBlogReader

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Class SplitPage
        Inherits Global.WindowsBlogReader.Common.LayoutAwarePage

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents pageRoot As Global.WindowsBlogReader.Common.LayoutAwarePage
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemsViewSource As Global.Windows.UI.Xaml.Data.CollectionViewSource
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents PopInStoryboard As Global.Windows.UI.Xaml.Media.Animation.Storyboard
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents primaryColumn As Global.Windows.UI.Xaml.Controls.ColumnDefinition
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents titlePanel As Global.Windows.UI.Xaml.Controls.Grid
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemListView As Global.Windows.UI.Xaml.Controls.ListView
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemDetail As Global.Windows.UI.Xaml.Controls.ScrollViewer
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemDetailGrid As Global.Windows.UI.Xaml.Controls.Grid
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemTitle As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents contentViewBorder As Global.Windows.UI.Xaml.Controls.Border
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents contentView As Global.Windows.UI.Xaml.Controls.WebView
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents backButton As Global.Windows.UI.Xaml.Controls.Button
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents pageTitle As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents ApplicationViewStates As Global.Windows.UI.Xaml.VisualStateGroup
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents FullScreenLandscapeOrWide As Global.Windows.UI.Xaml.VisualState
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents FilledOrNarrow As Global.Windows.UI.Xaml.VisualState
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents FullScreenPortrait As Global.Windows.UI.Xaml.VisualState
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents FullScreenPortrait_Detail As Global.Windows.UI.Xaml.VisualState
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents Snapped As Global.Windows.UI.Xaml.VisualState
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents Snapped_Detail As Global.Windows.UI.Xaml.VisualState

        Private _contentLoaded As Boolean

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub InitializeComponent()
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true

            Dim uri As New Global.System.Uri("ms-appx:///SplitPage.xaml")
            Global.Windows.UI.Xaml.Application.LoadComponent(Me, uri, Global.Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application)

            pageRoot = CType(Me.FindName("pageRoot"), Global.WindowsBlogReader.Common.LayoutAwarePage)
            itemsViewSource = CType(Me.FindName("itemsViewSource"), Global.Windows.UI.Xaml.Data.CollectionViewSource)
            PopInStoryboard = CType(Me.FindName("PopInStoryboard"), Global.Windows.UI.Xaml.Media.Animation.Storyboard)
            primaryColumn = CType(Me.FindName("primaryColumn"), Global.Windows.UI.Xaml.Controls.ColumnDefinition)
            titlePanel = CType(Me.FindName("titlePanel"), Global.Windows.UI.Xaml.Controls.Grid)
            itemListView = CType(Me.FindName("itemListView"), Global.Windows.UI.Xaml.Controls.ListView)
            itemDetail = CType(Me.FindName("itemDetail"), Global.Windows.UI.Xaml.Controls.ScrollViewer)
            itemDetailGrid = CType(Me.FindName("itemDetailGrid"), Global.Windows.UI.Xaml.Controls.Grid)
            itemTitle = CType(Me.FindName("itemTitle"), Global.Windows.UI.Xaml.Controls.TextBlock)
            contentViewBorder = CType(Me.FindName("contentViewBorder"), Global.Windows.UI.Xaml.Controls.Border)
            contentView = CType(Me.FindName("contentView"), Global.Windows.UI.Xaml.Controls.WebView)
            backButton = CType(Me.FindName("backButton"), Global.Windows.UI.Xaml.Controls.Button)
            pageTitle = CType(Me.FindName("pageTitle"), Global.Windows.UI.Xaml.Controls.TextBlock)
            ApplicationViewStates = CType(Me.FindName("ApplicationViewStates"), Global.Windows.UI.Xaml.VisualStateGroup)
            FullScreenLandscapeOrWide = CType(Me.FindName("FullScreenLandscapeOrWide"), Global.Windows.UI.Xaml.VisualState)
            FilledOrNarrow = CType(Me.FindName("FilledOrNarrow"), Global.Windows.UI.Xaml.VisualState)
            FullScreenPortrait = CType(Me.FindName("FullScreenPortrait"), Global.Windows.UI.Xaml.VisualState)
            FullScreenPortrait_Detail = CType(Me.FindName("FullScreenPortrait_Detail"), Global.Windows.UI.Xaml.VisualState)
            Snapped = CType(Me.FindName("Snapped"), Global.Windows.UI.Xaml.VisualState)
            Snapped_Detail = CType(Me.FindName("Snapped_Detail"), Global.Windows.UI.Xaml.VisualState)
        End Sub
    End Class

End Namespace


