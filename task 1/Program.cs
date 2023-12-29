
var person = new List<string>();
System.Console.WriteLine("Enter student name : ");
var student1 = new Student(System.Console.ReadLine());
student1.Study();

System.Console.WriteLine("Enter student name : ");
var student2 = new Student(System.Console.ReadLine());
student2.Study();

System.Console.WriteLine("Enter teacher name : ");
var teacher = new Teacher(System.Console.ReadLine());
teacher.Explain();



