﻿#pragma checksum "..\..\BookPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8EC00517CFCC9E8B2B24B21ACD85DB31FCBF2A907842DD776BC28447ED3A2469"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DemoExam8800;
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


namespace DemoExam8800 {
    
    
    /// <summary>
    /// BookPage
    /// </summary>
    public partial class BookPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\BookPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBook;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\BookPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LstBook;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\BookPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EditBook;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\BookPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DeleteBook;
        
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
            System.Uri resourceLocater = new System.Uri("/DemoExam8800;component/bookpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BookPage.xaml"
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
            this.AddBook = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\BookPage.xaml"
            this.AddBook.Click += new System.Windows.RoutedEventHandler(this.AddBook_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LstBook = ((System.Windows.Controls.ListView)(target));
            
            #line 17 "..\..\BookPage.xaml"
            this.LstBook.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LstBook_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EditBook = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\BookPage.xaml"
            this.EditBook.Click += new System.Windows.RoutedEventHandler(this.EditBook_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteBook = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\BookPage.xaml"
            this.DeleteBook.Click += new System.Windows.RoutedEventHandler(this.DeleteBook_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

