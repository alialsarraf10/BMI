

string weight, height, age;


Console.Write("input your weight in kg : ");
weight = Console.ReadLine();

Console.Write("input your height in cm: ");
height = Console.ReadLine();

double weightval = Convert.ToInt32(weight);
double heightval = Convert.ToInt32(height);


double bmi = (weightval / (Math.Pow(heightval, 2)/100)) * 100;

Console.WriteLine(bmi);

if (bmi >= 30)
{
    Console.WriteLine("Obese");
}
else if (bmi >= 25)
{
    Console.WriteLine("Overweight");
}
else if (bmi >= 18.5)
{
    Console.WriteLine("Healthy");
}
else
{
    Console.WriteLine("Underweight");
}


Console.WriteLine("BMI State by Age");

Console.Write("input your Age : ");
age = Console.ReadLine();

int agenum = Convert.ToInt32(age);

if (agenum >= 65 &&( bmi >= 24 && bmi <= 29))
{
    Console.WriteLine("Healthy");
}
else if (agenum >= 55 && (bmi >= 23 && bmi <= 28))
{
    Console.WriteLine("Healthy");
}
else if (agenum >= 45 && (bmi >= 22 && bmi <= 27))
{
    Console.WriteLine("Healthy");
}
else if (agenum >= 35 && (bmi >= 21 && bmi <= 26))
{
    Console.WriteLine("Healthy");
}
else if (agenum >= 25 && (bmi >= 20 && bmi <= 25))
{
    Console.WriteLine("Healthy");
}

else if (agenum >= 19 && (bmi >= 19 && bmi <= 24))
{
    Console.WriteLine("Healthy");
}
else
{
    Console.WriteLine("not healthy");
}




