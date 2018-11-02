namespace WinFormSimba
{
    partial class MainForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm1));
            this.SavannaBoard = new System.Windows.Forms.Panel();
            this.startConPnl = new System.Windows.Forms.Panel();
            this.NbrGrassTxtBox = new System.Windows.Forms.TextBox();
            this.GrassLbl = new System.Windows.Forms.Label();
            this.NbrLionsTxtBox = new System.Windows.Forms.TextBox();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.løverLbl = new System.Windows.Forms.Label();
            this.NbrWildebeestTxtBox = new System.Windows.Forms.TextBox();
            this.gnuerLbl = new System.Windows.Forms.Label();
            this.btnStopGame = new System.Windows.Forms.Button();
            this.btnBeginGame = new System.Windows.Forms.Button();
            this._btnRemovePanelGrid = new System.Windows.Forms.Button();
            this.btnDrawFields = new System.Windows.Forms.Button();
            this.board = new System.Windows.Forms.Panel();
            this.drawPanelGrid = new System.Windows.Forms.Panel();
            this.btnFlereRunder = new System.Windows.Forms.Button();
            this.statisticsPanel = new System.Windows.Forms.Panel();
            this.showRoundNbr = new System.Windows.Forms.Label();
            this.totalNbrOfAnimalsOutputLbl = new System.Windows.Forms.Label();
            this.rundelbl = new System.Windows.Forms.Label();
            this.totalAnmLbl = new System.Windows.Forms.Label();
            this.Statistik = new System.Windows.Forms.Label();
            this.lionOffspringLbl = new System.Windows.Forms.Label();
            this.afkomLøver = new System.Windows.Forms.Label();
            this.wildebeestOffspringLbl = new System.Windows.Forms.Label();
            this.afkomGnuer = new System.Windows.Forms.Label();
            this.lionMaleLbl = new System.Windows.Forms.Label();
            this.lionFemaleLbl = new System.Windows.Forms.Label();
            this.wildebeestFMaleLbl = new System.Windows.Forms.Label();
            this.wildebeestFemaleLbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnActivateRounde = new System.Windows.Forms.Button();
            this.timerGraphics = new System.Windows.Forms.Timer(this.components);
            this.SavannaBoard.SuspendLayout();
            this.startConPnl.SuspendLayout();
            this.board.SuspendLayout();
            this.statisticsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SavannaBoard
            // 
            this.SavannaBoard.BackColor = System.Drawing.SystemColors.Window;
            this.SavannaBoard.Controls.Add(this.startConPnl);
            this.SavannaBoard.Controls.Add(this.btnStopGame);
            this.SavannaBoard.Controls.Add(this.btnBeginGame);
            this.SavannaBoard.Controls.Add(this._btnRemovePanelGrid);
            this.SavannaBoard.Controls.Add(this.btnDrawFields);
            this.SavannaBoard.Controls.Add(this.board);
            this.SavannaBoard.Controls.Add(this.btnFlereRunder);
            this.SavannaBoard.Controls.Add(this.statisticsPanel);
            this.SavannaBoard.Controls.Add(this.btnActivateRounde);
            this.SavannaBoard.Location = new System.Drawing.Point(29, 12);
            this.SavannaBoard.Margin = new System.Windows.Forms.Padding(0);
            this.SavannaBoard.Name = "SavannaBoard";
            this.SavannaBoard.Size = new System.Drawing.Size(1200, 684);
            this.SavannaBoard.TabIndex = 1;
            this.SavannaBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.savannaBoard_Paint);
            // 
            // startConPnl
            // 
            this.startConPnl.BackColor = System.Drawing.Color.Transparent;
            this.startConPnl.Controls.Add(this.NbrGrassTxtBox);
            this.startConPnl.Controls.Add(this.GrassLbl);
            this.startConPnl.Controls.Add(this.NbrLionsTxtBox);
            this.startConPnl.Controls.Add(this.InfoLbl);
            this.startConPnl.Controls.Add(this.løverLbl);
            this.startConPnl.Controls.Add(this.NbrWildebeestTxtBox);
            this.startConPnl.Controls.Add(this.gnuerLbl);
            this.startConPnl.Location = new System.Drawing.Point(691, 254);
            this.startConPnl.Name = "startConPnl";
            this.startConPnl.Size = new System.Drawing.Size(493, 160);
            this.startConPnl.TabIndex = 22;
            // 
            // NbrGrassTxtBox
            // 
            this.NbrGrassTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.NbrGrassTxtBox.Location = new System.Drawing.Point(119, 107);
            this.NbrGrassTxtBox.Name = "NbrGrassTxtBox";
            this.NbrGrassTxtBox.Size = new System.Drawing.Size(40, 25);
            this.NbrGrassTxtBox.TabIndex = 19;
            this.NbrGrassTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NbrGrassTxtBox_KeyPress);
            // 
            // GrassLbl
            // 
            this.GrassLbl.AutoSize = true;
            this.GrassLbl.BackColor = System.Drawing.Color.Transparent;
            this.GrassLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrassLbl.Location = new System.Drawing.Point(117, 87);
            this.GrassLbl.Name = "GrassLbl";
            this.GrassLbl.Size = new System.Drawing.Size(44, 18);
            this.GrassLbl.TabIndex = 18;
            this.GrassLbl.Text = "Græs:";
            // 
            // NbrLionsTxtBox
            // 
            this.NbrLionsTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.NbrLionsTxtBox.Location = new System.Drawing.Point(63, 107);
            this.NbrLionsTxtBox.Name = "NbrLionsTxtBox";
            this.NbrLionsTxtBox.Size = new System.Drawing.Size(40, 25);
            this.NbrLionsTxtBox.TabIndex = 17;
            this.NbrLionsTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NbrLionsTxtBox_KeyPress);
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.InfoLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLbl.Location = new System.Drawing.Point(5, 21);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(389, 52);
            this.InfoLbl.TabIndex = 13;
            this.InfoLbl.Text = "Du kan selv bestemme startbetingelserne \r\nved at indtaste antal i boksene:";
            // 
            // løverLbl
            // 
            this.løverLbl.AutoSize = true;
            this.løverLbl.BackColor = System.Drawing.Color.Transparent;
            this.løverLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.løverLbl.Location = new System.Drawing.Point(61, 87);
            this.løverLbl.Name = "løverLbl";
            this.løverLbl.Size = new System.Drawing.Size(47, 18);
            this.løverLbl.TabIndex = 16;
            this.løverLbl.Text = "Løver:";
            // 
            // NbrWildebeestTxtBox
            // 
            this.NbrWildebeestTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.NbrWildebeestTxtBox.Location = new System.Drawing.Point(9, 107);
            this.NbrWildebeestTxtBox.Name = "NbrWildebeestTxtBox";
            this.NbrWildebeestTxtBox.Size = new System.Drawing.Size(40, 25);
            this.NbrWildebeestTxtBox.TabIndex = 15;
            this.NbrWildebeestTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NbrWildebeestTxtBox_KeyPress);
            // 
            // gnuerLbl
            // 
            this.gnuerLbl.AutoSize = true;
            this.gnuerLbl.BackColor = System.Drawing.Color.Transparent;
            this.gnuerLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnuerLbl.Location = new System.Drawing.Point(7, 87);
            this.gnuerLbl.Name = "gnuerLbl";
            this.gnuerLbl.Size = new System.Drawing.Size(51, 18);
            this.gnuerLbl.TabIndex = 14;
            this.gnuerLbl.Text = "Gnuer:";
            // 
            // btnStopGame
            // 
            this.btnStopGame.BackColor = System.Drawing.SystemColors.Window;
            this.btnStopGame.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnStopGame.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopGame.Location = new System.Drawing.Point(1027, 498);
            this.btnStopGame.Name = "btnStopGame";
            this.btnStopGame.Size = new System.Drawing.Size(143, 85);
            this.btnStopGame.TabIndex = 21;
            this.btnStopGame.Text = "Stop spil";
            this.btnStopGame.UseVisualStyleBackColor = false;
            this.btnStopGame.Visible = false;
            this.btnStopGame.Click += new System.EventHandler(this.btnStopGame_Click);
            // 
            // btnBeginGame
            // 
            this.btnBeginGame.BackColor = System.Drawing.SystemColors.Window;
            this.btnBeginGame.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnBeginGame.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeginGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBeginGame.Location = new System.Drawing.Point(696, 498);
            this.btnBeginGame.Name = "btnBeginGame";
            this.btnBeginGame.Size = new System.Drawing.Size(143, 85);
            this.btnBeginGame.TabIndex = 20;
            this.btnBeginGame.Text = "Start spillet";
            this.btnBeginGame.UseVisualStyleBackColor = false;
            this.btnBeginGame.Click += new System.EventHandler(this._btnBeginGame_Click);
            // 
            // _btnRemovePanelGrid
            // 
            this._btnRemovePanelGrid.BackColor = System.Drawing.SystemColors.Window;
            this._btnRemovePanelGrid.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this._btnRemovePanelGrid.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnRemovePanelGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this._btnRemovePanelGrid.Location = new System.Drawing.Point(696, 432);
            this._btnRemovePanelGrid.Name = "_btnRemovePanelGrid";
            this._btnRemovePanelGrid.Size = new System.Drawing.Size(78, 37);
            this._btnRemovePanelGrid.TabIndex = 6;
            this._btnRemovePanelGrid.Text = "Fjern felter";
            this._btnRemovePanelGrid.UseVisualStyleBackColor = false;
            this._btnRemovePanelGrid.Visible = false;
            this._btnRemovePanelGrid.Click += new System.EventHandler(this._btnRemovePanelGrid_Click);
            // 
            // btnDrawFields
            // 
            this.btnDrawFields.BackColor = System.Drawing.SystemColors.Window;
            this.btnDrawFields.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDrawFields.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawFields.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDrawFields.Location = new System.Drawing.Point(696, 432);
            this.btnDrawFields.Name = "btnDrawFields";
            this.btnDrawFields.Size = new System.Drawing.Size(78, 37);
            this.btnDrawFields.TabIndex = 5;
            this.btnDrawFields.Text = "Se felter";
            this.btnDrawFields.UseVisualStyleBackColor = false;
            this.btnDrawFields.Click += new System.EventHandler(this._btnDrawFields_Click);
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.Transparent;
            this.board.Controls.Add(this.drawPanelGrid);
            this.board.Location = new System.Drawing.Point(12, 12);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(665, 669);
            this.board.TabIndex = 4;
            this.board.Paint += new System.Windows.Forms.PaintEventHandler(this._board_Paint);
            // 
            // drawPanelGrid
            // 
            this.drawPanelGrid.Location = new System.Drawing.Point(0, 0);
            this.drawPanelGrid.Name = "drawPanelGrid";
            this.drawPanelGrid.Size = new System.Drawing.Size(662, 666);
            this.drawPanelGrid.TabIndex = 0;
            this.drawPanelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this._drawPanelGrid_Paint);
            // 
            // btnFlereRunder
            // 
            this.btnFlereRunder.BackColor = System.Drawing.SystemColors.Window;
            this.btnFlereRunder.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnFlereRunder.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlereRunder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFlereRunder.Location = new System.Drawing.Point(861, 498);
            this.btnFlereRunder.Name = "btnFlereRunder";
            this.btnFlereRunder.Size = new System.Drawing.Size(143, 85);
            this.btnFlereRunder.TabIndex = 3;
            this.btnFlereRunder.Text = "Kør fem runder";
            this.btnFlereRunder.UseVisualStyleBackColor = false;
            this.btnFlereRunder.Visible = false;
            this.btnFlereRunder.Click += new System.EventHandler(this._btnFlereRunder_Click);
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.BackColor = System.Drawing.Color.Transparent;
            this.statisticsPanel.Controls.Add(this.showRoundNbr);
            this.statisticsPanel.Controls.Add(this.totalNbrOfAnimalsOutputLbl);
            this.statisticsPanel.Controls.Add(this.rundelbl);
            this.statisticsPanel.Controls.Add(this.totalAnmLbl);
            this.statisticsPanel.Controls.Add(this.Statistik);
            this.statisticsPanel.Controls.Add(this.lionOffspringLbl);
            this.statisticsPanel.Controls.Add(this.afkomLøver);
            this.statisticsPanel.Controls.Add(this.wildebeestOffspringLbl);
            this.statisticsPanel.Controls.Add(this.afkomGnuer);
            this.statisticsPanel.Controls.Add(this.lionMaleLbl);
            this.statisticsPanel.Controls.Add(this.lionFemaleLbl);
            this.statisticsPanel.Controls.Add(this.wildebeestFMaleLbl);
            this.statisticsPanel.Controls.Add(this.wildebeestFemaleLbl);
            this.statisticsPanel.Controls.Add(this.pictureBox4);
            this.statisticsPanel.Controls.Add(this.pictureBox3);
            this.statisticsPanel.Controls.Add(this.pictureBox2);
            this.statisticsPanel.Controls.Add(this.pictureBox1);
            this.statisticsPanel.Location = new System.Drawing.Point(691, 12);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(493, 245);
            this.statisticsPanel.TabIndex = 2;
            // 
            // showRoundNbr
            // 
            this.showRoundNbr.AutoSize = true;
            this.showRoundNbr.BackColor = System.Drawing.Color.Transparent;
            this.showRoundNbr.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showRoundNbr.Location = new System.Drawing.Point(468, 0);
            this.showRoundNbr.Name = "showRoundNbr";
            this.showRoundNbr.Size = new System.Drawing.Size(22, 26);
            this.showRoundNbr.TabIndex = 15;
            this.showRoundNbr.Text = "0";
            // 
            // totalNbrOfAnimalsOutputLbl
            // 
            this.totalNbrOfAnimalsOutputLbl.AutoSize = true;
            this.totalNbrOfAnimalsOutputLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.totalNbrOfAnimalsOutputLbl.Location = new System.Drawing.Point(198, 220);
            this.totalNbrOfAnimalsOutputLbl.Name = "totalNbrOfAnimalsOutputLbl";
            this.totalNbrOfAnimalsOutputLbl.Size = new System.Drawing.Size(18, 22);
            this.totalNbrOfAnimalsOutputLbl.TabIndex = 14;
            this.totalNbrOfAnimalsOutputLbl.Text = "0";
            // 
            // rundelbl
            // 
            this.rundelbl.AutoSize = true;
            this.rundelbl.BackColor = System.Drawing.Color.Transparent;
            this.rundelbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rundelbl.Location = new System.Drawing.Point(385, 0);
            this.rundelbl.Name = "rundelbl";
            this.rundelbl.Size = new System.Drawing.Size(77, 26);
            this.rundelbl.TabIndex = 16;
            this.rundelbl.Text = "Runde:";
            // 
            // totalAnmLbl
            // 
            this.totalAnmLbl.AutoSize = true;
            this.totalAnmLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.totalAnmLbl.Location = new System.Drawing.Point(53, 217);
            this.totalAnmLbl.Name = "totalAnmLbl";
            this.totalAnmLbl.Size = new System.Drawing.Size(139, 22);
            this.totalAnmLbl.TabIndex = 13;
            this.totalAnmLbl.Text = "Dyr på savannen:";
            // 
            // Statistik
            // 
            this.Statistik.AutoSize = true;
            this.Statistik.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistik.Location = new System.Drawing.Point(3, 10);
            this.Statistik.Name = "Statistik";
            this.Statistik.Size = new System.Drawing.Size(185, 26);
            this.Statistik.TabIndex = 12;
            this.Statistik.Text = "Dyrenes livscyklus:";
            // 
            // lionOffspringLbl
            // 
            this.lionOffspringLbl.AutoSize = true;
            this.lionOffspringLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lionOffspringLbl.Location = new System.Drawing.Point(332, 151);
            this.lionOffspringLbl.Name = "lionOffspringLbl";
            this.lionOffspringLbl.Size = new System.Drawing.Size(18, 22);
            this.lionOffspringLbl.TabIndex = 11;
            this.lionOffspringLbl.Text = "0";
            // 
            // afkomLøver
            // 
            this.afkomLøver.AutoSize = true;
            this.afkomLøver.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.afkomLøver.Location = new System.Drawing.Point(240, 151);
            this.afkomLøver.Name = "afkomLøver";
            this.afkomLøver.Size = new System.Drawing.Size(94, 22);
            this.afkomLøver.TabIndex = 10;
            this.afkomLøver.Text = "Løveunger:";
            // 
            // wildebeestOffspringLbl
            // 
            this.wildebeestOffspringLbl.AutoSize = true;
            this.wildebeestOffspringLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.wildebeestOffspringLbl.Location = new System.Drawing.Point(332, 64);
            this.wildebeestOffspringLbl.Name = "wildebeestOffspringLbl";
            this.wildebeestOffspringLbl.Size = new System.Drawing.Size(18, 22);
            this.wildebeestOffspringLbl.TabIndex = 9;
            this.wildebeestOffspringLbl.Text = "0";
            // 
            // afkomGnuer
            // 
            this.afkomGnuer.AutoSize = true;
            this.afkomGnuer.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.afkomGnuer.Location = new System.Drawing.Point(278, 64);
            this.afkomGnuer.Name = "afkomGnuer";
            this.afkomGnuer.Size = new System.Drawing.Size(56, 22);
            this.afkomGnuer.TabIndex = 8;
            this.afkomGnuer.Text = "Kalve:";
            // 
            // lionMaleLbl
            // 
            this.lionMaleLbl.AutoSize = true;
            this.lionMaleLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lionMaleLbl.Location = new System.Drawing.Point(198, 151);
            this.lionMaleLbl.Name = "lionMaleLbl";
            this.lionMaleLbl.Size = new System.Drawing.Size(18, 22);
            this.lionMaleLbl.TabIndex = 7;
            this.lionMaleLbl.Text = "0";
            // 
            // lionFemaleLbl
            // 
            this.lionFemaleLbl.AutoSize = true;
            this.lionFemaleLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lionFemaleLbl.Location = new System.Drawing.Point(74, 153);
            this.lionFemaleLbl.Name = "lionFemaleLbl";
            this.lionFemaleLbl.Size = new System.Drawing.Size(18, 22);
            this.lionFemaleLbl.TabIndex = 6;
            this.lionFemaleLbl.Text = "0";
            // 
            // wildebeestFMaleLbl
            // 
            this.wildebeestFMaleLbl.AutoSize = true;
            this.wildebeestFMaleLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.wildebeestFMaleLbl.Location = new System.Drawing.Point(198, 64);
            this.wildebeestFMaleLbl.Name = "wildebeestFMaleLbl";
            this.wildebeestFMaleLbl.Size = new System.Drawing.Size(18, 22);
            this.wildebeestFMaleLbl.TabIndex = 5;
            this.wildebeestFMaleLbl.Text = "0";
            // 
            // wildebeestFemaleLbl
            // 
            this.wildebeestFemaleLbl.AutoSize = true;
            this.wildebeestFemaleLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.wildebeestFemaleLbl.Location = new System.Drawing.Point(74, 68);
            this.wildebeestFemaleLbl.Name = "wildebeestFemaleLbl";
            this.wildebeestFemaleLbl.Size = new System.Drawing.Size(18, 22);
            this.wildebeestFemaleLbl.TabIndex = 4;
            this.wildebeestFemaleLbl.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WinFormSimba.Resource1.lionMaleStatistics;
            this.pictureBox4.Location = new System.Drawing.Point(126, 131);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinFormSimba.Resource1.lionFemaleStatistics;
            this.pictureBox3.Location = new System.Drawing.Point(5, 131);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormSimba.Resource1.wildbeestMaleStatistics;
            this.pictureBox2.Location = new System.Drawing.Point(129, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnActivateRounde
            // 
            this.btnActivateRounde.BackColor = System.Drawing.SystemColors.Window;
            this.btnActivateRounde.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnActivateRounde.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateRounde.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnActivateRounde.Location = new System.Drawing.Point(696, 498);
            this.btnActivateRounde.Name = "btnActivateRounde";
            this.btnActivateRounde.Size = new System.Drawing.Size(143, 85);
            this.btnActivateRounde.TabIndex = 1;
            this.btnActivateRounde.Text = "Kør en omgang";
            this.btnActivateRounde.UseVisualStyleBackColor = false;
            this.btnActivateRounde.Visible = false;
            this.btnActivateRounde.Click += new System.EventHandler(this._btnActivateRounde_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.SavannaBoard);
            this.Name = "MainForm1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Savannen";
            this.SavannaBoard.ResumeLayout(false);
            this.startConPnl.ResumeLayout(false);
            this.startConPnl.PerformLayout();
            this.board.ResumeLayout(false);
            this.statisticsPanel.ResumeLayout(false);
            this.statisticsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SavannaBoard;
        private System.Windows.Forms.Button btnActivateRounde;
        private System.Windows.Forms.Panel statisticsPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnFlereRunder;
        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Button btnDrawFields;
        private System.Windows.Forms.Panel drawPanelGrid;
        private System.Windows.Forms.Button _btnRemovePanelGrid;
        private System.Windows.Forms.Label wildebeestFemaleLbl;
        private System.Windows.Forms.Label lionMaleLbl;
        private System.Windows.Forms.Label lionFemaleLbl;
        private System.Windows.Forms.Label wildebeestFMaleLbl;
        private System.Windows.Forms.Label wildebeestOffspringLbl;
        private System.Windows.Forms.Label afkomGnuer;
        private System.Windows.Forms.Label lionOffspringLbl;
        private System.Windows.Forms.Label afkomLøver;
        private System.Windows.Forms.Label Statistik;
        private System.Windows.Forms.TextBox NbrGrassTxtBox;
        private System.Windows.Forms.Label GrassLbl;
        private System.Windows.Forms.TextBox NbrLionsTxtBox;
        private System.Windows.Forms.Label løverLbl;
        private System.Windows.Forms.TextBox NbrWildebeestTxtBox;
        private System.Windows.Forms.Label gnuerLbl;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Button btnBeginGame;
        private System.Windows.Forms.Button btnStopGame;
        private System.Windows.Forms.Panel startConPnl;
        private System.Windows.Forms.Label totalNbrOfAnimalsOutputLbl;
        private System.Windows.Forms.Label totalAnmLbl;
        private System.Windows.Forms.Timer timerGraphics;
        private System.Windows.Forms.Label showRoundNbr;
        private System.Windows.Forms.Label rundelbl;
    }
}

