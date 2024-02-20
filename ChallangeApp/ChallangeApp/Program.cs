var name = "Ewa";
var isWoman = true;
var age = 30;

if (name == "Ewa" && age == 30 && isWoman == true)
{
    Console.WriteLine("Ewa lat 30");
}
else if (isWoman == true && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");

}
else if (isWoman == false && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");

}
