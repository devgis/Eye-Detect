#pragma checksum "..\..\..\..\Calibration\CalibrationPoint.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ABD6D6AB3C09DAA63A3C9E781BFB1A34EE7E8AA02977C2FF89A546BAF33BACC8"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using System.Windows.Forms.Integration;
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


namespace GazeTrackerUI.CalibrationUI {
    
    
    /// <summary>
    /// CalibrationPoint
    /// </summary>
    public partial class CalibrationPoint : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\Calibration\CalibrationPoint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TargetGrid;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Calibration\CalibrationPoint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Image;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Calibration\CalibrationPoint.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse Target;
        
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
            System.Uri resourceLocater = new System.Uri("/GazeTrackerUI;component/calibration/calibrationpoint.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Calibration\CalibrationPoint.xaml"
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
            this.TargetGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 40 "..\..\..\..\Calibration\CalibrationPoint.xaml"
            this.TargetGrid.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.OnMouseRightDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Image = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.Target = ((System.Windows.Shapes.Ellipse)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

