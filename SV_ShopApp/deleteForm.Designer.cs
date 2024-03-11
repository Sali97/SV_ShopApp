namespace SV_ShopApp
{
    partial class deleteForm
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
            lblMessage = new Label();
            btnDelAll = new Button();
            btnDelOne = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(0, 0);
            lblMessage.Margin = new Padding(0, 0, 3, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(554, 160);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "label1";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDelAll
            // 
            btnDelAll.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelAll.Location = new Point(3, 3);
            btnDelAll.Name = "btnDelAll";
            btnDelAll.Size = new Size(174, 49);
            btnDelAll.TabIndex = 4;
            btnDelAll.Text = "Mind törlése";
            btnDelAll.UseVisualStyleBackColor = true;
            btnDelAll.Click += btnDelAll_Click;
            // 
            // btnDelOne
            // 
            btnDelOne.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelOne.Location = new Point(183, 3);
            btnDelOne.Name = "btnDelOne";
            btnDelOne.Size = new Size(188, 49);
            btnDelOne.TabIndex = 5;
            btnDelOne.Text = "Egy  törlése";
            btnDelOne.UseVisualStyleBackColor = true;
            btnDelOne.Click += btnDelOne_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(377, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(174, 49);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Mégse";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelOne);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnDelAll);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 61);
            panel1.TabIndex = 7;
            // 
            // deleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 221);
            Controls.Add(lblMessage);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(570, 260);
            MinimumSize = new Size(570, 260);
            Name = "deleteForm";
            Text = "Termék törlése";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblMessage;
        private Button btnDelAll;
        private Button btnDelOne;
        private Button btnCancel;
        private Panel panel1;
    }
}