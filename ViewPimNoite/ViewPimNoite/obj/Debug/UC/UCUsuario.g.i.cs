﻿#pragma checksum "..\..\..\UC\UCUsuario.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0C97EEB47555BA6A5576573C9450A45AB9BCDD7CEB752CCE7F7B21227490599A"
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
    /// UCUsuario
    /// </summary>
    public partial class UCUsuario : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\UC\UCUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgUsuarios;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UC\UCUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbPesqUsuario;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\UC\UCUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbWaterMark;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\UC\UCUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAtualizar;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UC\UCUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIncluirUsuario;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\UC\UCUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditarUsuario;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\UC\UCUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExcluirUsuario;
        
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
            System.Uri resourceLocater = new System.Uri("/ViewPimNoite;component/uc/ucusuario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UC\UCUsuario.xaml"
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
            this.dgUsuarios = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\..\UC\UCUsuario.xaml"
            this.dgUsuarios.Initialized += new System.EventHandler(this.dgUsuarios_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txbPesqUsuario = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\UC\UCUsuario.xaml"
            this.txbPesqUsuario.LostFocus += new System.Windows.RoutedEventHandler(this.txbPesqUsuario_LostFocus);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\UC\UCUsuario.xaml"
            this.txbPesqUsuario.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txbPesqUsuario_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbWaterMark = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\UC\UCUsuario.xaml"
            this.txbWaterMark.GotFocus += new System.Windows.RoutedEventHandler(this.txbWaterMark_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAtualizar = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\UC\UCUsuario.xaml"
            this.btnAtualizar.Click += new System.Windows.RoutedEventHandler(this.btnAtualizar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnIncluirUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\UC\UCUsuario.xaml"
            this.btnIncluirUsuario.Click += new System.Windows.RoutedEventHandler(this.BtnIncluirUsuario_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnEditarUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\UC\UCUsuario.xaml"
            this.btnEditarUsuario.Click += new System.Windows.RoutedEventHandler(this.BtnEditarUsuario_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnExcluirUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\UC\UCUsuario.xaml"
            this.btnExcluirUsuario.Click += new System.Windows.RoutedEventHandler(this.btnExcluirUsuario_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

