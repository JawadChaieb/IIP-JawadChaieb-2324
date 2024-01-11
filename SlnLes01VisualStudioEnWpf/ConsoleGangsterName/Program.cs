using System;

class MainClass {
    public static void Main(string[] args) {

        Console.WriteLine("************************");
        Console.WriteLine("| GANGSTA NAME BUILDER |");
        Console.WriteLine("************************");



        string disneyName = GetDisneyName();
        string workbenchTool = GetWorkbenchTool();
        string lastName = GetLastName();

        string gangstaName = GetGangstaName(disneyName, workbenchTool, lastName);

        Console.WriteLine(gangstaName);
    }

    static string GetDisneyName() {
        Console.WriteLine("Give the first name of any Disney character:");
        string disneyName = Console.ReadLine();
        return disneyName;
    }

    static string GetWorkbenchTool() {
        Console.WriteLine("Give any workbench tool:");
        string workbenchTool = Console.ReadLine();
        return workbenchTool;
    }

    static string GetLastName() {
        Console.WriteLine("What is your last name:");
        string lastName = Console.ReadLine();
        return lastName;
    }

    static string GetGangstaName(string disneyName, string workbenchTool, string lastName) {
        string gangstaName = $"{disneyName} 'the {workbenchTool}' {lastName}";
        return gangstaName;
    }
}