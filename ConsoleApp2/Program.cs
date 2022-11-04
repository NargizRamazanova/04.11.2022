bool isActive = true;

// Il = 2

string[] students = { 
    "Ilahe Letifova", 
    "Elvin Qulizade", 
    "Sima Maniyeva",
    "Agha Bedelov",
    "Nihat Qehremanli"
};
while (isActive) {

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Menu: 1 - Get all students, 2- Find Student, 0 - Exit");
    Console.ResetColor();

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 0:
            isActive = false;
            break;
        case 1:
            {
                string studentsStr = "";
                for (int i = 0; i < students.Length; i++)
                {
                    studentsStr += students[i];
                    if (i != students.Length - 1)
                    {
                        studentsStr += ", ";
                    }
                }
                Console.WriteLine(studentsStr + "\n");
            }
            break;
        case 2:
            {
                Console.WriteLine("Enter student name:");
                string name = Console.ReadLine();

                bool isMatching;
                string result = "not found";

                for(int i = 0; i<students.Length; i++)
                {
                    isMatching = true;
                    if (name.Length > students[i].Length)
                    {
                        isMatching = false;
                        continue;
                    }
                    //if (name.Length < students[i].Length && students[i][name.Length] != ' ')
                    //{
                    //    isMatching = false;
                    //    continue;
                    //}
                    for (int j = 0; j<name.Length; j++)
                    {
                        if (j < students[i].Length-1 && name[j] != students[i][j])
                        {
                            isMatching = false;
                            break;
                        }
                    }
                    if(isMatching == true)
                    {
                        result = $"Student: {students[i]}";
                        break;
                    }
                }
                Console.WriteLine(result);
            }
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not an option!\n");
            Console.ResetColor();
            break;
    }
}