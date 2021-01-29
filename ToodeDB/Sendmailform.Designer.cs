namespace ToodeDB
{
	partial class Sendmailform
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
			this.txtle = new System.Windows.Forms.TextBox();
			this.txtteema = new System.Windows.Forms.TextBox();
			this.txtsonum = new System.Windows.Forms.RichTextBox();
			this.sonumbtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.boxle = new System.Windows.Forms.ComboBox();
			this.taiskas = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// txtle
			// 
			this.txtle.Location = new System.Drawing.Point(96, 65);
			this.txtle.Name = "txtle";
			this.txtle.Size = new System.Drawing.Size(100, 20);
			this.txtle.TabIndex = 0;
			// 
			// txtteema
			// 
			this.txtteema.Location = new System.Drawing.Point(96, 100);
			this.txtteema.Name = "txtteema";
			this.txtteema.Size = new System.Drawing.Size(100, 20);
			this.txtteema.TabIndex = 2;
			// 
			// txtsonum
			// 
			this.txtsonum.Location = new System.Drawing.Point(56, 140);
			this.txtsonum.Name = "txtsonum";
			this.txtsonum.Size = new System.Drawing.Size(435, 215);
			this.txtsonum.TabIndex = 3;
			this.txtsonum.Text = "Kirjuta sõnum...";
			// 
			// sonumbtn
			// 
			this.sonumbtn.Location = new System.Drawing.Point(389, 100);
			this.sonumbtn.Name = "sonumbtn";
			this.sonumbtn.Size = new System.Drawing.Size(102, 23);
			this.sonumbtn.TabIndex = 4;
			this.sonumbtn.Text = "Saada sõnum";
			this.sonumbtn.UseVisualStyleBackColor = true;
			this.sonumbtn.Click += new System.EventHandler(this.sonumbtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Kellele";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Kellelt";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Teema";
			// 
			// boxle
			// 
			this.boxle.FormattingEnabled = true;
			this.boxle.Location = new System.Drawing.Point(96, 24);
			this.boxle.Name = "boxle";
			this.boxle.Size = new System.Drawing.Size(121, 21);
			this.boxle.TabIndex = 8;
			
			// 
			// taiskas
			// 
			this.taiskas.AutoSize = true;
			this.taiskas.Location = new System.Drawing.Point(269, 24);
			this.taiskas.Name = "taiskas";
			this.taiskas.Size = new System.Drawing.Size(87, 17);
			this.taiskas.TabIndex = 19;
			this.taiskas.Text = "Täiskasvanu";
			this.taiskas.UseVisualStyleBackColor = true;
			this.taiskas.CheckedChanged += new System.EventHandler(this.taiskas_CheckedChanged);
			// 
			// Sendmailform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(530, 383);
			this.Controls.Add(this.taiskas);
			this.Controls.Add(this.boxle);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sonumbtn);
			this.Controls.Add(this.txtsonum);
			this.Controls.Add(this.txtteema);
			this.Controls.Add(this.txtle);
			this.Name = "Sendmailform";
			this.Text = "Sendmailform";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtle;
		private System.Windows.Forms.TextBox txtteema;
		private System.Windows.Forms.RichTextBox txtsonum;
		private System.Windows.Forms.Button sonumbtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox boxle;
		private System.Windows.Forms.CheckBox taiskas;
	}
}