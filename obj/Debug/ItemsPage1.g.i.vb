﻿

#ExternalChecksum("E:\Downloads\Windows8RTSReader\ItemsPage1.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "D700DD8F2E04694353F2DE95EAA94AB1")
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
    Partial Class ItemsPage1
        Inherits Global.WindowsBlogReader.Common.LayoutAwarePage

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents pageRoot As Global.WindowsBlogReader.Common.LayoutAwarePage
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemsViewSource As Global.Windows.UI.Xaml.Data.CollectionViewSource
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemGridView As Global.Windows.UI.Xaml.Controls.GridView
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents itemListView As Global.Windows.UI.Xaml.Controls.ListView
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents backButton As Global.Windows.UI.Xaml.Controls.Button
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents pageTitle As Global.Windows.UI.Xaml.Controls.TextBlock
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents ApplicationViewStates As Global.Windows.UI.Xaml.VisualStateGroup
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents FullScreenLandscape As Global.Windows.UI.Xaml.VisualState
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents Filled As Global.Windows.UI.Xaml.VisualState
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents FullScreenPortrait As Global.Windows.UI.Xaml.VisualState
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        private WithEvents Snapped As Global.Windows.UI.Xaml.VisualState

        Private _contentLoaded As Boolean

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub InitializeComponent()
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true

            Dim uri As New Global.System.Uri("ms-appx:///ItemsPage1.xaml")
            Global.Windows.UI.Xaml.Application.LoadComponent(Me, uri, Global.Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application)

            pageRoot = CType(Me.FindName("pageRoot"), Global.WindowsBlogReader.Common.LayoutAwarePage)
            itemsViewSource = CType(Me.FindName("itemsViewSource"), Global.Windows.UI.Xaml.Data.CollectionViewSource)
            itemGridView = CType(Me.FindName("itemGridView"), Global.Windows.UI.Xaml.Controls.GridView)
            itemListView = CType(Me.FindName("itemListView"), Global.Windows.UI.Xaml.Controls.ListView)
            backButton = CType(Me.FindName("backButton"), Global.Windows.UI.Xaml.Controls.Button)
            pageTitle = CType(Me.FindName("pageTitle"), Global.Windows.UI.Xaml.Controls.TextBlock)
            ApplicationViewStates = CType(Me.FindName("ApplicationViewStates"), Global.Windows.UI.Xaml.VisualStateGroup)
            FullScreenLandscape = CType(Me.FindName("FullScreenLandscape"), Global.Windows.UI.Xaml.VisualState)
            Filled = CType(Me.FindName("Filled"), Global.Windows.UI.Xaml.VisualState)
            FullScreenPortrait = CType(Me.FindName("FullScreenPortrait"), Global.Windows.UI.Xaml.VisualState)
            Snapped = CType(Me.FindName("Snapped"), Global.Windows.UI.Xaml.VisualState)
        End Sub
    End Class

End Namespace


