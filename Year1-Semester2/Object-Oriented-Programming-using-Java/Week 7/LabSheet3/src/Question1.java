import java.util.Date;

public class Question1 implements IExercise {
    public void Run() {
        var test = new MyClass();
        test.Message("test");
    }

    public class MyClass {

        public MyClass() {
        }

        public void Message(String message) {
            System.out.println(message);
        }
    }

    public class Student {
        private int StudentId;

        public Student(int studentId) {
            StudentId = studentId;
        }

        public Student() {
            StudentId = 0;
        }

        public void PrintStudentId() {
            System.out.println(StudentId);
        }
    }

    public class Person {
        private int IdNumber;
        private String Name;
        private Date DateOfBirth;

        public Person(int idNumber, String name, Date dateOfBirth) {
            IdNumber = idNumber;
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public String GetName() {
            return Name;
        }

        public Date GetDateOfBirth() {
            return DateOfBirth;
        }

        public int GetId() {
            return IdNumber;
        }

        public void SetName(String name) {
            Name = name;
        }

        public void SetId(int id) {
            IdNumber = id;
        }

        public void SetDate(Date date) {
            DateOfBirth = date;
        }

        public void PrintData() {
            System.out.println("Name: " + Name);
            System.out.println("Id Number: " + IdNumber);
            System.out.println("Date of birth: " + DateOfBirth);
        }
    }
}
