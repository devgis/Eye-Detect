﻿#pragma checksum "..\..\..\MenubarIconsUserControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2C5DFCF6BB1362ABA33F930D6D76EEBDEDDBC90DF9155EC5E96231F6D08FBB0C"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using GazeTrackerUI;
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


namespace GazeTrackerUI {
    
    
    /// <summary>
    /// MenubarIconsUserControl
    /// </summary>
    public partial class MenubarIconsUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\MenubarIconsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GazeTrackerUI.MenubarIconsUserControl UserControl;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\MenubarIconsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\MenubarIconsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanelIcons;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\MenubarIconsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IconSettings;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MenubarIconsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IconAutotune;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MenubarIconsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IconUDPClient;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MenubarIconsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IconTrackStats;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\MenubarIconsUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image IconDetachVideo;
        
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
            System.Uri resourceLocater = new System.Uri("/GazeTrackerUI;component/menubariconsusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MenubarIconsUserControl.xaml"
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
            this.UserControl = ((GazeTrackerUI.MenubarIconsUserControl)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.StackPanelIcons = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.IconSettings = ((System.Windows.Controls.Image)(target));
            
            #line 14 "..\..\..\MenubarIconsUserControl.xaml"
            this.IconSettings.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Settings);
            
            #line default
            #line hidden
            return;
            case 5:
            this.IconAutotune = ((System.Windows.Controls.Image)(target));
            
            #line 20 "..\..\..\MenubarIconsUserControl.xaml"
            this.IconAutotune.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Autotune);
            
            #line default
            #line hidden
            return;
            case 6:
            this.IconUDPClient = ((System.Windows.Controls.Image)(target));
            
            #line 32 "..\..\..\MenubarIconsUserControl.xaml"
            this.IconUDPClient.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.NetworkClient);
            
            #line default
            #line hidden
            return;
            case 7:
            this.IconTrackStats = ((System.Windows.Controls.Image)(target));
            
            #line 38 "..\..\..\MenubarIconsUserControl.xaml"
            this.IconTrackStats.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.TrackStats);
            
            #line default
            #line hidden
            return;
            case 8:
            this.IconDetachVideo = ((System.Windows.Controls.Image)(target));
            
            #line 44 "..\..\..\MenubarIconsUserControl.xaml"
            this.IconDetachVideo.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DetachVideo);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
