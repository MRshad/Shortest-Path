namespace Gui
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
            this.btnAddLoc = new System.Windows.Forms.Button();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmbLocations = new System.Windows.Forms.ComboBox();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.pnlView = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAddLoc
            // 
            this.btnAddLoc.Location = new System.Drawing.Point(16, 50);
            this.btnAddLoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLoc.Name = "btnAddLoc";
            this.btnAddLoc.Size = new System.Drawing.Size(187, 61);
            this.btnAddLoc.TabIndex = 0;
            this.btnAddLoc.Text = "Add Location";
            this.btnAddLoc.UseVisualStyleBackColor = true;
            this.btnAddLoc.Click += new System.EventHandler(this.btnAddLoc_Click);
            // 
            // txtweight
            // 
            this.txtweight.Location = new System.Drawing.Point(217, 17);
            this.txtweight.Margin = new System.Windows.Forms.Padding(4);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(72, 22);
            this.txtweight.TabIndex = 6;
            this.txtweight.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Weight added Connection";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(16, 137);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(105, 28);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 172);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 260);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cmbLocations
            // 
            this.cmbLocations.FormattingEnabled = true;
            this.cmbLocations.Location = new System.Drawing.Point(129, 139);
            this.cmbLocations.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(72, 24);
            this.cmbLocations.TabIndex = 9;
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Location = new System.Drawing.Point(297, 19);
            this.chkRandom.Margin = new System.Windows.Forms.Padding(4);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(85, 21);
            this.chkRandom.TabIndex = 12;
            this.chkRandom.Text = "aleatoire";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // pnlView
            // 
            this.pnlView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlView.Location = new System.Drawing.Point(217, 50);
            this.pnlView.Margin = new System.Windows.Forms.Padding(4);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(1185, 382);
            this.pnlView.TabIndex = 13;
            this.pnlView.Click += new System.EventHandler(this.pnlView_Click);
            this.pnlView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlView_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 448);
            this.Controls.Add(this.pnlView);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.cmbLocations);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnAddLoc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MRshad -Shortest Path";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddLoc;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbLocations;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.Panel pnlView;
    }
}

