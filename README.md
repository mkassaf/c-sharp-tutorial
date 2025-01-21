# C# Tutorials.

## Introduction to C#
https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/

## Manipulate integral and floating point numbers:**
https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp



## Function
- https://www.javatpoint.com/c-sharp-function
- https://github.com/mkassaf/c-sharp-tutorial/tree/main/FunctionInCsharp
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

	public void int mul(int x, int y){
		return x*y;
	}
	public static int divide(int x,int y){
		return x/y;
	}
	public static int sum(int x,int y){
		return x+y;
	}

```

## Array 

- https://github.com/mkassaf/c-sharp-tutorial/tree/main/ArraysInCsharp
- https://www.javatpoint.com/c-sharp-arrays 


```ruby
            SimpleArray simpleArray = new SimpleArray();
            simpleArray.Run();

            MultidimensionalArrays multidimensional = new MultidimensionalArrays();
            multidimensional.Run();

            JaggedArrays jaggedArrays = new JaggedArrays();
            jaggedArrays.Run();

            Params parmExample = new Params();
            parmExample.Run();

            ArrayClass arrayClass = new ArrayClass();
            arrayClass.Run();

            Test test = new Test(4);
```

## Namespaces
- https://www.javatpoint.com/c-sharp-namespaces
- https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/namespaces

## String
- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/ 

## The generic list type
### List
- https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/list-collection?tutorial-step=1
- https://www.javatpoint.com/c-sharp-collections
```ruby
var names = new List<string> { "<name>", "Ana", "Felipe" };
foreach (var name in names)
{
  Console.WriteLine($"Hello {name.ToUpper()}!");
}
```
### Map
- https://docs.microsoft.com/en-us/previous-versions/visualstudio/spec-explorer/ee681326(v=specexplorer.10) 

 
### HashMap

- https://docs.microsoft.com/en-us/dotnet/api/system.collections.hashtable?view=net-6.0 


### Dictionary
- https://www.c-sharpcorner.com/blogs/dictionary-and-maps-in-c-sharp 



## Debugging
- https://www.youtube.com/watch?v=pm_pv0Eb7Fw&list=PLdo4fOcmZ0oVxKLQCHpiUWun7vlJJvUiN&index=16 

## Object and Class
- https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes?WT.mc_id=Educationalcsharp-c9-scottha 

## Var keyword 
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var
- https://www.geeksforgeeks.org/var-keyword-in-c-sharp/#:~:text=Keywords%20are%20the%20words%20in,variable%20based%20on%20initial%20value. 

## Getter and Setter:
- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties 
- https://codeasy.net/lesson/properties 

## super(base keyword)
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/base 

## Constructors: 
- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors  
- https://www.c-sharpcorner.com/article/constructors-in-C-Sharp/#:~:text=A%20constructor%20in%20C%23%20is%20a%20member%20of%20a%20class,same%20name%20as%20the%20class. 


## Access Modifier
- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

## Static
- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
- https://www.geeksforgeeks.org/static-keyword-in-c-sharp/#:~:text=Static%20Variable&text=When%20a%20variable%20is%20declared,C%23
- 

## Abstract
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract

## Interface
- https://www.javatpoint.com/c-sharp-interface 
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface 


## Awit and async 
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/await 

## Exception and User-Defined Exceptions
- https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/exception-handling
- https://www.javatpoint.com/c-sharp-user-defined-exceptions

# Sealed
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed

# C# Coding Conventions
- https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions?fbclid=IwAR3nP2f-2LcdOcJcT1n8J8uNb6ilLBM2wSD5e3HOPT8a2FdgIeSVhPrKU7A
- https://www.dofactory.com/csharp-coding-standards
- https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md
- https://www.c-sharpcorner.com/UploadFile/8a67c0/C-Sharp-coding-standards-and-naming-conventions/

# => operator (C# reference)
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator

# Lambda expressions (C# reference)
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions 
- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/local-functions 

# Delegates
- https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/

# Task.Run 
- https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.run?view=net-6.0

# ObservableCollection<T> Class
- https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1?view=net-6.0
  
# readonly (C# Reference)
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly
   
# using statement 
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement
   
# Handle and raise events

- https://docs.microsoft.com/en-us/dotnet/standard/events/
- https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/event
   
