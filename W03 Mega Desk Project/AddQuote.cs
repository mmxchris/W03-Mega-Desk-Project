using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_Mega_Desk_Project
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            InitializeDeskMaterialBox();
            InitializeRushBox();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
        private void InitializeDeskMaterialBox()
        {
            DeskMaterials.Items.AddRange(Enum.GetNames(typeof(deskMaterial)));
        }
        private void InitializeRushBox()
        {
            RushOrder.Items.AddRange(Enum.GetNames(typeof(rushOrder)));
        }

        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                depth.BackColor = Color.Red;
            }
            else
            {
                depth.BackColor = SystemColors.Window;
            }
        }

        private void depth_TextChanged(object sender, EventArgs e)
        {

        }
        private void Width_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBoxWidth = (TextBox)sender;
            string input = textBoxWidth.Text;
            
            if (string.IsNullOrEmpty(input))
            {
                SetInvalidInput(textBoxWidth);
                e.Cancel = true;
                return;
            }

            if (!int.TryParse(input, out int width))
            {
                SetInvalidInput(textBoxWidth);
                e.Cancel = true;
                return;
            }

            if (width < 23 || width > 97)
            {
                SetInvalidInput(textBoxWidth);
                e.Cancel = true;
                return;
            }

            ResetInputStyle(textBoxWidth);
            e.Cancel = false;
        }

        private void SetInvalidInput(TextBox textBox)
        {
            textBox.BackColor = Color.Red;
        }

        private void ResetInputStyle(TextBox textBox)
        {
            textBox.BackColor = SystemColors.Window;
        }

        private void numOfDrawers_TextChanged(object sender, EventArgs e)
        {

        }

        private void RushOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayQuote_Click(object sender, EventArgs e)
        {
            try
            {
            
                MessageBox.Show("Adding " + customerName.Text + "to quotes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred: " + ex.Message, "Error");
            }
        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
