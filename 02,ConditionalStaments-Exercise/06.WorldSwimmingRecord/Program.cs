double timeRecord = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double newTime = double.Parse(Console.ReadLine());

double timeSwimmer = distance * newTime;
double distancePlus15m = Math.Floor(distance / 15) * 12.5;
double totalTime = timeSwimmer + distancePlus15m;


if (totalTime < timeRecord)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
}
else
{
    double difference = totalTime - timeRecord;
    Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
}