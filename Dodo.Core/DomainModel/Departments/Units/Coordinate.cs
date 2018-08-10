using System;

namespace Dodo.Core.DomainModel.Departments.Units
{
    public class Coordinate
    {
        public Coordinate(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public Decimal? X { get; private set; }
        public Decimal? Y { get; private set; }
    }
}
