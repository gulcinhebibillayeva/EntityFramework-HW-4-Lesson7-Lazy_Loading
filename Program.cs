
using ADO_NET_07_Homework_Lazy_Loading;
using Microsoft.EntityFrameworkCore;

using LibraryContext db = new();


while (true)
{
    Console.WriteLine("Choose");

    Console.WriteLine("1.Books by topic");
    Console.WriteLine("2.Books by Category");
    Console.WriteLine("3.Books by Author");
    if (!int.TryParse(Console.ReadLine(), out int choise))
    {
        Console.WriteLine("Please enter number\n");
        continue;
    }
    if (choise == 1)
    {
        var topics = db.Themes.ToList();
        foreach (var topic in topics)
        {
            Console.WriteLine($"*****************{topic.Id} {topic.Name}");
            foreach (var book in topic.Books)
            {
                Console.WriteLine($"{book.Name}");
            }
        }
    }


    else if (choise == 2)
    {
        var categories = db.Categories.ToList();
        foreach (var category in categories)
        {
            Console.WriteLine($"*****************{category.Id} {category.Name}");
            foreach (var book in category.Books)
            {
                Console.WriteLine($"{book.Name}");
            }

        }
    }

    else if (choise == 3)
    {
        var authors = db.Authors.ToList();
        foreach (var author in authors)
        {
            Console.WriteLine($"*****************{author.FirstName} {author.LastName}");
            foreach (var book in author.Books)
            {
                Console.WriteLine($"{book.Name}");
            }
        }
    }
    }


