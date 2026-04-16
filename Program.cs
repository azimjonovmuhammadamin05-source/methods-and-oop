// var p = new Post();

// while (true)
// {
//     System.Console.WriteLine("Choose operation:");
//     System.Console.WriteLine(@"1. SetPost
// 2. Add like
// 3. Add comment
// 4. Get information");
//     string a = Console.ReadLine();
//     switch (a)
//     {
//         case "1":
//             System.Console.WriteLine("Enter text for post: ");
//             var text = Console.ReadLine();
//             p.SetPost(text);
//             break;
//         case "2":
//             p.AddLike();
//             break;
//         case "3":
//             p.AddComment(Console.ReadLine());
//             break;
//         case "4":
//             p.GetInfo();
//             break;
//     }
// }

// Task3
// System.Console.Write("Enter player's name: ");
// var name = System.Console.ReadLine() ;

// System.Console.Write("Enter player's number: ");
// var numberText = System.Console.ReadLine();
// var number = int.Parse(numberText);

// System.Console.Write("Enter player's position: ");
// var position = System.Console.ReadLine();

// System.Console.Write("Enter player's team: ");
// var team = System.Console.ReadLine() ;

// var player = new Player
// {
// Name = name,
// Number = number,
// Position = position,
// Team = team
// };

// System.Console.WriteLine();
// System.Console.WriteLine(player.GetInfo());
// System.Console.WriteLine();
// player.ScoreGoal();

// System.Console.Write("Enter the name of the player who scored from the assist: ");
// var assistedPlayer = System.Console.ReadLine();
// player.AssistGoal(assistedPlayer);




// Task4
// System.Console.Write("Enter employee's FirstName: ");
// var name = System.Console.ReadLine();

// System.Console.Write("Enter employee's LastName: ");
// var LastName = System.Console.ReadLine();

// System.Console.Write("Enter employee's Age: ");
// var Age = int.Parse(System.Console.ReadLine());

// System.Console.Write("Enter employee's Position: ");
// var position = System.Console.ReadLine();

// System.Console.Write("Enter employee's Salary: ");
// var Salary = System.Console.ReadLine();

// var employee = new Employee
// {
//     FirstName = name,
//     LastName = LastName,
//     Position = position,
//     Age = Age,
//     Salary = Salary
// };

// System.Console.WriteLine();
// System.Console.WriteLine(employee.GetInfo());
// System.Console.WriteLine();

// System.Console.Write("Set a new Salary: ");
// var newsalary = System.Console.ReadLine();
// employee.Salary = newsalary;
// System.Console.WriteLine();
// System.Console.WriteLine(employee.GetInfo());


// Task2
// var s= new Calculator(10,5);
// System.Console.WriteLine(s.division());
// System.Console.WriteLine(s.subtruct());
// System.Console.WriteLine(s.sum());
// System.Console.WriteLine(s.multiplication());





// Task3
// var student = new Student(1,"John",20,3.5);
// student.ShowInfo();
// student.IsExcellentStudent();


// hometask1
// var book = new Book("world", "Max", 2010);
// book.GetInfo();
// book.IsPublishedRecently();


// hometask2
// System.Console.Write("Введите радиус окружности: ");
// double r = Convert.ToDouble(Console.ReadLine());

// var circle = new Circle(r);
// Console.WriteLine($"Радиус: {circle.GetRadius()}");
// Console.WriteLine($"Площадь: {circle.GetArea()}");
// Console.WriteLine($"Диаметр: {circle.GetDiameter()}");
// Console.WriteLine($"Длина окружности:: {circle.GetCircumference()}");


// hometask3

// Console.Write("Введите день: ");
// int d = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите месяц: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите год: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Date date = new Date(d, m, y);

// Console.WriteLine("Дата: " + date.ToString());

