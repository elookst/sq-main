﻿#pragma checksum "..\..\Planner.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FEF075B1C4DC900C484E4CE01B6FA4680F0AB60873E623532FE89BFF2E277665"
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
using TMS;


namespace TMS {
    
    
    /// <summary>
    /// Planner
    /// </summary>
    public partial class Planner : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Planner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogOut;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Planner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridCustomers;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Planner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnloaddata;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Planner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox orderID;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Planner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CarrierName;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Planner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar orderProcessingDate;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\Planner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OrderStatusCombo;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Planner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock orderStatusDisplay;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\Planner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridInvoices;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\Planner.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnloadinvoice;
        
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
            System.Uri resourceLocater = new System.Uri("/TMS;component/planner.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Planner.xaml"
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
            this.LogOut = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Planner.xaml"
            this.LogOut.Click += new System.Windows.RoutedEventHandler(this.Btn_LogOut_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataGridCustomers = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.btnloaddata = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Planner.xaml"
            this.btnloaddata.Click += new System.Windows.RoutedEventHandler(this.btnloaddata_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.orderID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CarrierName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.orderProcessingDate = ((System.Windows.Controls.Calendar)(target));
            return;
            case 7:
            this.OrderStatusCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 70 "..\..\Planner.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateOrder_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 78 "..\..\Planner.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddTrip_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.orderStatusDisplay = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.dataGridInvoices = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 12:
            this.btnloadinvoice = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\Planner.xaml"
            this.btnloadinvoice.Click += new System.Windows.RoutedEventHandler(this.btnloadinvoice_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

