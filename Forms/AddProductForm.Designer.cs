namespace MarketManager.Forms
{
    partial class AddProductForm
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
            ExitBtn = new Button();
            AddBtn = new Button();
            NameTextBox = new TextBox();
            CategoryTextBox = new TextBox();
            PriceTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitBtn.ForeColor = SystemColors.ButtonHighlight;
            ExitBtn.Location = new Point(476, 427);
            ExitBtn.Margin = new Padding(4, 3, 4, 3);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(139, 78);
            ExitBtn.TabIndex = 6;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Lime;
            AddBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddBtn.ForeColor = SystemColors.ButtonHighlight;
            AddBtn.Location = new Point(24, 427);
            AddBtn.Margin = new Padding(4, 3, 4, 3);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(166, 78);
            AddBtn.TabIndex = 5;
            AddBtn.Text = "Add product";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(24, 70);
            NameTextBox.Margin = new Padding(4, 3, 4, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(390, 23);
            NameTextBox.TabIndex = 7;
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(24, 185);
            CategoryTextBox.Margin = new Padding(4, 3, 4, 3);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(390, 23);
            CategoryTextBox.TabIndex = 7;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(24, 294);
            PriceTextBox.Margin = new Padding(4, 3, 4, 3);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(390, 23);
            PriceTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 8;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(24, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 8;
            label2.Text = "Category";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(24, 263);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 24);
            label3.TabIndex = 8;
            label3.Text = "Price";
            label3.Click += label1_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 519);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PriceTextBox);
            Controls.Add(CategoryTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(ExitBtn);
            Controls.Add(AddBtn);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddProductForm";
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}