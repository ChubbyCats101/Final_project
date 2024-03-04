namespace Final_Project
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            NametextBox = new TextBox();
            phonetextBox = new TextBox();
            PlanetcomboBox = new ComboBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            IDtextBox = new TextBox();
            Savebutton = new Button();
            Cancelbutton = new Button();
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnPhonenumber = new DataGridViewTextBoxColumn();
            ColumnIDcard = new DataGridViewTextBoxColumn();
            ShipColumn = new DataGridViewTextBoxColumn();
            ColumnPlanet = new DataGridViewTextBoxColumn();
            ColumnDate = new DataGridViewTextBoxColumn();
            ColumnTicketPrices = new DataGridViewTextBoxColumn();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label3 = new Label();
            shipcomboBox = new ComboBox();
            label10 = new Label();
            TotalPricetextBox = new TextBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            label1.Location = new Point(99, 138);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            label2.Location = new Point(52, 174);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 2;
            label2.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            label4.Location = new Point(98, 306);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 4;
            label4.Text = "Planet";
            // 
            // NametextBox
            // 
            NametextBox.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            NametextBox.Location = new Point(228, 135);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(190, 31);
            NametextBox.TabIndex = 6;
            // 
            // phonetextBox
            // 
            phonetextBox.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            phonetextBox.Location = new Point(228, 171);
            phonetextBox.Name = "phonetextBox";
            phonetextBox.Size = new Size(190, 31);
            phonetextBox.TabIndex = 7;
            // 
            // PlanetcomboBox
            // 
            PlanetcomboBox.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            PlanetcomboBox.FormattingEnabled = true;
            PlanetcomboBox.Items.AddRange(new object[] { "Matar Bay", "Alathfar XI", "Charon Prime", "Asperoth Prime", "Bore Rock", "Pathfinder V", "Klen Dahth II", "Widow's Harbor", "New Haven", "Pilen V" });
            PlanetcomboBox.Location = new Point(228, 303);
            PlanetcomboBox.Name = "PlanetcomboBox";
            PlanetcomboBox.Size = new Size(183, 29);
            PlanetcomboBox.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("SimSun", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(31, 18);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(63, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(55, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(110, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(110, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            label6.Location = new Point(77, 217);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 11;
            label6.Text = "ID card";
            // 
            // IDtextBox
            // 
            IDtextBox.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            IDtextBox.Location = new Point(228, 214);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(190, 31);
            IDtextBox.TabIndex = 12;
            // 
            // Savebutton
            // 
            Savebutton.BackColor = Color.Lime;
            Savebutton.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            Savebutton.Location = new Point(96, 487);
            Savebutton.Name = "Savebutton";
            Savebutton.Size = new Size(128, 52);
            Savebutton.TabIndex = 14;
            Savebutton.Text = "Save";
            Savebutton.UseVisualStyleBackColor = false;
            Savebutton.Click += Savebutton_Click;
            // 
            // Cancelbutton
            // 
            Cancelbutton.BackColor = Color.Red;
            Cancelbutton.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            Cancelbutton.Location = new Point(274, 487);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(128, 52);
            Cancelbutton.TabIndex = 15;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = false;
            Cancelbutton.Click += Cancelbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnPhonenumber, ColumnIDcard, ShipColumn, ColumnPlanet, ColumnDate, ColumnTicketPrices });
            dataGridView1.Location = new Point(424, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(715, 395);
            dataGridView1.TabIndex = 16;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Name";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 150;
            // 
            // ColumnPhonenumber
            // 
            ColumnPhonenumber.HeaderText = "Phonenumber";
            ColumnPhonenumber.MinimumWidth = 6;
            ColumnPhonenumber.Name = "ColumnPhonenumber";
            ColumnPhonenumber.Width = 150;
            // 
            // ColumnIDcard
            // 
            ColumnIDcard.HeaderText = "IDcard";
            ColumnIDcard.MinimumWidth = 6;
            ColumnIDcard.Name = "ColumnIDcard";
            ColumnIDcard.Width = 150;
            // 
            // ShipColumn
            // 
            ShipColumn.HeaderText = "SpaceShip";
            ShipColumn.Name = "ShipColumn";
            // 
            // ColumnPlanet
            // 
            ColumnPlanet.HeaderText = "Planet";
            ColumnPlanet.MinimumWidth = 6;
            ColumnPlanet.Name = "ColumnPlanet";
            ColumnPlanet.Width = 150;
            // 
            // ColumnDate
            // 
            ColumnDate.HeaderText = "Date";
            ColumnDate.MinimumWidth = 6;
            ColumnDate.Name = "ColumnDate";
            ColumnDate.Width = 150;
            // 
            // ColumnTicketPrices
            // 
            ColumnTicketPrices.HeaderText = "Ticket Prices";
            ColumnTicketPrices.Name = "ColumnTicketPrices";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            label5.Location = new Point(98, 348);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 17;
            label5.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(218, 348);
            dateTimePicker1.MinDate = new DateTime(3000, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.Value = new DateTime(3000, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SimSun", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(330, 30);
            label7.Name = "label7";
            label7.Size = new Size(520, 48);
            label7.TabIndex = 19;
            label7.Text = "HyperLightSpeedDrive";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.meme_1;
            pictureBox1.Location = new Point(72, 588);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 126);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("SimSun", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(491, 541);
            label8.Name = "label8";
            label8.Size = new Size(233, 37);
            label8.TabIndex = 21;
            label8.Text = "⚠️Warning⚠️";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(219, 600);
            label9.Name = "label9";
            label9.Size = new Size(920, 72);
            label9.TabIndex = 22;
            label9.Text = "Let's explore a new planet if we're sick of the same old one!\r\nIt's simple to fly to an other planet! Purchase your tickets from us! \r\nYou might not be able to go back, so proceed with caution.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            label3.Location = new Point(84, 266);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 23;
            label3.Text = "Spaceship";
            // 
            // shipcomboBox
            // 
            shipcomboBox.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            shipcomboBox.FormattingEnabled = true;
            shipcomboBox.Items.AddRange(new object[] { "Skywalker OG", "Ghost Train Haze", "Blue Dream", "Candy Kush Express" });
            shipcomboBox.Location = new Point(228, 263);
            shipcomboBox.Name = "shipcomboBox";
            shipcomboBox.Size = new Size(183, 29);
            shipcomboBox.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            label10.Location = new Point(77, 391);
            label10.Name = "label10";
            label10.Size = new Size(130, 21);
            label10.TabIndex = 25;
            label10.Text = "TotalPrice";
            // 
            // TotalPricetextBox
            // 
            TotalPricetextBox.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            TotalPricetextBox.Location = new Point(228, 388);
            TotalPricetextBox.Name = "TotalPricetextBox";
            TotalPricetextBox.Size = new Size(190, 31);
            TotalPricetextBox.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("SimSun", 15.75F, FontStyle.Bold);
            button1.Location = new Point(139, 425);
            button1.Name = "button1";
            button1.Size = new Size(246, 33);
            button1.TabIndex = 27;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.จองตั๋วHyperLightSpeedDrive;
            ClientSize = new Size(1151, 731);
            Controls.Add(button1);
            Controls.Add(TotalPricetextBox);
            Controls.Add(label10);
            Controls.Add(shipcomboBox);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(Cancelbutton);
            Controls.Add(Savebutton);
            Controls.Add(IDtextBox);
            Controls.Add(label6);
            Controls.Add(PlanetcomboBox);
            Controls.Add(phonetextBox);
            Controls.Add(NametextBox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox NametextBox;
        private TextBox phonetextBox;
        private ComboBox PlanetcomboBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Label label6;
        private TextBox IDtextBox;
        private Button Savebutton;
        private Button Cancelbutton;
        private DataGridView dataGridView1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private Label label3;
        private ComboBox shipcomboBox;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnPhonenumber;
        private DataGridViewTextBoxColumn ColumnIDcard;
        private DataGridViewTextBoxColumn ShipColumn;
        private DataGridViewTextBoxColumn ColumnPlanet;
        private DataGridViewTextBoxColumn ColumnDate;
        private DataGridViewTextBoxColumn ColumnTicketPrices;
        private Label label10;
        private TextBox TotalPricetextBox;
        private Button button1;
    }
}
