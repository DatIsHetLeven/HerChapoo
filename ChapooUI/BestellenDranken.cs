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
    public partial class BestellenDranken : Form
    {
        int TableId;
        public BestellenDranken(int tableId)
        {
            InitializeComponent();
        }

        private void Btn_GoDiner_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDiner bestellenDiner = new BestellenDiner(TableId);
            bestellenDiner.ShowDialog();
            this.Close();
        }

        private void btn_Go_Lunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDiner bestellenDiner = new BestellenDiner(TableId);
            bestellenDiner.ShowDialog();
            this.Close();
        }
    }
}
