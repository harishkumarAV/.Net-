// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using LinqPractise;
List<Student> students = new List<Student>
{
    new Student{Id = 1 ,Name = "Harish",Age = 21, Scores = new List<int>{90,98,96,91}},
    new Student{Id = 2 ,Name = "gg",Age = 21, Scores = new List<int>{80,58,77,35}},
    new Student{Id = 3 ,Name = "kl",Age = 91, Scores = new List<int>{01,100,90,56}},
    new Student{Id = 4 ,Name = "ab",Age = 101, Scores = new List<int>{09,99,99,71}},
};
var old = students.Where(s => s.Age > 90);
Console.WriteLine("old Students are");
foreach (var student in old)
{
    Console.WriteLine(student.Name);
}

var student_average = students.Select(s => new
{
    s.Name,
    Average = s.Scores.Average()
});
Console.WriteLine("Students and their averages are : \n");
foreach (var student in student_average)
{
    Console.WriteLine($"{student.Name}:{student.Average}");
}

var ordered_students = students.OrderBy(s => s.Age);
Console.WriteLine("Students name ordered by their age is\n");
foreach (var student in ordered_students)
{
    Console.WriteLine(student.Name);
}

var grouped_students = students.GroupBy(s => s.Age);
Console.WriteLine("Students name grouped by their age is \n");
foreach (var group in grouped_students)
{
    Console.WriteLine($"Age: {group.Key}");
    foreach (var student in group)
    {
        Console.WriteLine($"  {student.Name}");
    }
}
