using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Difficulty_Settings
{
    public partial class Form1 : Form
    {
        //global variables
        string heroName;
        string difficultyLevel;

        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            heroName = nameInput.Text;
            difficultyLevel = "easy";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            heroName = nameInput.Text;
            difficultyLevel = "medium";
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            heroName = nameInput.Text;
            difficultyLevel = "hard";
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = $"Welcome {heroName}. \n\nA true brave hero! Go forth and conquer the {difficultyLevel} path!";



        }

        
    }
}
