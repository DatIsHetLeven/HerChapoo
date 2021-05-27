using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class BestellenDiner : Form
    {
        int TableId;
        public BestellenDiner(int tableid)
        {
            this.TableId = tableid;
            InitializeComponent();
        }

        private void btn_Go_Lunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bestellen bestellen = new Bestellen(TableId);
            bestellen.ShowDialog();
            this.Close();

        }

        private void btn_Go_Drinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDranken bestellenDranken = new BestellenDranken(TableId);
            bestellenDranken.ShowDialog();
            this.Close();
        }
    }
}
