namespace MarketManager.Forms
{
    partial class UpdateProductForm
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PriceTextBox = new TextBox();
            CategoryTextBox = new TextBox();
            NameTextBox = new TextBox();
            ExitBtn = new Button();
            UpdateBtn = new Button();
            IdTextBox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(18, 317);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 24);
            label3.TabIndex = 14;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(18, 197);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 24);
            label2.TabIndex = 15;
            label2.Text = "Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(18, 89);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 16;
            label1.Text = "Name";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(18, 348);
            PriceTextBox.Margin = new Padding(4, 3, 4, 3);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(390, 23);
            PriceTextBox.TabIndex = 11;
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Location = new Point(18, 239);
            CategoryTextBox.Margin = new Padding(4, 3, 4, 3);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(390, 23);
            CategoryTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(18, 125);
            NameTextBox.Margin = new Padding(4, 3, 4, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(390, 23);
            NameTextBox.TabIndex = 13;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.Red;
            ExitBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ExitBtn.ForeColor = SystemColors.ButtonHighlight;
            ExitBtn.Location = new Point(491, 417);
            ExitBtn.Margin = new Padding(4, 3, 4, 3);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(139, 78);
            ExitBtn.TabIndex = 10;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Lime;
            UpdateBtn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            UpdateBtn.ForeColor = SystemColors.ButtonHighlight;
            UpdateBtn.Location = new Point(22, 417);
            UpdateBtn.Margin = new Padding(4, 3, 4, 3);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(209, 78);
            UpdateBtn.TabIndex = 9;
            UpdateBtn.Text = "Update product";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(18, 46);
            IdTextBox.Margin = new Padding(4, 3, 4, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(390, 23);
            IdTextBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(18, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(27, 24);
            label4.TabIndex = 16;
            label4.Text = "ID";
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 519);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(PriceTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(CategoryTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(ExitBtn);
            Controls.Add(UpdateBtn);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UpdateProductForm";
            Text = "UpdateProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label4;
    }
}