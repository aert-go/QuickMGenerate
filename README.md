#QuickMGenerate

##Introduction
An evolution from the QuickGenerate library.

Aiming for : 
 - a terser (Linq) syntax 
 - a better way of dealing with state
 - better composability of generators
 - fun


##Generating Primitives
###Integers
Use `MGen.Int()`.

The overload `MGen.Int(int min, int max)` generates an int higher or equal than min and lower than max.

The default generator is (min = 1, max = 100).

Can be made to return `int?` using the `.Nullable()` extension.

 - `int` is automatically detected and generated for object properties.

 - `Int32` is automatically detected and generated for object properties.

 - `int?` is automatically detected and generated for object properties.


###Chars
Use `MGen.Char()`. 

No overload Exists.

The default generator always generates a char between lower case 'a' and lower case 'z'.

Can be made to return `char?` using the `.Nullable()` extension.

 - `char` is automatically detected and generated for object properties.

 - `char?` is automatically detected and generated for object properties.


###Strings
Use `MGen.String()`. 

No overload Exists.

The Default generator generates a string of length higher than 0 and lower than 10.

The default generator always generates every char element of the string to be between lower case 'a' and lower case 'z'.


###Booleans
Use `MGen.Bool()`. 

No overload Exists.

The default generator generates True or False.

Can be made to return `bool?` using the `.Nullable()` extension.

 - `bool` is automatically detected and generated for object properties.

 - `bool?` is automatically detected and generated for object properties.



