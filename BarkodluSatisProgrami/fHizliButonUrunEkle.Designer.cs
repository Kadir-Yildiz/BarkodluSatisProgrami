namespace BarkodluSatisProgrami
{
    partial class fHizliButonUrunEkle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridUrunler = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tUrunAra = new System.Windows.Forms.TextBox();
            this.chTumu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lButonId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lButonId);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.chTumu);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(1073, 698);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridUrunler
            // 
            this.gridUrunler.AllowUserToAddRows = false;
            this.gridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.EnableHeadersVisualStyles = false;
            this.gridUrunler.Location = new System.Drawing.Point(0, 0);
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.RowHeadersVisible = false;
            this.gridUrunler.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            this.gridUrunler.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUrunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUrunler.RowTemplate.Height = 32;
            this.gridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunler.Size = new System.Drawing.Size(1073, 551);
            this.gridUrunler.TabIndex = 2;
            this.gridUrunler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUrunler_CellContentDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(23, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ürün Ara";
            // 
            // tUrunAra
            // 
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tUrunAra.Location = new System.Drawing.Point(16, 100);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(247, 30);
            this.tUrunAra.TabIndex = 4;
            this.tUrunAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // chTumu
            // 
            this.chTumu.AutoSize = true;
            this.chTumu.Location = new System.Drawing.Point(296, 109);
            this.chTumu.Name = "chTumu";
            this.chTumu.Size = new System.Drawing.Size(120, 20);
            this.chTumu.TabIndex = 6;
            this.chTumu.Text = "Tümünü Göster";
            this.chTumu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buton Numarası :";
            // 
            // lButonId
            // 
            this.lButonId.AutoSize = true;
            this.lButonId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lButonId.ForeColor = System.Drawing.Color.DarkCyan;
            this.lButonId.Location = new System.Drawing.Point(191, 23);
            this.lButonId.Name = "lButonId";
            this.lButonId.Size = new System.Drawing.Size(93, 25);
            this.lButonId.TabIndex = 8;
            this.lButonId.Text = "Buton No";
            // 
            // fHizliButonUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1073, 698);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fHizliButonUrunEkle";
            this.Text = "Hızlı Buton Ürün Ekleme";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridUrunler;
        private System.Windows.Forms.CheckBox chTumu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tUrunAra;
        public System.Windows.Forms.Label lButonId;
        private System.Windows.Forms.Label label1;
    }
}