using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab11
{
    public partial class Add_Square : Form
    {
        private Form1 form1;
        public Add_Square(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        Shape shape;

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Get_Area_btn_Click(object sender, EventArgs e)
        {
            shape = new Square()
            {
                Side1 = double.Parse(textBox1.Text)
            };

            form1.Shapes_list.Items.Add(shape.GetProperty());

            MessageBox.Show("Area of the " + shape.Name + " = " + shape.CalculateArea());

            this.Close();
        }
    }
}
