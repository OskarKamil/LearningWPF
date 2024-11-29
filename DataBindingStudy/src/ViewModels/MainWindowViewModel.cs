using DataBindingStudy.src.Models;
using System.Collections.ObjectModel;

namespace DataBindingStudy.src.ViewModels
{
    internal class MainWindowViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }
        public List<Sex> SexOptions { get; } = Enum.GetValues(typeof(Sex)).Cast<Sex>().ToList();

        public MainWindowViewModel()
        {
            Persons = new ObservableCollection<Person>
            {
                new Person { Name = "Mark", Age = 35, Sex=Sex.Male },
                new Person { Name = "Zoe", Age =33, Sex =Sex.Female },
                new Person { Name = "Eve", Age = 23 ,Sex= Sex.Female},
                new Person { Name = "Damian", Age = 54, Sex = Sex.Male },
                new Person { Name = "Dave", Age = 19 },
                new Person { Name = "Carla", Age = 28 }
            };
        }
    }
}