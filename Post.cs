// class Post
// {
//     public string? Text { get; set; }
//     public int Likes { get; set; }
//     public List<string> Comments { get; set; } = [];

//     public void SetPost(string text)
//     {
//         Text = text;
//         System.Console.WriteLine("The post created.");
//     }

//     public void AddLike()
//     {
//         Likes++;
//     }

//     public void AddComment(string comment)
//     {
//         Comments.Add(comment);
//     }

//     public void GetInfo()
//     {
//         System.Console.WriteLine(Text);
//         System.Console.WriteLine(Likes);
//         System.Console.WriteLine("Comments on this post:");
//         foreach (var item in Comments)
//         {
//             System.Console.WriteLine(item);
//         }
//     }
// }


// Task3
// public class Player
// {
//     public string Name { get; set; }
//     public int Number { get; set; }
//     public string Position { get; set; }
//     public string Team { get; set; }

//     public void ScoreGoal()
//     {
//         System.Console.WriteLine($"{Name} (#{Number}) scored a goal!");
//     }

//     public void AssistGoal(string playerName)
//     {
//         System.Console.WriteLine($"{Name} assists a goal for {playerName}.");
//     }

//     public string GetInfo()
//     {
//         return $@"Name: {Name},
//          Number: {Number}, 
//          Position: {Position}, 
//          Team: {Team}";
//     }
// }



// // Task4
// public class Employee
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public int Age { get; set; }
//     public string Position { get; set; }
//     public string Salary { get; set; }


//     public string GetInfo()
//     {
//         return $@"Name: {FirstName},
// LastName: {LastName}, 
// Age: {Age}, 
// Position: {Position},
// Salary: {Salary}";
//     }
// }


// Task1-calculator
// public class Calculator
// {
//     public double FirstNumber { get; set; }
//     public double SecondNumber { get; set; }

//     public Calculator(double firstNumber, double secondNumber)
//     {
//         FirstNumber = firstNumber;
//         SecondNumber = secondNumber;
//     }
//     public double sum()
//     {
//         return FirstNumber + SecondNumber;
//     }
//     public double subtruct()
//     {
//         return FirstNumber - SecondNumber;
//     }
//     public double multiplication()
//     {
//         return FirstNumber * SecondNumber;
//     }
//     public double division()
//     {
//         return FirstNumber / SecondNumber;
//     }
// }



// Task2
// public class diagram
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public string UserName { get; set; }
//     private string _Password { get; set; }

//     public diagram(string firstName, string lastName, string userName, string password)
//     {
//         FirstName = firstName;
//         LastName = lastName;
//         UserName = userName;
//         _Password = password;

//     }
//     public string GetInfo()
//     {
//         return FirstName + " " + LastName;
//     }
//     public bool Login(string userName, string password)
//     {
//         return UserName ==  userName && password==_Password;
//     }
// }


// Task3
// public class User
// {
//     public string FirstName { get; set; }
//     public string LastName { get; set; }
//     public string UserName { get; set; }
//     private string password;

//     public User(string firstName, string lastName, string userName, string password)
//     {
//         FirstName = firstName;
//         LastName = lastName;
//         UserName = userName;
//         this.password = password;
//     }

//     public string GetInfo()
//     {
//         return FirstName + " " + LastName;
//     }

//     public bool Login(string userName, string password)
//     {
//         return UserName == userName && this.password == password;
//     }
// }


// Task4
// public class Student
// {
//     public int Id{get;set;}
//     public string Name{get;set;}
//     public int Age{get;set;}
//     public double Avarage{get;set;}
//     public Student (int id,string name,int age,double avarage)
//     {
//         Id = id;
//         Name = name;
//         Age = age;
//         Avarage = avarage;
//     }
//     public void ShowInfo()
//     {
//         Console.Write($"ID: {Id}"+" ");
//         Console.Write($"Name: {Name}"+" ");
//         Console.Write($"Age: {Age}"+" ");
//         Console.Write($"Avarage: {Avarage}"+" ");
//     }
//     public void IsExcellentStudent()
//     {
//         if (Avarage >= 4.0)
//         {
//             System.Console.WriteLine("true");
//         }
//         else
//         {
//             System.Console.WriteLine("false");
//         }
//     }
// }



// hometask1
// public class Book
// {
//     public string Title { get; set; }
//     public string Author { get; set; }
//     public int Year { get; set; }

//     public Book(string title, string author, int year)
//     {
//         Title = title;
//         Author = author;
//         Year = year;
//     }
//     public void GetInfo()
//     {
//         Console.Write($"Title: {Title}" + " ");
//         System.Console.WriteLine();
//         Console.Write($"Author: {Author}" + " ");
//         System.Console.WriteLine();
//         Console.Write($"Year: {Year}" + " ");
//         System.Console.WriteLine();

//     }
//     public void IsPublishedRecently()
//     {
//         if (Year > 2010)
//         {
//             System.Console.WriteLine("true");
//         }
//         else
//         {
//             System.Console.WriteLine("false");
//         }
//     }

// }


// hometask2
// public class Circle
// {
//      double radius ;
//      double pi =3.14159;

//      public Circle (double r)
//      {
//         radius=r;
//      }
//      public Circle ()
//      {
//         radius=0;
//      }
//        public void SetRadius (double r)
//      {
//         radius=r;
//      }
//      public double GetRadius()
//      {
//         return radius;
//      }
//      public double GetArea()
//      {
//         return pi*radius*radius;
//      }
//      public double GetDiameter()
//      {
//         return 2*radius;
//      }
//      public double GetCircumference()
//      {
//         return 2*radius*pi;
//      }
// }


// hometask3
// public class Date
// {
//     int Day { get; set; }
//     int Month { get; set; }
//     int Year { get; set; }

//     public Date(int day, int month, int year)
//     {
//         Day = day;
//         Month = month;
//         Year = year;
//     }
//     public override string ToString()
//     {
//         return $"{Day:D2}/{Month:D2}/{Year}";
//     }

// }