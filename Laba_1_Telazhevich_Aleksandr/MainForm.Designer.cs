namespace PROBizness
{
    partial class MainForm
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
            this.dataGridViewBD = new System.Windows.Forms.DataGridView();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonEditing = new System.Windows.Forms.Button();
            this.messeg = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрактToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статитикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.входToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSelecTabl = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonRegBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBD
            // 
            this.dataGridViewBD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewBD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBD.Location = new System.Drawing.Point(5, 29);
            this.dataGridViewBD.Name = "dataGridViewBD";
            this.dataGridViewBD.Size = new System.Drawing.Size(671, 170);
            this.dataGridViewBD.TabIndex = 0;
            // 
            // buttonSort
            // 
            this.buttonSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSort.Location = new System.Drawing.Point(0, 3);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(144, 32);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Сортировка";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonEditing
            // 
            this.buttonEditing.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEditing.Location = new System.Drawing.Point(521, 27);
            this.buttonEditing.Name = "buttonEditing";
            this.buttonEditing.Size = new System.Drawing.Size(144, 32);
            this.buttonEditing.TabIndex = 2;
            this.buttonEditing.Text = "Редактирование";
            this.buttonEditing.UseVisualStyleBackColor = true;
            // 
            // messeg
            // 
            this.messeg.AutoSize = true;
            this.messeg.Location = new System.Drawing.Point(153, 5);
            this.messeg.Name = "messeg";
            this.messeg.Size = new System.Drawing.Size(35, 13);
            this.messeg.TabIndex = 3;
            this.messeg.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.входToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицуToolStripMenuItem,
            this.контрактToolStripMenuItem,
            this.статитикаToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // таблицуToolStripMenuItem
            // 
            this.таблицуToolStripMenuItem.Name = "таблицуToolStripMenuItem";
            this.таблицуToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.таблицуToolStripMenuItem.Text = "Таблицу";
            // 
            // контрактToolStripMenuItem
            // 
            this.контрактToolStripMenuItem.Name = "контрактToolStripMenuItem";
            this.контрактToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.контрактToolStripMenuItem.Text = "Контракт";
            // 
            // статитикаToolStripMenuItem
            // 
            this.статитикаToolStripMenuItem.Name = "статитикаToolStripMenuItem";
            this.статитикаToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.статитикаToolStripMenuItem.Text = "Статитика";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.сохранитьToolStripMenuItem.Text = "Загрузить";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // входToolStripMenuItem
            // 
            this.входToolStripMenuItem.Name = "входToolStripMenuItem";
            this.входToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.входToolStripMenuItem.Text = "Вход";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // buttonSelecTabl
            // 
            this.buttonSelecTabl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSelecTabl.Location = new System.Drawing.Point(521, 65);
            this.buttonSelecTabl.Name = "buttonSelecTabl";
            this.buttonSelecTabl.Size = new System.Drawing.Size(144, 32);
            this.buttonSelecTabl.TabIndex = 5;
            this.buttonSelecTabl.Text = "Выбрать таблицу";
            this.buttonSelecTabl.UseVisualStyleBackColor = true;
            this.buttonSelecTabl.Click += new System.EventHandler(this.buttonSelecTabl_Click);
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.buttonRegBD);
            this.panelControl.Controls.Add(this.buttonEditing);
            this.panelControl.Controls.Add(this.messeg);
            this.panelControl.Controls.Add(this.buttonSelecTabl);
            this.panelControl.Controls.Add(this.buttonSort);
            this.panelControl.Location = new System.Drawing.Point(8, 200);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(668, 100);
            this.panelControl.TabIndex = 6;
            // 
            // buttonRegBD
            // 
            this.buttonRegBD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRegBD.Location = new System.Drawing.Point(3, 65);
            this.buttonRegBD.Name = "buttonRegBD";
            this.buttonRegBD.Size = new System.Drawing.Size(141, 32);
            this.buttonRegBD.TabIndex = 6;
            this.buttonRegBD.Text = "Редактирование БД";
            this.buttonRegBD.UseVisualStyleBackColor = true;
            this.buttonRegBD.Click += new System.EventHandler(this.buttonRegBD_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(681, 308);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.dataGridViewBD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonEditing;
        private System.Windows.Forms.Label messeg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem входToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрактToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статитикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.Panel panelControl;
        public System.Windows.Forms.DataGridView dataGridViewBD;
        public System.Windows.Forms.Button buttonSelecTabl;
        private System.Windows.Forms.Button buttonRegBD;
    }
}