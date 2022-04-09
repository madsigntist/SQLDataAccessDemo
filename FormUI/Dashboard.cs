namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Product> products = new List<Product>();
        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            itemsFoundListBox.DataSource = products;
            itemsFoundListBox.DisplayMember = "ProductInfo";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            products = db.GetProduct(itemNumberText.Text);
            UpdateBinding();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertProduct(itemNumberText.Text, itemDescriptionText.Text);

            itemNumberText.Text = "";
            itemDescriptionText.Text = "";

        }

        private void showAll_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            products = db.GetProducts();
            UpdateBinding();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteProduct(itemNumberText.Text);    
        }
    }
}