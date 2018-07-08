namespace Minesweeper
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelMine = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.gameGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.beginnerBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediateIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TableLayoutPanelMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanelMain
            // 
            this.TableLayoutPanelMain.ColumnCount = 10;
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TableLayoutPanelMain.Controls.Add(this.pictureBox2, 0, 0);
            this.TableLayoutPanelMain.Controls.Add(this.pictureBox1, 5, 0);
            this.TableLayoutPanelMain.Controls.Add(this.labelMine, 7, 0);
            this.TableLayoutPanelMain.Controls.Add(this.labelTime, 2, 0);
            this.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableLayoutPanelMain.Location = new System.Drawing.Point(0, 400);
            this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            this.TableLayoutPanelMain.RowCount = 1;
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMain.Size = new System.Drawing.Size(800, 50);
            this.TableLayoutPanelMain.TabIndex = 1;
            // 
            // labelMine
            // 
            this.labelMine.AutoSize = true;
            this.labelMine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMine.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMine.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelMine.Location = new System.Drawing.Point(519, 0);
            this.labelMine.Name = "labelMine";
            this.labelMine.Size = new System.Drawing.Size(114, 50);
            this.labelMine.TabIndex = 4;
            this.labelMine.Text = "Mine";
            this.labelMine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTime.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelTime.Location = new System.Drawing.Point(122, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(114, 50);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameGToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // gameGToolStripMenuItem
            // 
            this.gameGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameNToolStripMenuItem,
            this.toolStripMenuItem1,
            this.beginnerBToolStripMenuItem,
            this.intermediateIToolStripMenuItem,
            this.expertEToolStripMenuItem,
            this.toolStripMenuItem2,
            this.settingtoolStripMenuItem,
            this.exitXToolStripMenuItem});
            this.gameGToolStripMenuItem.Name = "gameGToolStripMenuItem";
            this.gameGToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.gameGToolStripMenuItem.Text = "Game(&G)";
            // 
            // newGameNToolStripMenuItem
            // 
            this.newGameNToolStripMenuItem.Name = "newGameNToolStripMenuItem";
            this.newGameNToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.newGameNToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.newGameNToolStripMenuItem.Text = "New Game(&N)";
            this.newGameNToolStripMenuItem.Click += new System.EventHandler(this.newGameNToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 6);
            // 
            // beginnerBToolStripMenuItem
            // 
            this.beginnerBToolStripMenuItem.Checked = true;
            this.beginnerBToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.beginnerBToolStripMenuItem.Name = "beginnerBToolStripMenuItem";
            this.beginnerBToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.beginnerBToolStripMenuItem.Text = "Beginner(&B)";
            this.beginnerBToolStripMenuItem.Click += new System.EventHandler(this.newGameNToolStripMenuItem_Click);
            // 
            // intermediateIToolStripMenuItem
            // 
            this.intermediateIToolStripMenuItem.Name = "intermediateIToolStripMenuItem";
            this.intermediateIToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.intermediateIToolStripMenuItem.Text = "Intermediate(&I)";
            this.intermediateIToolStripMenuItem.Click += new System.EventHandler(this.newGameNToolStripMenuItem_Click);
            // 
            // expertEToolStripMenuItem
            // 
            this.expertEToolStripMenuItem.Name = "expertEToolStripMenuItem";
            this.expertEToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.expertEToolStripMenuItem.Text = "Expert(&E)";
            this.expertEToolStripMenuItem.Click += new System.EventHandler(this.newGameNToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 6);
            // 
            // settingtoolStripMenuItem
            // 
            this.settingtoolStripMenuItem.Name = "settingtoolStripMenuItem";
            this.settingtoolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.settingtoolStripMenuItem.Text = "Setting(&S)";
            this.settingtoolStripMenuItem.Click += new System.EventHandler(this.settingtoolStripMenuItem_Click);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.exitXToolStripMenuItem.Text = "Exit(&X)";
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.exitXToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutAToolStripMenuItem.Text = "About(&A)";
            this.aboutAToolStripMenuItem.Click += new System.EventHandler(this.aboutAToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Minesweeper.Properties.Resources.alarmclock;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 44);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Minesweeper.Properties.Resources.mine;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(400, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 44);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableLayoutPanelMain);
            this.Controls.Add(this.menuStripMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Minesweeper";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.TableLayoutPanelMain.ResumeLayout(false);
            this.TableLayoutPanelMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelMine;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem gameGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameNToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem beginnerBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermediateIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingtoolStripMenuItem;
    }
}

