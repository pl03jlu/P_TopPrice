#pragma checksum "C:\Users\sergh\Documents\GitHub\P_TopPrice\SmartphoneManager\SmartphoneManager\Pages\SearchPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9AB4777A5EF6D0BB284330EFFF1FF603FEA9DF496234D28EFD7F3954F3046743"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartphoneManager.Pages
{
    partial class SearchPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\SearchPage.xaml line 95
                {
                    this.phoneLibrary = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.GridView>(target);
                }
                break;
            case 3: // Pages\SearchPage.xaml line 64
                {
                    this.cbOS = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ComboBox)this.cbOS).SelectionChanged += this.cbFilters;
                }
                break;
            case 4: // Pages\SearchPage.xaml line 72
                {
                    this.cbConstructor = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ComboBox)this.cbConstructor).SelectionChanged += this.cbFilters;
                }
                break;
            case 5: // Pages\SearchPage.xaml line 86
                {
                    this.cbSort = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ComboBox>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ComboBox)this.cbSort).SelectionChanged += this.cbFilters;
                }
                break;
            case 6: // Pages\SearchPage.xaml line 23
                {
                    this.tbSearch = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                }
                break;
            case 7: // Pages\SearchPage.xaml line 32
                {
                    this.btnSearch = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.btnSearch).Click += this.btnSearch_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

