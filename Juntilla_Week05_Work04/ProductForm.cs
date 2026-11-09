using System;
using System.Windows.Forms;

namespace Juntilla_Week05_Work04
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

            btnSave.Click += btnSave_Click;
            btnClear.Click += btnClear_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal cost;
            decimal price;
            decimal markup;

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show(
                    "Barcode and name are required.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!decimal.TryParse(tbCost.Text, out cost) ||
                !decimal.TryParse(tbPrice.Text, out price) ||
                !decimal.TryParse(tbMarkup.Text, out markup))
            {
                MessageBox.Show(
                    "Cost, price, and markup must be valid numbers.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string origin = rblocal.Checked ? "Local" :
                            rbabroad.Checked ? "Abroad" : "Not specified";

            ProductRecord product = new ProductRecord
            {
                Barcode = textBox1.Text.Trim(),
                Name = textBox2.Text.Trim(),
                Description = textBox3.Text.Trim(),
                Category = comboBox1.Text.Trim(),
                Origin = origin,
                IsActive = cbActive.Checked,
                Cost = cost,
                Price = price,
                Markup = markup
            };

            List.Products.Add(product);

            MessageBox.Show(
                "Product added successfully.",
                "Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            using (List productList = new List())
            {
                productList.ShowDialog();
                this.Hide();
            }

            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            tbCost.Clear();
            tbPrice.Clear();
            tbMarkup.Clear();
            cbActive.Checked = false;
            rblocal.Checked = false;
            rbabroad.Checked = false;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }
    }
}
