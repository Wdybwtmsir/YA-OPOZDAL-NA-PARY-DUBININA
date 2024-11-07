//Class Array
//Length - длина массива
//Rank - размерность массива
//BinarySearch - бинарный поиск
//Sort - сортировка
//IndexOf - Возвращает индекс первого вхождения элемента в массив
//LastIndexOf - Возвращает индекс последнего вхождения элемента в массив
//FindIndex - Возвращает индекс первого вхождения элемента, который удовлетворяет определенному условию
//FindLastIndex - Возвращает индекс последнего вхождения элемента который удовлетворяет определенному условию
//Find - находит первый элемент который удовлетворяет определенному условию. Если элемент не найден то возвращается null.
//FindLast - находит последний элемент который удовлетворяет определенному условию Если элемент не найден то возвращается null
//FindAll - возвращает все элеменды в виде массива которые удовлетворяет определенному уровню
//Reverse - Распологает элементы массива в обратном порядке
//Exists - проверяет удовлетворяет ли массив заданному условию
//Fill - 
//Copy - 
string[] people = { "Gabitov tvar", "Karpov mraz", "Goluboy G", "Kirill Chmo" };
int[] numbers = { 4, 8, 3, 2, 6, 9, 1, 7 };
Console.WriteLine(people.Length);
Console.WriteLine(people.Rank);
Array.Sort(people);
foreach (string item in people) Console.Write(item+" ");
Console.WriteLine();
Console.WriteLine(Array.BinarySearch(people,"Karpov mraz"));
Console.WriteLine(Array.BinarySearch(people, "Seroga"));
Array.Sort(numbers);
foreach (int item in numbers) Console.Write(item + " ");
Console.WriteLine();
Console.WriteLine(Array.BinarySearch(numbers, 2));
int[] mas = { 2, 5, 7, 9, 1, 10, 1, 2, 16, 7, };
Console.WriteLine(Array.IndexOf(mas,3));
int lastIndex=Array.LastIndexOf(mas,3);
Console.WriteLine(lastIndex);
Console.WriteLine(Array.FindIndex(mas, p => p > 8));
Console.WriteLine(Array.FindLastIndex(mas, p => p > 8));
Console.WriteLine(Array.Find(mas, p => p >= 9));
Console.WriteLine(Array.FindLast(mas, p => p <= 5));
int[] res=Array.FindAll(mas, p => p > 5);
foreach (int item in res) Console.Write(item+" ");
Console.WriteLine();
Array.Reverse(mas);
foreach (int item in mas) Console.Write(item + " ");
Console.WriteLine();
Console.WriteLine(Array.Exists(mas,p=>p>7));
int[] fillmas = new int[10];
Array.Fill(fillmas, 5);
foreach (int item in fillmas) Console.Write(item + " ");
Console.WriteLine();
Array.Fill(fillmas, 3, 1, 7);
foreach (int item in fillmas) Console.Write(item + " ");
Console.WriteLine();
int[] copymas = new int[10];
Array.Copy(fillmas, copymas, 5);
foreach (int item in copymas) Console.Write(item + " ");
Console.WriteLine();
Array.Clear(mas);
foreach (int item in mas) Console.Write(item + " ");

    
