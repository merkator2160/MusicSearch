namespace MusicSearch.Forms
{
	partial class AlbumSearchForm
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
			if(disposing && (components != null))
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
			this.SearchBtn = new System.Windows.Forms.Button();
			this.QueryTb = new System.Windows.Forms.TextBox();
			this.searchResultTb = new System.Windows.Forms.TextBox();
			this.EnterGroupNameLbl = new System.Windows.Forms.Label();
			this.AlbumsLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SearchBtn
			// 
			this.SearchBtn.Location = new System.Drawing.Point(547, 29);
			this.SearchBtn.Name = "SearchBtn";
			this.SearchBtn.Size = new System.Drawing.Size(75, 23);
			this.SearchBtn.TabIndex = 0;
			this.SearchBtn.Text = "Search";
			this.SearchBtn.UseVisualStyleBackColor = true;
			this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
			// 
			// QueryTb
			// 
			this.QueryTb.Location = new System.Drawing.Point(12, 31);
			this.QueryTb.Name = "QueryTb";
			this.QueryTb.Size = new System.Drawing.Size(529, 20);
			this.QueryTb.TabIndex = 1;
			// 
			// searchResultTb
			// 
			this.searchResultTb.Location = new System.Drawing.Point(12, 79);
			this.searchResultTb.Multiline = true;
			this.searchResultTb.Name = "searchResultTb";
			this.searchResultTb.Size = new System.Drawing.Size(610, 320);
			this.searchResultTb.TabIndex = 2;
			// 
			// EnterGroupNameLbl
			// 
			this.EnterGroupNameLbl.AutoSize = true;
			this.EnterGroupNameLbl.Location = new System.Drawing.Point(12, 15);
			this.EnterGroupNameLbl.Name = "EnterGroupNameLbl";
			this.EnterGroupNameLbl.Size = new System.Drawing.Size(94, 13);
			this.EnterGroupNameLbl.TabIndex = 3;
			this.EnterGroupNameLbl.Text = "Enter group name:";
			// 
			// AlbumsLbl
			// 
			this.AlbumsLbl.AutoSize = true;
			this.AlbumsLbl.Location = new System.Drawing.Point(12, 63);
			this.AlbumsLbl.Name = "AlbumsLbl";
			this.AlbumsLbl.Size = new System.Drawing.Size(44, 13);
			this.AlbumsLbl.TabIndex = 4;
			this.AlbumsLbl.Text = "Albums:";
			// 
			// AlbumSearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 411);
			this.Controls.Add(this.AlbumsLbl);
			this.Controls.Add(this.EnterGroupNameLbl);
			this.Controls.Add(this.searchResultTb);
			this.Controls.Add(this.QueryTb);
			this.Controls.Add(this.SearchBtn);
			this.MaximumSize = new System.Drawing.Size(650, 450);
			this.MinimumSize = new System.Drawing.Size(650, 450);
			this.Name = "AlbumSearchForm";
			this.Text = "Album search";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SearchBtn;
		private System.Windows.Forms.TextBox QueryTb;
		private System.Windows.Forms.TextBox searchResultTb;
		private System.Windows.Forms.Label EnterGroupNameLbl;
		private System.Windows.Forms.Label AlbumsLbl;
	}
}

