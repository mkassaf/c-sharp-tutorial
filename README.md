# C# Tutorials.

## Introduction to C#
https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/

## Manipulate integral and floating point numbers:**
https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp

## The generic list type
- https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/list-collection?tutorial-step=1
- https://www.javatpoint.com/c-sharp-collections
```ruby
var names = new List<string> { "<name>", "Ana", "Felipe" };
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
```

## Function
- https://www.javatpoint.com/c-sharp-function
```ruby
   public void Print(string message)
        {
            Console.WriteLine("Hello " + message);
        }
        public void CallByValue(int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the CallByValue function " + val);
        }
        public void CallByRefrence(ref int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the CallByRefrence function " + val);
        }

        /**
         * 
         * C# Out Parameter
         * C# provides out keyword to pass arguments as out-type. 
         * It is like reference-type, except that it does not require variable to initialize before passing. 
         * We must use out keyword to pass argument as out-type.
         * It is useful when we want a function to return multiple values.
         * 
         */
        public void CallFunUsingOutParam(out int val) // Out parameter  
        {
            int square = 5;
            val = square;
            val *= val; // Manipulating value
            Console.WriteLine("Value inside the CallFunUsingOutParam function " + val);
        }
```


