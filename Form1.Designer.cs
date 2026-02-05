namespace OOP_Laba_3
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.clear_btn = new System.Windows.Forms.Button();
            this.keys_label = new System.Windows.Forms.Label();
            this.lbXcord = new System.Windows.Forms.Label();
            this.lbYcord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(12, 12);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 0;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // keys_label
            // 
            this.keys_label.AutoSize = true;
            this.keys_label.Location = new System.Drawing.Point(93, 15);
            this.keys_label.Name = "keys_label";
            this.keys_label.Size = new System.Drawing.Size(86, 16);
            this.keys_label.TabIndex = 1;
            this.keys_label.Text = "Key pressed:";
            // 
            // lbXcord
            // 
            this.lbXcord.AutoSize = true;
            this.lbXcord.Location = new System.Drawing.Point(13, 42);
            this.lbXcord.Name = "lbXcord";
            this.lbXcord.Size = new System.Drawing.Size(14, 16);
            this.lbXcord.TabIndex = 2;
            this.lbXcord.Text = "0";
            // 
            // lbYcord
            // 
            this.lbYcord.AutoSize = true;
            this.lbYcord.Location = new System.Drawing.Point(12, 62);
            this.lbYcord.Name = "lbYcord";
            this.lbYcord.Size = new System.Drawing.Size(14, 16);
            this.lbYcord.TabIndex = 3;
            this.lbYcord.Text = "0";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 488);
            this.Controls.Add(this.lbYcord);
            this.Controls.Add(this.lbXcord);
            this.Controls.Add(this.keys_label);
            this.Controls.Add(this.clear_btn);
            this.Name = "mainForm";
            this.Text = "form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label keys_label;
        private System.Windows.Forms.Label lbXcord;
        private System.Windows.Forms.Label lbYcord;
    }
}

