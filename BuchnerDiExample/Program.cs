using BuchnerDi.Utilities;
using System;

namespace BuchnerDi
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Setup(new PlayerInterface())
                            .AskForAmountOfPlayers();
        }
    }
}
