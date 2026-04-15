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