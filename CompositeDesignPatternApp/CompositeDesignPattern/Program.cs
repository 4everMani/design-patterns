using CompositeDesignPattern.Example1;

#region Mathematics department
// 2 lecturers work in Mathematics department
Employee mathTeacher1 = new Employee("M.Joy", "Mathematic", "Lecturer");

Employee mathTeacher2 = new Employee("M.Roony", "Mathematics", "Lecturer");

CompositeEmployee hodMaths = new CompositeEmployee("Mrs.S.Das","Maths","HOD-Maths");
// Lecturers of Mathematics directly reports to HOD-Maths
hodMaths.AddSubordinate(mathTeacher1);
hodMaths.AddSubordinate(mathTeacher2);
#endregion

#region Computer Science department
// 3 lecturers work in Computer Sc. department
Employee cseTeacher1 = new Employee("C.Sam", "Computer Science","Lecturer");
Employee cseTeacher2 = new Employee("C.Jones", "Computer Science.", "Lecturer");
Employee cseTeacher3 = new Employee("C.Marium", "Computer Science", "Lecturer");
// The college has a Head of Department in Computer science
CompositeEmployee hodCompSc = new CompositeEmployee("MrV.Sarcar", "Computer Sc.","HOD - Computer Sc." );
/* Lecturers of Computer Sc. directly reports to HOD-CSE */
hodCompSc.AddSubordinate(cseTeacher1);
hodCompSc.AddSubordinate(cseTeacher2);
hodCompSc.AddSubordinate(cseTeacher3);
#endregion

#region Top level management
// The college also has a Principal
CompositeEmployee principal = new CompositeEmployee("Dr.S.Som", "Planning-Supervising-Managing", "Principal");
/* Head of Departments's of Maths and Computer Science directly
reports to Principal.*/
principal.AddSubordinate(hodMaths);
principal.AddSubordinate(hodCompSc);
#endregion

principal.DisplayDetails();