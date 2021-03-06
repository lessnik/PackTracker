﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace PackTracker.Controls.Settings {
  /// <summary>
  /// Interaktionslogik für Credits.xaml
  /// </summary>
  public partial class Credits : MetroContentControl, ITitledElement {
    public string Title => "Credits";

    public Credits() {
      InitializeComponent();
    }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e) {
      System.Diagnostics.Process.Start(e.Uri.ToString());
    }
  }
}
