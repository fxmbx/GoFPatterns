namespace SOLID.ISP
{

    public class Document 
    {
      public string Name { get; set; }
      public int DocSize { get; set; }
    }
    //Instead of having all these here, have different interfaces incase classes dont need all the functionalities 
    // public interface IMachine{
    //     // void Print(Document d);
    //     // void Scan(Document d);

    //     // void Fax(Document d);
    // }
    public interface IScanner {
        void Scan(Document d);
    }

    public interface IPrinter{
        void Print(Document d);
    }

    public interface IMultiInterface : IScanner, IPrinter{
        void Fax();
    }
 
    //You could go this way
    public class MultiPurposeMachine : IMultiInterface
    {
        public void Fax()
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        
        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }

    //OR usingdecorator pattern and delegating the calls 
    public class MultiMachineFunction : IMultiInterface{
        private readonly IPrinter iprinter;
        private readonly IScanner iscanner;
        public MultiMachineFunction(IPrinter printer, IScanner scanner)
        {
            iprinter = printer;
            iscanner = scanner;
        }

        public void Fax(){
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            iprinter.Print(d);
        }

        public void Scan(Document d)
        {
            iscanner.Scan(d);
            
        }
    }


    //by following Interface segregation principle this class doesn't have to enforce a method it doesn't use or need
    public class Photocopier : IPrinter
    {
        public void Print(Document d)
        {
            throw new NotImplementedException();
        }
    }

}