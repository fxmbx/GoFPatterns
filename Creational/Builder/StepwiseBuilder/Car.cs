namespace Builder.StepwiseBuilder{

    public enum CarType {
        Toyota,
        Honda
    }
    public class Car{
        public CarType Type { get; set; }
        //Note you can only selecet certain wheelsize based on your cartype
        public int WheelSize { get; set; }
    }
}