Creating "Sample Api" with Asp.Net 
Creating "Sample Api" with Asp.Net
1.	Create a new project,	File  New-Project
 
2.	Selct MVC in template, in for the AUTHENTICATION   “Individual User Accounts”
 



3.	Add new class in your Models, Right-click ModelsAddClass [Students]

 

 







4.	Entity Framework part
Add students in your IdentityModel.cs in Models, 
[ public DbSet<Students> Students{get; set;} ]

 
5.	Open Your PackageManager Console.
a.	“enable-migrations”
b.	“add-migration [nameofmigration]”
c.	Update-database
 






6.	Click Show All Files, the icon is shown in the picture below, and .mdf is your database
 
7.	Populate your Students table, right-click Students tableShow Table Data
 


8.	API PART
a.	Add folder in Controllers folder and name it as “api”
b.	Add Web API 2 Controller – Empty, and name it as “studentsController”
 
9.	Go to Global.asax.cs in your Solution Explorer, Global.asaxGlobal.asax.cs, and follow the pictures below
 

 


10.	 In your studentsController, add ApplicationDbContext	

 







11.	GET METHOD
a.	The GetStudents() code-block enables your API to get a list of students in your db
b.	The GetStudents(int id)  codeblock enables your API to get a specific student by id
 
12.	POST METHOD
_context.Students.Add(students);  add the student object you passed to the url “localhost/api/students” via body in POSTMAN

_context.SaveChanges();  saves the object(Students students) you passed in .Add().
 



13.	PUT METHOD

 

14.	DELETE METHOD
 



