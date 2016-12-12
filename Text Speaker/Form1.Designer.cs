namespace Text_Speaker
{
    partial class Speak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Speak));
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neutralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teenagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seniorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notSetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.installedVoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(671, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Speak";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(662, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(121, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genderToolStripMenuItem,
            this.ageToolStripMenuItem,
            this.toolStripSeparator2,
            this.installedVoicesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // genderToolStripMenuItem
            // 
            this.genderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maleToolStripMenuItem,
            this.femaleToolStripMenuItem,
            this.neutralToolStripMenuItem,
            this.notSetToolStripMenuItem});
            this.genderToolStripMenuItem.Name = "genderToolStripMenuItem";
            this.genderToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.genderToolStripMenuItem.Text = "Gender";
            // 
            // maleToolStripMenuItem
            // 
            this.maleToolStripMenuItem.Name = "maleToolStripMenuItem";
            this.maleToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.maleToolStripMenuItem.Text = "Male";
            this.maleToolStripMenuItem.Click += new System.EventHandler(this.selectGender_Click);
            // 
            // femaleToolStripMenuItem
            // 
            this.femaleToolStripMenuItem.Name = "femaleToolStripMenuItem";
            this.femaleToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.femaleToolStripMenuItem.Text = "Female";
            this.femaleToolStripMenuItem.Click += new System.EventHandler(this.selectGender_Click);
            // 
            // neutralToolStripMenuItem
            // 
            this.neutralToolStripMenuItem.Name = "neutralToolStripMenuItem";
            this.neutralToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.neutralToolStripMenuItem.Text = "Neutral";
            this.neutralToolStripMenuItem.Click += new System.EventHandler(this.selectGender_Click);
            // 
            // notSetToolStripMenuItem
            // 
            this.notSetToolStripMenuItem.Name = "notSetToolStripMenuItem";
            this.notSetToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.notSetToolStripMenuItem.Text = "Not Set";
            this.notSetToolStripMenuItem.Click += new System.EventHandler(this.selectGender_Click);
            // 
            // ageToolStripMenuItem
            // 
            this.ageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.childToolStripMenuItem,
            this.teenagerToolStripMenuItem,
            this.adultToolStripMenuItem,
            this.seniorToolStripMenuItem,
            this.notSetToolStripMenuItem1});
            this.ageToolStripMenuItem.Name = "ageToolStripMenuItem";
            this.ageToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ageToolStripMenuItem.Text = "Age";
            // 
            // childToolStripMenuItem
            // 
            this.childToolStripMenuItem.Name = "childToolStripMenuItem";
            this.childToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.childToolStripMenuItem.Text = "Child";
            this.childToolStripMenuItem.Click += new System.EventHandler(this.selectAge_Click);
            // 
            // teenagerToolStripMenuItem
            // 
            this.teenagerToolStripMenuItem.Name = "teenagerToolStripMenuItem";
            this.teenagerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.teenagerToolStripMenuItem.Text = "Teenager";
            this.teenagerToolStripMenuItem.Click += new System.EventHandler(this.selectAge_Click);
            // 
            // adultToolStripMenuItem
            // 
            this.adultToolStripMenuItem.Name = "adultToolStripMenuItem";
            this.adultToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.adultToolStripMenuItem.Text = "Adult";
            this.adultToolStripMenuItem.Click += new System.EventHandler(this.selectAge_Click);
            // 
            // seniorToolStripMenuItem
            // 
            this.seniorToolStripMenuItem.Name = "seniorToolStripMenuItem";
            this.seniorToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.seniorToolStripMenuItem.Text = "Senior";
            this.seniorToolStripMenuItem.Click += new System.EventHandler(this.selectAge_Click);
            // 
            // notSetToolStripMenuItem1
            // 
            this.notSetToolStripMenuItem1.Name = "notSetToolStripMenuItem1";
            this.notSetToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.notSetToolStripMenuItem1.Text = "Not Set";
            this.notSetToolStripMenuItem1.Click += new System.EventHandler(this.selectAge_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // installedVoicesToolStripMenuItem
            // 
            this.installedVoicesToolStripMenuItem.Name = "installedVoicesToolStripMenuItem";
            this.installedVoicesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.installedVoicesToolStripMenuItem.Text = "Installed Voices";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.toolStripSeparator1,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.69469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.30532F));
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 511);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 32);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(803, 478);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // Speak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 546);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Speak";
            this.Text = "Speaker of words";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem genderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neutralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem childToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teenagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seniorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notSetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem installedVoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

