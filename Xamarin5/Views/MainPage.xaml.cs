using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin5.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            try
            {
                InitializeComponent();
            }catch(Exception a)
            {
                var e = a;
            }
            
        }
    }
}
