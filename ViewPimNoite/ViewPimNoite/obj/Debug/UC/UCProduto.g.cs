﻿#pragma checksum "..\..\..\UC\UCProduto.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EEC79C582019EF363B89FE9B71C3FF40E86D8778502D2C18B251BC03F5387ADC"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
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
using ViewPimNoite.UC;


namespace ViewPimNoite.UC {
    
    
    /// <summary>
    /// UCProduto
    /// </summary>
    public partial class UCProduto : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\UC\UCProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgProdutos;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UC\UCProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPesqProduto;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UC\UCProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbWaterMark;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\UC\UCProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIncluirProduto;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UC\UCProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditarProduto;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UC\UCProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExcluirProduto;
        
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
            System.Uri resourceLocater = new System.Uri("/ViewPimNoite;component/uc/ucproduto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UC\UCProduto.xaml"
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
            this.dgProdutos = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\..\UC\UCProduto.xaml"
            this.dgProdutos.Initialized += new System.EventHandler(this.dgProdutos_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txbPesqProduto = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\..\UC\UCProduto.xaml"
            this.txbPesqProduto.LostFocus += new System.Windows.RoutedEventHandler(this.txbPesqProduto_LostFocus);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\UC\UCProduto.xaml"
            this.txbPesqProduto.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txbPesqProduto_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbWaterMark = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\UC\UCProduto.xaml"
            this.txbWaterMark.GotFocus += new System.Windows.RoutedEventHandler(this.txbWaterMark_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnIncluirProduto = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\UC\UCProduto.xaml"
            this.btnIncluirProduto.Click += new System.Windows.RoutedEventHandler(this.BtnIncluirProduto_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEditarProduto = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\UC\UCProduto.xaml"
            this.btnEditarProduto.Click += new System.Windows.RoutedEventHandler(this.BtnEditarProduto_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnExcluirProduto = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\UC\UCProduto.xaml"
            this.btnExcluirProduto.Click += new System.Windows.RoutedEventHandler(this.btnExcluirProduto_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

