using System.Collections.ObjectModel;

namespace GridMVVMColumns {
    public class Employee {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StateProvinceName { get; set; }
    }
    public class EmployeesDataModel {
        public static ObservableCollection<Employee> GetEmployees() {
            ObservableCollection<Employee> people = new ObservableCollection<Employee> {
                new Employee() { FirstName = "Bruce", LastName = "Cambell", StateProvinceName = "Missouri"},
                new Employee() { FirstName = "Cindy", LastName = "Haneline", StateProvinceName = "Oklahoma"},
                new Employee() { FirstName = "Andrea", LastName = "Deville", StateProvinceName = "Colorado"},
                new Employee() { FirstName = "Anita", LastName = "Ryan", StateProvinceName = "Colorado"}
            };
            return people;
        }
    }
}
