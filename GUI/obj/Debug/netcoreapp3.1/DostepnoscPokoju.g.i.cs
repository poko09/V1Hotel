﻿#pragma checksum "..\..\..\DostepnoscPokoju.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3BDAFF3B4635BFF18987E4A2961896BEAED50CB5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using GUI;
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


namespace GUI {
    
    
    /// <summary>
    /// DostepnoscPokoju
    /// </summary>
    public partial class DostepnoscPokoju : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\DostepnoscPokoju.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDataPoczatkowa;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\DostepnoscPokoju.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDataKoncowa;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\DostepnoscPokoju.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSprawdz;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\DostepnoscPokoju.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonWroc;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\DostepnoscPokoju.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonWyczysc;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GUI;component/dostepnoscpokoju.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DostepnoscPokoju.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dpDataPoczatkowa = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.dpDataKoncowa = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.buttonSprawdz = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\DostepnoscPokoju.xaml"
            this.buttonSprawdz.Click += new System.Windows.RoutedEventHandler(this.buttonSprawdz_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonWroc = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\DostepnoscPokoju.xaml"
            this.buttonWroc.Click += new System.Windows.RoutedEventHandler(this.buttonWroc_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonWyczysc = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\DostepnoscPokoju.xaml"
            this.buttonWyczysc.Click += new System.Windows.RoutedEventHandler(this.buttonWyczysc_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

