namespace FoldersComparer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            buttonAnalyze = new Button();
            folderOne = new TextBox();
            folderTwo = new TextBox();
            browseOne = new Button();
            browseTwo = new Button();
            message = new Label();
            logDest = new TextBox();
            label3 = new Label();
            browseLog = new Button();
            menuStrip1 = new MenuStrip();
            whatDoesItDoToolStripMenuItem = new ToolStripMenuItem();
            maxFilesSizeToolStripMenuItem = new ToolStripMenuItem();
            aToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            insertSizeToolStripMenuItem = new ToolStripMenuItem();
            sizeTypes = new ToolStripComboBox();
            madeByBioShip0706ToolStripMenuItem = new ToolStripMenuItem();
            rememberSize = new ToolStripMenuItem();
            buttonSwap = new Button();
            label4 = new Label();
            filterOne = new ComboBox();
            label5 = new Label();
            filterTwo = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            extensionOne = new TextBox();
            extensionTwo = new TextBox();
            label8 = new Label();
            label9 = new Label();
            enableFilterOne = new CheckBox();
            enableFilterTwo = new CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Folder One";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 88);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Folder Two";
            // 
            // buttonAnalyze
            // 
            buttonAnalyze.Enabled = false;
            buttonAnalyze.Location = new Point(29, 222);
            buttonAnalyze.Name = "buttonAnalyze";
            buttonAnalyze.Size = new Size(180, 43);
            buttonAnalyze.TabIndex = 2;
            buttonAnalyze.Text = "COMPARE";
            buttonAnalyze.UseVisualStyleBackColor = true;
            buttonAnalyze.Click += buttonAnalyze_Click;
            // 
            // folderOne
            // 
            folderOne.Location = new Point(29, 54);
            folderOne.Name = "folderOne";
            folderOne.Size = new Size(180, 23);
            folderOne.TabIndex = 3;
            // 
            // folderTwo
            // 
            folderTwo.Location = new Point(29, 106);
            folderTwo.Name = "folderTwo";
            folderTwo.ScrollBars = ScrollBars.Vertical;
            folderTwo.Size = new Size(180, 23);
            folderTwo.TabIndex = 4;
            // 
            // browseOne
            // 
            browseOne.Location = new Point(215, 54);
            browseOne.Name = "browseOne";
            browseOne.Size = new Size(75, 23);
            browseOne.TabIndex = 5;
            browseOne.Text = "Browse...";
            browseOne.UseVisualStyleBackColor = true;
            browseOne.Click += browseOne_Click;
            // 
            // browseTwo
            // 
            browseTwo.Location = new Point(215, 105);
            browseTwo.Name = "browseTwo";
            browseTwo.Size = new Size(75, 23);
            browseTwo.TabIndex = 6;
            browseTwo.Text = "Browse...";
            browseTwo.UseVisualStyleBackColor = true;
            browseTwo.Click += browseTwo_Click;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(102, 154);
            message.Name = "message";
            message.Size = new Size(0, 15);
            message.TabIndex = 7;
            // 
            // logDest
            // 
            logDest.Location = new Point(30, 172);
            logDest.Name = "logDest";
            logDest.ScrollBars = ScrollBars.Vertical;
            logDest.Size = new Size(180, 23);
            logDest.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 154);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 9;
            label3.Text = "Log destination";
            // 
            // browseLog
            // 
            browseLog.Location = new Point(215, 171);
            browseLog.Name = "browseLog";
            browseLog.Size = new Size(75, 23);
            browseLog.TabIndex = 10;
            browseLog.Text = "Browse...";
            browseLog.UseVisualStyleBackColor = true;
            browseLog.Click += browseLog_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { whatDoesItDoToolStripMenuItem, maxFilesSizeToolStripMenuItem, madeByBioShip0706ToolStripMenuItem, rememberSize });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(642, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // whatDoesItDoToolStripMenuItem
            // 
            whatDoesItDoToolStripMenuItem.Name = "whatDoesItDoToolStripMenuItem";
            whatDoesItDoToolStripMenuItem.Size = new Size(102, 20);
            whatDoesItDoToolStripMenuItem.Text = "What does it do";
            whatDoesItDoToolStripMenuItem.Click += whatDoesItDoToolStripMenuItem_Click;
            // 
            // maxFilesSizeToolStripMenuItem
            // 
            maxFilesSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aToolStripMenuItem, toolStripTextBox2, toolStripSeparator1, insertSizeToolStripMenuItem, sizeTypes });
            maxFilesSizeToolStripMenuItem.Name = "maxFilesSizeToolStripMenuItem";
            maxFilesSizeToolStripMenuItem.Size = new Size(61, 20);
            maxFilesSizeToolStripMenuItem.Text = "Options";
            maxFilesSizeToolStripMenuItem.Click += maxFilesSizeToolStripMenuItem_Click;
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(203, 22);
            aToolStripMenuItem.Text = "Max File size (In Mbytes)";
            aToolStripMenuItem.Click += aToolStripMenuItem_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.BackColor = SystemColors.ButtonFace;
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 23);
            toolStripTextBox2.Visible = false;
            toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(200, 6);
            // 
            // insertSizeToolStripMenuItem
            // 
            insertSizeToolStripMenuItem.Name = "insertSizeToolStripMenuItem";
            insertSizeToolStripMenuItem.Size = new Size(203, 22);
            insertSizeToolStripMenuItem.Text = "Size Type";
            insertSizeToolStripMenuItem.Visible = false;
            // 
            // sizeTypes
            // 
            sizeTypes.BackColor = SystemColors.ButtonFace;
            sizeTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            sizeTypes.Items.AddRange(new object[] { "Kbytes", "Mbytes", "Gbytes" });
            sizeTypes.Name = "sizeTypes";
            sizeTypes.Size = new Size(121, 23);
            sizeTypes.Visible = false;
            // 
            // madeByBioShip0706ToolStripMenuItem
            // 
            madeByBioShip0706ToolStripMenuItem.Enabled = false;
            madeByBioShip0706ToolStripMenuItem.Name = "madeByBioShip0706ToolStripMenuItem";
            madeByBioShip0706ToolStripMenuItem.Size = new Size(137, 20);
            madeByBioShip0706ToolStripMenuItem.Text = "-Made by BioShip0706";
            // 
            // rememberSize
            // 
            rememberSize.Enabled = false;
            rememberSize.Name = "rememberSize";
            rememberSize.Size = new Size(199, 20);
            rememberSize.Text = "Remember to set the max file size!";
            // 
            // buttonSwap
            // 
            buttonSwap.Enabled = false;
            buttonSwap.Location = new Point(100, 80);
            buttonSwap.Name = "buttonSwap";
            buttonSwap.Size = new Size(109, 23);
            buttonSwap.TabIndex = 12;
            buttonSwap.Text = "Swap directories";
            buttonSwap.UseVisualStyleBackColor = true;
            buttonSwap.Click += buttonSwap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 36);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 13;
            label4.Text = "Files filter:";
            // 
            // filterOne
            // 
            filterOne.DropDownStyle = ComboBoxStyle.DropDownList;
            filterOne.Enabled = false;
            filterOne.FormattingEnabled = true;
            filterOne.Items.AddRange(new object[] { "Starts with", "Contains", "Ends with" });
            filterOne.Location = new Point(348, 54);
            filterOne.Name = "filterOne";
            filterOne.Size = new Size(121, 23);
            filterOne.TabIndex = 14;
            filterOne.SelectedIndexChanged += filterOne_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(348, 88);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 15;
            label5.Text = "Files filter:";
            // 
            // filterTwo
            // 
            filterTwo.DropDownStyle = ComboBoxStyle.DropDownList;
            filterTwo.Enabled = false;
            filterTwo.FormattingEnabled = true;
            filterTwo.Items.AddRange(new object[] { "Starts with", "Contains", "Ends with" });
            filterTwo.Location = new Point(348, 105);
            filterTwo.Name = "filterTwo";
            filterTwo.Size = new Size(121, 23);
            filterTwo.TabIndex = 16;
            filterTwo.SelectedIndexChanged += filterTwo_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 58);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 17;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(475, 109);
            label7.Name = "label7";
            label7.Size = new Size(10, 15);
            label7.TabIndex = 18;
            label7.Text = ":";
            // 
            // extensionOne
            // 
            extensionOne.Enabled = false;
            extensionOne.Location = new Point(491, 54);
            extensionOne.Name = "extensionOne";
            extensionOne.Size = new Size(100, 23);
            extensionOne.TabIndex = 19;
            // 
            // extensionTwo
            // 
            extensionTwo.Enabled = false;
            extensionTwo.Location = new Point(491, 105);
            extensionTwo.Name = "extensionTwo";
            extensionTwo.Size = new Size(100, 23);
            extensionTwo.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(491, 36);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 21;
            label8.Text = "Word/Extension";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(491, 88);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 22;
            label9.Text = "Word/Extension";
            // 
            // enableFilterOne
            // 
            enableFilterOne.AutoSize = true;
            enableFilterOne.Location = new Point(296, 58);
            enableFilterOne.Name = "enableFilterOne";
            enableFilterOne.RightToLeft = RightToLeft.No;
            enableFilterOne.Size = new Size(52, 19);
            enableFilterOne.TabIndex = 23;
            enableFilterOne.Text = "Filter";
            enableFilterOne.UseVisualStyleBackColor = true;
            enableFilterOne.CheckedChanged += enableFilterOne_CheckedChanged;
            // 
            // enableFilterTwo
            // 
            enableFilterTwo.AutoSize = true;
            enableFilterTwo.Location = new Point(296, 110);
            enableFilterTwo.Name = "enableFilterTwo";
            enableFilterTwo.RightToLeft = RightToLeft.No;
            enableFilterTwo.Size = new Size(52, 19);
            enableFilterTwo.TabIndex = 24;
            enableFilterTwo.Text = "Filter";
            enableFilterTwo.UseVisualStyleBackColor = true;
            enableFilterTwo.CheckedChanged += enableFilterTwo_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 277);
            Controls.Add(enableFilterTwo);
            Controls.Add(enableFilterOne);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(extensionTwo);
            Controls.Add(extensionOne);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(filterTwo);
            Controls.Add(label5);
            Controls.Add(filterOne);
            Controls.Add(label4);
            Controls.Add(buttonSwap);
            Controls.Add(browseLog);
            Controls.Add(label3);
            Controls.Add(logDest);
            Controls.Add(message);
            Controls.Add(browseTwo);
            Controls.Add(browseOne);
            Controls.Add(folderTwo);
            Controls.Add(folderOne);
            Controls.Add(buttonAnalyze);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Folders Comparator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonAnalyze;
        private TextBox folderOne;
        private TextBox folderTwo;
        private Button browseOne;
        private Button browseTwo;
        private Label message;
        private TextBox logDest;
        private Label label3;
        private Button browseLog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem whatDoesItDoToolStripMenuItem;
        private ToolStripMenuItem madeByBioShip0706ToolStripMenuItem;
        private Button buttonSwap;
        private ToolStripMenuItem maxFilesSizeToolStripMenuItem;
        private ToolStripMenuItem insertSizeToolStripMenuItem;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripComboBox sizeTypes;
        private Label label4;
        private ComboBox filterOne;
        private Label label5;
        private ComboBox filterTwo;
        private Label label6;
        private Label label7;
        private TextBox extensionOne;
        private TextBox extensionTwo;
        private Label label8;
        private Label label9;
        private CheckBox enableFilterOne;
        private CheckBox enableFilterTwo;
        private ToolStripMenuItem rememberSize;
    }
}
