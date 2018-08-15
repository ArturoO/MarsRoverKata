using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Rover
    {
        Coordinates coordinates = new Coordinates();
        
        public string GetCoordinates()
        {
            return coordinates.Format();
        }

        public void Execute(string commands)
        {
            for(var i=0; i<commands.Length; i++)
            {
                coordinates.Execute(commands[i]);
            }
        }

        
    }
}
