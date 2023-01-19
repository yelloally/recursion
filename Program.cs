using System.IO;
using System.Threading.Tasks;

class Program
{
    //create a method where we create an array with reccursive output
    static void MyArray(int[] callArray, int i = 0)
    {
        //condition that prevenrs infinite recirsion
         if (i < callArray.Length)
        {
            Console.WriteLine(callArray[i]);
            MyArray(callArray, i + 1);
            
        }
    }

    static void Main(string[] args)
    {
        //create user's otput 
        Console.WriteLine("Paste size of array: ");
        int len = int.Parse(Console.ReadLine());

        int[] callArray = new int[len];

        for (int i = 0; i < callArray.Length; i++)
        {
            Console.WriteLine($"Paste the value for element [{i}]: ");
            callArray[i] = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("Thank you, array is created!");
        MyArray(callArray);
    }      
    
}
//output:
//Paste size of array: 
//3
//Paste the value for element [0]: 
//1
//Paste the value for element [1]: 
//2
//Paste the value for element [2]: 
//3
//Thank you, array is created!
//1
//2
//3