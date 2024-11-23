LINQ –Day1 Assignments  
  
Using Console Application:  
  
Declare a List of numbers as shown :   
 List<int> numbers = new List<int>() { 2,4,6,7,1,4,2,9,1};   
Then write the following queries   
  
Query1: Display numbers without any repeated Data and sorted    
Query2: using Query1  result and show each number and it’s multiplication  
declare an array of names as shown :   
string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };   
  
Then write the following queries:   
 
Query1: Select names with length equal 3.  
  
Query2: Select names that contains “a” letter (Capital or Small )then sort them by length  
  
Query3: Display the first 2 names  

  
3- Declare a class Subject that contains the following properties (Code, Name) and declare Student class that contains the following properties (ID, FirstName, LastName , Subject []), then define List of students As follow  
  
List<Student> students=new List<Student> (){              new Student(){ ID=1, FirstName="Ali", LastName="Mohammed", 
subjects=new Subjcet[]{ new Subjcet(){ Code=22,Name="EF"}, new Subjcet(){ Code=33,Name="UML"}}},              new Student(){ ID=2, FirstName="Mona", LastName="Gala", 
subjects=new Subject []{ new Subject(){ Code=22,Name="EF"}, new Subject (){ Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}},             new 
Student(){ ID=3, FirstName="Yara", LastName="Yousf", subjects=new Subject 
[]{ new Subject (){ Code=22,Name="EF"}, new Subject (){ Code=25,Name="JS"}}},               new Student(){ ID=1, FirstName="Ali", LastName="Ali", 
subjects=new Subject []{  new Subject (){ Code=33,Name="UML"}}},  
              
            };  
  
Then write the following queries   
  
Query1: Display Full name and number of subjects for each student as follow  
  
  
Query2: Write a query which orders the elements in the list by FirstName Descending then by LastName Ascending and result of query displays only first names and last names for the elements in list as follow  
  
  
    
  
  
