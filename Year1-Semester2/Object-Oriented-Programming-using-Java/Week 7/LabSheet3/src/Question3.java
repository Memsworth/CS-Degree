public class Question3 implements IExercise {
    public void Run() {

        var emp = new Employee(1, "John", "Doe", 5000);

        System.out.println("ID: " + emp.getID());
        System.out.println("First Name: " + emp.getFirstName());
        System.out.println("Last Name: " + emp.getLastName());
        System.out.println("Full Name: " + emp.getName());
        System.out.println("Monthly Salary: " + emp.getSalary());
        System.out.println("Annual Salary: " + emp.getAnnualSalary());

        emp.raiseSalary(10);
        System.out.println("Salary after 10% raise: " + emp.getSalary());

        emp.setSalary(6000);
        System.out.println("Updated Salary: " + emp.getSalary());

        System.out.println(emp);
    }

    public class Employee {
        private int Id;
        private String FirstName;
        private String LastName;
        private int Salary;

        public Employee(int id, String firstName, String lastName, int salary) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public int getID() {
            return Id;
        }

        public String getFirstName() {
            return FirstName;
        }

        public String getLastName() {
            return LastName;
        }

        public String getName() {
            return FirstName + " " + LastName;
        }

        public int getSalary() {
            return Salary;
        }

        public void setSalary(int salary) {
            Salary = salary;
        }

        public int getAnnualSalary() {
            return Salary * 12;
        }

        public int raiseSalary(int percent) {
            Salary += Salary * percent / 100;
            return Salary;
        }

        @Override
        public String toString() {
            return "Employee[id=" + Id +
                    ", name=" + getName() +
                    ", salary=" + Salary + "]";
        }
    }
}