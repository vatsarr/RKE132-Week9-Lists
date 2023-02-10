
string folderPath = @"C:\Users\Risto\source\data";
string fileName = "myShoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> mySHoppingList = new List<string>();

if (File.Exists(filePath))
{
    mySHoppingList = GetItemsFromUser();
    //ShowItemsFromList(mySHoppingList);
    File.WriteAllLines(filePath, mySHoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created!");
    mySHoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, mySHoppingList);
}



static List<string> GetItemsFromUser()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item or exit (q / exit):");
        string userInput = Console.ReadLine();

        if (userInput == "exit" || userInput == "q")
        {
            Console.WriteLine("Baiii!");
            break;
        }
        else
        {
            //string userItem = Console.ReadLine();
            userList.Add(userInput);
        };

    };

    return userList;
}

static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"There are {listLength} items in your list.");

    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}