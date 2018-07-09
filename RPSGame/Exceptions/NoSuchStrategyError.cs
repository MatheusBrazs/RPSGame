using System;

namespace RockPaperScissors.Bll.Exceptions
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError() 
            : base()
        {
        }

        public NoSuchStrategyError(string message) 
            : base(message)
        {
        }
    }
}
