using DieRoller;

Die myDie = new Die();
myDie.FaceValue = 6;
byte currentValue = myDie.FaceValue;
myDie.Roll();
Console.ReadKey();