﻿#pragma checksum "..\..\..\View\GeneralPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AA1F25A0A1C135A2DAB7E9CBEF5512E24DC0E5F60965EB51F4978F07DCACB69B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CyberClub_POS.View;
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


namespace CyberClub_POS.View {
    
    
    /// <summary>
    /// GeneralPage
    /// </summary>
    public partial class GeneralPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\GeneralPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label OperatorLogin;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\GeneralPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label OperatorFName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\GeneralPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WorkedHoursL;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\GeneralPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar MainCalendar;
        
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
            System.Uri resourceLocater = new System.Uri("/CyberClub_POS;component/view/generalpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\GeneralPage.xaml"
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
            this.OperatorLogin = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.OperatorFName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.WorkedHoursL = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.MainCalendar = ((System.Windows.Controls.Calendar)(target));
            return;
            case 5:
            
            #line 18 "..\..\..\View\GeneralPage.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.HelpLink_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 19 "..\..\..\View\GeneralPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CyberX_site_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 40 "..\..\..\View\GeneralPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CyberX_VK_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 61 "..\..\..\View\GeneralPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Asiec_site_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 82 "..\..\..\View\GeneralPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Me_GitHub_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

