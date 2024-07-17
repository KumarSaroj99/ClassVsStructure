using ClassVsStructure.Models;

namespace ClassVsStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassDemo classObj1 = new ClassDemo() { Number1=1, Number2=2 };//class instance is stored in Heap
            StructureDemo structureObj1 = new StructureDemo() { Number1 = 1, Number2=2 };//structure instance is stored in stack

            ClassDemo classObj2 = classObj1;   //classObj1 and classObj2 refer to the same object
            StructureDemo structureObj2 = structureObj1;   //A copy of structure1 is stored in structure2 ,
                                                           //They do not refer to the same mamory address

            classObj2.Number1 = 10;  //It will change Number1 value for classObj1 also Because class are reference type
            structureObj2.Number1 = 10; //It will not change Number1 value for structureObj1 also Because structure are value type


            
            Console.WriteLine($"In Class1 , (Number1 ,Number2) : ({classObj1.Number1},{classObj1.Number2})");
            Console.WriteLine($"In Class2 , (Number1 ,Number2) : ({classObj2.Number1},{classObj2.Number2})\n");
            
            Console.WriteLine($"In Structure1 , (Number1 ,Number2) : ({structureObj1.Number1},{structureObj1.Number2})");
            Console.WriteLine($"In Structure2 , (Number1 ,Number2) : ({structureObj2.Number1},{structureObj2.Number2})");


        }
    }
    
}
