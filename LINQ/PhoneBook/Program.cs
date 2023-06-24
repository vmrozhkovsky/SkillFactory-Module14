using PhoneBook;

var phoneBook = new List<Contact>();

phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
phoneBook.Add(new Contact("Сергей", "Довлатов",79990000010, "serge@example.com"));
phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
phoneBook.Add(new Contact("Валерий", "Леонтьев",79990000012, "valera@example.com"));
phoneBook.Add(new Contact("Сергей", "Брин",  799900000013, "serg@example.com"));
phoneBook.Add(new Contact("Иннокентий", "Смоктуновский",799900000013, "innokentii@example.com"));

var sortedPhoneBook = phoneBook.OrderBy(b => b.Name).ThenBy(b => b.LastName);
foreach(var b in sortedPhoneBook)
    Console.WriteLine($"{b.Name} {b.LastName}");

