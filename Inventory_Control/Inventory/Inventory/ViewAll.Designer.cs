namespace Inventory
{
    partial class ViewAll
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
            this.btnback = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productUserControl1 = new Inventory.ProductUserControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(325, 405);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 33);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.productUserControl1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(531, 387);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // productUserControl1
            // 
            this.productUserControl1.Checked = null;
            this.productUserControl1.Count = null;
            this.productUserControl1.Date = null;
            this.productUserControl1.Is_Available = null;
            this.productUserControl1.Location = new System.Drawing.Point(3, 3);
            this.productUserControl1.MyProperty = null;
            this.productUserControl1.Name = "productUserControl1";
            this.productUserControl1.Object = null;
            this.productUserControl1.Original = null;
            this.productUserControl1.Price = null;
            this.productUserControl1.Refurbished = null;
            this.productUserControl1.Size = new System.Drawing.Size(257, 443);
            this.productUserControl1.TabIndex = 0;
            // 
            // ViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ViewAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAll";
            this.Load += new System.EventHandler(this.ViewAll_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ProductUserControl productUserControl1;
    }
}