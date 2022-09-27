/*
 * 
 * File Name: GamePlay.cs
 * Description: Provide a user interface with buttons for interacting with the game
 * 
 * Project Revision:
 *      Guilherme Bueno, 2022.09.25: Created
 *      Guilherme Bueno, 2022.09.26: Bug fix
 *      Guilherme Bueno, 2022.09.27: Final Review
 * 
*/


using OneHundredMillionGame.PlayerInformations;
using OneHundredMillionGame.QuestionsAndAnswers;
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
    public partial class GamePlay : Form
    {
        //Variables, lists and instances initialization
        string playerName;
        int countdownSeconds;
        int totalScore = 0;
        string[] buttonsDisplay = new string[4];
        string[] shuffleDisplayButtons = new string[4];
        bool hasUserAnsweredQuestion = false;
        string currentCorrectAnswer;
        Random random = new Random();
        List<QuestionsAndAnswersInfo> questionsAndAnwersList = new List<QuestionsAndAnswersInfo>();
        List<QuestionsAndAnswersInfo> shuffleQuestionsAndAnswersList = new List<QuestionsAndAnswersInfo>();
        Scoring playerScore = new Scoring();

        //Constructor Default
        public GamePlay()
        {
            InitializeComponent();
        }

        //Constructor With Value (player name variable from Start Screen)
        public GamePlay(string value)
        {
            InitializeComponent();

            // Display and store player name information to the game mode
            lbl_playerNameGame.Text = value;
            playerName = value;


            //Add values (questions and answers) to the list
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "How long is an Olympic swimming pool (in meters)?", CorrectAnswer = "50 meters", IncorrectAnswer1 = "30 meters", IncorrectAnswer2 = "40 meters", IncorrectAnswer3 = "60 meters", Hint = "Half of 100" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "What geometric shape is generally used for stop signs?", CorrectAnswer = "Octagon", IncorrectAnswer1 = "Triangle", IncorrectAnswer2 = "Cube", IncorrectAnswer3 = "Circle", Hint = "8 sides" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "What is 'cynophobia' ?", CorrectAnswer = "Fear of dogs", IncorrectAnswer1 = "Fear of cars", IncorrectAnswer2 = "Fear of studying", IncorrectAnswer3 = "Fear of heights", Hint = "Pets" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "How many languages are written from right to left?", CorrectAnswer = "12", IncorrectAnswer1 = "2", IncorrectAnswer2 = "6", IncorrectAnswer3 = "20", Hint = "Egg box" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "What is the name of the biggest technology company in South Korea?", CorrectAnswer = "Samsung", IncorrectAnswer1 = "Apple", IncorrectAnswer2 = "Alibaba", IncorrectAnswer3 = "Microsoft", Hint = "Galaxy series" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "Which animal can be seen on the Porsche logo?", CorrectAnswer = "Horse", IncorrectAnswer1 = "Bird", IncorrectAnswer2 = "Spider", IncorrectAnswer3 = "Lion", Hint = "Jockey" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "Which country consumes the most chocolate per capita?", CorrectAnswer = "Switzerland", IncorrectAnswer1 = "Brazil", IncorrectAnswer2 = "Canada", IncorrectAnswer3 = "United States", Hint = "Oktoberfest" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "What is the most consumed manufactured drink in the world?", CorrectAnswer = "Tea", IncorrectAnswer1 = "Coke", IncorrectAnswer2 = "Juice", IncorrectAnswer3 = "Beer", Hint = "Green" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "Which is the only edible food that never goes bad?", CorrectAnswer = "Honey", IncorrectAnswer1 = "Sausage", IncorrectAnswer2 = "Chicken", IncorrectAnswer3 = "Bread", Hint = "Bee" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "How many points did Michael Jordan score on his first NBA game?", CorrectAnswer = "16 points", IncorrectAnswer1 = "40 points", IncorrectAnswer2 = "36 points", IncorrectAnswer3 = "22 points", Hint = "8+8" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "How many colors are there in the rainbow?", CorrectAnswer = "Seven", IncorrectAnswer1 = "Six", IncorrectAnswer2 = "Eight", IncorrectAnswer3 = "Nine", Hint = "3+4" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "What color is a ruby?", CorrectAnswer = "Red", IncorrectAnswer1 = "Purple", IncorrectAnswer2 = "Pink", IncorrectAnswer3 = "Black", Hint = "Blood" });
            questionsAndAnwersList.Add(new QuestionsAndAnswersInfo() { Question = "What is the loudest animal on Earth?", CorrectAnswer = "Whales", IncorrectAnswer1 = "Dogs", IncorrectAnswer2 = "Lions", IncorrectAnswer3 = "Cats", Hint = "Ocean" });


            //Shuffle Questions List
            shuffleQuestionsAndAnswersList = questionsAndAnwersList.OrderBy(question => random.Next()).ToList();

            //Assigning answers to each button
            buttonsDisplay[0] = shuffleQuestionsAndAnswersList[0].CorrectAnswer;
            buttonsDisplay[1] = shuffleQuestionsAndAnswersList[0].IncorrectAnswer1;
            buttonsDisplay[2] = shuffleQuestionsAndAnswersList[0].IncorrectAnswer2;
            buttonsDisplay[3] = shuffleQuestionsAndAnswersList[0].IncorrectAnswer3;

            //Shuffle Buttons 
            var shuffleDisplayButtons = buttonsDisplay.OrderBy(question => random.Next()).ToArray();

            //Display Questions informations to the Game For Rich Box Text and Buttons
            richQuestionBox.Text = shuffleQuestionsAndAnswersList[0].Question;
            btn_Option1.Text = shuffleDisplayButtons[0];
            btn_Option2.Text = shuffleDisplayButtons[1];
            btn_Option3.Text = shuffleDisplayButtons[2];
            btn_Option4.Text = shuffleDisplayButtons[3];

            //Set up the player name to the class Scoring
            playerScore.CurrentPlayerName = playerName;
            
            //Storing the correct answer to a variable
            currentCorrectAnswer = shuffleQuestionsAndAnswersList[0].CorrectAnswer;

        }

        
        private void GamePlay_Load(object sender, EventArgs e)
        {

            //Initialize Scoring Player Class
            Scoring playerScore = new Scoring(playerName, totalScore);

            //Setting the timer and starting from the load of the game
            countdownSeconds = 60;
            lbl_countdownSeconds.Text = countdownSeconds.ToString();
            countdownTimer.Start();

            //Display first question to the user
            var randomQuestions = new Random();
            var shuffled = questionsAndAnwersList.OrderBy(question => randomQuestions.Next());

            //Button next is unavailable until user choose an answer
            btn_Next.Enabled = false;
            btn_Next.BackColor = Color.Gray;

            //Arrangement of colors
            pbBox1.BackColor = Color.Goldenrod;
            lbl_1.BackColor = Color.Goldenrod;
            lbl_100.BackColor = Color.Goldenrod;

            //At the beginning of the game, display the player's score
            lblPlayerScore2.Text= playerScore.Score.ToString();

            //Align the question text to the rich box's center
            richQuestionBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            //Decrease countdown of the timer
            countdownSeconds--;

            if (countdownSeconds == 0) //Restart Countdown and call next button event
            {
                if (hasUserAnsweredQuestion) // if user has answered the question
                {
                    //Restart Countdown and timer
                    lbl_countdownSeconds.Text = "ZERO";
                    countdownSeconds = 60;
                    countdownTimer.Start();

                    //Call Next button event to save informations and display new question to the user
                    btn_Next.PerformClick();

                    //Reset variable of answering
                    hasUserAnsweredQuestion = false;
                }
                else // if user has NOT answered the question
                {
                    //Stop timer, display user points and close form
                    countdownTimer.Stop();
                    playerScore.Score = totalScore;
                    MessageBox.Show($"You have not answered. You will be redirect to the main screen. \n You have scored: {playerScore.Score}");
                    StartScreen startScreen = new StartScreen();
                    this.Hide();
                    startScreen.ShowDialog();
                    this.Close();
                }


            } //Countdown 3..2...1...
            else if (countdownSeconds == 1)
            {
                lbl_countdownSeconds.Text = "ONE"; // Countdown last second
            }
            else if (countdownSeconds == 2)
            {
                lbl_countdownSeconds.Text = "TWO"; // Countdown last two seconds
            }
            else if (countdownSeconds == 3)
            {
                lbl_countdownSeconds.Text = "THREE"; // Countdown last three seconds
            }
            else
            {
                //Keep updating label to display to player the countdown timer
                lbl_countdownSeconds.Text = countdownSeconds.ToString();
            }
            
        }

        private void btn_hint_Click(object sender, EventArgs e)
        {
            //Setting up the variable thar user has used the button hint
            playerScore.wasHintUsed = true;

            //Display Hint information
            btn_hint.Text = shuffleQuestionsAndAnswersList[0].Hint;

            //Disable button
            btn_hint.Enabled = false;
            

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            //Check if user has used button hint
            if (playerScore.wasHintUsed) // If yes
            {
                //Colors, disable button and text are assigned
                btn_hint.Text = "Hint";
                btn_hint.BackColor = Color.Gray;
                btn_hint.Enabled=false;
            }
            else // If not
            {
                //Enable button and color is assigned
                btn_hint.Enabled = true;
                btn_hint.BackColor = Color.RoyalBlue;
            }

            //Check if user has used button 5050
            if (playerScore.was5050Used) // If yes
            {
                //color is assigned
                btn5050.BackColor = Color.Gray;
            }
            else //If not
            {
                //Enable button and color is assigned
                btn5050.Enabled = true;
                btn5050.BackColor = Color.RoyalBlue;
            }
                    
            //Reset variable of answering
            hasUserAnsweredQuestion = false;

            //Refresh countdown timer and start
            countdownSeconds = 60;
            countdownTimer.Start();

            //Remove questions and answers already used from list
            shuffleQuestionsAndAnswersList.RemoveAt(0);

            //Save points
            if (totalScore == 0)
            {
                totalScore = 100;
            }
            else if (totalScore == 10000000) // If user reach 100000000 points the user will win the game and the form will be closed.
            {
                totalScore *= 10;
                playerScore.Score = totalScore;
                MessageBox.Show($"You have won the game! Congratulations !!\n{playerScore.CurrentPlayerName} you earned a total of {playerScore.Score} points!","Well Done",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                StartScreen startScreen = new StartScreen();
                this.Hide();
                startScreen.ShowDialog();
                this.Close();
            }
            else 
            {
                totalScore *= 10; //Current score will be multiplied by 10

            }

            //Display New Questions to the user

            //Assigning answers to the button array
            buttonsDisplay[0] = shuffleQuestionsAndAnswersList[0].CorrectAnswer;
            buttonsDisplay[1] = shuffleQuestionsAndAnswersList[0].IncorrectAnswer1;
            buttonsDisplay[2] = shuffleQuestionsAndAnswersList[0].IncorrectAnswer2;
            buttonsDisplay[3] = shuffleQuestionsAndAnswersList[0].IncorrectAnswer3;

            //Shuffle the answers
            shuffleDisplayButtons = buttonsDisplay.OrderBy(question => random.Next()).ToArray();

            //Display questions informations to the game
            richQuestionBox.Text = shuffleQuestionsAndAnswersList[0].Question;
            btn_Option1.Text = shuffleDisplayButtons[0];
            btn_Option2.Text = shuffleDisplayButtons[1];
            btn_Option3.Text = shuffleDisplayButtons[2];
            btn_Option4.Text = shuffleDisplayButtons[3];

            //Save players informations (name and score)
            playerScore.CurrentPlayerName = playerName;
            playerScore.Score = totalScore;

            //Update User Score
            lblPlayerScore2.Text = playerScore.Score.ToString();


            //Colors points to display in the screen
            if (playerScore.Score == 0)
            {
                pbBox1.BackColor = Color.Goldenrod;
                lbl_1.BackColor = Color.Goldenrod;
                lbl_100.BackColor = Color.Goldenrod;
            }
            else if (playerScore.Score == 100)
            {
                pbBox1.BackColor = Color.Green;
                lbl_1.BackColor = Color.Green;
                lbl_100.BackColor = Color.Green;
                pbBox2.BackColor = Color.Goldenrod;
                lbl_2.BackColor = Color.Goldenrod;
                lbl_1000.BackColor = Color.Goldenrod;
            }
            else if (playerScore.Score == 1000)
            {
                pbBox2.BackColor = Color.DarkSeaGreen;
                lbl_2.BackColor = Color.DarkSeaGreen;
                lbl_1000.BackColor = Color.DarkSeaGreen;
                pbBox3.BackColor = Color.Goldenrod;
                lbl_3.BackColor = Color.Goldenrod;
                lbl_10000.BackColor = Color.Goldenrod;
            }
            else if (playerScore.Score == 10000)
            {
                pbBox3.BackColor = Color.Green;
                lbl_3.BackColor = Color.Green;
                lbl_10000.BackColor = Color.Green;
                pbBox4.BackColor = Color.Goldenrod;
                lbl_4.BackColor = Color.Goldenrod;
                lbl_100000.BackColor = Color.Goldenrod;
            }
            else if (playerScore.Score == 100000)
            {
                lbl_4.BackColor = Color.DarkSeaGreen;
                lbl_100000.BackColor= Color.DarkSeaGreen;
                pbBox4.BackColor = Color.DarkSeaGreen;
                pbBox5.BackColor = Color.Goldenrod;
                lbl_5.BackColor = Color.Goldenrod;
                lbl_1000000.BackColor = Color.Goldenrod;
            }
            else if (playerScore.Score == 1000000)
            {
                lbl_5.BackColor = Color.Green;
                lbl_1000000.BackColor = Color.Green;
                pbBox5.BackColor = Color.Green;
                pbBox6.BackColor = Color.Goldenrod;
                lbl_10000000.BackColor = Color.Goldenrod;
                lbl_6.BackColor = Color.Goldenrod;
            }
            else if (playerScore.Score == 10000000)
            {
                lbl_10000000.BackColor = Color.DarkSeaGreen;
                lbl_6.BackColor = Color.DarkSeaGreen;
                pbBox6.BackColor = Color.DarkSeaGreen;
                pbBox7.BackColor = Color.Goldenrod;
                lbl_7.BackColor = Color.Goldenrod;
                lbl_100000000.BackColor = Color.Goldenrod;
            }

            //enable options
            btn_Option1.Enabled = true;
            btn_Option2.Enabled = true;
            btn_Option3.Enabled = true;
            btn_Option4.Enabled = true;
            btn_Option1.BackColor = Color.RoyalBlue;
            btn_Option2.BackColor = Color.RoyalBlue;
            btn_Option3.BackColor = Color.RoyalBlue;
            btn_Option4.BackColor = Color.RoyalBlue;

            //disable options
            btn_Next.Enabled = false;
            btn_Next.BackColor = Color.Gray;

            //Save Correct Answer to the variable
            currentCorrectAnswer = shuffleQuestionsAndAnswersList[0].CorrectAnswer;
            
            //Align question text to the center
            richQuestionBox.SelectionAlignment = HorizontalAlignment.Center;

        }

        private void btn_Option1_Click(object sender, EventArgs e)
        {
            //Check if answer was correct
            if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option1.Text)) //If yes
            {
                //Stop counter and display a message
                countdownTimer.Stop();
                MessageBox.Show("Correct Answer! Click Next to continue...");
                hasUserAnsweredQuestion = true;

                //disable options
                btn_Option1.Enabled = false;
                btn_Option2.Enabled = false;
                btn_Option3.Enabled = false;
                btn_Option4.Enabled = false;
                btn5050.Enabled = false;
                btn_hint.Enabled = false;
                btn_Option1.BackColor = Color.Gray;
                btn_Option2.BackColor = Color.Gray;
                btn_Option3.BackColor = Color.Gray;
                btn_Option4.BackColor = Color.Gray;
                btn5050.BackColor = Color.Gray;
                btn_hint.BackColor = Color.Gray;
                btn_hint.FlatAppearance.BorderColor = Color.Gray;


                //enable options
                btn_Next.Enabled = true;
                btn_Next.BackColor = Color.Red;
            }
            else //If not
            {
                //Stop counter
                countdownTimer.Stop();

                //Check which button contains the correct answer and highlight it for the user
                if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option2.Text))    
                {
                    btn_Option2.BackColor = Color.Yellow;
                    btn_Option2.ForeColor = Color.Black;

                }
                else if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option3.Text))
                {
                    btn_Option3.BackColor = Color.Yellow;
                    btn_Option3.ForeColor = Color.Black;
                }
                else if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option4.Text))
                {
                    btn_Option4.BackColor = Color.Yellow;
                    btn_Option4.ForeColor = Color.Black;
                }

                //Store user's points information
                playerScore.Score = totalScore;

                //Display message
                MessageBox.Show($"Incorrect Answer!\n\nBetter Try next time\n\nThe Correct answer was '{currentCorrectAnswer}' \n\nYou have scored: {playerScore.Score}\n", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hasUserAnsweredQuestion = false;

                //Reopen StartScreen after closing the form
                StartScreen startScreen = new StartScreen();
                this.Hide();
                startScreen.ShowDialog();
                this.Close();
            }
            
        }

        private void btn_Option2_Click(object sender, EventArgs e)
        {
            //Check if answer was correct
            if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option2.Text)) //If yes
            {
                //Stop counter and display a message
                countdownTimer.Stop();
                MessageBox.Show("Correct Answer! Click Next to continue...");
                hasUserAnsweredQuestion = true;

                //disable options
                btn_Option1.Enabled = false;
                btn_Option2.Enabled = false;
                btn_Option3.Enabled = false;
                btn_Option4.Enabled = false;
                btn5050.Enabled = false;
                btn_hint.Enabled = false;
                btn_Option1.BackColor = Color.Gray;
                btn_Option2.BackColor = Color.Gray;
                btn_Option3.BackColor = Color.Gray;
                btn_Option4.BackColor = Color.Gray;
                btn5050.BackColor = Color.Gray;
                btn_hint.BackColor = Color.Gray;
                btn_hint.FlatAppearance.BorderColor = Color.Gray;

                //enable options
                btn_Next.Enabled = true;
                btn_Next.BackColor = Color.Red;

            }
            else //If not
            {
                //Stop counter
                countdownTimer.Stop();

                //Check which button contains the correct answer and highlight it for the user
                if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option1.Text))
                {
                    btn_Option1.ForeColor = Color.Black;
                    btn_Option1.BackColor = Color.Yellow;

                }
                else if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option3.Text))
                {
                    btn_Option3.BackColor = Color.Yellow;
                    btn_Option3.ForeColor = Color.Black;
                }
                else if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option4.Text))
                {
                    btn_Option4.BackColor = Color.Yellow;
                    btn_Option4.ForeColor = Color.Black;
                }

                //Store user's points information
                playerScore.Score = totalScore;

                //Display message
                MessageBox.Show($"Incorrect Answer!\n\nBetter Try next time\n\nThe Correct answer was '{currentCorrectAnswer}' \n\nYou have scored: {playerScore.Score}\n", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hasUserAnsweredQuestion = false;

                //Reopen StartScreen after closing the form
                StartScreen startScreen = new StartScreen();
                this.Hide();
                startScreen.ShowDialog();
                this.Close();
            }
        }

        private void btn_Option3_Click(object sender, EventArgs e)
        {
            //Check if answer was correct
            if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option3.Text)) //If yes
            {
                //Stop counter and display a message
                countdownTimer.Stop();
                MessageBox.Show("Correct Answer! Click Next to continue...");
                hasUserAnsweredQuestion = true;

                //disable options
                btn_Option1.Enabled = false;
                btn_Option2.Enabled = false;
                btn_Option3.Enabled = false;
                btn_Option4.Enabled = false;
                btn5050.Enabled = false;
                btn_hint.Enabled = false;
                btn_Option1.BackColor = Color.Gray;
                btn_Option2.BackColor = Color.Gray;
                btn_Option3.BackColor = Color.Gray;
                btn_Option4.BackColor = Color.Gray;
                btn5050.BackColor = Color.Gray;
                btn_hint.BackColor = Color.Gray;
                btn_hint.FlatAppearance.BorderColor = Color.Gray;

                //enable options
                btn_Next.Enabled = true;
                btn_Next.BackColor = Color.Red;

            }
            else //If not
            {
                //Stop counter
                countdownTimer.Stop();

                //Check which button contains the correct answer and highlight it for the user
                if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option1.Text))
                {
                    btn_Option1.BackColor = Color.Yellow;
                    btn_Option1.ForeColor = Color.Black;

                }
                else if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option2.Text))
                {
                    btn_Option2.BackColor = Color.Yellow;
                    btn_Option2.ForeColor = Color.Black;
                }
                else if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option4.Text))
                {
                    btn_Option4.BackColor = Color.Yellow;
                    btn_Option4.ForeColor = Color.Black;
                }

                //Store user's points information
                playerScore.Score = totalScore;

                //Display message
                MessageBox.Show($"Incorrect Answer!\n\nBetter Try next time\n\nThe Correct answer was '{currentCorrectAnswer}' \n\nYou have scored: {playerScore.Score}\n", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hasUserAnsweredQuestion = false;

                //Reopen StartScreen after closing the form
                StartScreen startScreen = new StartScreen();
                this.Hide();
                startScreen.ShowDialog();
                this.Close();
            }
        }

        private void btn_Option4_Click(object sender, EventArgs e)
        {
            //Check if answer was correct
            if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option4.Text)) //If yes
            {
                //Stop counter and display a message
                countdownTimer.Stop();
                MessageBox.Show("Correct Answer! Click Next to continue...");
                hasUserAnsweredQuestion = true;

                //disable options
                btn_Option1.Enabled = false;
                btn_Option2.Enabled = false;
                btn_Option3.Enabled = false;
                btn_Option4.Enabled = false;
                btn5050.Enabled = false;
                btn_hint.Enabled = false;
                btn_Option1.BackColor = Color.Gray;
                btn_Option2.BackColor = Color.Gray;
                btn_Option3.BackColor = Color.Gray;
                btn_Option4.BackColor = Color.Gray;
                btn5050.BackColor = Color.Gray;
                btn_hint.BackColor = Color.Gray;
                btn_hint.FlatAppearance.BorderColor = Color.Gray;

                //enable options
                btn_Next.Enabled = true;
                btn_Next.BackColor = Color.Red;
            }
            else //If not
            {
                //Stop counter
                countdownTimer.Stop();

                //Check which button contains the correct answer and highlight it for the user
                if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option1.Text))
                {
                    btn_Option1.BackColor = Color.Yellow;
                    btn_Option1.ForeColor = Color.Black;

                }
                else if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option2.Text))
                {
                    btn_Option2.BackColor = Color.Yellow;
                    btn_Option2.ForeColor = Color.Black;
                }
                else if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option3.Text))
                {
                    btn_Option3.BackColor = Color.Yellow;
                    btn_Option3.ForeColor = Color.Black;
                }

                //Store user's points information
                playerScore.Score = totalScore;

                //Display message
                MessageBox.Show($"Incorrect Answer!\n\nBetter Try next time\n\nThe Correct answer was '{currentCorrectAnswer}' \n\nYou have scored: {playerScore.Score}\n", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hasUserAnsweredQuestion = false;

                //Reopen StartScreen after closing the form
                StartScreen startScreen = new StartScreen();
                this.Hide();
                startScreen.ShowDialog();
                this.Close();
            }
        }

        private void btn5050_Click(object sender, EventArgs e)
        {
            //Setting up the variable thar user has used the button 50/50
            playerScore.was5050Used = true;

            //Disable button
            btn5050.Enabled = false;

            //ArrayList to store user button name
            string[] buttons = { "btn_Option1", "btn_Option2", "btn_Option3", "btn_Option4" };
            var buttonsList = buttons.ToList();

            //Check which button contains the correct answer
            if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option1.Text))
            {
                buttonsList.RemoveAt(0);
            }
            if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option2.Text))
            {
                buttonsList.RemoveAt(1);
            }
            if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option3.Text))
            {
                buttonsList.RemoveAt(2);
            }
            if (shuffleQuestionsAndAnswersList[0].IsAnswerCorrect(btn_Option4.Text))
            {
                buttonsList.RemoveAt(3);
            }

            //Shuffle array list
            var shuffleButtonsList = buttonsList.OrderBy(button => random.Next()).ToList();

            //Remove the first option.  The ArrayList will then only contain two options
            shuffleButtonsList.RemoveAt(0);

            //It will be disable the buttons whose names match one of the array options (two buttons)
            if (btn_Option1.Name == shuffleButtonsList[0] || btn_Option1.Name == shuffleButtonsList[1])
            {
                btn_Option1.Enabled = false;
                btn_Option1.BackColor = Color.Gray;
            }
            if (btn_Option2.Name == shuffleButtonsList[0] || btn_Option2.Name == shuffleButtonsList[1])
            {
                btn_Option2.Enabled = false;
                btn_Option2.BackColor = Color.Gray;
            }
            if (btn_Option3.Name == shuffleButtonsList[0] || btn_Option3.Name == shuffleButtonsList[1])
            {
                btn_Option3.Enabled = false;
                btn_Option3.BackColor = Color.Gray;
            }
            if (btn_Option4.Name == shuffleButtonsList[0] || btn_Option4.Name == shuffleButtonsList[1])
            {
                btn_Option4.Enabled = false;
                btn_Option4.BackColor = Color.Gray;
            }
        }
    }
}
