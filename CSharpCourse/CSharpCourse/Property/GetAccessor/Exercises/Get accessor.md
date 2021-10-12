﻿# Get accessor

Create a class **Address**. The class should have the following properies:

- Street
- StreetNumber
- City
- ZipCode

First create a method *GetFullStreet* that returns street combined with the streetnumber.

Then create *getter* named *FullStreet* that should work in the same way.

Create an instance of Address. Write the values of the object as shown below:

![25](Images/25.png)

## Extra

1. What is the advantages/disadvantages of using the getter *FullStreet* instead of *GetFullStreet*?

2. Whould the solution be better or worse if we could *set* FullStreet?

3. Create a getter-property for the exercise with the cube (6.2)

4. Create another class with some properties. One of the properties should be a “getter”. 

## Hint

A normal class method:

    public string GetFullStreet()
    {
        return "....";
    }

A getter:

    public string FullStreet
    {
        get
        {
            return "...";
        }
    }

The same as above but shorter:

    public string FullStreet => "...";
