
namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.lstPlayer = new System.Windows.Forms.ListBox();
            this.Checkbox_Team4 = new System.Windows.Forms.CheckBox();
            this.Checkbox_Team3 = new System.Windows.Forms.CheckBox();
            this.Checkbox_Team2 = new System.Windows.Forms.CheckBox();
            this.Checkbox_Team1 = new System.Windows.Forms.CheckBox();
            this.btnSubmitTeams = new System.Windows.Forms.Button();
            this.txtTeamsName = new System.Windows.Forms.TextBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitPlayers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.lstTeams);
            this.tabPage1.Controls.Add(this.lstPlayer);
            this.tabPage1.Controls.Add(this.Checkbox_Team4);
            this.tabPage1.Controls.Add(this.Checkbox_Team3);
            this.tabPage1.Controls.Add(this.Checkbox_Team2);
            this.tabPage1.Controls.Add(this.Checkbox_Team1);
            this.tabPage1.Controls.Add(this.btnSubmitTeams);
            this.tabPage1.Controls.Add(this.txtTeamsName);
            this.tabPage1.Controls.Add(this.txtPlayerName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSubmitPlayers);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(602, 231);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(159, 147);
            this.lstTeams.TabIndex = 12;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // lstPlayer
            // 
            this.lstPlayer.FormattingEnabled = true;
            this.lstPlayer.Location = new System.Drawing.Point(139, 231);
            this.lstPlayer.Name = "lstPlayer";
            this.lstPlayer.Size = new System.Drawing.Size(160, 147);
            this.lstPlayer.TabIndex = 11;
            // 
            // Checkbox_Team4
            // 
            this.Checkbox_Team4.AutoSize = true;
            this.Checkbox_Team4.BackColor = System.Drawing.Color.OliveDrab;
            this.Checkbox_Team4.Location = new System.Drawing.Point(515, 268);
            this.Checkbox_Team4.Name = "Checkbox_Team4";
            this.Checkbox_Team4.Size = new System.Drawing.Size(62, 17);
            this.Checkbox_Team4.TabIndex = 10;
            this.Checkbox_Team4.Text = "Team 4";
            this.Checkbox_Team4.UseVisualStyleBackColor = false;
            // 
            // Checkbox_Team3
            // 
            this.Checkbox_Team3.AutoSize = true;
            this.Checkbox_Team3.BackColor = System.Drawing.Color.OliveDrab;
            this.Checkbox_Team3.Location = new System.Drawing.Point(515, 245);
            this.Checkbox_Team3.Name = "Checkbox_Team3";
            this.Checkbox_Team3.Size = new System.Drawing.Size(62, 17);
            this.Checkbox_Team3.TabIndex = 9;
            this.Checkbox_Team3.Text = "Team 3";
            this.Checkbox_Team3.UseVisualStyleBackColor = false;
            this.Checkbox_Team3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Checkbox_Team2
            // 
            this.Checkbox_Team2.AutoSize = true;
            this.Checkbox_Team2.BackColor = System.Drawing.Color.OliveDrab;
            this.Checkbox_Team2.Location = new System.Drawing.Point(515, 222);
            this.Checkbox_Team2.Name = "Checkbox_Team2";
            this.Checkbox_Team2.Size = new System.Drawing.Size(62, 17);
            this.Checkbox_Team2.TabIndex = 8;
            this.Checkbox_Team2.Text = "Team 2";
            this.Checkbox_Team2.UseVisualStyleBackColor = false;
            this.Checkbox_Team2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Checkbox_Team1
            // 
            this.Checkbox_Team1.AutoSize = true;
            this.Checkbox_Team1.Location = new System.Drawing.Point(515, 199);
            this.Checkbox_Team1.Name = "Checkbox_Team1";
            this.Checkbox_Team1.Size = new System.Drawing.Size(62, 17);
            this.Checkbox_Team1.TabIndex = 7;
            this.Checkbox_Team1.Text = "Team 1";
            this.Checkbox_Team1.UseVisualStyleBackColor = true;
            this.Checkbox_Team1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSubmitTeams
            // 
            this.btnSubmitTeams.Location = new System.Drawing.Point(654, 156);
            this.btnSubmitTeams.Name = "btnSubmitTeams";
            this.btnSubmitTeams.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitTeams.TabIndex = 6;
            this.btnSubmitTeams.Text = "Submit";
            this.btnSubmitTeams.UseVisualStyleBackColor = true;
            this.btnSubmitTeams.Click += new System.EventHandler(this.btnSubmitTeams_Click);
            // 
            // txtTeamsName
            // 
            this.txtTeamsName.Location = new System.Drawing.Point(515, 159);
            this.txtTeamsName.Name = "txtTeamsName";
            this.txtTeamsName.Size = new System.Drawing.Size(100, 20);
            this.txtTeamsName.TabIndex = 5;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(155, 159);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerName.TabIndex = 2;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teams";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Players";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSubmitPlayers
            // 
            this.btnSubmitPlayers.Location = new System.Drawing.Point(298, 159);
            this.btnSubmitPlayers.Name = "btnSubmitPlayers";
            this.btnSubmitPlayers.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitPlayers.TabIndex = 1;
            this.btnSubmitPlayers.Text = "Submit";
            this.btnSubmitPlayers.UseVisualStyleBackColor = true;
            this.btnSubmitPlayers.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.Screenshot_2023_03_06_154622;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 416);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(423, 365);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(102, 39);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.ListBox lstPlayer;
        private System.Windows.Forms.CheckBox Checkbox_Team4;
        private System.Windows.Forms.CheckBox Checkbox_Team3;
        private System.Windows.Forms.CheckBox Checkbox_Team2;
        private System.Windows.Forms.CheckBox Checkbox_Team1;
        private System.Windows.Forms.Button btnSubmitTeams;
        private System.Windows.Forms.TextBox txtTeamsName;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitPlayers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnNext;
    }
}

