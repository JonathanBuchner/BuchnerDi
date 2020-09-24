using BuchnerDi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuchnerDi.Utilities
{
    public class PlayerInterface : IPlayerInterface
    {
        public void Tell(string message)
        {
            Console.WriteLine(message);
        }

        public string Ask(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
