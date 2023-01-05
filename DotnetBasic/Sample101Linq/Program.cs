using Sample101Linq.DataSources;

public class Program
{
    public static void Main()
    {
        AggregateOperator aggregateOperator = new AggregateOperator();
        aggregateOperator.CountSyntax();
        Console.WriteLine("Nested Count");
        aggregateOperator.CountNested();
        aggregateOperator.SumSyntax();
    }
}

