using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings
{
    public partial class f_splash : Form
    {
        public f_splash()
        {
            InitializeComponent();

        }
        //Timer => 1 segundo
        private void timer1_Tick(object sender, EventArgs e)
        {
            pbTempo.Value += 10;

            if (pbTempo.Value == 100)
            {
                timer1.Enabled= false;
            
                this.Close();
            }
        }
    }
}
