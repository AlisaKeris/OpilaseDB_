namespace ToodeDB
{
	partial class Vanemadform
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.vannimitxt = new System.Windows.Forms.TextBox();
			this.vangmtxt = new System.Windows.Forms.TextBox();
			this.vanteltxt = new System.Windows.Forms.TextBox();
			this.lapsbox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnvanInsert = new System.Windows.Forms.Button();
			this.btnvanUpdate = new System.Windows.Forms.Button();
			this.btnvanDelete = new System.Windows.Forms.Button();
			this.Opilasedbtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(326, 68);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(434, 189);
			this.dataGridView1.TabIndex = 0;
			// 
			// vannimitxt
			// 
			this.vannimitxt.Location = new System.Drawing.Point(127, 48);
			this.vannimitxt.Name = "vannimitxt";
			this.vannimitxt.Size = new System.Drawing.Size(100, 20);
			this.vannimitxt.TabIndex = 1;
			// 
			// vangmtxt
			// 
			this.vangmtxt.Location = new System.Drawing.Point(127, 85);
			this.vangmtxt.Name = "vangmtxt";
			this.vangmtxt.Size = new System.Drawing.Size(100, 20);
			this.vangmtxt.TabIndex = 2;
			// 
			// vanteltxt
			// 
			this.vanteltxt.Location = new System.Drawing.Point(127, 120);
			this.vanteltxt.Name = "vanteltxt";
			this.vanteltxt.Size = new System.Drawing.Size(100, 20);
			this.vanteltxt.TabIndex = 3;
			// 
			// lapsbox
			// 
			this.lapsbox.FormattingEnabled = true;
			this.lapsbox.Location = new System.Drawing.Point(127, 155);
			this.lapsbox.Name = "lapsbox";
			this.lapsbox.Size = new System.Drawing.Size(121, 21);
			this.lapsbox.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(94, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Nimi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(88, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Gmail";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(94, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Tel";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(86, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Laps";
			// 
			// btnvanInsert
			// 
			this.btnvanInsert.Location = new System.Drawing.Point(27, 243);
			this.btnvanInsert.Name = "btnvanInsert";
			this.btnvanInsert.Size = new System.Drawing.Size(94, 34);
			this.btnvanInsert.TabIndex = 9;
			this.btnvanInsert.Text = "Lisa uus";
			this.btnvanInsert.UseVisualStyleBackColor = true;
			this.btnvanInsert.Click += new System.EventHandler(this.btnvanInsert_Click);
			// 
			// btnvanUpdate
			// 
			this.btnvanUpdate.Location = new System.Drawing.Point(137, 254);
			this.btnvanUpdate.Name = "btnvanUpdate";
			this.btnvanUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnvanUpdate.TabIndex = 10;
			this.btnvanUpdate.Text = "Uuenda";
			this.btnvanUpdate.UseVisualStyleBackColor = true;
			this.btnvanUpdate.Click += new System.EventHandler(this.btnvanUpdate_Click);
			// 
			// btnvanDelete
			// 
			this.btnvanDelete.Location = new System.Drawing.Point(218, 254);
			this.btnvanDelete.Name = "btnvanDelete";
			this.btnvanDelete.Size = new System.Drawing.Size(75, 23);
			this.btnvanDelete.TabIndex = 11;
			this.btnvanDelete.Text = "Kustutsa";
			this.btnvanDelete.UseVisualStyleBackColor = true;
			this.btnvanDelete.Click += new System.EventHandler(this.btnvanDelete_Click);
			// 
			// Opilasedbtn
			// 
			this.Opilasedbtn.Location = new System.Drawing.Point(685, 22);
			this.Opilasedbtn.Name = "Opilasedbtn";
			this.Opilasedbtn.Size = new System.Drawing.Size(75, 23);
			this.Opilasedbtn.TabIndex = 12;
			this.Opilasedbtn.Text = "Õpilased";
			this.Opilasedbtn.UseVisualStyleBackColor = true;
			this.Opilasedbtn.Click += new System.EventHandler(this.Opilasedbtn_Click);
			// 
			// Vanemadform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 303);
			this.Controls.Add(this.Opilasedbtn);
			this.Controls.Add(this.btnvanDelete);
			this.Controls.Add(this.btnvanUpdate);
			this.Controls.Add(this.btnvanInsert);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lapsbox);
			this.Controls.Add(this.vanteltxt);
			this.Controls.Add(this.vangmtxt);
			this.Controls.Add(this.vannimitxt);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Vanemadform";
			this.Text = "Vanemadform";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox vannimitxt;
		private System.Windows.Forms.TextBox vangmtxt;
		private System.Windows.Forms.TextBox vanteltxt;
		private System.Windows.Forms.ComboBox lapsbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnvanInsert;
		private System.Windows.Forms.Button btnvanUpdate;
		private System.Windows.Forms.Button btnvanDelete;
		private System.Windows.Forms.Button Opilasedbtn;
	}
}