using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int N, arrMaxIndex,arrSumIndexPositive=0, intNum=0;
double arrSumMinus = 0, arrMin, arrMax, arrMaxAbs, arrMaxAbsReal;
Console.Write("Введіть кількість елементів в масиві: ");
int.TryParse(Console.ReadLine(), out N);
double[] arr = new double[N];
Random rnd = new Random();
Console.Write("Масив: ");
for (int j = 0; j < N; j++)
{
    arr[j] = rnd.Next(20) - 10 + rnd.NextDouble();
    arr[j] = Math.Round(arr[j],1);
    Console.Write($"{arr[j]}\t");
}
arrMin = arr[0];
arrMax = arr[0];
arrMaxAbs = arr[0];
arrMaxAbsReal = arr[0];
arrMaxIndex = 0;
for (int j = 0; j < N; j++)
{
    if (arr[j] < 0)
       arrSumMinus += arr[j];
    if (arr[j] > 0)
        arrSumIndexPositive += j;
    if ((arr[j]*10) % 10 == 0)
        intNum ++;
    if (arrMin > arr[j])
        arrMin = arr[j];
    if (arrMax < arr[j])
    {
        arrMax = arr[j];
        arrMaxIndex = j;
    }
    if (arrMaxAbs < Math.Abs(arr[j]))
    {
        arrMaxAbs = Math.Abs(arr[j]);
        arrMaxAbsReal = arr[j];
    }
}
Console.WriteLine($"\nсума від’ємних елементів масиву: {arrSumMinus}");
Console.WriteLine($"мінімальний елемент масиву: {arrMin}");
Console.WriteLine($"номер (індекс) максимального елемента масиву: {arrMaxIndex}");
Console.WriteLine($"максимальний за модулем елемент масиву: {arrMaxAbsReal}");
Console.WriteLine($"сума індексів додатних елементів: {arrSumIndexPositive}");
Console.WriteLine($"кількість цілих чисел у масиві: {intNum}");