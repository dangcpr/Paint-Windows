﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EF87BCEF2D9D2F38C382A84EDEEC899E0C35DEAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MainProject;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MainProject {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton UndoButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton RedoButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Ribbon.RibbonButton ZoomButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MainProject;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((MainProject.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 19 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.ImportButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 20 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.ExportButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UndoButton = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.UndoButton.Click += new System.Windows.RoutedEventHandler(this.UndoButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RedoButton = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 24 "..\..\..\MainWindow.xaml"
            this.RedoButton.Click += new System.Windows.RoutedEventHandler(this.RedoButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ZoomButton = ((System.Windows.Controls.Ribbon.RibbonButton)(target));
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.ZoomButton.Click += new System.Windows.RoutedEventHandler(this.ZoomButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 28 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.LineRibbonButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 29 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.EllipseRibbonButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 30 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Ribbon.RibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.RectangleRibbonButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.canvas.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseDown);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.canvas.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_MouseUp);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.canvas.MouseMove += new System.Windows.Input.MouseEventHandler(this.Canvas_MouseMove);
            
            #line default
            #line hidden
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.canvas.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.canvas_MouseWheel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

