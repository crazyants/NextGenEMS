#pragma checksum "..\..\..\Frontend\PatientInfoEditor.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FD5BB9107BB3E8A269D1E19A85092C37F3D30AB5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NextGenEMS.Frontend;
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


namespace NextGenEMS.Frontend
{


    /// <summary>
    /// PatientInfoEditor
    /// </summary>
    public partial class PatientInfoEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 10 "..\..\..\Frontend\PatientInfoEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox Demographics;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NextGenEMS;component/frontend/patientinfoeditor.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Frontend\PatientInfoEditor.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.PatientInfoWindow = ((NextGenEMS.Frontend.PatientInfoEditor)(target));
                    return;
                case 2:
                    this.Demographics = ((System.Windows.Controls.GroupBox)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window PatientInfoWindow;
        internal System.Windows.Controls.TextBox LastNameTextbox_Copy;
        internal System.Windows.Controls.TextBox LastNameTextbox_Copy1;
        internal System.Windows.Controls.TextBox LastNameTextbox_Copy2;
        internal System.Windows.Controls.TextBox LastNameTextbox_Copy3;
        internal System.Windows.Controls.TextBox LastNameTextbox_Copy4;
        internal System.Windows.Controls.TextBox LastNameTextbox_Copy5;
        internal System.Windows.Controls.TextBox LastNameTextbox_Copy6;
        internal System.Windows.Controls.GroupBox Demographics_Copy;
    }
}

