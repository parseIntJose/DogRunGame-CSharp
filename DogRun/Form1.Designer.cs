namespace DogRun
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_dog1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_dog2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_dog3 = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.checkBox_dog1 = new System.Windows.Forms.CheckBox();
            this.checkBox_dog2 = new System.Windows.Forms.CheckBox();
            this.checkBox_dog3 = new System.Windows.Forms.CheckBox();
            this.textBox_wl = new System.Windows.Forms.TextBox();
            this.timer_run = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_flag = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_flag)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1274, 374);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_dog1
            // 
            this.pictureBox_dog1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_dog1.BackgroundImage")));
            this.pictureBox_dog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_dog1.Location = new System.Drawing.Point(219, 74);
            this.pictureBox_dog1.Name = "pictureBox_dog1";
            this.pictureBox_dog1.Size = new System.Drawing.Size(108, 62);
            this.pictureBox_dog1.TabIndex = 1;
            this.pictureBox_dog1.TabStop = false;
            // 
            // pictureBox_dog2
            // 
            this.pictureBox_dog2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_dog2.BackgroundImage")));
            this.pictureBox_dog2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_dog2.Location = new System.Drawing.Point(219, 179);
            this.pictureBox_dog2.Name = "pictureBox_dog2";
            this.pictureBox_dog2.Size = new System.Drawing.Size(108, 62);
            this.pictureBox_dog2.TabIndex = 2;
            this.pictureBox_dog2.TabStop = false;
            // 
            // pictureBox_dog3
            // 
            this.pictureBox_dog3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_dog3.BackgroundImage")));
            this.pictureBox_dog3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_dog3.Location = new System.Drawing.Point(219, 287);
            this.pictureBox_dog3.Name = "pictureBox_dog3";
            this.pictureBox_dog3.Size = new System.Drawing.Size(108, 62);
            this.pictureBox_dog3.TabIndex = 3;
            this.pictureBox_dog3.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.Enabled = false;
            this.button_start.Location = new System.Drawing.Point(38, 409);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(151, 79);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // checkBox_dog1
            // 
            this.checkBox_dog1.AutoSize = true;
            this.checkBox_dog1.Location = new System.Drawing.Point(270, 409);
            this.checkBox_dog1.Name = "checkBox_dog1";
            this.checkBox_dog1.Size = new System.Drawing.Size(100, 19);
            this.checkBox_dog1.TabIndex = 5;
            this.checkBox_dog1.TabStop = false;
            this.checkBox_dog1.Text = "CACHORRO 1";
            this.checkBox_dog1.UseVisualStyleBackColor = true;
            this.checkBox_dog1.CheckedChanged += new System.EventHandler(this.checkBox_dog1_CheckedChanged);
            // 
            // checkBox_dog2
            // 
            this.checkBox_dog2.AutoSize = true;
            this.checkBox_dog2.Location = new System.Drawing.Point(270, 440);
            this.checkBox_dog2.Name = "checkBox_dog2";
            this.checkBox_dog2.Size = new System.Drawing.Size(100, 19);
            this.checkBox_dog2.TabIndex = 6;
            this.checkBox_dog2.Text = "CACHORRO 2";
            this.checkBox_dog2.UseVisualStyleBackColor = true;
            this.checkBox_dog2.CheckedChanged += new System.EventHandler(this.checkBox_dog2_CheckedChanged);
            // 
            // checkBox_dog3
            // 
            this.checkBox_dog3.AutoSize = true;
            this.checkBox_dog3.Location = new System.Drawing.Point(270, 469);
            this.checkBox_dog3.Name = "checkBox_dog3";
            this.checkBox_dog3.Size = new System.Drawing.Size(100, 19);
            this.checkBox_dog3.TabIndex = 7;
            this.checkBox_dog3.Text = "CACHORRO 3";
            this.checkBox_dog3.UseVisualStyleBackColor = true;
            this.checkBox_dog3.CheckedChanged += new System.EventHandler(this.checkBox_dog3_CheckedChanged);
            // 
            // textBox_wl
            // 
            this.textBox_wl.Font = new System.Drawing.Font("Verdana", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_wl.Location = new System.Drawing.Point(447, 432);
            this.textBox_wl.Name = "textBox_wl";
            this.textBox_wl.Size = new System.Drawing.Size(269, 38);
            this.textBox_wl.TabIndex = 8;
            this.textBox_wl.Text = "APOSTE!!";
            this.textBox_wl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer_run
            // 
            this.timer_run.Tick += new System.EventHandler(this.timer_run_Tick);
            // 
            // pictureBox_flag
            // 
            this.pictureBox_flag.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_flag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_flag.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_flag.Image")));
            this.pictureBox_flag.InitialImage = null;
            this.pictureBox_flag.Location = new System.Drawing.Point(1177, 287);
            this.pictureBox_flag.Name = "pictureBox_flag";
            this.pictureBox_flag.Size = new System.Drawing.Size(100, 102);
            this.pictureBox_flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_flag.TabIndex = 9;
            this.pictureBox_flag.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(769, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogo desenvolvido como aprendizagem de C#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desenvolvido por José Henrique de Andrade";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(6, 96);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(400, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/parseIntJose/DogRunGame-CSharp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_flag);
            this.Controls.Add(this.textBox_wl);
            this.Controls.Add(this.checkBox_dog3);
            this.Controls.Add(this.checkBox_dog2);
            this.Controls.Add(this.checkBox_dog1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox_dog3);
            this.Controls.Add(this.pictureBox_dog2);
            this.Controls.Add(this.pictureBox_dog1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RunDog!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_flag)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox_dog1;
        private PictureBox pictureBox_dog2;
        private PictureBox pictureBox_dog3;
        private Button button_start;
        private CheckBox checkBox_dog1;
        private CheckBox checkBox_dog2;
        private CheckBox checkBox_dog3;
        private TextBox textBox_wl;
        private System.Windows.Forms.Timer timer_run;
        private PictureBox pictureBox_flag;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Label label1;
    }
}