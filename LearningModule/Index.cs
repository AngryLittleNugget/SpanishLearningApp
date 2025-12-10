using SpanishApp.ModuleNamespace;
using SpanishApp.WordLists;

string userInput = "";
List<LearningModule> learningModules = new List<LearningModule>();


Console.WriteLine("Time to learn some Spanish, baybee!");
Console.WriteLine("1: Unlocked Modules and Stats\n" +
     "2: Review Module Materials\n"
    + "3: Test for Latest Module");

Console.Write("Please enter the number of your choice: ");

while (userInput == "")
{
    userInput = Console.ReadLine() ?? "";
}

if (userInput == "1")
{
    DisplayModules(learningModules);
}
else if (userInput == "2")
{
    // ReviewModuleMaterials();
}
else if (userInput == "3")
{
    // TestLatestModule();
}
else
{
    Console.WriteLine("Invalid input, please try again.");
}


void DisplayModules(List<LearningModule> learningModules)
{
    if (learningModules.Count != 0)
    {
        Console.WriteLine("Unlocked Modules:");
        for (int i = 0; i < learningModules.Count; i++)
        {
            Console.WriteLine($"{learningModules[i].name}");
        }
    }

    Console.WriteLine("Enter a selection, or type 'exit' to leave.");

}
/*
string[] testOne = { "one", "two", "three", };
string[] testTwo = { "gleep", "gloop"};

LearningModule learningModuleOne = new LearningModule(testOne, testTwo);

foreach (string word in learningModuleOne.nouns)
{
    Console.WriteLine(word);
}

foreach (string word in learningModuleOne.verbs)
{
    Console.WriteLine(word);
}
*/