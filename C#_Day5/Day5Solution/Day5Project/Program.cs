using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Day5Project
{
    class Program
    {
        void UnderstandingCollection()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(12.3f);
            list.Add("Hello");
            list.Add(123.2);
            list.Add(new Object());
            list.Add("Hello");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The capacity of the collection is "+list.Capacity);
            list.TrimToSize();
            Console.WriteLine("The capacity of the collection after trim is " + list.Capacity);
            list.Add("Hello");
            Console.WriteLine("How many elements are present in the collection?? "+list.Count);
            double sum = 0;
            foreach (var item in list)
            {
                sum += Convert.ToDouble(item);
            }
        }
        void UnderstandingList()
        {
            List<int> intList = new List<int>();
            intList.Add(123);
            intList.Add(254);
            intList.Add(12);
            intList.Add(476587);
            intList.Add(12);
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }
            intList.Sort();
            Console.WriteLine("After sort");
            foreach (int item in intList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("the element in position 3 is "+intList[2]);
        }
        void UnderstandingMoreAboutList()
        {
            List<Employee> employees = new List<Employee>();
            //int choice = 0;
            //do
            //{
            //    Employee employee = new Employee();
            //    employee.TakeEmployeeData();
            //    employees.Add(employee);
            //    Console.WriteLine("Enter a number > 0 to continue. 0 to exit");
            //    choice = Convert.ToInt32(Console.ReadLine());
            //} while (choice>0);
            employees.Add(new Employee(101, "Ramu", 32423));
            employees.Add(new Employee(102, "Bimu", 2131));
            employees.Add(new Employee(103, "Lomu", 353687));
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
                Console.WriteLine("------------------------");
            }
            employees.Sort(new EmployeeNameSort());
            Console.WriteLine("After sort");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
                Console.WriteLine("------------------------");
            }
            //Employee checkEmployee = new Employee(102, "Bimu", 2131);
            //if(employees[1].Equals(checkEmployee))
            //    Console.WriteLine("Same");
            //else
            //    Console.WriteLine("Shame");
            //Console.WriteLine("Does it contain the employee with id 102?? "+employees.Contains(checkEmployee));
        }
        void UnderstandingStack()
        {
            Stack<float> numberStack = new Stack<float>();
            numberStack.Push(123.4f);
            numberStack.Push(455.4f);
            numberStack.Push(866.2f);
            numberStack.Push(334.5f);
            foreach (float item in numberStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("number of elements in stack now "+numberStack.Count);
            Console.WriteLine("Lets pop the element "+numberStack.Pop());
            Console.WriteLine("number of elements in stack now " + numberStack.Count);
            //gives back what the next retrivable element is but does not remove it
            Console.WriteLine("Lets not pop but lets peek what is the next element "+numberStack.Peek());
            Console.WriteLine("number of elements in stack now " + numberStack.Count);
        }
        void UnderstandingQueue()
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Ramu");
            names.Enqueue("Bimu");
            names.Enqueue("Somu");
            names.Enqueue("Jimu");
            names.Enqueue("Pomu");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Deque check "+names.Dequeue());
            Console.WriteLine("Count after dequque "+names.Count);
            Console.WriteLine("Peek check "+names.Peek());
            Console.WriteLine("Count after peek " + names.Count);
        }
        void UnderstandingDictionary()
        {
            Dictionary<int, string> pairs = new Dictionary<int, string>();
            pairs.Add(101, "Ramu");
            pairs.Add(102, "Somu");
            pairs.Add(103, "Bimu");
            pairs.Add(104, "Timu");
            pairs.Add(105, "Pomu");
            foreach (var item in pairs)
            {
                Console.WriteLine(item);
            }
            pairs.Add(106, "Gomu");
            Console.WriteLine("Using the key to access the value "+pairs[103]);
            pairs.Remove(102);
            Console.WriteLine("After removing");
            foreach (var item in pairs)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Printing key and value");
            foreach (var item in pairs.Keys)
            {
                Console.WriteLine(item +" "+pairs[item]);
            }
            Console.WriteLine("Does the collection contain 104?? "+pairs.ContainsKey(104));
        }
        void UnderstandingSet()
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(10);
            set.Add(3);
            set.Add(345);
            set.Add(10);
            set.Add(4534);
            Console.WriteLine("Does teh set conain a 3?? "+set.Contains(3));
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Let's see another set");
            SortedSet<double> sortedSet = new SortedSet<double>();
            foreach (var item in set)
            {
                sortedSet.Add(item);
            }
            foreach (var item in sortedSet)
            {
                Console.WriteLine(item);
            }
            SortedSet<Employee> employees = new SortedSet<Employee>();
            employees.Add(new Employee(101,"Ramu",32423));
            employees.Add(new Employee(102, "Bimu", 2131));
            employees.Add(new Employee(103, "Lomu", 353687));
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            new Program().UnderstandingMoreAboutList();
            Console.ReadKey();
        }
    }

    class Employee : IComparable<Employee>
    {
        //public override int GetHashCode()
        //{
        //    return Id * 2 + 10;
        //}
        public override bool Equals(object obj)
        {
            bool result = false;
            Employee e1, e2;
            e1 = this;
            e2 = (Employee)obj;
            if (e1.Id == e2.Id && e1.Name == e2.Name && e1.Salary == e2.Salary)
                result = true;
            return result;
        }

        public int CompareTo(Employee other)
        {
            //return this.Name.CompareTo(other.Name);
            return this.Salary.CompareTo(other.Salary);
        }

        public Employee()
        {
        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return "ID is " + Id
                + "\nName is " + Name
                + "\nSalary is " + Salary;
        }
        public void TakeEmployeeData()
        {
            Console.WriteLine("Please enter the employee ID");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee Salary");
            Salary = Convert.ToDouble(Console.ReadLine());
        }
    }
}
