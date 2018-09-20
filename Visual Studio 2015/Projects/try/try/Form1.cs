using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Form1 form = new Form1();
            //form.Load += Form_Load;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("im loaded");
            
        }

        private void Button_Adip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("im clicked");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_Adip.Click += Button_Adip_Click;
        }
    }
}
