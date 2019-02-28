# C# coding challenge - dependency management

Most modern programming languages rely on reusable functionality in the form of individual components.  In order for an application to execute, all dependent components need to be loaded before a component is loaded.

Given this example:
```
              component4
                 / \
                /   \
               /     \
       component3   component2
          / 
         /   
        / 
    component1    
```
Component4 is the entry point of the application.  Component4 requires component2 and component3, and component3 requires component1.  The correct load order would be:
```
component1
component2
component3
component4
```

Using the included C# boilerplate project and sample json input file, write code that determines the minimum required components to load, and their correct load order for the components specified in the input file ```input.json```

## Requirements
* Load the input file from disk.
* Implement the ResolveDependencies function.
* Call DisplayDependencyLoadOrder to display the output.

## Assumptions
* The input file will be well formed json.
* The components specified in ```input.json``` are in no particular order.
* The ```Entry``` property of the ```Component``` object specifies the entry point for the application described in the input file.
