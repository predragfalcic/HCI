﻿#pragma checksum "..\..\..\LogiWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3157263E866A126BD75D1CC7070072AF"
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


namespace MapaLokala {
    
    
    /// <summary>
    /// LogiWindow
    /// </summary>
    public partial class LogiWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 47 "..\..\..\LogiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_username;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\LogiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_lozinka;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\LogiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_prijava;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\LogiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_username_reg;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\LogiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_lozinka_reg;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\LogiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txt_lozinka_reg_ponovo;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\LogiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_reg;
        
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
            System.Uri resourceLocater = new System.Uri("/MapaLokala;component/logiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LogiWindow.xaml"
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
            this.txt_username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_lozinka = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.btn_prijava = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\LogiWindow.xaml"
            this.btn_prijava.Click += new System.Windows.RoutedEventHandler(this.btnPrijavi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt_username_reg = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txt_lozinka_reg = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.txt_lozinka_reg_ponovo = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.btn_reg = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\LogiWindow.xaml"
            this.btn_reg.Click += new System.Windows.RoutedEventHandler(this.btnRegistruj_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

