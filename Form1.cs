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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Shape shape;

        private void Add_Quadrilateral_btn_Click(object sender, EventArgs e)
        {
            Add_Quadrilateral add_Quadrilateral = new Add_Quadrilateral(this);
            add_Quadrilateral.Show();
        }

        private void Add_Parallelogram_btn_Click(object sender, EventArgs e)
        {
            Add_Parallelogram add_Parallelogram = new Add_Parallelogram(this);
            add_Parallelogram.Show();
        }

        private void Add_Rhombus_btn_Click(object sender, EventArgs e)
        {
            Add_Rhombus add_Rhombus = new Add_Rhombus(this);
            add_Rhombus.Show();
        }

        private void Add_Rectangle_btn_Click(object sender, EventArgs e)
        {
            Add_Rectangle add_Rectangle = new Add_Rectangle(this);
            add_Rectangle.Show();
        }

        private void Add_Square_btn_Click(object sender, EventArgs e)
        {
            Add_Square add_Square = new Add_Square(this);
            add_Square.Show();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_list_btn_Click(object sender, EventArgs e)
        {
            Shapes_list.Items.Clear();
        }

        private void Sort_btn_Click(object sender, EventArgs e)
        {
            Shapes_list.Sorted = true;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (Shapes_list.SelectedItems.Count == 0)
                return;
            while (Shapes_list.SelectedItems.Count > 0)
            {
                Shapes_list.Items.Remove(Shapes_list.SelectedItems[0]);
            }
        }
    }
}
