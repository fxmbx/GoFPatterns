using System;

namespace Factory
{
    public enum CoordinateSystem {
        Cartesian,
        Polar
    }
    public class Point
    {
        //factory method
        public static Point NewCartesianPoin(double x, double y){
            return new Point(x,y);
        }
        public static Point NewPolarPoint(double rho, double theta){
            return new Point (rho*Math.Cos(theta), rho*Math.Sin(theta));
        }
        private Point(double x, double y){
            this.x= x;
            this.y =y;
        }
        private double x,y;

        public override string ToString(){
            return $"{nameof(x)}: {x}, {nameof(y)}:{y}";
        }
        // this constructor has toomuch going on for it 
        // public Point(double a , double b, CoordinateSystem system = CoordinateSystem.Cartesian)
        // {
        //    switch (system)
        //    {
        //        case CoordinateSystem.Cartesian:
        //             x=a;
        //             y=b;
        //             break;
        //         case CoordinateSystem.Polar:
        //             x=a* Math.Cos(b);
        //             y= a * Math.Sin(b);
        //         break;
        //        default:
        //         throw new ArgumentOutOfRangeException(nameof(system), system,null);
        //    }
        // }
    
    }
}