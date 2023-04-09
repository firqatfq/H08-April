//Student student = new Student();

//student.Name = "Firgat";
//student.SurName = "Gasimov";
//student.Group = "P234";
//student.Point = 99;
//student.IsGraduated = false;

Student student = new Student("Firgat", "Gasimov", "P234", 99, false);

student.GetFullName();
student.GetAllInfo();
student.CheckPoint();
