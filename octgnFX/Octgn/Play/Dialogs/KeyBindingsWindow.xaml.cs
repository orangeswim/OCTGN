// /* This Source Code Form is subject to the terms of the Mozilla Public
//  * License, v. 2.0. If a copy of the MPL was not distributed with this
//  * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using Octgn.Core;
using Octgn.DataNew.Entities;
using Octgn.Utils;
using Octgn.Core.DataExtensionMethods;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Octgn.Play.Dialogs
{

    public partial class KeyBindingsWindow : Window
    {

        public KeyBindingsWindow()
        {
            this.InitializeComponent();
            var size = Prefs.PreviewCardWindowLocation;
            Left = size.Left;
            Top = size.Top;
            Height = size.Height;
            Width = size.Width;
            DataContext = getData();
        }

        private ObservableCollection<string> getData()
        {
            ObservableCollection<string> col = new ObservableCollection<string>();
            col.Add("Hello");
            col.Add("World");
            return col;
        }


        private void Window_Closed(object sender, System.EventArgs e)
        {
            Prefs.PreviewCardWindowLocation = new Rect(Left, Top, ActualWidth, ActualHeight);
        }

    }
}