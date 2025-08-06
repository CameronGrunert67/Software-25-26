// See https://aka.ms/new-console-template for more information
Console.WriteLine("Recipients full name");
string fullname = Console.ReadLine();
Console.WriteLine("Senders full name");
string sfullname = Console.ReadLine();
Console.WriteLine("Subject of email");
string subject = Console.ReadLine();
Console.WriteLine("Name of project discussed");
string projectname = Console.ReadLine();
Console.WriteLine("Possible follow up date (e.g., MM/DD/YYYY)");
string date = Console.ReadLine();





Console.WriteLine($"To: {fullname}.");
Console.WriteLine($"Dear {fullname}.");
Console.WriteLine($"Subject: {subject}.");
Console.WriteLine($"I am writing to you today regarding the {projectname}.");
Console.WriteLine($"We anticipate completing the initial phase by {date}.");


Console.WriteLine($"Sincerely, {fullname}.");



