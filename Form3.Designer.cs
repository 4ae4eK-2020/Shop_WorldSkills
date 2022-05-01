
namespace Shop_WorldSkills
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.users = new Shop_WorldSkills.Users();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Category = new System.Windows.Forms.Button();
            this.Product = new System.Windows.Forms.Button();
            this.Order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // users
            // 
            this.users.DataSetName = "Users";
            this.users.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = this.users;
            this.usersBindingSource.Position = 0;
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Consolas", 14F);
            this.Category.Location = new System.Drawing.Point(136, 109);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(494, 89);
            this.Category.TabIndex = 0;
            this.Category.Text = "Категорию";
            this.Category.UseVisualStyleBackColor = true;
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Consolas", 14F);
            this.Product.Location = new System.Drawing.Point(136, 204);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(494, 89);
            this.Product.TabIndex = 0;
            this.Product.Text = "Продукт";
            this.Product.UseVisualStyleBackColor = true;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // Order
            // 
            this.Order.Font = new System.Drawing.Font("Consolas", 14F);
            this.Order.Location = new System.Drawing.Point(136, 299);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(494, 89);
            this.Order.TabIndex = 0;
            this.Order.Text = "Заказ";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F);
            this.label1.Location = new System.Drawing.Point(190, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите что хотите изменить";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Category);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Users users;
        private System.Windows.Forms.Button Category;
        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Label label1;
    }
}