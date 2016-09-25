namespace bolsh
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Draw = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textbox_it = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1s = new System.Windows.Forms.PictureBox();
            this.label1s = new System.Windows.Forms.Label();
            this.textBox1s = new System.Windows.Forms.TextBox();
            this.serp1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1k = new System.Windows.Forms.TextBox();
            this.resultPBk = new System.Windows.Forms.PictureBox();
            this.drawButtonk = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1h = new System.Windows.Forms.PictureBox();
            this.button1h = new System.Windows.Forms.Button();
            this.textBox1h = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1s)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPBk)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1h)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 677);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_Draw);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.textbox_it);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(726, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Кривая Гильберта";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Итерации";
            // 
            // btn_Draw
            // 
            this.btn_Draw.Location = new System.Drawing.Point(7, 74);
            this.btn_Draw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Draw.Name = "btn_Draw";
            this.btn_Draw.Size = new System.Drawing.Size(129, 40);
            this.btn_Draw.TabIndex = 6;
            this.btn_Draw.Text = "Рисовать";
            this.btn_Draw.UseVisualStyleBackColor = true;
            this.btn_Draw.Click += new System.EventHandler(this.btn_Draw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(155, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 550);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textbox_it
            // 
            this.textbox_it.Location = new System.Drawing.Point(98, 20);
            this.textbox_it.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_it.Name = "textbox_it";
            this.textbox_it.Size = new System.Drawing.Size(38, 26);
            this.textbox_it.TabIndex = 4;
            this.textbox_it.Text = "3";
            this.textbox_it.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1s);
            this.tabPage2.Controls.Add(this.label1s);
            this.tabPage2.Controls.Add(this.textBox1s);
            this.tabPage2.Controls.Add(this.serp1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(726, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ковер Серпинского";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1s
            // 
            this.pictureBox1s.Location = new System.Drawing.Point(155, 50);
            this.pictureBox1s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1s.Name = "pictureBox1s";
            this.pictureBox1s.Size = new System.Drawing.Size(550, 550);
            this.pictureBox1s.TabIndex = 7;
            this.pictureBox1s.TabStop = false;
            // 
            // label1s
            // 
            this.label1s.AutoSize = true;
            this.label1s.ForeColor = System.Drawing.Color.Black;
            this.label1s.Location = new System.Drawing.Point(6, 20);
            this.label1s.Name = "label1s";
            this.label1s.Size = new System.Drawing.Size(83, 20);
            this.label1s.TabIndex = 6;
            this.label1s.Text = "Итерации";
            // 
            // textBox1s
            // 
            this.textBox1s.Location = new System.Drawing.Point(98, 20);
            this.textBox1s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1s.Name = "textBox1s";
            this.textBox1s.Size = new System.Drawing.Size(38, 26);
            this.textBox1s.TabIndex = 5;
            this.textBox1s.Text = "4";
            this.textBox1s.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serp1
            // 
            this.serp1.Location = new System.Drawing.Point(7, 74);
            this.serp1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serp1.Name = "serp1";
            this.serp1.Size = new System.Drawing.Size(129, 40);
            this.serp1.TabIndex = 4;
            this.serp1.Text = "Рисовать";
            this.serp1.UseVisualStyleBackColor = true;
            this.serp1.Click += new System.EventHandler(this.serp1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox1k);
            this.tabPage3.Controls.Add(this.resultPBk);
            this.tabPage3.Controls.Add(this.drawButtonk);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(726, 644);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Множество Кантора";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox1k
            // 
            this.textBox1k.Location = new System.Drawing.Point(98, 20);
            this.textBox1k.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1k.Name = "textBox1k";
            this.textBox1k.Size = new System.Drawing.Size(38, 26);
            this.textBox1k.TabIndex = 7;
            this.textBox1k.Text = "4";
            this.textBox1k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultPBk
            // 
            this.resultPBk.BackColor = System.Drawing.Color.White;
            this.resultPBk.Location = new System.Drawing.Point(155, 50);
            this.resultPBk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultPBk.Name = "resultPBk";
            this.resultPBk.Size = new System.Drawing.Size(550, 550);
            this.resultPBk.TabIndex = 6;
            this.resultPBk.TabStop = false;
            // 
            // drawButtonk
            // 
            this.drawButtonk.Location = new System.Drawing.Point(7, 74);
            this.drawButtonk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawButtonk.Name = "drawButtonk";
            this.drawButtonk.Size = new System.Drawing.Size(129, 40);
            this.drawButtonk.TabIndex = 5;
            this.drawButtonk.Text = "Рисовать";
            this.drawButtonk.UseVisualStyleBackColor = true;
            this.drawButtonk.Click += new System.EventHandler(this.drawButtonk_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.pictureBox1h);
            this.tabPage4.Controls.Add(this.button1h);
            this.tabPage4.Controls.Add(this.textBox1h);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(726, 644);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Снежинка Коха";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1h
            // 
            this.pictureBox1h.Location = new System.Drawing.Point(155, 50);
            this.pictureBox1h.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1h.Name = "pictureBox1h";
            this.pictureBox1h.Size = new System.Drawing.Size(550, 550);
            this.pictureBox1h.TabIndex = 5;
            this.pictureBox1h.TabStop = false;
            // 
            // button1h
            // 
            this.button1h.Location = new System.Drawing.Point(7, 74);
            this.button1h.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1h.Name = "button1h";
            this.button1h.Size = new System.Drawing.Size(129, 40);
            this.button1h.TabIndex = 4;
            this.button1h.Text = "Рисовать";
            this.button1h.UseVisualStyleBackColor = true;
            this.button1h.Click += new System.EventHandler(this.button1h_Click);
            // 
            // textBox1h
            // 
            this.textBox1h.Location = new System.Drawing.Point(98, 20);
            this.textBox1h.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1h.Name = "textBox1h";
            this.textBox1h.Size = new System.Drawing.Size(38, 26);
            this.textBox1h.TabIndex = 3;
            this.textBox1h.Text = "4";
            this.textBox1h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Итерации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Итерации";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 677);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Фракталы";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1s)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPBk)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1h)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Draw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textbox_it;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1s;
        private System.Windows.Forms.Label label1s;
        private System.Windows.Forms.TextBox textBox1s;
        private System.Windows.Forms.Button serp1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox1k;
        private System.Windows.Forms.PictureBox resultPBk;
        private System.Windows.Forms.Button drawButtonk;
        private System.Windows.Forms.PictureBox pictureBox1h;
        private System.Windows.Forms.Button button1h;
        private System.Windows.Forms.TextBox textBox1h;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

