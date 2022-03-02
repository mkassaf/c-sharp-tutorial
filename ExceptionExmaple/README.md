## Exception and User-Defined Exceptions
- https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/exception-handling
- https://www.javatpoint.com/c-sharp-user-defined-exceptions



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

## Exception Handling   

- https://github.com/mkassaf/c-sharp-tutorial/tree/main/ArraysInCsharp
- https://www.javatpoint.com/c-sharp-arrays 


```ruby
try
{
    // Code to try goes here.
}
catch (SomeSpecificException ex)
{
    // Code to handle the exception goes here.
    // Only catch exceptions that you know how to handle.
    // Never catch base class System.Exception without
    // rethrowing it at the end of the catch block.
}
finally
{
    // Code to execute after the try (and possibly catch) blocks
    // goes here.
}
```
