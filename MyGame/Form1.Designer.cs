using System.Windows.Forms;

namespace MyGame
{
    partial class AlienShooter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlienShooter));
            this.Life = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.Life1 = new System.Windows.Forms.PictureBox();
            this.Life2 = new System.Windows.Forms.PictureBox();
            this.PlayerMove = new System.Windows.Forms.Timer(this.components);
            this.RocketMove = new System.Windows.Forms.Timer(this.components);
            this.ScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemieRocketTimer = new System.Windows.Forms.Timer(this.components);
            this.BustTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).BeginInit();
            this.SuspendLayout();
            // 
            // Life
            // 
            this.Life.AutoSize = true;
            this.Life.BackColor = System.Drawing.Color.Black;
            this.Life.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Life.ForeColor = System.Drawing.Color.White;
            this.Life.Location = new System.Drawing.Point(12, 821);
            this.Life.Name = "Life";
            this.Life.Size = new System.Drawing.Size(99, 31);
            this.Life.TabIndex = 0;
            this.Life.Text = "Жизни:";
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.BackColor = System.Drawing.Color.Black;
            this.Counter.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.ForeColor = System.Drawing.Color.White;
            this.Counter.Location = new System.Drawing.Point(1428, 821);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(97, 31);
            this.Counter.TabIndex = 1;
            this.Counter.Text = "Счёт: 0";
            // 
            // Life1
            // 
            this.Life1.BackColor = System.Drawing.Color.Transparent;
            this.Life1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Life1.BackgroundImage")));
            this.Life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Life1.Location = new System.Drawing.Point(117, 811);
            this.Life1.Name = "Life1";
            this.Life1.Size = new System.Drawing.Size(50, 50);
            this.Life1.TabIndex = 2;
            this.Life1.TabStop = false;
            // 
            // Life2
            // 
            this.Life2.BackColor = System.Drawing.Color.Transparent;
            this.Life2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Life2.BackgroundImage")));
            this.Life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Life2.Location = new System.Drawing.Point(173, 811);
            this.Life2.Name = "Life2";
            this.Life2.Size = new System.Drawing.Size(50, 50);
            this.Life2.TabIndex = 3;
            this.Life2.TabStop = false;
            this.Life2.Tag = "";
            // 
            // PlayerMove
            // 
            this.PlayerMove.Enabled = true;
            this.PlayerMove.Interval = 1;
            this.PlayerMove.Tick += new System.EventHandler(this.MovePlayer);
            // 
            // RocketMove
            // 
            this.RocketMove.Enabled = true;
            this.RocketMove.Interval = 1;
            this.RocketMove.Tick += new System.EventHandler(this.RocketsBustersMove);
            // 
            // ScoreTimer
            // 
            this.ScoreTimer.Enabled = true;
            this.ScoreTimer.Interval = 1;
            this.ScoreTimer.Tick += new System.EventHandler(this.GetScore);
            // 
            // EnemieRocketTimer
            // 
            this.EnemieRocketTimer.Enabled = true;
            this.EnemieRocketTimer.Interval = 15;
            this.EnemieRocketTimer.Tick += new System.EventHandler(this.GetEnemieRocket);
            // 
            // BustTimer
            // 
            this.BustTimer.Enabled = true;
            this.BustTimer.Interval = 1;
            this.BustTimer.Tick += new System.EventHandler(this.TimeOfBusts);
            // 
            // AlienShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.Life2);
            this.Controls.Add(this.Life1);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.Life);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlienShooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlienShooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeysDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeysUp);
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Life;
        private System.Windows.Forms.Label Counter;
        private Timer PlayerMove;
        private Timer RocketMove;
        private Timer ScoreTimer;
        private Timer EnemieRocketTimer;
        public PictureBox Life1;
        public PictureBox Life2;
        private Timer BustTimer;
    }
}

