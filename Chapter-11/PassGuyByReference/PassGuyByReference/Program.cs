using PassGuyByReference;

var i = 1;
var guy = new Guy() { Name = "Joe", Age = 26 };
Console.WriteLine("i is {0} and guy is {1}", i, guy);
ModifyAnIntAndGuy(ref i, ref guy);
Console.WriteLine("i is {0} and guy is {1}", i, guy);

static void ModifyAnIntAndGuy(ref int valueRef, ref Guy guyRef)
{
    valueRef += 10;
    guyRef.Name = "Bob";
    guyRef.Age = 37;
}
