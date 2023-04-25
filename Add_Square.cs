using System;
using System.Windows.Forms;

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
        
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Get_Area_btn_Click(object sender, EventArgs e)
        {
            Shape shape;

            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    throw new Exception("Please fill in all fields.");
                }
                else
                {
                    double side1;

                    if (!double.TryParse(textBox1.Text, out side1) || side1 <= 0)
                    {
                        throw new ArgumentException("Side1 must be a positive number.");
                    }

                    shape = new Square(side1);
                }                

                form1.Shapes_list.Items.Add(shape);

                MessageBox.Show("Shape: " + shape.Name + " successfully added");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
