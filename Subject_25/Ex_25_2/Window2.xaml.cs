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
using System.Windows.Shapes;

namespace Ex_25_2
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            buttonClose_2.Click += ButtonClose_2_Click;
        }

        public Window2(string appInfo) : this()
        {
            textBlockInfo.Text = appInfo;
        }

        private void ButtonClose_2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
