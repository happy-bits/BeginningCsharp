
# Car 4

Remove the methods and use **properties** instead.

This:

    var c1 = new Car("blue", 1200);
    var c2 = new Car("red", 800);
    var c3 = new Car(); 

    c2.Color = "yellow"; 
    c2.Weight = 600;

    Console.WriteLine($"The color of car1 is {c1.Color} and the weight is {c1.Weight}");
    Console.WriteLine($"The color of car2 is {c2.Color} and the weight is {c2.Weight}");
    Console.WriteLine($"The color of car3 is {c3.Color} and the weight is {c3.Weight}");

...should output:

![](Images/car4.PNG)