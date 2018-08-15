using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Rover
    {
        protected char direction = 'N';
        
        public string GetCoordinates()
        {
            return "0:0:" + direction;
        }

        public void Execute(string commands)
        {
            for(var i=0; i<commands.Length; i++)
            {
                Rotate(commands[i]);
            }
        }

        protected void Rotate(char command)
        {
            if (direction == 'N')
            {
                if (command == 'R')
                    direction = 'E';
                else if (command == 'L')
                    direction = 'W';
            }
            else if (direction == 'E')
            {
                if (command == 'R')
                    direction = 'S';
                else if (command == 'L')
                    direction = 'N';
            }
            else if (direction == 'S')
            {
                if (command == 'R')
                    direction = 'W';
                else if (command == 'L')
                    direction = 'E';
            }
            else if (direction == 'W')
            {
                if (command == 'R')
                    direction = 'N';
                else if (command == 'L')
                    direction = 'S';
            }
        }
    }
}
