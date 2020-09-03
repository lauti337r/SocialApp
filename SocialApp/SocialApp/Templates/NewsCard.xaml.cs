using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SocialApp.Templates
{
    /// <summary>
    /// Template of News Card shown on Home Page
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsCard : ContentView
    {
        public NewsCard()
        {
            InitializeComponent();
        }
    }
}