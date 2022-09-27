/*
 * 
 * File Name: Scoring.cs
 * Description: The player's scoring data class is provided.
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

namespace OneHundredMillionGame.PlayerInformations
{
    public class Scoring
    {
        //Private variables initialization for the Scoring class
        private string _currentPlayerName;
        private int _score;
        private string _errors;
        private bool _wasHintUsed;
        private bool _was5050Used;

        //Default Constructor
        public Scoring()
        {
        }

        // Constructor with player name and scoring parameters
        public Scoring(string currentPlayerName, int score)
        {
            CurrentPlayerName = currentPlayerName;
            Score = score;
        }

        //Properties and data validation of Score field.
        public int Score { get { return _score; } set {
                this._score = value;
            } }

        //Properties and data validation of Player Name field.
        public string CurrentPlayerName { get { return _currentPlayerName; } set {
                this._currentPlayerName = value;
            } }

        //Properties Get for the Errors field.
        public string Errors { get { return _errors; } }

        //Properties of wasHintUsed field. This refers to the Hint button.
        public bool wasHintUsed { get { return _wasHintUsed; } set
            {
                this._wasHintUsed = value;
            }
        }
        //Properties of was5050Used field. This refers to the Hint button.
        public bool was5050Used { get { return _was5050Used;  } set {
                this._was5050Used = value;
            } }
    }
}
