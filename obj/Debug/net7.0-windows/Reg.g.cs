﻿#pragma checksum "..\..\..\Reg.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B3E9CE9853CC1F122AA9042C209869A6B7BE9785"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp2;


namespace WpfApp2 {
    
    
    /// <summary>
    /// Reg
    /// </summary>
    public partial class Reg : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ToRegButton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox1;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShowBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Hide;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ShowBox1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Hide1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Show1;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Show;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Reg.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Error;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp2;component/reg.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Reg.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\Reg.xaml"
            ((WpfApp2.Reg)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ToRegButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Reg.xaml"
            this.ToRegButton.Click += new System.Windows.RoutedEventHandler(this.ToRegButtonClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\Reg.xaml"
            this.Email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnEmailChange);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 17 "..\..\..\Reg.xaml"
            this.PasswordBox.PasswordChanged += new System.Windows.RoutedEventHandler(this.OnPasswordChange);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\Reg.xaml"
            this.Login.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnLoginChange);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PasswordBox1 = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 19 "..\..\..\Reg.xaml"
            this.PasswordBox1.PasswordChanged += new System.Windows.RoutedEventHandler(this.OnPasswordChange);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GoBack = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Reg.xaml"
            this.GoBack.Click += new System.Windows.RoutedEventHandler(this.GoBack_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ShowBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\Reg.xaml"
            this.ShowBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnPasswordChange);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Hide = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Reg.xaml"
            this.Hide.Click += new System.Windows.RoutedEventHandler(this.Hide_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ShowBox1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\Reg.xaml"
            this.ShowBox1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnPasswordChange);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Hide1 = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Reg.xaml"
            this.Hide1.Click += new System.Windows.RoutedEventHandler(this.Hide1_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Show1 = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Reg.xaml"
            this.Show1.Click += new System.Windows.RoutedEventHandler(this.Hide1_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Show = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Reg.xaml"
            this.Show.Click += new System.Windows.RoutedEventHandler(this.Hide_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.Error = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
