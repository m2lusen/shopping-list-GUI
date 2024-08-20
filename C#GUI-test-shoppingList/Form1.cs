namespace C_GUI_test_shoppingList {
    public partial class Form1 : Form
    {
        List<string> shoppingItems = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            shoppingItems.Add(shoppingItemInput.Text);

            ListShoppingItems.DataSource = null;
            ListShoppingItems.DataSource = shoppingItems;
        }

        private void ListShoppingItems_DoubleClick(object sender, EventArgs e) {
            shoppingItems.RemoveAt(ListShoppingItems.SelectedIndex);
            
            ListShoppingItems.DataSource = null;
            ListShoppingItems.DataSource = shoppingItems;
        }
    }
}
