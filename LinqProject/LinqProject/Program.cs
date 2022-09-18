﻿namespace LinqProject
{
    internal class Program
    {
    //        Select: определяет проекцию выбранных значений
    //Where: определяет фильтр выборки
    //OrderBy: упорядочивает элементы по возрастанию
    //OrderByDescending: упорядочивает элементы по убыванию
    //ThenBy: задает дополнительные критерии для упорядочивания элементов возрастанию
    //ThenByDescending: задает дополнительные критерии для упорядочивания элементов по убыванию
    //Join: соединяет две коллекции по определенному признаку
    //Aggregate: применяет к элементам последовательности агрегатную функцию, которая сводит их к одному объекту
    //GroupBy: группирует элементы по ключу
    //ToLookup: группирует элементы по ключу, при этом все элементы добавляются в словарь
    //GroupJoin: выполняет одновременно соединение коллекций и группировку элементов по ключу
    //Reverse: располагает элементы в обратном порядке
    //All: определяет, все ли элементы коллекции удовлятворяют определенному условию
    //Any: определяет, удовлетворяет хотя бы один элемент коллекции определенному условию
    //Contains: определяет, содержит ли коллекция определенный элемент
    //Distinct: удаляет дублирующиеся элементы из коллекции
    //Except: возвращает разность двух коллекцию, то есть те элементы, которые создаются только в одной коллекции
    //Union: объединяет две однородные коллекции
    //Intersect: возвращает пересечение двух коллекций, то есть те элементы, которые встречаются в обоих коллекциях
    //Count: подсчитывает количество элементов коллекции, которые удовлетворяют определенному условию
    //Sum: подсчитывает сумму числовых значений в коллекции
    //Average: подсчитывает cреднее значение числовых значений в коллекции
    //Min: находит минимальное значение
    //Max: находит максимальное значение
    //Take: выбирает определенное количество элементов
    //Skip: пропускает определенное количество элементов
    //TakeWhile: возвращает цепочку элементов последовательности, до тех пор, пока условие истинно
    //SkipWhile: пропускает элементы в последовательности, пока они удовлетворяют заданному условию, и затем возвращает оставшиеся элементы
    //Concat: объединяет две коллекции
    //Zip: объединяет две коллекции в соответствии с определенным условием
    //First: выбирает первый элемент коллекции
    //FirstOrDefault: выбирает первый элемент коллекции или возвращает значение по умолчанию
    //Single: выбирает единственный элемент коллекции, если коллекция содержит больше или меньше одного элемента, то генерируется исключение
    //SingleOrDefault: выбирает единственный элемент коллекции.Если коллекция пуста, возвращает значение по умолчанию. Если в коллекции больше одного элемента, генерирует исключение
    //ElementAt: выбирает элемент последовательности по определенному индексу
    //ElementAtOrDefault: выбирает элемент коллекции по определенному индексу или возвращает значение по умолчанию, если индекс вне допустимого диапазона
    //Last: выбирает последний элемент коллекции
    //LastOrDefault: выбирает последний элемент коллекции или возвращает значение по умолчанию

        static void Main(string[] args)
        {
            //string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };
            //var selectedPeople = new List<string>();
            //foreach (string person in people)
            //{

            //    if (person.ToUpper().StartsWith("T"))
            //        selectedPeople.Add(person);
            //}
            //selectedPeople.Sort();
            //foreach (string person in selectedPeople)
            //    Console.WriteLine(person);

            //LINQ
            //формат запросов
            // создаем новый список для результатов
            //var selectedPeople = from p in people // передаем каждый элемент из people в переменную p
            //                     where p.ToUpper().StartsWith("T") //фильтрация по критерию
            //                     orderby p  // упорядочиваем по возрастанию
            //                     select p; // выбираем объект в создаваемую коллекцию
            //foreach (string person in selectedPeople)
            //    Console.WriteLine(person);

            //ниже краткая запись
            //var selectedPeople = from p in people where p.ToUpper().StartsWith("T") orderby p select p;

            //формат методов расширения
            //var selectedPeople = people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p => p);
        }
    }

    //SELECT*********************************************
    var people = new List<Person>
    {
        new Person ("Tom", 23),
        new Person ("Bob", 27),
        new Person ("Sam", 29),
        new Person ("Alice", 24)
    };
    //var names = from p in people select p.Name;
    var names = people.Select(u => u.Name);
    foreach (string n in names)
     Console.WriteLine(n);
    //***************************************************
    //WHERE*********************************************
    //Where<TSource>(Func<TSource, bool> predicate)

        string[] people = { "Tom", "Alice", "Bob", "Sam", "Tim", "Tomas", "Bill" };
        var selectedPeople = people.Where(p => p.Length == 3); // "Tom", "Bob", "Sam", "Tim"
        foreach (string person in selectedPeople)
            Console.WriteLine(person);


        var selectedPeople = from p in people
                             where p.Length == 3
                             select p;
int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
var evens1 = numbers.Where(i => i % 2 == 0 && i > 10);
    //****************************************

    class Person
    {
        string name;
        int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}