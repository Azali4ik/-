Console.Write("Введите число: ");
string numA= Console.ReadLine();

int sum = 0;
for (int i =0; i < numA.Length; i++ )
{
    string temp = Convert.ToString(numA[i]);
    sum += Convert.ToInt32(temp);
}
Console.WriteLine(sum);