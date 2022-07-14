

namespace Builder.StepwiseBuilder
{
    public class CarBuilder 
    {

        //could have put the builder in the car as its own
        
        //this make the builder Private
        //we split the interfaces into methods that only return one after the other
        private class Implement : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
        {
            private Car car = new Car();
          
            public  ISpecifyWheelSize OfType(CarType type){
                car.Type = type;
                //return ISpecifuWheelSize
                return this;
            }
            public  IBuildCar WithWheels(int size){
                switch(car.Type){
                    case CarType.Toyota when size < 17 || size >20:
                    case CarType.Honda when size < 15 || size >17:
                        throw new ArgumentException(String.Format("Wrong size of wheel for {0}",car.Type));
                }
                car.WheelSize = size;
                return this;
            }

            public Car Build(){
                return car;
            }

        }
        public static ISpecifyCarType Create(){
            return new Implement();
        }
    }
}