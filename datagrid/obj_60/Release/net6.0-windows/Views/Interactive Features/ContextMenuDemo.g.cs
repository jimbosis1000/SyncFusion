﻿#pragma checksum "..\..\..\..\..\Views\Interactive Features\ContextMenuDemo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E6D5214300B02576EDB6167942E39CF3BCC349E1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Syncfusion;
using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.Charts;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Converter;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using Syncfusion.UI.Xaml.ProgressBar;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Filtering;
using Syncfusion.Windows;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
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
using syncfusion.datagriddemos.wpf;
using syncfusion.demoscommon.wpf;


namespace syncfusion.datagriddemos.wpf {
    
    
    /// <summary>
    /// ContextMenuDemo
    /// </summary>
    public partial class ContextMenuDemo : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\Views\Interactive Features\ContextMenuDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.UI.Xaml.Grid.SfDataGrid datagrid;
        
        #line default
        #line hidden
        
        
        #line 373 "..\..\..\..\..\Views\Interactive Features\ContextMenuDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Cut;
        
        #line default
        #line hidden
        
        
        #line 395 "..\..\..\..\..\Views\Interactive Features\ContextMenuDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Copy;
        
        #line default
        #line hidden
        
        
        #line 410 "..\..\..\..\..\Views\Interactive Features\ContextMenuDemo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Paste;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/syncfusion.datagriddemos.wpf;component/views/interactive%20features/contextmenud" +
                    "emo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Interactive Features\ContextMenuDemo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.datagrid = ((Syncfusion.UI.Xaml.Grid.SfDataGrid)(target));
            return;
            case 2:
            this.Cut = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Copy = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Paste = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
