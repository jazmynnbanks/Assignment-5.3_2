static int ClimbStairs(int n)
{
    if (n == 1) return 1;
    if (n ==2) return 2;

    int first = 1;
    int second = 2;
    int totalSteps = 0;

    for (int i = 3; i <= n; i++)
    {
        totalSteps = first + second;
        first = second;
        second = totalSteps;
    }
    return totalSteps;
}

Console.Write("Enter number of steps: ");
int steps = Convert.ToInt32(Console.ReadLine());
int result= ClimbStairs(steps);
Console.WriteLine($"You can climb the stairs in {result} different ways");