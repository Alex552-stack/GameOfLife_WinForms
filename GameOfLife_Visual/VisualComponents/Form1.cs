using GameOfLife_Visual.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GameOfLife_Visual
{
    public partial class Form1 : Form
    {
        private bool firstClickLines = true;
        private bool firstClickRows = true;
        public int RowNumber { get; private set; }
        public int LinesNumber { get; private set; }
        public Form1()
        {
            InitializeComponent();
            Initialize_Button.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton()
        {
            if (!firstClickLines && !firstClickRows) { Initialize_Button.Enabled = true; } 
        }

        private void InputLines_KeyPress(object sender, KeyPressEventArgs e)
        {

            e = TextBoxController.Input_Only_Char(e);
            UpdateButton();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void InputRows_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = TextBoxController.Input_Only_Char(e);
            UpdateButton();
        }

        private void InputRows_Click(object sender, EventArgs e)
        {
            if(firstClickRows) 
            {
                InputRows.Text = string.Empty;
                firstClickRows = false;
            }
        }

        private void InputLines_Click(object sender, EventArgs e)
        {
            if(firstClickLines)
            {
                InputLines.Text = string.Empty;
                firstClickLines = false;
            }
        }

        private void Initialize_Button_Click(object sender, EventArgs e)
        {
            LinesNumber = int.Parse(InputLines.Text);
            RowNumber = int.Parse(InputRows.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
