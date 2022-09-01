namespace SQLite_DBimages
{
    partial class DBimages
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
            this.groupBoxAddUpload = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBoxAddLoad = new System.Windows.Forms.PictureBox();
            this.groupBoxFetch = new System.Windows.Forms.GroupBox();
            this.radioBtnName = new System.Windows.Forms.RadioButton();
            this.radioBtnID = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.pictureBoxFetch = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxAddUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddLoad)).BeginInit();
            this.groupBoxFetch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFetch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddUpload
            // 
            this.groupBoxAddUpload.Controls.Add(this.textBoxName);
            this.groupBoxAddUpload.Controls.Add(this.labelName);
            this.groupBoxAddUpload.Controls.Add(this.btnSave);
            this.groupBoxAddUpload.Controls.Add(this.btnLoad);
            this.groupBoxAddUpload.Controls.Add(this.pictureBoxAddLoad);
            this.groupBoxAddUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddUpload.Location = new System.Drawing.Point(14, 12);
            this.groupBoxAddUpload.Name = "groupBoxAddUpload";
            this.groupBoxAddUpload.Size = new System.Drawing.Size(314, 464);
            this.groupBoxAddUpload.TabIndex = 0;
            this.groupBoxAddUpload.TabStop = false;
            this.groupBoxAddUpload.Text = "Add / Upload Images";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(170, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(28, 407);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 34);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBoxAddLoad
            // 
            this.pictureBoxAddLoad.Location = new System.Drawing.Point(11, 41);
            this.pictureBoxAddLoad.Name = "pictureBoxAddLoad";
            this.pictureBoxAddLoad.Size = new System.Drawing.Size(292, 281);
            this.pictureBoxAddLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddLoad.TabIndex = 0;
            this.pictureBoxAddLoad.TabStop = false;
            // 
            // groupBoxFetch
            // 
            this.groupBoxFetch.Controls.Add(this.radioBtnName);
            this.groupBoxFetch.Controls.Add(this.radioBtnID);
            this.groupBoxFetch.Controls.Add(this.textBoxSearch);
            this.groupBoxFetch.Controls.Add(this.labelSearch);
            this.groupBoxFetch.Controls.Add(this.btnFetch);
            this.groupBoxFetch.Controls.Add(this.pictureBoxFetch);
            this.groupBoxFetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFetch.Location = new System.Drawing.Point(344, 12);
            this.groupBoxFetch.Name = "groupBoxFetch";
            this.groupBoxFetch.Size = new System.Drawing.Size(314, 464);
            this.groupBoxFetch.TabIndex = 1;
            this.groupBoxFetch.TabStop = false;
            this.groupBoxFetch.Text = "Fetch Images";
            // 
            // radioBtnName
            // 
            this.radioBtnName.AutoSize = true;
            this.radioBtnName.Location = new System.Drawing.Point(175, 339);
            this.radioBtnName.Name = "radioBtnName";
            this.radioBtnName.Size = new System.Drawing.Size(73, 24);
            this.radioBtnName.TabIndex = 7;
            this.radioBtnName.TabStop = true;
            this.radioBtnName.Text = "Name";
            this.radioBtnName.UseVisualStyleBackColor = true;
            // 
            // radioBtnID
            // 
            this.radioBtnID.AutoSize = true;
            this.radioBtnID.Checked = true;
            this.radioBtnID.Location = new System.Drawing.Point(85, 339);
            this.radioBtnID.Name = "radioBtnID";
            this.radioBtnID.Size = new System.Drawing.Size(46, 24);
            this.radioBtnID.TabIndex = 6;
            this.radioBtnID.TabStop = true;
            this.radioBtnID.Text = "ID";
            this.radioBtnID.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(83, 373);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(220, 26);
            this.textBoxSearch.TabIndex = 5;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(11, 376);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(66, 20);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Search";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(114, 416);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(99, 34);
            this.btnFetch.TabIndex = 3;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // pictureBoxFetch
            // 
            this.pictureBoxFetch.Location = new System.Drawing.Point(11, 41);
            this.pictureBoxFetch.Name = "pictureBoxFetch";
            this.pictureBoxFetch.Size = new System.Drawing.Size(292, 281);
            this.pictureBoxFetch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFetch.TabIndex = 1;
            this.pictureBoxFetch.TabStop = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(79, 356);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(220, 26);
            this.textBoxName.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(18, 359);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // DBimages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 486);
            this.Controls.Add(this.groupBoxFetch);
            this.Controls.Add(this.groupBoxAddUpload);
            this.Name = "DBimages";
            this.Text = "DB Images Using Sqlite";
            this.groupBoxAddUpload.ResumeLayout(false);
            this.groupBoxAddUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddLoad)).EndInit();
            this.groupBoxFetch.ResumeLayout(false);
            this.groupBoxFetch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFetch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddUpload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pictureBoxAddLoad;
        private System.Windows.Forms.GroupBox groupBoxFetch;
        private System.Windows.Forms.RadioButton radioBtnName;
        private System.Windows.Forms.RadioButton radioBtnID;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.PictureBox pictureBoxFetch;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}

