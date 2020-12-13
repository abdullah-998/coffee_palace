namespace CoffeeShop
{
    partial class UpdateItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textITID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpitem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textItPrice = new System.Windows.Forms.TextBox();
            this.txtItname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textITID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonUpitem);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textItPrice);
            this.panel1.Controls.Add(this.txtItname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 438);
            this.panel1.TabIndex = 0;
            // 
            // textITID
            // 
            this.textITID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textITID.Location = new System.Drawing.Point(144, 84);
            this.textITID.Name = "textITID";
            this.textITID.Size = new System.Drawing.Size(384, 31);
            this.textITID.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(140, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Item ID";
            // 
            // buttonUpitem
            // 
            this.buttonUpitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(252)))), ((int)(((byte)(136)))));
            this.buttonUpitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpitem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpitem.ForeColor = System.Drawing.Color.White;
            this.buttonUpitem.Location = new System.Drawing.Point(410, 261);
            this.buttonUpitem.Name = "buttonUpitem";
            this.buttonUpitem.Size = new System.Drawing.Size(118, 38);
            this.buttonUpitem.TabIndex = 31;
            this.buttonUpitem.Text = "Update Item";
            this.buttonUpitem.UseVisualStyleBackColor = false;
            this.buttonUpitem.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(140, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Item Price";
            // 
            // textItPrice
            // 
            this.textItPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textItPrice.Location = new System.Drawing.Point(144, 207);
            this.textItPrice.Name = "textItPrice";
            this.textItPrice.Size = new System.Drawing.Size(384, 31);
            this.textItPrice.TabIndex = 28;
            // 
            // txtItname
            // 
            this.txtItname.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItname.Location = new System.Drawing.Point(144, 140);
            this.txtItname.Name = "txtItname";
            this.txtItname.Size = new System.Drawing.Size(384, 31);
            this.txtItname.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(140, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Item Name";
            // 
            // UpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UpdateItem";
            this.Size = new System.Drawing.Size(700, 438);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonUpitem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textItPrice;
        private System.Windows.Forms.TextBox txtItname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textITID;
        private System.Windows.Forms.Label label1;
    }
}
