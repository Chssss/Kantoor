﻿#pragma checksum "..\..\..\..\View\OpslaanPlattegrond.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "058CC6F587DA29EB46220494C4B047FFED835B38"
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
    /// OpslaanPlattegrond
    /// </summary>
    public partial class OpslaanPlattegrond : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\View\OpslaanPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBProjectNaam;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\OpslaanPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBPlattegrondNaam;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\View\OpslaanPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBLengte;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\View\OpslaanPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBBreedte;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\View\OpslaanPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBHoogte;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\OpslaanPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAnnuleren;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\OpslaanPlattegrond.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpslaan;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
<<<<<<< HEAD
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
=======
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
>>>>>>> ad83fa974362199d6a19e595a63071f411dfc86a
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/KantoorInrichtingWPF;component/view/opslaanplattegrond.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\OpslaanPlattegrond.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
<<<<<<< HEAD
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
=======
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
>>>>>>> ad83fa974362199d6a19e595a63071f411dfc86a
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TBProjectNaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TBPlattegrondNaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBLengte = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBBreedte = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TBHoogte = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ButtonAnnuleren = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\View\OpslaanPlattegrond.xaml"
            this.ButtonAnnuleren.Click += new System.Windows.RoutedEventHandler(this.OnAnnulerenButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonOpslaan = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\View\OpslaanPlattegrond.xaml"
            this.ButtonOpslaan.Click += new System.Windows.RoutedEventHandler(this.OnOpslaanButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

