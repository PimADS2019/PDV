﻿#pragma checksum "..\..\..\UC\UCCliente.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "79E80BBB65AA5E12DA57D6B4EA116FDBC8664D5781D62D7DB3B5D820FB136F2F"
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
    /// UCCliente
    /// </summary>
    public partial class UCCliente : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\UC\UCCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgClientes;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UC\UCCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPesqCliente;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\UC\UCCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIncluirCliente;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UC\UCCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditarCliente;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\UC\UCCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExcluirCliente;
        
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
            System.Uri resourceLocater = new System.Uri("/ViewPimNoite;component/uc/uccliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UC\UCCliente.xaml"
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
            this.dgClientes = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\..\UC\UCCliente.xaml"
            this.dgClientes.Initialized += new System.EventHandler(this.dgClientes_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txbPesqCliente = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\UC\UCCliente.xaml"
            this.txbPesqCliente.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.TxbPesqCliente_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\UC\UCCliente.xaml"
            this.txbPesqCliente.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txbPesqCliente_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnIncluirCliente = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\UC\UCCliente.xaml"
            this.btnIncluirCliente.Click += new System.Windows.RoutedEventHandler(this.BtnIncluirCliente_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnEditarCliente = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\UC\UCCliente.xaml"
            this.btnEditarCliente.Click += new System.Windows.RoutedEventHandler(this.BtnEditarCliente_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnExcluirCliente = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

