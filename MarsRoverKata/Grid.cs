using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Grid
    {
        List<Coordinates> obstacles = new List<Coordinates>();

        public void AddObstacle(Coordinates obstacle)
        {
            obstacles.Add(obstacle);
        }

        internal bool AreCoordinatesTraversable(Coordinates nextCoordinates)
        {
            return obstacles.Contains(nextCoordinates);
        }
    }
}
