using SampleCode.GameOfLifeCore;
using SampleCode.GameOfLifeUI;
using SampleCode.GameOfLifeUI.Base;

namespace SampleCode.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            var neighbourCellsFinder = new NeighbourCellsFinder();
            var gameRules = new GameRules(new LiveCellRule(), new DeadCellRule());
            var evolution = new Evolution(neighbourCellsFinder, gameRules);
            var gridRowColumnParser = new GridRowColumnParser();
            //could replace this code using an IoC container
            IGameOfLife gameOfLife = new GameOfLifeUI.GameOfLife(evolution, gridRowColumnParser);
            gameOfLife.Start();
        }
    }
}