using BotInterface.Bot;
using BotInterface.Game;

namespace Dynamite
{
    public class Bot : IBot
    {
        public Move MakeMove(Gamestate gamestate)
        {
            return Move.P;
        }
    }
}