namespace MarketManager.Forms
{
    partial class ProductListForm
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
            dataGridView1 = new DataGridView();
            RefreshBtn = new Button();
            ExitBtn = new Button();
            SortByPriceButton = new Button();
            SortByNameButton = new Button();
            SortByCategoryButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 35);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(823, 376);
            dataGridView1.TabIndex = 0;
            // 
            // RefreshBtn
            // 
            RefreshBtn.BackColor = Color.Lime;
            RefreshBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RefreshBtn.ForeColor = SystemColors.ButtonHighlight;
            RefreshBtn.Location = new Point(30, 427);
            RefreshBtn.Margin = new Padding(4, 3, 4, 3);
            RefreshBtn.Name = "RefreshBtn";
            RefreshBtn.Size = new Size(166, 78);
            RefreshBtn.TabIndex = 3;
            RefreshBtn.Text = "Refresh";
            RefreshBtn.UseVisualStyleBackColor = false;
            RefreshBtn.Click += RefreshBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitBtn.ForeColor = SystemColors.ButtonHighlight;
            ExitBtn.Location = new Point(714, 427);
            ExitBtn.Margin = new Padding(4, 3, 4, 3);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(139, 78);
            ExitBtn.TabIndex = 4;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // SortByPriceButton
            // 
            SortByPriceButton.BackColor = Color.Lime;
            SortByPriceButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SortByPriceButton.ForeColor = SystemColors.ButtonHighlight;
            SortByPriceButton.Location = new Point(540, 427);
            SortByPriceButton.Margin = new Padding(4, 3, 4, 3);
            SortByPriceButton.Name = "SortByPriceButton";
            SortByPriceButton.Size = new Size(166, 78);
            SortByPriceButton.TabIndex = 5;
            SortByPriceButton.Text = "Sort By Price";
            SortByPriceButton.UseVisualStyleBackColor = false;
            SortByPriceButton.Click += SortByPriceButton_Click;
            // 
            // SortByNameButton
            // 
            SortByNameButton.BackColor = Color.Lime;
            SortByNameButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SortByNameButton.ForeColor = SystemColors.ButtonHighlight;
            SortByNameButton.Location = new Point(200, 427);
            SortByNameButton.Margin = new Padding(4, 3, 4, 3);
            SortByNameButton.Name = "SortByNameButton";
            SortByNameButton.Size = new Size(166, 78);
            SortByNameButton.TabIndex = 6;
            SortByNameButton.Text = "Sort By Name";
            SortByNameButton.UseVisualStyleBackColor = false;
            SortByNameButton.Click += SortByNameButton_Click;
            // 
            // SortByCategoryButton
            // 
            SortByCategoryButton.BackColor = Color.Lime;
            SortByCategoryButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SortByCategoryButton.ForeColor = SystemColors.ButtonHighlight;
            SortByCategoryButton.Location = new Point(370, 427);
            SortByCategoryButton.Margin = new Padding(4, 3, 4, 3);
            SortByCategoryButton.Name = "SortByCategoryButton";
            SortByCategoryButton.Size = new Size(166, 78);
            SortByCategoryButton.TabIndex = 7;
            SortByCategoryButton.Text = "Sort By Category";
            SortByCategoryButton.UseVisualStyleBackColor = false;
            SortByCategoryButton.Click += SortByCategoryButton_Click;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 519);
            Controls.Add(SortByCategoryButton);
            Controls.Add(SortByNameButton);
            Controls.Add(SortByPriceButton);
            Controls.Add(ExitBtn);
            Controls.Add(RefreshBtn);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductListForm";
            Text = "ProductList";
            Load += ProductListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ExitBtn;
        private Button SortByPriceButton;
        private Button SortByNameButton;
        private Button SortByCategoryButton;
    }
}