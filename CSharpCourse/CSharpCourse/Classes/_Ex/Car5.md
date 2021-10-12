# Car 5

Make a small adjustment to the program so we can't change the color or weight of the car after it is created:

    var c1 = new Car("blue", 1200);
    var c2 = new Car("red", 800);
    var c3 = new Car(); 

    c2.Color = "yellow";  // this shouldn't work
    c2.Weight = 600;      // this shouldn't work