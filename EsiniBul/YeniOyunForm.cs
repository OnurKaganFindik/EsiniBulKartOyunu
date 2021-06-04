using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsiniBul
{
    public partial class YeniOyunForm : Form
    {
        public YeniOyunForm()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            ZorlukSeviye zs = rbKolay.Checked ? ZorlukSeviye.Kolay : (rbOrta.Checked ? ZorlukSeviye.Orta : ZorlukSeviye.Zor);
            Hide();
            Form1 frmOyun = new Form1(zs);
            frmOyun.Show(this);
        }
    }
}
