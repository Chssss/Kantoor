﻿#pragma checksum "..\..\..\..\View\LadenPlattegrond.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "816785D36C002EFBF7E7A5806AAFCCCB52D3392A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KantoorInrichtingWPF.View;
using KantoorInrichtingWPF.ViewModel;
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


namespace KantoorInrichtingWPF.View {
    
    
    /// <summary>
    /// LadenPlategrond
    /// </summary>
    public partial class LadenPlategrond : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\View\LadenPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGLadenPlategronden;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\LadenPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBzoekbalk;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\View\LadenPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonZoekenPlattegrondNaam;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\View\LadenPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonTerug;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\View\LadenPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonZoekenProjectNaam;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\LadenPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButoonRefresh;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\LadenPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBProjectNaam;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/KantoorInrichtingWPF;component/view/ladenplattegrond.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\LadenPlattegrond.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DGLadenPlategronden = ((System.Windows.Controls.DataGrid)(target));
            
            #line 18 "..\..\..\..\View\LadenPlattegrond.xaml"
            this.DGLadenPlategronden.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\..\View\LadenPlattegrond.xaml"
            this.DGLadenPlategronden.MouseRightButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseRightButtonPressed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TBzoekbalk = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ButtonZoekenPlattegrondNaam = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\View\LadenPlattegrond.xaml"
            this.ButtonZoekenPlattegrondNaam.Click += new System.Windows.RoutedEventHandler(this.ButtonZoekenPlattegrondNaam_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonTerug = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\View\LadenPlattegrond.xaml"
            this.ButtonTerug.Click += new System.Windows.RoutedEventHandler(this.ButtonTerug_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonZoekenProjectNaam = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\View\LadenPlattegrond.xaml"
            this.ButtonZoekenProjectNaam.Click += new System.Windows.RoutedEventHandler(this.ButtonZoekenProjectNaam_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButoonRefresh = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.TBProjectNaam = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

