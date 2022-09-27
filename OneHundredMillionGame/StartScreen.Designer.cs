namespace OneHundredMillionGame
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.txt_playerName = new System.Windows.Forms.TextBox();
            this.btn_EnterGame = new System.Windows.Forms.Button();
            this.lbl_Errors = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(141, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.AutoSize = true;
            this.lbl_playerName.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_playerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_playerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_playerName.Location = new System.Drawing.Point(342, 243);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(55, 17);
            this.lbl_playerName.TabIndex = 1;
            this.lbl_playerName.Text = "Player: ";
            // 
            // txt_playerName
            // 
            this.txt_playerName.BackColor = System.Drawing.Color.RoyalBlue;
            this.txt_playerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_playerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_playerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_playerName.Location = new System.Drawing.Point(401, 244);
            this.txt_playerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_playerName.Name = "txt_playerName";
            this.txt_playerName.Size = new System.Drawing.Size(250, 18);
            this.txt_playerName.TabIndex = 2;
            // 
            // btn_EnterGame
            // 
            this.btn_EnterGame.BackColor = System.Drawing.Color.Red;
            this.btn_EnterGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_EnterGame.FlatAppearance.BorderSize = 0;
            this.btn_EnterGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EnterGame.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_EnterGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EnterGame.Location = new System.Drawing.Point(382, 320);
            this.btn_EnterGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EnterGame.Name = "btn_EnterGame";
            this.btn_EnterGame.Size = new System.Drawing.Size(131, 49);
            this.btn_EnterGame.TabIndex = 3;
            this.btn_EnterGame.Text = "Enter";
            this.btn_EnterGame.UseVisualStyleBackColor = false;
            this.btn_EnterGame.Click += new System.EventHandler(this.btn_EnterGame_Click);
            // 
            // lbl_Errors
            // 
            this.lbl_Errors.AutoSize = true;
            this.lbl_Errors.ForeColor = System.Drawing.Color.Red;
            this.lbl_Errors.Location = new System.Drawing.Point(297, 269);
            this.lbl_Errors.Name = "lbl_Errors";
            this.lbl_Errors.Size = new System.Drawing.Size(0, 15);
            this.lbl_Errors.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox4.Location = new System.Drawing.Point(287, 238);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(388, 28);
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.richTextBox1.Location = new System.Drawing.Point(141, 392);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(645, 128);
            this.richTextBox1.TabIndex = 40;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(940, 532);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_Errors);
            this.Controls.Add(this.btn_EnterGame);
            this.Controls.Add(this.txt_playerName);
            this.Controls.Add(this.lbl_playerName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_playerName;
        private TextBox txt_playerName;
        private Button btn_EnterGame;
        private Label lbl_Errors;
        private PictureBox pictureBox4;
        private RichTextBox richTextBox1;
    }
}