#pragma checksum "..\..\..\..\Pages\AddDiscountPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1EFA1FF01EEC0CB62684E9CD380890CF42A87275"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library.Pages;
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


namespace Library.Pages {
    
    
    /// <summary>
    /// AddDiscountPage
    /// </summary>
    public partial class AddDiscountPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Pages\AddDiscountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox genreCombo;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Pages\AddDiscountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker byPrintDate;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Pages\AddDiscountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pubCombo;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Pages\AddDiscountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newPriceText;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Pages\AddDiscountPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmDiscount;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library;V1.0.0.0;component/pages/adddiscountpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AddDiscountPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.genreCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.byPrintDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.pubCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.newPriceText = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\..\Pages\AddDiscountPage.xaml"
            this.newPriceText.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.newPriceText_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.confirmDiscount = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Pages\AddDiscountPage.xaml"
            this.confirmDiscount.Click += new System.Windows.RoutedEventHandler(this.confirmDiscount_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

