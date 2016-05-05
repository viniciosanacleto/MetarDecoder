namespace MetarDecoder
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
            this.txt_icao = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.lbl_metar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_icao
            // 
            this.txt_icao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_icao.Location = new System.Drawing.Point(12, 28);
            this.txt_icao.MaxLength = 4;
            this.txt_icao.Name = "txt_icao";
            this.txt_icao.Size = new System.Drawing.Size(100, 20);
            this.txt_icao.TabIndex = 0;
            this.txt_icao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(131, 26);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 23);
            this.bt_search.TabIndex = 1;
            this.bt_search.Text = "SEARCH";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // lbl_metar
            // 
            this.lbl_metar.AutoSize = true;
            this.lbl_metar.Location = new System.Drawing.Point(308, 170);
            this.lbl_metar.Name = "lbl_metar";
            this.lbl_metar.Size = new System.Drawing.Size(35, 13);
            this.lbl_metar.TabIndex = 2;
            this.lbl_metar.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 590);
            this.Controls.Add(this.lbl_metar);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.txt_icao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_icao;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Label lbl_metar;
    }
}

