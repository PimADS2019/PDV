﻿#pragma checksum "..\..\..\UC\UCEfetuarVenda.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8B9A5A0CC3A5951A60B9FAFD3A6443A757BFCC1C0E06A4C2C5B138F3C19AABD3"
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
    /// UCEfetuarVenda
    /// </summary>
    public partial class UCEfetuarVenda : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\UC\UCEfetuarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFinalizarVenda;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\UC\UCEfetuarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgProdutosVenda;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UC\UCEfetuarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbQuantidadeProduto;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UC\UCEfetuarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIncluirItem;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UC\UCEfetuarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSubTotal;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\UC\UCEfetuarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQtdItens;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UC\UCEfetuarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDesconto;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UC\UCEfetuarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotal;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\UC\UCEfetuarVenda.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbProduto;
        
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
            System.Uri resourceLocater = new System.Uri("/ViewPimNoite;component/uc/ucefetuarvenda.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UC\UCEfetuarVenda.xaml"
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
            this.btnFinalizarVenda = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\UC\UCEfetuarVenda.xaml"
            this.btnFinalizarVenda.Click += new System.Windows.RoutedEventHandler(this.btnFinalizarVenda_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgProdutosVenda = ((System.Windows.Controls.DataGrid)(target));
            
            #line 17 "..\..\..\UC\UCEfetuarVenda.xaml"
            this.dgProdutosVenda.AddingNewItem += new System.EventHandler<System.Windows.Controls.AddingNewItemEventArgs>(this.dgProdutosVenda_AddingNewItem);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbQuantidadeProduto = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\UC\UCEfetuarVenda.xaml"
            this.txbQuantidadeProduto.KeyDown += new System.Windows.Input.KeyEventHandler(this.txbQuantidadeProduto_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnIncluirItem = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\UC\UCEfetuarVenda.xaml"
            this.btnIncluirItem.Click += new System.Windows.RoutedEventHandler(this.btnIncluirItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lblSubTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblQtdItens = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lblDesconto = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.cmbProduto = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

