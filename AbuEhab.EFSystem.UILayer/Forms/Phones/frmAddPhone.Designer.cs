namespace AbuEhab.EFSystem.UILayer.Forms.Phones
{
	partial class frmAddPhone
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtJawwal = new System.Windows.Forms.TextBox();
			this.txtOoredoo = new System.Windows.Forms.TextBox();
			this.btnOkay = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(96, 52);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(188, 29);
			this.txtName.TabIndex = 0;
			this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtJawwal
			// 
			this.txtJawwal.Location = new System.Drawing.Point(96, 96);
			this.txtJawwal.Name = "txtJawwal";
			this.txtJawwal.Size = new System.Drawing.Size(188, 29);
			this.txtJawwal.TabIndex = 1;
			this.txtJawwal.Text = "0";
			this.txtJawwal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtJawwal.TextChanged += new System.EventHandler(this.txtJawwal_TextChanged);
			this.txtJawwal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJawwal_KeyPress);
			// 
			// txtOoredoo
			// 
			this.txtOoredoo.Location = new System.Drawing.Point(96, 140);
			this.txtOoredoo.Name = "txtOoredoo";
			this.txtOoredoo.Size = new System.Drawing.Size(182, 29);
			this.txtOoredoo.TabIndex = 2;
			this.txtOoredoo.Text = "0";
			this.txtOoredoo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtOoredoo.TextChanged += new System.EventHandler(this.txtOoredoo_TextChanged);
			this.txtOoredoo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOoredoo_KeyPress);
			// 
			// btnOkay
			// 
			this.btnOkay.BackColor = System.Drawing.Color.Green;
			this.btnOkay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOkay.ForeColor = System.Drawing.Color.Yellow;
			this.btnOkay.Location = new System.Drawing.Point(96, 192);
			this.btnOkay.Name = "btnOkay";
			this.btnOkay.Size = new System.Drawing.Size(75, 35);
			this.btnOkay.TabIndex = 3;
			this.btnOkay.Text = "Ok";
			this.btnOkay.UseVisualStyleBackColor = false;
			this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(96, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Add Phone";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 21);
			this.label2.TabIndex = 5;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 21);
			this.label3.TabIndex = 6;
			this.label3.Text = "Jawwal";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "Ooredoo";
			// 
			// frmAddPhone
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(313, 239);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOkay);
			this.Controls.Add(this.txtOoredoo);
			this.Controls.Add(this.txtJawwal);
			this.Controls.Add(this.txtName);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmAddPhone";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.frmAddPhone_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtName;
		private TextBox txtJawwal;
		private TextBox txtOoredoo;
		private Button btnOkay;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
	}
}