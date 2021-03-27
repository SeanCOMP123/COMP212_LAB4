using System;
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

namespace COMP212_LAB4_Q2
{
    /// <summary>
    /// Interaction logic for LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }
        public string userName 
        {
            get { return (string)GetValue(userNameproperty); }
            set { SetValue(userNameproperty, value); }
        }
        public static DependencyProperty userNameproperty = DependencyProperty.Register(nameof(userName), typeof(string), typeof(LoginUserControl), new PropertyMetadata(""));

        public string pw
        {
            get { return (string)GetValue(pwProperty); }
            set { SetValue(pwProperty, value); }
        }
        public static DependencyProperty pwProperty = DependencyProperty.Register(nameof(pw), typeof(string), typeof(LoginUserControl), new PropertyMetadata(""));

    }
}
