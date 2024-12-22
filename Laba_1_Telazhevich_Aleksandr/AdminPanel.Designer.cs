namespace PROBizness
{
    partial class AdminPanel
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
            this.buttonDelTabl = new System.Windows.Forms.Button();
            this.buttonAddTabl = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelTabl
            // 
            this.buttonDelTabl.Location = new System.Drawing.Point(12, 47);
            this.buttonDelTabl.Name = "buttonDelTabl";
            this.buttonDelTabl.Size = new System.Drawing.Size(121, 29);
            this.buttonDelTabl.TabIndex = 0;
            this.buttonDelTabl.Text = "Удалить таблицу";
            this.buttonDelTabl.UseVisualStyleBackColor = true;
            this.buttonDelTabl.Click += new System.EventHandler(this.buttonDelTabl_Click);
            // 
            // buttonAddTabl
            // 
            this.buttonAddTabl.Location = new System.Drawing.Point(12, 12);
            this.buttonAddTabl.Name = "buttonAddTabl";
            this.buttonAddTabl.Size = new System.Drawing.Size(121, 29);
            this.buttonAddTabl.TabIndex = 1;
            this.buttonAddTabl.Text = "Добавить таблицу ";
            this.buttonAddTabl.UseVisualStyleBackColor = true;
            this.buttonAddTabl.Click += new System.EventHandler(this.buttonAddTabl_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(158, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(158, 113);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(120, 20);
            this.Input.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 114);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(103, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(12, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 129);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 283);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonAddTabl);
            this.Controls.Add(this.buttonDelTabl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelTabl;
        private System.Windows.Forms.Button buttonAddTabl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}