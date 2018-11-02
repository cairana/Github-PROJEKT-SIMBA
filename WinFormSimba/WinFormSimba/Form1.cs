using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimbaTvaerfagligt;
using System.Threading;


namespace WinFormSimba
{
    public partial class MainForm1 : Form
    {
        private Savanna s = new Savanna();               
        private Bitmap lionFemalePng = new Bitmap(Resource1.lionFemale,31,31);
        private Bitmap lionMalePng = new Bitmap(Resource1.lionMale, 31, 31);
        private Bitmap wildbeestFemalePng = new Bitmap(Resource1.wildbeestFemale, 31, 31);
        private Bitmap wildbeestMalePng = new Bitmap(Resource1.wildbeestMale, 31, 31);
        private Bitmap grassPng = new Bitmap(Resource1.grass, 31, 31);
        private Bitmap savanna = new Bitmap(Resource1.backgroundBright);
        private int nbrOfCells = 20;
        private int squareSize = 31;
        private int antalRunder = 5;
        private bool gameActivated;
        private int roundNbr { get; set; }


        public MainForm1()
        {
            InitializeComponent();
          
        }

        private void savannaBoard_Paint(object sender, PaintEventArgs e)
        {          
            int counter = 0; 

            if (counter == 0)
            {
                e.Graphics.DrawImage(savanna, 0, 0);
                counter++;
            }           
        }

        private void ActivateGame()
        {        
            _optionalStartingConditions();
            s.ActivateGameWithPreConditions();           
            _getStats();
            _showRoundNbr();
            board.Refresh();
            
        }

        private void _showRoundNbr()
        {     
            this.roundNbr++;
            showRoundNbr.Text = roundNbr.ToString();
        }
         private void _btnBeginGame_Click(object sender, EventArgs e)
        {
            this.gameActivated = true;
            ActivateGame();
            btnBeginGame.Visible = false;
            btnActivateRounde.Visible = true;
            btnFlereRunder.Visible = true;
            btnStopGame.Visible = true;
            NbrGrassTxtBox.Clear();
            NbrLionsTxtBox.Clear();
            NbrWildebeestTxtBox.Clear();

        }

        private void _optionalStartingConditions()
        {
            startConPnl.Visible = false;

            //Hvis der ikke bliver indtastet antal dyr og græs så starter spillet med nedenstående. 
            if (!int.TryParse(NbrGrassTxtBox.Text, out s.nbrOfGrassPatches))
            {
                s.nbrOfGrassPatches = 100;
            }
            if (!int.TryParse(NbrLionsTxtBox.Text, out s.nbrOfLions))
            {
                s.nbrOfLions = 10;
            }
            if (!int.TryParse(NbrWildebeestTxtBox.Text, out s.nbrOfWildebeest))
            {
                s.nbrOfWildebeest = 30;
            }         
        }

        private void _stopDueToOverpopulation()
        {
            if (s.OverpopulationStopGame(_getStats()) == true)
            {
                MessageBox.Show("Beklager - Der er ikke plads til flere dyr på savannen og spillet afsluttes");
                StopGame();
            }
        }


