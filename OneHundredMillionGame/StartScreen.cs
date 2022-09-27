/*
 * 
 * File Name: StartScreen.cs
 * Description: Show the game's start screen with instructions
 * 
 * Project Revision:
 *      Guilherme Bueno, 2022.09.25: Created
 *      Guilherme Bueno, 2022.09.26: Bug fix
 *      Guilherme Bueno, 2022.09.27: Final Review
 * 
*/



using OneHundredMillionGame.PlayerInformations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneHundredMillionGame
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();

            //instructions are loaded and displayed
            richTextBox1.Text = "General Instructions:" +
                "\n-Enter your name and press enter" +
                "\n-A random question will be displayed and you will have 60 seconds to answer it" +
                "\n-A hint of the questions can be displayed once by clicking Hint button" +
                "\n-By clicking the 50/50 button, half of incorrect answers will be removed" +
                "\n-You will win the game when you reach 100000000 points" +
                "\n-You will lose if you choose the wrong answer and will be automatically redirected to the main screen";
        }



        private void btn_EnterGame_Click(object sender, EventArgs e)
        {

            //Variables initialization;
            string playerName;

            //Player instance initialization
            Player player = new Player();


            try
            {
                //Getting player's name info and storing to Player's class
                playerName = txt_playerName.Text;
                player.PlayerName = playerName;

                
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show("Error: " + ex.Message);
            }


            if (String.IsNullOrEmpty(player.Errors)) //If there is no error recorded start the game (GamePlay form)
            {
                GamePlay gamePlay = new GamePlay(player.PlayerName);
                this.Hide(); 
                gamePlay.ShowDialog();
                this.Close(); //Close current form
            }
            else //An error message will appear if the name input is incorrect
            {
                lbl_Errors.Text = $"{player.Errors}"; 
            }


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
