﻿#pragma checksum "..\..\..\Produto\FrmEditProduto.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "22E4085182CB1087F27097D80E269178626337DA0C9D84723D92920445A1F4C5"
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
using ViewPimNoite.Produto;


namespace ViewPimNoite.Produto {
    
    
    /// <summary>
    /// FrmEditProduto
    /// </summary>
    public partial class FrmEditProduto : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\Produto\FrmEditProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbIdProduto;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Produto\FrmEditProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbProduto;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Produto\FrmEditProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbFabricante;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Produto\FrmEditProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbCodReferencia;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Produto\FrmEditProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbFornecedor;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Produto\FrmEditProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbCusto;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Produto\FrmEditProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPrecoVenda;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Produto\FrmEditProduto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSalvarProduto;
        
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
            System.Uri resourceLocater = new System.Uri("/ViewPimNoite;component/produto/frmeditproduto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Produto\FrmEditProduto.xaml"
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
            this.txbIdProduto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txbProduto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txbFabricante = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txbCodReferencia = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\Produto\FrmEditProduto.xaml"
            this.txbCodReferencia.KeyDown += new System.Windows.Input.KeyEventHandler(this.txbCodReferencia_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txbFornecedor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txbCusto = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\Produto\FrmEditProduto.xaml"
            this.txbCusto.KeyDown += new System.Windows.Input.KeyEventHandler(this.txbCusto_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txbPrecoVenda = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\Produto\FrmEditProduto.xaml"
            this.txbPrecoVenda.KeyDown += new System.Windows.Input.KeyEventHandler(this.txbPrecoVenda_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSalvarProduto = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Produto\FrmEditProduto.xaml"
            this.btnSalvarProduto.Click += new System.Windows.RoutedEventHandler(this.btnSalvarProduto_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