        private void _roundAndRefesh()
        {           
            s.DoRound();
            _showRoundNbr();
            _getStats();
            statisticsPanel.Refresh();
            board.Refresh();            
            _stopDueToOverpopulation();
        }
        private void _btnActivateRounde_Click(object sender, EventArgs e)
        {           
            _roundAndRefesh();
        }
        private void _btnFlereRunder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < antalRunder; i++)
            {
                _roundAndRefesh();
                Thread.Sleep(3000);
            }
            
        }
        /// <summary>
        /// Output statestik på GUI 
        /// </summary>
        /// <returns> int totalNbrOffAnimals, til brug i stopDueToOverpopulation();</returns>
        private int _getStats()
        {

            AnimalStats stats = this.s.OutputTotalSavannaLifeOnForm();

            this.wildebeestFemaleLbl.Text = stats.TotalFemaleWildebeests.ToString();
            this.wildebeestFMaleLbl.Text = stats.TotalMaleWildebeests.ToString();
            this.lionFemaleLbl.Text = stats.TotalFemaleLions.ToString();
            this.lionMaleLbl.Text = stats.TotalMaleLions.ToString();
            this.wildebeestOffspringLbl.Text = stats.TotalNbrOffspringWildebeests.ToString();
            this.lionOffspringLbl.Text = stats.TotalNbrOffspringLions.ToString();
            //Tilføjet efter aflevering           
            this.totalNbrOfAnimalsOutputLbl.Text = stats.TotalNbrOffAnimals.ToString();
            int totalNbrOfAnimals = stats.TotalNbrOffAnimals;

            return totalNbrOfAnimals;
        }
        
        private void GrassPng_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < nbrOfCells; x ++)
            {
                for (int y = 0; y < nbrOfCells; y ++)
                {                    
                    if (s.grid[x][y].grass == true)
                    {
                       
                        e.Graphics.DrawImage(grassPng, x * squareSize, y * squareSize);                        
                    }
                }
            }     
        }

        private void AddInitialAnimals_Paint(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < nbrOfCells; x++)
            {
                for (int y = 0; y < nbrOfCells; y++)
                {
                    bool wildebeestFemale = false;
                    bool wildebeestMale = false;
                    bool lionFemale = false;
                    bool lionMale = false;


                    foreach (Animal item in s.grid[x][y].animals)
                    {
                        if (item.Name == "Wildebeest" && item.IsFemale== true && !wildebeestFemale)
                        {
                            e.Graphics.DrawImage(wildbeestFemalePng, x * squareSize, y * squareSize);                           
                            wildebeestFemale = true;                           
                        }
                        if (item.Name == "Wildebeest" && item.IsFemale == false && !wildebeestMale)
                        {
                            e.Graphics.DrawImage(wildbeestMalePng, x * squareSize, y * squareSize);
                            wildebeestMale = true;
                        }
                        if (item.Name == "Lion" && item.IsFemale == false && !lionMale)
                        {
                            e.Graphics.DrawImage(lionMalePng, x * squareSize, y * squareSize);
                            lionMale = true;
                        }
                        if (item.Name == "Lion" && item.IsFemale == true && !lionFemale)
                        {
                            e.Graphics.DrawImage(lionFemalePng, x * squareSize, y * squareSize);                          
                            lionFemale = true;
                        }
                    }
                }
            }
        }

        //void PaintPlayField()
        //{
        //    for (int x = 0; x < nbrOfCells; x++)
        //    {
        //        for (int y = 0; y < nbrOfCells; y++)
        //        {
        //            bool lionFemale = false;

        //            foreach (Animal item in s.grid[x][y].animals)
        //            {
        //                if (item.Name == "Lion" && item.IsFemale == true && !lionFemale)
        //                {
        //                    //e.Graphics.DrawImage(lionFemalePng, x * squareSize, y * squareSize);
        //                    Bitmap lionFemalePng = new Bitmap(Resource1.lionFemale, 31, 31);
        //                    //Bitmap bufl = new Bitmap(pf.Width, pf.Height);
        //                    using (Graphics g = Graphics.FromImage(lionFemalePng))
        //                    {
        //                        //g.FillRectangle(Brushes.Black, new Rectangle(0, 0, pf.Width, pf.Height));
        //                        board.CreateGraphics().DrawImageUnscaled(lionFemalePng, x * squareSize, y * squareSize);
        //                    }
        //                    lionFemale = true;
        //                }
        //            }
        //        }
        //    }


            
        //}

        private void _board_Paint(object sender, PaintEventArgs e)
        {
            GrassPng_Paint(sender, e);
            AddInitialAnimals_Paint(sender, e);
            //this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }


        private bool _doCustomeGrid = false;
        private void _btnDrawFields_Click(object sender, EventArgs e)
        {
            _doCustomeGrid = true;
            drawPanelGrid.Invalidate(true);
            _btnRemovePanelGrid.Visible = true;
            btnDrawFields.Visible = false;                   
        }
        
        private void _drawPanelGrid_Paint(object sender, PaintEventArgs e)
        {            
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            if (_doCustomeGrid)
            {
                for (int i = 0; i <= nbrOfCells; i++)
                {
                    e.Graphics.DrawLine(pen, i * squareSize, 0, i * squareSize, nbrOfCells * squareSize);
                    e.Graphics.DrawLine(pen, 0, i * squareSize, nbrOfCells * squareSize, i * squareSize);
                }             
            }         
        }

        private void _btnRemovePanelGrid_Click(object sender, EventArgs e)
        {
            if (_doCustomeGrid == true)
            {               
                _doCustomeGrid = false;
                this.drawPanelGrid.Refresh();
                btnDrawFields.Visible = true;
                _btnRemovePanelGrid.Visible = false;
            }
        }

        private void NbrWildebeestTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Prøv igen - der kan kun indtastes tal");
            }
        }

        private void NbrLionsTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Prøv igen - der kan kun indtastes tal");
            }
            
        }

        private void NbrGrassTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Prøv igen - der kan kun indtastes tal");
            }
        }

        private void btnStopGame_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void StopGame()
        {
            s.RestartGame();
            SavannaBoard.Refresh();           
            _refreshStatisticsPanel();                                 
            this.gameActivated = false;
            btnBeginGame.Visible = true;
            btnActivateRounde.Visible = false;
            btnFlereRunder.Visible = false;
            btnStopGame.Visible = false;
            startConPnl.Visible = true;
        }

        //Kodet efter aflevering af opgaven
        private void _refreshStatisticsPanel()
        {
            showRoundNbr.Text = 0.ToString();
            this.roundNbr = 0;
            totalNbrOfAnimalsOutputLbl.Text = 0.ToString();
            lionFemaleLbl.Text = 0.ToString();
            lionMaleLbl.Text = 0.ToString();
            wildebeestFemaleLbl.Text = 0.ToString();
            wildebeestFMaleLbl.Text = 0.ToString();
            wildebeestOffspringLbl.Text = 0.ToString();
            lionOffspringLbl.Text = 0.ToString();
        }
    }       
}




