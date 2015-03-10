using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication_forGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ай, хорошо нажал!");
            Vertex3d a = new Vertex3d();
            a.X = 1;
            a.Y = 3.4;
            a.Z = 5.0;
            MessageBox.Show("X " + a.X.ToString() + "; Y " + a.Y.ToString() + "; Z " + a.Z.ToString() + ";");
            a.SetToOrigin();
            MessageBox.Show("X " + a.X.ToString() + "; Y " + a.Y.ToString() + "; Z " + a.Z.ToString() + ";");
        }
    }
}
