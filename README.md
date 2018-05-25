
Creating "Sample Api" with Asp.Net
1.	Create a new project,	File -> New -> Project


![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/1.png)


2.	Selct MVC in template, in for the AUTHENTICATION ->  “Individual User Accounts”
 

![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/2.png)


3.	Add new class in your Models, Right-click Models -> Add -> Class [Students]


![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/3a.png)


![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/3b.png)


4.	Entity Framework part


![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/4.png)
Add students in your IdentityModel.cs in Models, 
[ public DbSet<Students> Students{get; set;} ]

 
5.	Open Your PackageManager Console.
a.	“enable-migrations”
b.	“add-migration [nameofmigration]”
c.	Update-database
 
 
 
 ![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/5.png)



6.	Click Show All Files, the icon is shown in the picture below, and .mdf is your database


![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/6.png)



7.	Populate your Students table, right-click Students tableShow Table Data
 
 
 ![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/7.png)


8.	API PART
a.	Add folder in Controllers folder and name it as “api”
b.	Add Web API 2 Controller – Empty, and name it as “studentsController”
 
 
 
 ![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/8.png)
 
 
9.	Go to Global.asax.cs in your Solution Explorer, Global.asaxGlobal.asax.cs, and follow the pictures below
 

 
![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/9.png)


![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/9a.png)


10.	 In your studentsController, add ApplicationDbContext	

 
![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/10.png)




11.	GET METHOD
a.	The GetStudents() code-block enables your API to get a list of students in your db
b.	The GetStudents(int id)  codeblock enables your API to get a specific student by id



![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/11.png)



12.	POST METHOD


![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/12.png)


_context.Students.Add(students); -> add the student object you passed to the url “localhost/api/students” via body in POSTMAN

_context.SaveChanges(); -> saves the object(Students students) you passed in .Add().
 



13.	PUT METHOD

 
![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/13.png)


14.	DELETE METHOD
 

![alt text]( https://github.com/mbflores/sampleapi.asp.net/blob/master/img/14.png)

