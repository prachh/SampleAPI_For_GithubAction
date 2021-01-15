using System;

namespace SampleAPI.Data
{
    public class Operation
    {  
        public double NumberA { get; set; }
       
        public double NumberB { get; set; }

        public OperationType OperationType { get; set; }
    }

    public enum OperationType
    {
        Addition,
        Multiplication,
        Division,
        Subtraction
    }
}
