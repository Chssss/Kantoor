﻿#pragma checksum "..\..\..\NieuwePlattegrond.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2573817DB3E5F42BF506D83A02C7C3488D0DCB7A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KantoorInrichtingWPF;
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


namespace KantoorInrichtingWPF {
    
    
    /// <summary>
    /// NieuwePlattegrond
    /// </summary>
    public partial class NieuwePlattegrond : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\NieuwePlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBTag;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\NieuwePlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBNaam;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\NieuwePlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBLengte;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\NieuwePlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBBreedte;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\NieuwePlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAanmaken;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\NieuwePlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAnnuleren;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/KantoorInrichtingWPF;component/nieuweplattegrond.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\NieuwePlattegrond.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TBTag = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TBNaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBLengte = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBBreedte = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ButtonAanmaken = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\NieuwePlattegrond.xaml"
            this.ButtonAanmaken.Click += new System.Windows.RoutedEventHandler(this.OnButton_Aanmaken_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonAnnuleren = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\NieuwePlattegrond.xaml"
            this.ButtonAnnuleren.Click += new System.Windows.RoutedEventHandler(this.OnButton_Annuleren_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

