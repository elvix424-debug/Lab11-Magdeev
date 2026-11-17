// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1075;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }

// Console.WriteLine(found ? "Студент найден" : "Студент не найден");



// int variant = 5;
// bool isPrime = true;

// if (variant < 2)
// {
//     Console.WriteLine("Номер варианта не является ни простым, ни составным");
//     return;
// }

// for (int divisor = 2; divisor < variant; divisor++)
// {
//     if (variant % divisor == 0)
//     {
//         isPrime = false;
//         break;
//     }
// }
// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");



// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int cn = 0;
// foreach (int point in pointsPerLab)
// {
//     if (point < 0)
//     {
//         continue;
//     }
//     cn += 1;
//     sum += point;
// }
// Console.WriteLine($"Работ сдано: {cn}");
// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");



int[] groupIds = { 101, 104, 107, 104, 110 };
bool hasDuplicates = false;

for (int i = 0; i < groupIds.Length; i++)
{
    for (int j = i + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            Console.WriteLine($"Совпали номера зачётки: {groupIds[i]} и {groupIds[j]}");            
            hasDuplicates = true;
            break;
        }
    }
}

if (!hasDuplicates)
{
    Console.WriteLine("Все номера уникальны");
}
