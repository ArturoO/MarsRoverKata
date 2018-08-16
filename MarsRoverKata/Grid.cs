using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata
{
    public class Grid
    {
        public int MinX = 0;
        public int MaxX = 9;
        public int MinY = 0;
        public int MaxY = 9;
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
