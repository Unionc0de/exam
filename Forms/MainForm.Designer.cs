namespace exam
{
    partial class MainForm
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
            exitBtn = new Button();
            dataGridView1 = new DataGridView();
            seachTextBox = new TextBox();
            searchBtn = new Button();
            manageProduct = new Button();
            manageOrders = new Button();
            sortByAsc = new Button();
            sortByDesc = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Red;
            exitBtn.ForeColor = SystemColors.ButtonHighlight;
            exitBtn.Location = new Point(541, 390);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(99, 48);
            exitBtn.TabIndex = 1;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(516, 348);
            dataGridView1.TabIndex = 2;
            // 
            // seachTextBox
            // 
            seachTextBox.Location = new Point(12, 4);
            seachTextBox.Name = "seachTextBox";
            seachTextBox.Size = new Size(435, 23);
            seachTextBox.TabIndex = 3;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(453, 3);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // manageProduct
            // 
            manageProduct.Location = new Point(541, 4);
            manageProduct.Name = "manageProduct";
            manageProduct.Size = new Size(99, 46);
            manageProduct.TabIndex = 5;
            manageProduct.Text = "Manage Products";
            manageProduct.UseVisualStyleBackColor = true;
            // 
            // manageOrders
            // 
            manageOrders.Location = new Point(541, 56);
            manageOrders.Name = "manageOrders";
            manageOrders.Size = new Size(99, 46);
            manageOrders.TabIndex = 6;
            manageOrders.Text = "Manage orders";
            manageOrders.UseVisualStyleBackColor = true;
            // 
            // sortByAsc
            // 
            sortByAsc.Location = new Point(12, 392);
            sortByAsc.Name = "sortByAsc";
            sortByAsc.Size = new Size(99, 46);
            sortByAsc.TabIndex = 8;
            sortByAsc.Text = "Sort by ASC";
            sortByAsc.UseVisualStyleBackColor = true;
            // 
            // sortByDesc
            // 
            sortByDesc.Location = new Point(117, 392);
            sortByDesc.Name = "sortByDesc";
            sortByDesc.Size = new Size(99, 46);
            sortByDesc.TabIndex = 9;
            sortByDesc.Text = "Sort by DESC";
            sortByDesc.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 450);
            Controls.Add(sortByDesc);
            Controls.Add(sortByAsc);
            Controls.Add(manageOrders);
            Controls.Add(manageProduct);
            Controls.Add(searchBtn);
            Controls.Add(seachTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(exitBtn);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button exitBtn;
        private DataGridView dataGridView1;
        private TextBox seachTextBox;
        private Button searchBtn;
        private Button manageProduct;
        private Button manageOrders;
        private Button sortByAsc;
        private Button sortByDesc;
    }
}
