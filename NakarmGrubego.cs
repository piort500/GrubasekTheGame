using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Timer = System.Threading.Timer;

namespace Grubas
{
    public partial class NakarmGrubego : Form
    {
        public NakarmGrubego()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string foodName = insertFood.Text;

            MessageBox.Show("Mniam mniam pyszne "+foodName+".");
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            btnClose.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void question_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            btnClose.Visible = false;
        }


    }
}
