using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
using System.Windows.Shapes;
using System.Windows.Forms;

namespace DXApplication1
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void listBox_Initialized(object sender, EventArgs e)
        {
            string add = "";
            List<string> registerItems = new List<string>();

            for(int i = 1; i <= 100; i++ )
            {
                InitializeComponent();

                if(i % 3 == 0)
                {
                    add += " Register";
                }
                if(i % 5 == 0)
                {
                    add += " Patient";
                }
                if((i % 3 != 0) && ( i % 5 != 0))
                {
                    add += i.ToString();
                }

                add += "\n";
                
            }

            textBlock.Text = add;
        }
    }
}
