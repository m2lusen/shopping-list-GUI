namespace C_GUI_test_shoppingList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            shoppingItemInput = new TextBox();
            AddItem = new Button();
            ListShoppingItems = new ListBox();
            SuspendLayout();
            // 
            // shoppingItemInput
            // 
            shoppingItemInput.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            shoppingItemInput.Location = new Point(15, 15);
            shoppingItemInput.Margin = new Padding(4);
            shoppingItemInput.Name = "shoppingItemInput";
            shoppingItemInput.Size = new Size(229, 27);
            shoppingItemInput.TabIndex = 0;
            // 
            // AddItem
            // 
            AddItem.AccessibleName = "Add Item";
            AddItem.Location = new Point(269, 13);
            AddItem.Margin = new Padding(4);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(87, 29);
            AddItem.TabIndex = 1;
            AddItem.Text = "Add Item";
            AddItem.UseVisualStyleBackColor = true;
            AddItem.Click += AddItem_Click;
            // 
            // ListShoppingItems
            // 
            ListShoppingItems.FormattingEnabled = true;
            ListShoppingItems.ItemHeight = 19;
            ListShoppingItems.Location = new Point(15, 64);
            ListShoppingItems.Name = "ListShoppingItems";
            ListShoppingItems.Size = new Size(341, 479);
            ListShoppingItems.TabIndex = 3;
            ListShoppingItems.DoubleClick += ListShoppingItems_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 570);
            Controls.Add(ListShoppingItems);
            Controls.Add(AddItem);
            Controls.Add(shoppingItemInput);
            Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox shoppingItemInput;
        private Button AddItem;
        private ListBox ListShoppingItems;
    }
}
