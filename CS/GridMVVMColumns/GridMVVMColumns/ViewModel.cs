using DevExpress.Mvvm;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GridMVVMColumns {
    public class ViewModel : ViewModelBase {
        public ViewModel() {
            Source = EmployeesDataModel.GetEmployees();
            States = Source.Select(x => x.StateProvinceName).Distinct().ToList();

            Columns = new ObservableCollection<TextColumn>() {
                new TextColumn(nameof(Employee.FirstName)),
                new TextColumn(nameof(Employee.LastName)),
                new ComboBoxColumn(nameof(Employee.StateProvinceName), States)
            };
        }
        public ObservableCollection<Employee> Source { get; }
        public ObservableCollection<TextColumn> Columns { get; }
        public List<string> States { get; }
    }

    public class TextColumn : BindableBase {
        public TextColumn(string fieldname) {
            FieldName = fieldname;
        }
        public string FieldName { get; }
    }
    public class ComboBoxColumn : TextColumn {
        public ComboBoxColumn(string fieldname, IList items) : base(fieldname) {
            Items = items;
        }
        public IList Items { get; }
    }
}
