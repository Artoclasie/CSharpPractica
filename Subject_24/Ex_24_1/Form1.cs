using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_24_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int openDocuments = 0;
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    // Создаем новый UserControl вместо ChildForm
                    UserControl newControl = new UserControl();
                    newControl.Dock = DockStyle.Fill;
                    newControl.BackColor = Color.LightBlue;

                    // Добавляем UserControl на форму
                    this.Controls.Add(newControl);

                    // Увеличиваем счетчик открытых документов
                    openDocuments++;
                    break;

                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;

                case "Title":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }
        }

        private void spWin_Click(object sender, EventArgs e)
        {
            spWin.Text="Windows is horizontal";
        }
    }
}
