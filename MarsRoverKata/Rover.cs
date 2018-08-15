using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Rover
    {
        char direction = 'N';
        Coordinates coordinates = new Coordinates();
        bool encounteredObstacle = false;
        Grid grid = new Grid();

        public Rover() { }

        public Rover(Grid grid)
        {
            this.grid = grid;
        }

        public void Execute(string commands)
        {
            for(var i=0; i<commands.Length; i++)
            {
                switch (commands[i])
                {
                    case 'R':
                    case 'L':
                        Rotate(commands[i]);
                        break;
                    case 'M':
                        Move();
                        break;
                }
            }
        }

        public string GetCoordinates()
        {
            return (encounteredObstacle ? "O:" : "") + coordinates.X + ":" + coordinates.Y + ":" + direction;
        }

        public void Move()
        {
            Coordinates nextCoordinates = new Coordinates(coordinates);

            if (direction == 'N')
            {
                if (nextCoordinates.Y < 9)
                    nextCoordinates.Y++;
                else
                    TurnAround();
            }
            else if (direction == 'S')
            {
                if (nextCoordinates.Y > 0)
                    nextCoordinates.Y--;
                else
                    TurnAround();
            }
            else if (direction == 'E')
            {
                if (nextCoordinates.X < 9)
                    nextCoordinates.X++;
                else
                    TurnAround();
            }
            else if (direction == 'W')
            {
                if (nextCoordinates.X > 0)
                    nextCoordinates.X--;
                else
                    TurnAround();
            }

            if (grid.AreCoordinatesTraversable(nextCoordinates))
                encounteredObstacle = true;
            else
                coordinates = nextCoordinates;
        }

        public void Rotate(char command)
        {
            if (direction == 'N') direction = Coordinates.North[command];
            else if (direction == 'E') direction = Coordinates.East[command];
            else if (direction == 'S') direction = Coordinates.South[command];
            else if (direction == 'W') direction = Coordinates.West[command];
        }

        public void TurnAround()
        {
            Rotate('R');
            Rotate('R');
        }

    }
}
