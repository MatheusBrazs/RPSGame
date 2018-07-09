using System;

namespace RockPaperScissors.Bll.Exceptions
{
    public class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError() 
            : base()
        {
        }

        public WrongNumberOfPlayersError(string message) 
            : base(message)
        {
        }
    }
}
