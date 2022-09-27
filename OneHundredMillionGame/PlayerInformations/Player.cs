/*
 * 
 * File Name: Player.cs
 * Description: Provides a data class for the player's name
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
    public class Player
    {
        //Private variables initialization for the Player
        private string _playerName;
        private string _errors;

        //Default Constructor
        public Player()
        {

        }

        // Constructor with player name parameter
        public Player(string playerName)
        {
            PlayerName = playerName;
        }

        //Properties and data validation of Player Name field.
        public string PlayerName
        {
            get { return _playerName; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value) && value.Length <= 20)
                {
                    _playerName = value;
                }
                else
                {
                    _errors += "\nA player's name cannot be empty or longer than 20 characters ";
                }
            }
        }

        //Properties Get for the Errors field.
        public string Errors { get { return _errors; } }
    }
}
