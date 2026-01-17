using Microsoft.VisualBasic;
using System;

class Student
{
    int id;
    string name;
    string surname;
    double mc;


    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public double Mc { get; set; }

    public void Info()
    {
        Console.WriteLine($"Nume: {Name} {Surname}");
        Console.WriteLine($"Media concurs: {Mc}");
        ValidateMark();
    }


    public void ValidateMark()
    {
        //Console.WriteLine("MC : " + Mc);
        if (Mc < 5)
        {
            Console.WriteLine("Nu esti admis");
        }
        else if (Mc < 7)
        {
            Console.WriteLine("Suficient!");
        }
        else if (Mc <= 9)
        {
            Console.WriteLine("Bravo!");
        }
        else
        {
            Console.WriteLine("Felicitari!");
        }
    }


}

class Ex1
{

    private static double convertStringToDouble(string number)
    {
        return Convert.ToDouble(number);
    }



    private static double readToDouble()
    {
        string word = Console.ReadLine();
        return convertStringToDouble(word);
    }

    public static void Main()
    {
        Console.WriteLine("Acesta este primul meu program în C#");

        Student student = new Student();

        Console.WriteLine("Introduceti numele: ");
        student.Name = Console.ReadLine();


        Console.WriteLine("Introduceti prenumele: ");
        student.Surname = Console.ReadLine();




        Console.WriteLine("Introduceti media notelor anuale la 4 disciplini de profil: ");
        double MNDP = readToDouble();
        while (MNDP <= 0 || MNDP > 10)
        {
            Console.WriteLine("Introduceti un numar valid: ");
            MNDP = readToDouble();

        }


        Console.WriteLine("Introduceti media notelor de la examenele de absolvire: ");
        double MNEA = readToDouble();
        while (MNEA <= 0 || MNEA > 10)
        {
            Console.WriteLine("Introduceti un numar valid: ");
            MNEA = readToDouble();

        }

        double MC = 0.6 * MNDP + MNEA * 0.4;
        //Console.WriteLine("Media de concurs este : " + MC);
        student.Mc = MC;


        student.Info();

    }
}