﻿#pragma checksum "..\..\PersonenDB.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7A090D55C582A41C24514F3D80F5BCD9573FF645"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PersonenDB_Bsp;
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


namespace PersonenDB_Bsp {
    
    
    /// <summary>
    /// PersonenDB
    /// </summary>
    public partial class PersonenDB : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\PersonenDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNeu;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\PersonenDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnÄndern;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\PersonenDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLöschen;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\PersonenDB.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgdPersonen;
        
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
            System.Uri resourceLocater = new System.Uri("/PersonenDB_Bsp;component/personendb.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PersonenDB.xaml"
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
            
            #line 12 "..\..\PersonenDB.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Beenden_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\PersonenDB.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnNeu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 17 "..\..\PersonenDB.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnÄndern_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 18 "..\..\PersonenDB.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btnLöschen_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnNeu = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\PersonenDB.xaml"
            this.btnNeu.Click += new System.Windows.RoutedEventHandler(this.btnNeu_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnÄndern = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\PersonenDB.xaml"
            this.btnÄndern.Click += new System.Windows.RoutedEventHandler(this.btnÄndern_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnLöschen = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\PersonenDB.xaml"
            this.btnLöschen.Click += new System.Windows.RoutedEventHandler(this.btnLöschen_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dgdPersonen = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

