namespace ToodeDB
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.Nimitxt = new System.Windows.Forms.TextBox();
			this.Teltxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toodetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.database1DataSet = new ToodeDB.Database1DataSet();
			this.toodetableTableAdapter = new ToodeDB.Database1DataSetTableAdapters.ToodetableTableAdapter();
			this.btnLisapilt = new System.Windows.Forms.Button();
			this.picBox = new System.Windows.Forms.PictureBox();
			this.box_ruhm = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.database1DataSet1 = new ToodeDB.Database1DataSet1();
			this.toodetableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.toodetableTableAdapter1 = new ToodeDB.Database1DataSet1TableAdapters.ToodetableTableAdapter();
			this.label2 = new System.Windows.Forms.Label();
			this.gmtxt = new System.Windows.Forms.TextBox();
			this.sonum = new System.Windows.Forms.Button();
			this.vanemadbtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toodetableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.toodetableBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// Nimitxt
			// 
			this.Nimitxt.Location = new System.Drawing.Point(69, 26);
			this.Nimitxt.Name = "Nimitxt";
			this.Nimitxt.Size = new System.Drawing.Size(100, 20);
			this.Nimitxt.TabIndex = 0;
			// 
			// Teltxt
			// 
			this.Teltxt.Location = new System.Drawing.Point(69, 100);
			this.Teltxt.Name = "Teltxt";
			this.Teltxt.Size = new System.Drawing.Size(100, 20);
			this.Teltxt.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nimi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tel";
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(12, 399);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(94, 34);
			this.btnInsert.TabIndex = 6;
			this.btnInsert.Text = "Lisa uus";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(112, 410);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Uuenda";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(193, 410);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Kustutsa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(304, 55);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(634, 319);
			this.dataGridView1.TabIndex = 9;
			// 
			// toodetableBindingSource
			// 
			this.toodetableBindingSource.DataMember = "Toodetable";
			this.toodetableBindingSource.DataSource = this.database1DataSet;
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// toodetableTableAdapter
			// 
			this.toodetableTableAdapter.ClearBeforeFill = true;
			// 
			// btnLisapilt
			// 
			this.btnLisapilt.Location = new System.Drawing.Point(211, 354);
			this.btnLisapilt.Name = "btnLisapilt";
			this.btnLisapilt.Size = new System.Drawing.Size(75, 23);
			this.btnLisapilt.TabIndex = 10;
			this.btnLisapilt.Text = "Lisa pilt";
			this.btnLisapilt.UseVisualStyleBackColor = true;
			this.btnLisapilt.Click += new System.EventHandler(this.btnLisapilt_Click);
			// 
			// picBox
			// 
			this.picBox.Location = new System.Drawing.Point(12, 202);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(193, 180);
			this.picBox.TabIndex = 13;
			this.picBox.TabStop = false;
			// 
			// box_ruhm
			// 
			this.box_ruhm.FormattingEnabled = true;
			this.box_ruhm.Items.AddRange(new object[] {
            "AUTpe20-1 ",
            "AUTpe20-2",
            "KRRpe20",
            "KRRpv20",
            "LOGApe20",
            "LOGApv20-1",
            "LOGApv20-2",
            "LOGITpe20",
            "LOGITpv20",
            "MEHpe20-1 ",
            "MEHpe20-2",
            "MEHpv20-1",
            "MEHpv20-2",
            "MRApe20",
            "SKApe20",
            "TARpe20",
            "TARpv20",
            "TITpe20",
            "TITpv20",
            "AUTpe19-1 distantsõpe",
            "AUTpe19-2",
            "KRRpe19",
            "KRRpv19",
            "LOGApe19",
            "LOGApv19-1",
            "LOGApv19-2",
            "LOGITpe19",
            "LOGITpv19",
            "MEHpe19",
            "MEHpv19-1",
            "MEHpv19-2",
            "MRApe19 ",
            "ROOpe19",
            "ROOpv19",
            "SKApe19",
            "TARpe19",
            "TARpv19",
            "TITpe19",
            "TITpv19",
            "AUTpe18-1",
            "AUTpe18-2",
            "KRRpe18",
            "KRRpv18",
            "LOGApe18",
            "LOGApv18-1",
            "LOGApv18-2",
            "LOGITpe18",
            "LOGITpv18",
            "MEHpe18",
            "MEHpv18",
            "METpe18",
            "MRApe18",
            "ROOpv18",
            "SKApe18",
            "TARpe18",
            "TARpv18",
            "TITpe18",
            "TITpv18",
            "AUMge20",
            "AUTge20",
            "BRBge20-1",
            "JKSge20-1",
            "JKSge20-2",
            "KRRge20",
            "LOGgv20",
            "LOGITge20",
            "LOGITgv20",
            "TARge20",
            "TARgv20",
            "TITge20",
            "TITgv20",
            "VLOGge20",
            "VLOGgv20",
            "EKSgeMS20",
            "FREgvMS20",
            "KYMgeMS20",
            "LMTgeMS20",
            "MEHgeMS20",
            "MEHgvMS20",
            "MÜKgeMS20",
            "ROTgeMS20",
            "SADgeMS20",
            "KRRgeÕ20",
            "NÜRgeÕ20",
            "AUTge19",
            "JKSge19-1",
            "JKSge19-2",
            "KRRge19",
            "LOGITge19",
            "LOGITgv19",
            "MEHgv19",
            "TARge19",
            "TARgv19",
            "VLOGge19",
            "VLOGgv19",
            "ATMgeMS19",
            "KYMgeMS19",
            "MEHgeMS19",
            "MEHgvMS19",
            "MÜKgeMS19",
            "KRRgeÕ19"});
			this.box_ruhm.Location = new System.Drawing.Point(69, 138);
			this.box_ruhm.Name = "box_ruhm";
			this.box_ruhm.Size = new System.Drawing.Size(100, 21);
			this.box_ruhm.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Rühm";
			// 
			// database1DataSet1
			// 
			this.database1DataSet1.DataSetName = "Database1DataSet1";
			this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// toodetableBindingSource1
			// 
			this.toodetableBindingSource1.DataMember = "Toodetable";
			this.toodetableBindingSource1.DataSource = this.database1DataSet1;
			// 
			// toodetableTableAdapter1
			// 
			this.toodetableTableAdapter1.ClearBeforeFill = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Gmail";
			// 
			// gmtxt
			// 
			this.gmtxt.Location = new System.Drawing.Point(69, 61);
			this.gmtxt.Name = "gmtxt";
			this.gmtxt.Size = new System.Drawing.Size(100, 20);
			this.gmtxt.TabIndex = 17;
			// 
			// sonum
			// 
			this.sonum.Location = new System.Drawing.Point(850, 380);
			this.sonum.Name = "sonum";
			this.sonum.Size = new System.Drawing.Size(75, 23);
			this.sonum.TabIndex = 19;
			this.sonum.Text = "Uus sõnum";
			this.sonum.UseVisualStyleBackColor = true;
			this.sonum.Click += new System.EventHandler(this.sonum_Click);
			// 
			// vanemadbtn
			// 
			this.vanemadbtn.Location = new System.Drawing.Point(850, 12);
			this.vanemadbtn.Name = "vanemadbtn";
			this.vanemadbtn.Size = new System.Drawing.Size(75, 23);
			this.vanemadbtn.TabIndex = 20;
			this.vanemadbtn.Text = "Vanemad";
			this.vanemadbtn.UseVisualStyleBackColor = true;
			this.vanemadbtn.Click += new System.EventHandler(this.vanemadbtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 496);
			this.Controls.Add(this.vanemadbtn);
			this.Controls.Add(this.sonum);
			this.Controls.Add(this.gmtxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.box_ruhm);
			this.Controls.Add(this.picBox);
			this.Controls.Add(this.btnLisapilt);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Teltxt);
			this.Controls.Add(this.Nimitxt);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toodetableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.toodetableBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nimitxt;
        private System.Windows.Forms.TextBox Teltxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource toodetableBindingSource;
        private Database1DataSetTableAdapters.ToodetableTableAdapter toodetableTableAdapter;
        private System.Windows.Forms.Button btnLisapilt;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ComboBox box_ruhm;
        private System.Windows.Forms.Label label4;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource toodetableBindingSource1;
        private Database1DataSet1TableAdapters.ToodetableTableAdapter toodetableTableAdapter1;
        private System.Windows.Forms.Button sonumbtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox gmtxt;
		private System.Windows.Forms.Button sonum;
		private System.Windows.Forms.Button vanemadbtn;
	}
}

