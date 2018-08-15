using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Coordinates
    {
        public Direction direction = new Direction();
        public int X = 0;
        public int Y = 0;

        public void Execute(char command)
        {
            if (command == 'R' || command == 'L')
                direction.Rotate(command);
            else
                Move();
        }

        public void Move()
        {
            if (direction.Current == 'N')
            {
                if (Y < 9)
                    Y++;
                else
                    direction.TurnAround();
            }
            else if (direction.Current == 'S')
            {
                if (Y > 0)
                    Y--;
                else
                    direction.TurnAround();
            }
            else if (direction.Current == 'E')
            {
                if (X < 9)
                    X++;
                else
                    direction.TurnAround();
            }
            else if (direction.Current == 'W')
            {
                if (X > 0)
                    X--;
                else
                    direction.TurnAround();
            }
        }

        public string Format()
        {
            return X + ":" + Y + ":" + direction.Current;
        }

    }
}
