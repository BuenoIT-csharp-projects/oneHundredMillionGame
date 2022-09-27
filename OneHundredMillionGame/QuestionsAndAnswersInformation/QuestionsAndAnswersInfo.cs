/*
 * 
 * File Name: QestionAndAnswersInfo.cs
 * Description: Provides a data class for the game's questions and answers
 * 
 * Project Revision:
 *      Guilherme Bueno, 2022.09.25: Created
 *      Guilherme Bueno, 2022.09.26: Bug fix
 *      Guilherme Bueno, 2022.09.27: Final Review
 * 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHundredMillionGame.QuestionsAndAnswers
{
    internal class QuestionsAndAnswersInfo
    {

        //Properties of the Questions and Answers
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string IncorrectAnswer1 { get; set; }
        public string IncorrectAnswer2 { get; set; }
        public string IncorrectAnswer3 { get; set; }
        public string Hint { get; set; }


        //Validation method for determining whether the answer is correct;
        public bool IsAnswerCorrect(string userAnswer)
        {
            if (userAnswer == this.CorrectAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
