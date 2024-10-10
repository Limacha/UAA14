namespace act2.classs
{
    public class Cercle
    {
        private double _radius;
        public double Radius { get { return _radius; } set { if (value > 0) { _radius = value; } } }

        public Cercle(double radius)
        {
            _radius = radius;
        }

        public double CalculerAire()
        {
            return Math.PI * (_radius * _radius);
        }

        public double CalculerPerimetre()
        {
            return (2 * Math.PI) * _radius;
        }
    }
}
