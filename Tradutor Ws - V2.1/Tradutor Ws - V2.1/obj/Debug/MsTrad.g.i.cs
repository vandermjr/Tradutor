﻿#pragma checksum "..\..\MsTrad.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06329ED0A26C31D256F3294CCFF5AFFBDE82BCBFDBEB4C7F6F617774BF7F5B33"
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
using Tradutor_Ws___V2._1;


namespace Tradutor_Ws___V2._1 {
    
    
    /// <summary>
    /// MsTrad
    /// </summary>
    public partial class MsTrad : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MsTrad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CboFrom;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MsTrad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CboTo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MsTrad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextConta1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MsTrad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextTo;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MsTrad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextSaidaIdioma;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MsTrad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LblIdiFrom;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MsTrad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextFrom;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MsTrad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextIdiomaDetect;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\MsTrad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextIdSaida;
        
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
            System.Uri resourceLocater = new System.Uri("/Tradutor Ws - V2.1;component/mstrad.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MsTrad.xaml"
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
            this.CboFrom = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\MsTrad.xaml"
            this.CboFrom.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CboFrom_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CboTo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\MsTrad.xaml"
            this.CboTo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CboTo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextConta1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TextTo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 14 "..\..\MsTrad.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextSaidaIdioma = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.LblIdiFrom = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.TextFrom = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\MsTrad.xaml"
            this.TextFrom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextFrom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TextIdiomaDetect = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.TextIdSaida = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

