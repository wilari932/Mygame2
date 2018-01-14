namespace Animacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labellevel = new System.Windows.Forms.Label();
            this.labelNewGame = new System.Windows.Forms.Label();
            this.LabelGameOver = new System.Windows.Forms.Label();
            this.labellose = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.Playerbox = new System.Windows.Forms.PictureBox();
            this.WallDown = new System.Windows.Forms.PictureBox();
            this.WallLeft = new System.Windows.Forms.PictureBox();
            this.Walltop = new System.Windows.Forms.PictureBox();
            this.WallRight = new System.Windows.Forms.PictureBox();
            this.AnimationObject = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Playerbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Walltop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimationObject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labellevel);
            this.panel1.Controls.Add(this.labelNewGame);
            this.panel1.Controls.Add(this.LabelGameOver);
            this.panel1.Controls.Add(this.labellose);
            this.panel1.Controls.Add(this.TimerLabel);
            this.panel1.Controls.Add(this.Playerbox);
            this.panel1.Controls.Add(this.WallDown);
            this.panel1.Controls.Add(this.WallLeft);
            this.panel1.Controls.Add(this.Walltop);
            this.panel1.Controls.Add(this.WallRight);
            this.panel1.Controls.Add(this.AnimationObject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1914, 844);
            this.panel1.TabIndex = 0;
            // 
            // labellevel
            // 
            this.labellevel.AutoSize = true;
            this.labellevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labellevel.Location = new System.Drawing.Point(209, 16);
            this.labellevel.Name = "labellevel";
            this.labellevel.Size = new System.Drawing.Size(111, 29);
            this.labellevel.TabIndex = 10;
            this.labellevel.Text = "Level : 1";
            // 
            // labelNewGame
            // 
            this.labelNewGame.AutoSize = true;
            this.labelNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNewGame.Location = new System.Drawing.Point(621, 413);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(698, 135);
            this.labelNewGame.TabIndex = 9;
            this.labelNewGame.Text = "New Game ";
            this.labelNewGame.Visible = false;
            this.labelNewGame.Click += new System.EventHandler(this.labelNewGame_Click);
            this.labelNewGame.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.labelNewGame.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // LabelGameOver
            // 
            this.LabelGameOver.AutoSize = true;
            this.LabelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelGameOver.Location = new System.Drawing.Point(621, 238);
            this.LabelGameOver.Name = "LabelGameOver";
            this.LabelGameOver.Size = new System.Drawing.Size(685, 135);
            this.LabelGameOver.TabIndex = 8;
            this.LabelGameOver.Text = "Game Over";
            this.LabelGameOver.Visible = false;
            // 
            // labellose
            // 
            this.labellose.AutoSize = true;
            this.labellose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellose.ForeColor = System.Drawing.Color.White;
            this.labellose.Location = new System.Drawing.Point(480, 10);
            this.labellose.Name = "labellose";
            this.labellose.Size = new System.Drawing.Size(130, 32);
            this.labellose.TabIndex = 7;
            this.labellose.Text = "Loses: 0";
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimerLabel.Location = new System.Drawing.Point(13, 16);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(87, 29);
            this.TimerLabel.TabIndex = 6;
            this.TimerLabel.Text = "Time: ";
            // 
            // Playerbox
            // 
            this.Playerbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Playerbox.Location = new System.Drawing.Point(770, 765);
            this.Playerbox.Name = "Playerbox";
            this.Playerbox.Size = new System.Drawing.Size(358, 22);
            this.Playerbox.TabIndex = 5;
            this.Playerbox.TabStop = false;
            // 
            // WallDown
            // 
            this.WallDown.BackColor = System.Drawing.Color.Maroon;
            this.WallDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WallDown.Location = new System.Drawing.Point(10, 834);
            this.WallDown.Name = "WallDown";
            this.WallDown.Size = new System.Drawing.Size(1894, 10);
            this.WallDown.TabIndex = 4;
            this.WallDown.TabStop = false;
            // 
            // WallLeft
            // 
            this.WallLeft.BackColor = System.Drawing.Color.Maroon;
            this.WallLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.WallLeft.Location = new System.Drawing.Point(0, 10);
            this.WallLeft.Name = "WallLeft";
            this.WallLeft.Size = new System.Drawing.Size(10, 834);
            this.WallLeft.TabIndex = 3;
            this.WallLeft.TabStop = false;
            // 
            // Walltop
            // 
            this.Walltop.BackColor = System.Drawing.Color.Maroon;
            this.Walltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Walltop.Location = new System.Drawing.Point(0, 0);
            this.Walltop.Name = "Walltop";
            this.Walltop.Size = new System.Drawing.Size(1904, 10);
            this.Walltop.TabIndex = 2;
            this.Walltop.TabStop = false;
            // 
            // WallRight
            // 
            this.WallRight.BackColor = System.Drawing.Color.Maroon;
            this.WallRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.WallRight.Location = new System.Drawing.Point(1904, 0);
            this.WallRight.Name = "WallRight";
            this.WallRight.Size = new System.Drawing.Size(10, 844);
            this.WallRight.TabIndex = 1;
            this.WallRight.TabStop = false;
            // 
            // AnimationObject
            // 
            this.AnimationObject.Image = global::Animacion.Properties.Resources.Untitled2;
            this.AnimationObject.Location = new System.Drawing.Point(710, 16);
            this.AnimationObject.Name = "AnimationObject";
            this.AnimationObject.Size = new System.Drawing.Size(148, 116);
            this.AnimationObject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnimationObject.TabIndex = 0;
            this.AnimationObject.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 844);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Playerbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Walltop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnimationObject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox AnimationObject;
        private System.Windows.Forms.PictureBox WallDown;
        private System.Windows.Forms.PictureBox WallLeft;
        private System.Windows.Forms.PictureBox Walltop;
        private System.Windows.Forms.PictureBox WallRight;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Playerbox;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label labellose;
        private System.Windows.Forms.Label labelNewGame;
        private System.Windows.Forms.Label LabelGameOver;
        private System.Windows.Forms.Label labellevel;
    }
}

