using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public partial class Rover
    {
        Direction direction = new Direction();
        int coordinateX = 0;
        int coordinateY = 0;

        public string GetCoordinates()
        {
            return coordinateX + ":" + coordinateY + ":" + direction.Current;
        }

        public void Execute(string commands)
        {
            for(var i=0; i<commands.Length; i++)
            {
                if (commands[i] == 'R' || commands[i] == 'L')
                    direction.Rotate(commands[i]);
                else
                {
                    if (direction.Current == 'N')
                    {
                        if (coordinateY < 9)
                            coordinateY++;
                        else
                            direction.TurnAround();
                    }
                    else if (direction.Current == 'S')
                    {
                        if (coordinateY > 0)
                            coordinateY--;
                        else
                            direction.TurnAround();
                    }
                    else if (direction.Current == 'E')
                    {
                        if (coordinateX < 9)
                            coordinateX++;
                        else
                            direction.TurnAround();
                    }
                    else if (direction.Current == 'W')
                    {
                        if (coordinateX > 0)
                            coordinateX--;
                        else
                            direction.TurnAround();
                    }
                }
                    
            }
        }

        
    }
}
