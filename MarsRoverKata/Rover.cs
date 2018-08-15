using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public partial class Rover
    {
        Direction direction = new Direction();

        public string GetCoordinates()
        {
            return "0:0:" + direction.Current;
        }

        public void Execute(string commands)
        {
            for(var i=0; i<commands.Length; i++)
            {
                direction.Rotate(commands[i]);
            }
        }

        
    }
}
