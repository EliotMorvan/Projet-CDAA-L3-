using Projet2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class Form1 : Form
    {

        private static Characters characters;
        private static Planets planets;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projet2.IHM.initForTest(ref planets, ref characters);
            m_Display.Text = characters.ToString();
        }
    }
}
