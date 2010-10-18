using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Threading;
using SampleLocalization.Resources;

namespace SampleLocalization
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void FrenchBt_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-CA");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-CA");
            ResetResources();
        }

        private void EnglishBt_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            ResetResources();
        }

        private void ResetResources()
        {
            ((LabelsManagerDynamic)App.Current.Resources["LabelsManagerDynamic"]).ResetResources();
        }

        
    }
}