﻿#pragma checksum "..\..\main_designer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0624ADE43EFA6843B44B83B13F53CFE623AF5507D3102BE26F7595F3AF482BF3"
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
using iamapollojusticeandiamfine;


namespace iamapollojusticeandiamfine {
    
    
    /// <summary>
    /// main_designer
    /// </summary>
    public partial class main_designer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\main_designer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Designer_fullname_here;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\main_designer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TO_All_orders_button;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\main_designer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TO_Completed_orders_button;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\main_designer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit_Button;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\main_designer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid All_orders_datagrid;
        
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
            System.Uri resourceLocater = new System.Uri("/iamapollojusticeandiamfine;component/main_designer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\main_designer.xaml"
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
            
            #line 8 "..\..\main_designer.xaml"
            ((iamapollojusticeandiamfine.main_designer)(target)).Loaded += new System.Windows.RoutedEventHandler(this.DoAfterLoad);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Designer_fullname_here = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TO_All_orders_button = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\main_designer.xaml"
            this.TO_All_orders_button.Click += new System.Windows.RoutedEventHandler(this.TO_All_orders_button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TO_Completed_orders_button = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\main_designer.xaml"
            this.TO_Completed_orders_button.Click += new System.Windows.RoutedEventHandler(this.TO_Completed_orders_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Exit_Button = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\main_designer.xaml"
            this.Exit_Button.Click += new System.Windows.RoutedEventHandler(this.Exit_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.All_orders_datagrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

