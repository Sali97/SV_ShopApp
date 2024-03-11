namespace SV_ShopApp
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            panel3 = new Panel();
            btnPay = new Button();
            lblAllSumPrice = new Label();
            groupBox1 = new GroupBox();
            btnMultiAdd = new Button();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 381);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 90;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.False;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(709, 381);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(709, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 381);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Cornsilk;
            groupBox2.Controls.Add(panel3);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 227);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(225, 154);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fizetendő(HUF)";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPay);
            panel3.Controls.Add(lblAllSumPrice);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 112);
            panel3.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(20, 54);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(174, 49);
            btnPay.TabIndex = 3;
            btnPay.Text = "Fizetés";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // lblAllSumPrice
            // 
            lblAllSumPrice.AutoSize = true;
            lblAllSumPrice.Dock = DockStyle.Fill;
            lblAllSumPrice.Location = new Point(0, 0);
            lblAllSumPrice.Margin = new Padding(0);
            lblAllSumPrice.Name = "lblAllSumPrice";
            lblAllSumPrice.Size = new Size(32, 37);
            lblAllSumPrice.TabIndex = 0;
            lblAllSumPrice.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnMultiAdd);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bevitel";
            // 
            // btnMultiAdd
            // 
            btnMultiAdd.Location = new Point(23, 114);
            btnMultiAdd.Name = "btnMultiAdd";
            btnMultiAdd.Size = new Size(174, 49);
            btnMultiAdd.TabIndex = 1;
            btnMultiAdd.Text = "Mennyiség";
            btnMultiAdd.UseVisualStyleBackColor = true;
            btnMultiAdd.Click += btnMultiAdd_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 42);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 43);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 381);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MinimumSize = new Size(950, 420);
            Name = "Form1";
            Text = "S.V. ShopApp";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private GroupBox groupBox2;
        private Panel panel3;
        private Label lblAllSumPrice;
        private GroupBox groupBox1;
        private Button btnMultiAdd;
        private TextBox textBox1;
        private Button btnPay;
    }
}