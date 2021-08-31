using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        class Book
        {
            public int Price { get; set; }
            public string Name { get; set; }
        }
        
        static void Main(string[] args)
        {
            var numbers = new List<int>(){ 17,2,22,1,22,37 };
            numbers.Sort();
 
            var result = new Dictionary<int,int>();
            for(int i = 1;i < numbers.Count; i++)
            {
                if(numbers[i] == numbers[i-1]) 
                {
                    if(!result.Keys.Contains(numbers[i]))
                        result.Add(numbers[i],1);
                    else result[numbers[i]]++;
                }
            }
            foreach (int val in numbers.Distinct())
            {
                Console.WriteLine(val + " - " + numbers.Where(x => x == val).Count() + " раз");
            }
            
            List<Book> books = new List<Book>();
            books.Add(new Book() { Price = 5, Name = "aaa" });
            books.Add(new Book() { Price = 13, Name = "eee" });
            books.Add(new Book() { Price = 5, Name = "ttt" });
            books.Add(new Book() { Price = 45, Name = "ooo" });
            
            List<Book> foundBooks = books.FindAll(item => item.Price==5);
            
            foreach (Book book in foundBooks)
                Console.WriteLine($"Price: {book.Price}, Name: {book.Name}");
        }
    }
}