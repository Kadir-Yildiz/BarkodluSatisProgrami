namespace BarkodluSatisProgrami
{
    partial class fUrunGrubuEkle
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
            this.lStandart1 = new BarkodluSatisProgrami.lStandart();
            this.tStandart1 = new BarkodluSatisProgrami.tStandart();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bStandart1 = new BarkodluSatisProgrami.bStandart();
            this.SuspendLayout();
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(25, 23);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(147, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Ürün Grubu Adı";
            // 
            // tStandart1
            // 
            this.tStandart1.BackColor = System.Drawing.Color.White;
            this.tStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tStandart1.Location = new System.Drawing.Point(12, 51);
            this.tStandart1.Name = "tStandart1";
            this.tStandart1.Size = new System.Drawing.Size(250, 30);
            this.tStandart1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(250, 279);
            this.listBox1.TabIndex = 2;
            // 
            // bStandart1
            // 
            this.bStandart1.BackColor = System.Drawing.Color.Tomato;
            this.bStandart1.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bStandart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bStandart1.ForeColor = System.Drawing.Color.White;
            this.bStandart1.Image = global::BarkodluSatisProgrami.Properties.Resources.Ekle20;
            this.bStandart1.Location = new System.Drawing.Point(12, 381);
            this.bStandart1.Margin = new System.Windows.Forms.Padding(1);
            this.bStandart1.Name = "bStandart1";
            this.bStandart1.Size = new System.Drawing.Size(250, 57);
            this.bStandart1.TabIndex = 0;
            this.bStandart1.Text = "bStandart1";
            this.bStandart1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bStandart1.UseVisualStyleBackColor = false;
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bStandart1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tStandart1);
            this.Controls.Add(this.lStandart1);
            this.Name = "fUrunGrubuEkle";
            this.Text = "Ürün Grubu İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lStandart lStandart1;
        private tStandart tStandart1;
        private System.Windows.Forms.ListBox listBox1;
        private bStandart bStandart1;
    }
}