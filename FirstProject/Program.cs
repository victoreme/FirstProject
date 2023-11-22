namespace FirstProject;

public class User
{
    public static void Main(string[] args)
    {
        double based, height, area;
 
        Console.WriteLine("Enter the base:");
        based = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        height = Convert.ToDouble(Console.ReadLine());

        area = (based * height) / 2;

        Console.WriteLine("The area is " + area);
    }
}