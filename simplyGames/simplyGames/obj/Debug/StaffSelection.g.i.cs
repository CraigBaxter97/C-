﻿#pragma checksum "..\..\StaffSelection.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3F81EEACF45BE1984C9F0178A9E68B8F55031815"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace SimplyGames {
    
    
    /// <summary>
    /// StaffSelection
    /// </summary>
    public partial class StaffSelection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\StaffSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditGame;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\StaffSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlaceOrder;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\StaffSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddGame;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\StaffSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchGame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SimplyGames;component/staffselection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\StaffSelection.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnEditGame = ((System.Windows.Controls.Button)(target));
            
            #line 6 "..\..\StaffSelection.xaml"
            this.btnEditGame.Click += new System.Windows.RoutedEventHandler(this.btnEditGame_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnPlaceOrder = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\StaffSelection.xaml"
            this.btnPlaceOrder.Click += new System.Windows.RoutedEventHandler(this.btnPlaceOrder_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnAddGame = ((System.Windows.Controls.Button)(target));
            
            #line 8 "..\..\StaffSelection.xaml"
            this.btnAddGame.Click += new System.Windows.RoutedEventHandler(this.btnAddGame_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSearchGame = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\StaffSelection.xaml"
            this.btnSearchGame.Click += new System.Windows.RoutedEventHandler(this.btnSearchGame_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
