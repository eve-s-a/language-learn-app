﻿#pragma checksum "..\..\Activity2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6455DD8DFECDD7C0428A81BCC24302D6C3248E7EB58C0261E746E9A317500707"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Newproject;
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


namespace Newproject {
    
    
    /// <summary>
    /// Activity2
    /// </summary>
    public partial class Activity2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Activity2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image mineralwaterimage;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Activity2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TB_Answer;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Activity2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button submit3;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Activity2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lscorec;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Activity2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Lscorei;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Activity2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OK2;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Activity2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Activity2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image yay;
        
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
            System.Uri resourceLocater = new System.Uri("/Newproject;component/activity2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Activity2.xaml"
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
            this.mineralwaterimage = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.TB_Answer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.submit3 = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Activity2.xaml"
            this.submit3.Click += new System.Windows.RoutedEventHandler(this.submit3_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Lscorec = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Lscorei = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.OK2 = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Activity2.xaml"
            this.OK2.Click += new System.Windows.RoutedEventHandler(this.OK2_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Activity2.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.yay = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

