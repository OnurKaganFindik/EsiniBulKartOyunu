
namespace EsiniBul
{
    partial class YeniOyunForm
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.gbpGrup = new System.Windows.Forms.GroupBox();
            this.rbZor = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKolay = new System.Windows.Forms.RadioButton();
            this.gbpGrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasla.Location = new System.Drawing.Point(42, 209);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(196, 64);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "OYUNU BAŞLAT";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // gbpGrup
            // 
            this.gbpGrup.Controls.Add(this.rbZor);
            this.gbpGrup.Controls.Add(this.rbOrta);
            this.gbpGrup.Controls.Add(this.rbKolay);
            this.gbpGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpGrup.Location = new System.Drawing.Point(42, 17);
            this.gbpGrup.Name = "gbpGrup";
            this.gbpGrup.Size = new System.Drawing.Size(196, 186);
            this.gbpGrup.TabIndex = 2;
            this.gbpGrup.TabStop = false;
            this.gbpGrup.Text = "Zorluk Seviyesi";
            // 
            // rbZor
            // 
            this.rbZor.AutoSize = true;
            this.rbZor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbZor.Location = new System.Drawing.Point(7, 124);
            this.rbZor.Name = "rbZor";
            this.rbZor.Size = new System.Drawing.Size(99, 28);
            this.rbZor.TabIndex = 2;
            this.rbZor.Text = "Zor(8x8)";
            this.rbZor.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOrta.Location = new System.Drawing.Point(7, 79);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(105, 28);
            this.rbOrta.TabIndex = 1;
            this.rbOrta.Text = "Orta(6x6)";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKolay
            // 
            this.rbKolay.AutoSize = true;
            this.rbKolay.Checked = true;
            this.rbKolay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKolay.Location = new System.Drawing.Point(7, 34);
            this.rbKolay.Name = "rbKolay";
            this.rbKolay.Size = new System.Drawing.Size(116, 28);
            this.rbKolay.TabIndex = 0;
            this.rbKolay.TabStop = true;
            this.rbKolay.Text = "Kolay(4x4)";
            this.rbKolay.UseVisualStyleBackColor = true;
            // 
            // YeniOyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 290);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.gbpGrup);
            this.Name = "YeniOyunForm";
            this.Text = "YeniOyunForm";
            this.gbpGrup.ResumeLayout(false);
            this.gbpGrup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.GroupBox gbpGrup;
        private System.Windows.Forms.RadioButton rbZor;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKolay;
    }
}