using System;
using System.Windows.Forms;

namespace Juntilla_Week05_Work04
{
    public partial class List : Form
    {
        public static readonly System.Collections.Generic.List<ProductRecord> Products =
            new System.Collections.Generic.List<ProductRecord>();

        public List()
        {
            InitializeComponent();
        }

        private void List_Load_1(object sender, EventArgs e)
        {
            DisplayProductInformation();
        }

        private void DisplayProductInformation()
        {
            if (Products.Count == 0)
            {
                label2.Text = "No product added";
                label4.Text = "No product added";
                label6.Text = "No product added";
                label8.Text = "No product added";
                label10.Text = "No product added";
                label12.Text = "No product added";
                label14.Text = "No product added";
                label16.Text = "No product added";
                label18.Text = "No product added";

                return;
            }

            ProductRecord product = Products[Products.Count - 1];

            label2.Text = product.Barcode;
            label4.Text = product.Name;
            label6.Text = product.Description;
            label8.Text = product.Category;
            label10.Text = product.Origin;
            label12.Text = product.IsActive ? "Active" : "Inactive";
            label14.Text = product.Cost.ToString("0.00");
            label16.Text = product.Price.ToString("0.00");
            label18.Text = product.Markup.ToString("0.00") + "%";

            Text = "Product Information";
            label19.Text = "Product Information";
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }
    }

    public class ProductRecord
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Origin { get; set; }
        public bool IsActive { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public decimal Markup { get; set; }
    }
}
