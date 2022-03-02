## Exception and User-Defined Exceptions
- https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/exception-handling
- https://www.javatpoint.com/c-sharp-user-defined-exceptions



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
