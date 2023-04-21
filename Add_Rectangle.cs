using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Add_Rectangle : Form
    {
        private Form1 form1;
        public Add_Rectangle(Form1 form1)
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
            shape = new Rectangle()
            {
                Side1 = double.Parse(textBox1.Text),
                Side2 = double.Parse(textBox2.Text)
            };

            form1.Shapes_list.Items.Add(shape.GetProperty());

            MessageBox.Show("Area of the " + shape.Name + " = " + shape.CalculateArea());

            this.Close();
        }
    }
}
