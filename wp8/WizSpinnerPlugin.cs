using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Info;
using Microsoft.Phone.Controls;
using System.IO.IsolatedStorage;
using System.Windows.Resources;
using System.IO;
using System.Diagnostics;
using phonegap.plugins.wizSpinner;
using System.Windows.Threading;

namespace WPCordovaClassLib.Cordova.Commands
{
    public class WizSpinnerPlugin : BaseCommand
    {
        Popup popup = new Popup();

        public void show(string options)
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                OverLay ovr = new OverLay();
                ovr.Opacity = 0.8;
                this.popup.Child = ovr;
                this.popup.IsOpen = true;    
            });
        }

        public void hide(string options)
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                this.popup.IsOpen = false;
            });
        }
    }
}
