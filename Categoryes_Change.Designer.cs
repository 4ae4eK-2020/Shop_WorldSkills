
namespace Shop_WorldSkills
{
    partial class Categoryes_Change
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryContext = new Shop_WorldSkills.CategoryContext();
            this.categoryesTableAdapter = new Shop_WorldSkills.CategoryContextTableAdapters.CategoryesTableAdapter();
            this.OldCategoryNameLabel = new System.Windows.Forms.Label();
            this.OldCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.NewCategoryNameLabel = new System.Windows.Forms.Label();
            this.NewCatregoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoryesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(303, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryesBindingSource
            // 
            this.categoryesBindingSource.DataMember = "Categoryes";
            this.categoryesBindingSource.DataSource = this.categoryContext;
            // 
            // categoryContext
            // 
            this.categoryContext.DataSetName = "CategoryContext";
            this.categoryContext.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryesTableAdapter
            // 
            this.categoryesTableAdapter.ClearBeforeFill = true;
            // 
            // OldCategoryNameLabel
            // 
            this.OldCategoryNameLabel.AutoSize = true;
            this.OldCategoryNameLabel.Location = new System.Drawing.Point(318, 64);
            this.OldCategoryNameLabel.Name = "OldCategoryNameLabel";
            this.OldCategoryNameLabel.Size = new System.Drawing.Size(193, 17);
            this.OldCategoryNameLabel.TabIndex = 1;
            this.OldCategoryNameLabel.Text = "Старое название категории";
            // 
            // OldCategoryNameTextBox
            // 
            this.OldCategoryNameTextBox.Location = new System.Drawing.Point(321, 84);
            this.OldCategoryNameTextBox.Name = "OldCategoryNameTextBox";
            this.OldCategoryNameTextBox.Size = new System.Drawing.Size(360, 22);
            this.OldCategoryNameTextBox.TabIndex = 2;
            this.OldCategoryNameTextBox.TextChanged += new System.EventHandler(this.OldCategoryNameTextBox_TextChanged);
            // 
            // NewCategoryNameLabel
            // 
            this.NewCategoryNameLabel.AutoSize = true;
            this.NewCategoryNameLabel.Location = new System.Drawing.Point(318, 117);
            this.NewCategoryNameLabel.Name = "NewCategoryNameLabel";
            this.NewCategoryNameLabel.Size = new System.Drawing.Size(186, 17);
            this.NewCategoryNameLabel.TabIndex = 1;
            this.NewCategoryNameLabel.Text = "Новое название категории";

            // 
            // NewCatregoryNameTextBox
            // 
            this.NewCatregoryNameTextBox.Location = new System.Drawing.Point(321, 137);
            this.NewCatregoryNameTextBox.Name = "NewCatregoryNameTextBox";
            this.NewCatregoryNameTextBox.Size = new System.Drawing.Size(360, 22);
            this.NewCatregoryNameTextBox.TabIndex = 2;
            this.NewCatregoryNameTextBox.TextChanged += new System.EventHandler(this.NewCategoryNameTextBox_TextChanged);
            // 
            // CreateSubmit
            // 
            this.CreateSubmit.Location = new System.Drawing.Point(321, 198);
            this.CreateSubmit.Name = "CreateSubmit";
            this.CreateSubmit.Size = new System.Drawing.Size(359, 58);
            this.CreateSubmit.TabIndex = 3;
            this.CreateSubmit.Text = "Создать";
            this.CreateSubmit.UseVisualStyleBackColor = true;
            this.CreateSubmit.Click += new System.EventHandler(this.CreateSubmit_Click);
            // 
            // Categoryes_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateSubmit);
            this.Controls.Add(this.NewCatregoryNameTextBox);
            this.Controls.Add(this.NewCategoryNameLabel);
            this.Controls.Add(this.OldCategoryNameTextBox);
            this.Controls.Add(this.OldCategoryNameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Categoryes_Change";
            this.Text = "Categoryes_Change";
            this.Load += new System.EventHandler(this.Categoryes_Change_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CategoryContext categoryContext;
        private System.Windows.Forms.BindingSource categoryesBindingSource;
        private CategoryContextTableAdapters.CategoryesTableAdapter categoryesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label OldCategoryNameLabel;
        private System.Windows.Forms.TextBox OldCategoryNameTextBox;
        private System.Windows.Forms.Label NewCategoryNameLabel;
        private System.Windows.Forms.TextBox NewCatregoryNameTextBox;
        private System.Windows.Forms.Button CreateSubmit;
    }
}