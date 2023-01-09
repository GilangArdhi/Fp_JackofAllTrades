namespace Jack_Of_All_Trade
{
    partial class Percobaan
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
            this.Elektro = new System.Windows.Forms.CheckBox();
            this.bengkel = new System.Windows.Forms.CheckBox();
            this.kuli = new System.Windows.Forms.CheckBox();
            this.kunci = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Elektro
            // 
            this.Elektro.AutoSize = true;
            this.Elektro.Location = new System.Drawing.Point(121, 28);
            this.Elektro.Name = "Elektro";
            this.Elektro.Size = new System.Drawing.Size(88, 20);
            this.Elektro.TabIndex = 0;
            this.Elektro.Text = "Elektronik";
            this.Elektro.UseVisualStyleBackColor = true;
            // 
            // bengkel
            // 
            this.bengkel.AutoSize = true;
            this.bengkel.Location = new System.Drawing.Point(121, 106);
            this.bengkel.Name = "bengkel";
            this.bengkel.Size = new System.Drawing.Size(65, 20);
            this.bengkel.TabIndex = 1;
            this.bengkel.Text = "montir";
            this.bengkel.UseVisualStyleBackColor = true;
            // 
            // kuli
            // 
            this.kuli.AutoSize = true;
            this.kuli.Location = new System.Drawing.Point(121, 80);
            this.kuli.Name = "kuli";
            this.kuli.Size = new System.Drawing.Size(49, 20);
            this.kuli.TabIndex = 2;
            this.kuli.Text = "kuli";
            this.kuli.UseVisualStyleBackColor = true;
            // 
            // kunci
            // 
            this.kunci.AutoSize = true;
            this.kunci.Location = new System.Drawing.Point(121, 54);
            this.kunci.Name = "kunci";
            this.kunci.Size = new System.Drawing.Size(60, 20);
            this.kunci.TabIndex = 3;
            this.kunci.Text = "kunci";
            this.kunci.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(301, 177);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(705, 662);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(324, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Percobaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.kunci);
            this.Controls.Add(this.kuli);
            this.Controls.Add(this.bengkel);
            this.Controls.Add(this.Elektro);
            this.Name = "Percobaan";
            this.Text = "Percobaan";
            this.Load += new System.EventHandler(this.Percobaan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Elektro;
        private System.Windows.Forms.CheckBox bengkel;
        private System.Windows.Forms.CheckBox kuli;
        private System.Windows.Forms.CheckBox kunci;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}