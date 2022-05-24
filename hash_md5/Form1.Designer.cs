namespace hash_md5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hashedText = new System.Windows.Forms.TextBox();
            this.getHash = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sourceText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.hashedText, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.getHash, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.file, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.reset, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.864989F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.30664F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.20103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.43814F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72998F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.30664F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 776);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(36, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "write a text or choose a txt file by clicking File button below";
            // 
            // sourceText
            // 
            this.sourceText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sourceText.Location = new System.Drawing.Point(11, 68);
            this.sourceText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sourceText.Multiline = true;
            this.sourceText.Name = "sourceText";
            this.sourceText.Size = new System.Drawing.Size(676, 112);
            this.sourceText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(247, 370);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "the path is: none";
            // 
            // hashedText
            // 
            this.hashedText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hashedText.Location = new System.Drawing.Point(11, 546);
            this.hashedText.Multiline = true;
            this.hashedText.Name = "hashedText";
            this.hashedText.Size = new System.Drawing.Size(676, 112);
            this.hashedText.TabIndex = 3;
            // 
            // getHash
            // 
            this.getHash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.getHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(147)))));
            this.getHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getHash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getHash.Location = new System.Drawing.Point(269, 448);
            this.getHash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getHash.Name = "getHash";
            this.getHash.Size = new System.Drawing.Size(160, 78);
            this.getHash.TabIndex = 0;
            this.getHash.Text = "Get hash";
            this.getHash.UseVisualStyleBackColor = false;
            this.getHash.Click += new System.EventHandler(this.getHash_Click);
            // 
            // file
            // 
            this.file.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(79)))), ((int)(((byte)(213)))));
            this.file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.file.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.file.Location = new System.Drawing.Point(287, 241);
            this.file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(125, 57);
            this.file.TabIndex = 4;
            this.file.Text = "File";
            this.file.UseVisualStyleBackColor = false;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // reset
            // 
            this.reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(79)))), ((int)(((byte)(213)))));
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reset.Location = new System.Drawing.Point(285, 703);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(129, 43);
            this.reset.TabIndex = 6;
            this.reset.Text = "reset path";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(229)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(696, 777);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(718, 833);
            this.Name = "Form1";
            this.Text = "MD5 Hash";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox sourceText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getHash;
        private System.Windows.Forms.Button file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hashedText;
        private System.Windows.Forms.Button reset;
    }
}

