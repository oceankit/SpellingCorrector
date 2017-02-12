namespace SpellCorrector
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.autocorrect_btn = new System.Windows.Forms.Button();
            this.change_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 200);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not in dictionary:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(517, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // autocorrect_btn
            // 
            this.autocorrect_btn.Location = new System.Drawing.Point(514, 41);
            this.autocorrect_btn.Name = "autocorrect_btn";
            this.autocorrect_btn.Size = new System.Drawing.Size(91, 45);
            this.autocorrect_btn.TabIndex = 13;
            this.autocorrect_btn.Text = "Autocorrect";
            this.autocorrect_btn.UseVisualStyleBackColor = true;
            this.autocorrect_btn.Click += new System.EventHandler(this.autocorrect_btn_Click);
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(514, 217);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(100, 52);
            this.change_btn.TabIndex = 14;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(514, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 24);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(473, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpellCorrector.Properties.Resources.lightning_strike_one_world_trade_center_wallpaper_1366x768;
            this.ClientSize = new System.Drawing.Size(632, 424);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.change_btn);
            this.Controls.Add(this.autocorrect_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Spelling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button autocorrect_btn;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

