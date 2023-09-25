# Allergies

This is an application that practices the implementation of C# Dictionaries and includes methods that adds allergen scores to a user's total score based on the allergen that a user inputs, for example:

```csharp
// {Allegern, score}
{"Eggs", 1}
{"Peanuts", 2}
{"Shellfish, 4}
{Strawberries, 8}
{"Tomatoes", 16}
{"Chocolate", 32}
{"Pollen", 64}
{"Cats", 128}
```
A user input of `"Chocolate"` is 32 which then the user's total score becomes 32. If the user inputs another allergen `"Pollen"`, their total score increments and becomes 96. 

## Application Setup

1. Clone this repo.
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called `Allergies`.
3. In the command line, run the command `dotnet run` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
4. Optionally, you can run `dotnet build` to compile this console app without running it.