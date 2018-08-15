using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Rover
    {
        public char direction = 'N';
        public Coordinates coordinates = new Coordinates();
        public bool obstacle = false;
        List<Coordinates> obstacles = new List<Coordinates>();

        readonly Dictionary<char, char> North = new Dictionary<char, char>() { { 'L', 'W' }, { 'R', 'E' } };
        readonly Dictionary<char, char> East = new Dictionary<char, char>() { { 'L', 'N' }, { 'R', 'S' } };
        readonly Dictionary<char, char> South = new Dictionary<char, char>() { { 'L', 'E' }, { 'R', 'W' } };
        readonly Dictionary<char, char> West = new Dictionary<char, char>() { { 'L', 'S' }, { 'R', 'N' } };

        public Rover() { }

        public Rover(List<Coordinates> obstacles)
        {
            this.obstacles = obstacles;
        }

        public string GetCoordinates()
        {
            return Format();
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

        public string Format()
        {
            return (obstacle ? "O:" : "") + coordinates.X + ":" + coordinates.Y + ":" + direction;
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

            if (obstacles.Contains(nextCoordinates))
            {
                obstacle = true;
            }
            else
            {
                coordinates = nextCoordinates;
            }

        }

        public void Rotate(char command)
        {
            if (direction == 'N') direction = North[command];
            else if (direction == 'E') direction = East[command];
            else if (direction == 'S') direction = South[command];
            else if (direction == 'W') direction = West[command];
        }

        public void TurnAround()
        {
            Rotate('R');
            Rotate('R');
        }

    }
}
