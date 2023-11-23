using GameOfLife_Visual.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife_Visual.VisualComponents
{
    public partial class Game : Form
    {
        public int RowNumber;
        public int ColumnNumber;
        private GameBord gameBord;
        public Game(int rowNumber, int columnNumber)
        {
            RowNumber = rowNumber;
            ColumnNumber = columnNumber;
            InitializeComponent();
            tableLayoutPanel.RowCount = RowNumber;
            tableLayoutPanel.ColumnCount = ColumnNumber;
            tableLayoutPanel.AutoSize = true;
            gameBord = new GameBord(RowNumber, ColumnNumber);
            this.MouseClick += MainForm_MouseClick;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int panelWidth = screenWidth / ColumnNumber;
            int panelHeight = screenHeight / RowNumber;

            Parallel.For(0, RowNumber, i =>
            {
                for (int j = 0; j < ColumnNumber; j++)
                {
                    Panel block = new Panel();
                    block.BackColor = gameBord.Bord[i, j] ? Color.Green : Color.Black;
                    //block.Dock = DockStyle.Fill;
                    block.Margin = new Padding(1);
                    block.Width = panelWidth;
                    block.Height = panelHeight;
                    block.MouseClick += MainForm_MouseClick;

                    // Use Invoke to ensure thread-safe addition to tableLayoutPanel
                    tableLayoutPanel.Invoke(new Action(() =>
                    {
                        tableLayoutPanel.Controls.Add(block, j, i);
                    }));
                }
            });

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            gameBord.Simulate();
            UpdateUI();
        }
        private void UpdateUI()
        {
            // Create a list to store the controls for parallel processing
            List<Control> controlsToUpdate = new List<Control>();

            // Collect controls from the tableLayoutPanel for parallel processing
            foreach (Control control in tableLayoutPanel.Controls)
            {
                if (control is Panel panel)
                {
                    controlsToUpdate.Add(panel);
                }
            }

            // Update the UI controls in parallel
            Parallel.ForEach(controlsToUpdate, panel =>
            {
                int row = tableLayoutPanel.GetRow(panel);
                int column = tableLayoutPanel.GetColumn(panel);

                // Update the panel's background color based on the game board state
                panel.BackColor = gameBord.Bord[column, row] ? Color.Green : Color.Black;
            });
        }
    }
}
