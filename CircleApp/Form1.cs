using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircleTest;

namespace CircleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Circle aCircle;
        private void showButton_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);
            aCircle=new Circle(radius);
            texArea.Text = aCircle.GetPerimeter().ToString();
            label.Text = aCircle.GetArea().ToString();
            txtPerimeter.Text = aCircle.GetDiameter().ToString();
        }
    }
}
