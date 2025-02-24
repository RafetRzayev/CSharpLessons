namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person() { Name = "Kenan", Id = 1 };
            Person person2 = new Person() { Name = "Eli", Id = 2 };

            People people = new People();
            //people.AddPerson(person1);
            //people.AddPerson(person2);
            people[43650] = person1;
            people[1] = person2;
            //people["Kenan"] = new Person() { Name = "Fazil" };

            people.PrintPeopleList();
            Console.WriteLine(people[0].Name);
            //Console.WriteLine(people.GetPerson(0).Name)
            string CurrentAccount = "hello";

            string currentAccountInfo = CurrentAccount == null ? "no one has been designated as a current user" : $"{CurrentAccount} is current account";
        }
    }


    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class People
    {
        private Person[] _people = new Person[10];
        private int _count = 0;

        public Person this[int index]
        {
            get
            {
                try
                {
                    return _people[index];
                }
                catch
                {

                    return new Person();
                }
            }
            set
            {
                try
                {
                    _people[index] = value;
                }
                catch
                {

                }
            }
        }

        public Person this[string name]
        {
            get
            {
                foreach (var item in _people)
                {
                    if (item == null) continue;

                    if (item.Name == name) return item;
                }

                return new Person();
            }
            set
            {
                for (int i = 0; i < _people.Length; i++)
                {
                    if (_people[i] == null) continue;

                    if (_people[i].Name == name)
                    {
                        _people[i] = value;
                    }
                }
            }
        }
        public void AddPerson(Person person)
        {
            _people[_count++] = person;
        }

        public Person GetPerson(int index)
        {
            return _people[index];
        }

        public void PrintPeopleList()
        {
            foreach (Person person in _people)
            {
                if (person == null) continue;

                Console.WriteLine(person.Name);
            }
        }
    }

    internal class Grid
    {
        private int[,] _grid;

        public Grid(int row, int column)
        {
            _grid = new int[row, column];
        }

        public int this[int row, int column]
        {
            get
            {
                return _grid[row, column];
            }
            set
            {
                _grid[row, column] = value;
            }
        }

        public void PrintGrid()
        {
            for (int i = 0; i < _grid.GetLength(0); i++)
            {
                for (int j = 0; j < _grid.GetLength(1); j++)
                {
                    Console.Write(_grid[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
