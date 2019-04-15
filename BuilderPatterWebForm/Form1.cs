using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderPatterWebForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Yellow, 5);
            PersonThinBuilder ptb = new PersonThinBuilder(pictureBox1.CreateGraphics(), pen);
            PersionDirector pdThin = new PersionDirector(ptb);
            pdThin.CreatePerson();
        }
    }
}
