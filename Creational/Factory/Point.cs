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
        private double x,y;
       
        private Point(double x, double y){
            this.x= x;
            this.y =y;
        }

        public override string ToString(){
            return $"{nameof(x)}: {x}, {nameof(y)}:{y}";
        }

        // public static Point Origin => new Point(0,0); //this is a property and when you access it you get a new poin 0,0
        public static Point Orgin2 = new Point(0,0); //this is a field and it gets initialized once .better than line 23 depending on whta you want to do 
        //by making the facctory an innerclass, it can access the provate constructor 
        public class Factory {
            public static Point NewCartesianPoint(double x, double y) {
                return new Point(x,y);
            }

            public static Point NewPolarPoint(double rho, double theta){
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }
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