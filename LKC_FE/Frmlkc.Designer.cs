using static Wisej.Web.JavaScript;

namespace LKC_FE
{
	partial class frmlkc
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

		#region Wisej.NET Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Wisej.Web.JavaScript.ClientEvent clientEvent1 = new Wisej.Web.JavaScript.ClientEvent();
            this.dataRepeater1 = new Wisej.Web.DataRepeater();
            this.tahunTerbit = new Wisej.Web.Label();
            this.label3 = new Wisej.Web.Label();
            this.description = new Wisej.Web.Label();
            this.label2 = new Wisej.Web.Label();
            this.label1 = new Wisej.Web.Label();
            this.imageCoverBuku = new Wisej.Web.PictureBox();
            this.namaBuku = new Wisej.Web.Label();
            this.txtsearch = new Wisej.Web.TagTextBox();
            this.btnSearch = new Wisej.Web.Button();
            this.label4 = new Wisej.Web.Label();
            this.authorby = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).BeginInit();
            this.dataRepeater1.ItemTemplate.SuspendLayout();
            this.dataRepeater1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCoverBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // dataRepeater1
            // 
            this.dataRepeater1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dataRepeater1.ItemHeaderVisible = true;
            this.dataRepeater1.ItemSize = new System.Drawing.Size(200, 279);
            // 
            // dataRepeater1.ItemTemplate
            // 
            this.dataRepeater1.ItemTemplate.Controls.Add(this.authorby);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label4);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.tahunTerbit);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label3);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.description);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label2);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.label1);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.imageCoverBuku);
            this.dataRepeater1.ItemTemplate.Controls.Add(this.namaBuku);
            this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(917, 279);
            this.dataRepeater1.Location = new System.Drawing.Point(20, 63);
            this.dataRepeater1.Name = "dataRepeater1";
            this.dataRepeater1.Size = new System.Drawing.Size(919, 440);
            this.dataRepeater1.TabIndex = 1;
            this.dataRepeater1.Text = "dataRepeater1";
            // 
            // tahunTerbit
            // 
            this.tahunTerbit.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tahunTerbit.ForeColor = System.Drawing.Color.FromName("@invalid");
            this.tahunTerbit.Location = new System.Drawing.Point(347, 64);
            this.tahunTerbit.Name = "tahunTerbit";
            this.tahunTerbit.Size = new System.Drawing.Size(104, 26);
            this.tahunTerbit.TabIndex = 6;
            this.tahunTerbit.Text = "tahunTerbit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(234, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Publication Year";
            // 
            // description
            // 
            this.description.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.description.Font = new System.Drawing.Font("default, Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.ForeColor = System.Drawing.Color.FromName("@buttonPressed");
            this.description.Location = new System.Drawing.Point(234, 147);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(651, 124);
            this.description.TabIndex = 4;
            this.description.Text = "description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(233, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(234, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Title";
            // 
            // imageCoverBuku
            // 
            this.imageCoverBuku.Location = new System.Drawing.Point(14, 18);
            this.imageCoverBuku.Name = "imageCoverBuku";
            this.imageCoverBuku.Size = new System.Drawing.Size(206, 253);
            this.imageCoverBuku.SizeMode = Wisej.Web.PictureBoxSizeMode.Cover;
            // 
            // namaBuku
            // 
            this.namaBuku.Font = new System.Drawing.Font("default, Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namaBuku.ForeColor = System.Drawing.Color.Indigo;
            this.namaBuku.Location = new System.Drawing.Point(235, 37);
            this.namaBuku.Name = "namaBuku";
            this.namaBuku.Size = new System.Drawing.Size(644, 26);
            this.namaBuku.TabIndex = 0;
            this.namaBuku.Text = "namaBuku1";
            // 
            // txtsearch
            // 
            this.txtsearch.AutoComplete = Wisej.Web.AutoComplete.Off;
            this.txtsearch.AutoSize = false;
            clientEvent1.Event = "focusout";
            clientEvent1.JavaScript = "var text = this.__getFieldText();\r\n    if (text) {\r\n        this.__addTag(this.__" +
    "getFieldText());\r\n        this.__setFieldText(\"\");\r\n        e.stop();\r\n    }";
            this.txtsearch.ClientEvents.Add(clientEvent1);
            this.txtsearch.EnableNativeContextMenu = false;
            this.txtsearch.KeepWatermark = true;
            this.txtsearch.Label.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtsearch.Label.Position = Wisej.Web.LabelPosition.Left;
            this.txtsearch.LabelText = "Search Book";
            this.txtsearch.Location = new System.Drawing.Point(20, 23);
            this.txtsearch.MaxTagCount = 3;
            this.txtsearch.MinFieldLength = 40;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(539, 24);
            this.txtsearch.TabIndex = 8;
            this.txtsearch.Watermark = "Book Title/Year/Author";
            this.txtsearch.WordWrap = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromName("@focusFrame");
            this.btnSearch.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.btnSearch.ImageSource = "icon-search";
            this.btnSearch.Location = new System.Drawing.Point(564, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 24);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(234, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Author By";
            // 
            // authorby
            // 
            this.authorby.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.authorby.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.authorby.Location = new System.Drawing.Point(347, 96);
            this.authorby.Name = "authorby";
            this.authorby.Size = new System.Drawing.Size(558, 16);
            this.authorby.TabIndex = 9;
            this.authorby.Text = "Author By";
            // 
            // frmlkc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 530);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataRepeater1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
            this.Name = "frmlkc";
            this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
            this.Text = "LKC Library Dashboard";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmlkc_Load);
            this.Appear += new System.EventHandler(this.frmlkc_Appear);
            this.dataRepeater1.ItemTemplate.ResumeLayout(false);
            this.dataRepeater1.ItemTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).EndInit();
            this.dataRepeater1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCoverBuku)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion
        private Wisej.Web.DataRepeater dataRepeater1;
        private Wisej.Web.Label namaBuku;
        private Wisej.Web.PictureBox imageCoverBuku;
        private Wisej.Web.Label description;
        private Wisej.Web.Label label2;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label tahunTerbit;
        private Wisej.Web.Label label3;
        private Wisej.Web.TagTextBox txtsearch;
        private Wisej.Web.Button btnSearch;
        private Wisej.Web.Label authorby;
        private Wisej.Web.Label label4;
    }
}

