using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPOlab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {          
            Click click = new Click(checkBox1);
            Observer observer = new Observer(textBox1, textBox2, click);
            click.CheckClick();
        }
    }
}
