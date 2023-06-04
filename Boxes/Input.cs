namespace Boxes;

public static class Input
{
    public static IReadOnlyList<Stack<int>> ReadInputData()
    {
        const string fileName = "boxes.txt";

        var result = new List<Stack<int>>();
        using var reader = new StreamReader(fileName);
        while (reader.EndOfStream is false)
        {
            var numbers = reader.ReadLine()?.Split(' ') ?? throw new InvalidDataException();

            var valueList = numbers.Select(int.Parse).ToList();
                
            result.Add(GetStackFromList(valueList));
        }

        return result;
    }

    private static Stack<int> GetStackFromList(List<int> valueList)
    {
        var stack = new Stack<int>();

        foreach (var value in valueList)
        {
            stack.Push(value);
        }

        return stack;
    }

    public static void WriteResult(string result)
    {
        const string fileName = "moves.txt";

        using var writer = new StreamWriter(fileName);
        writer.WriteLine(result);
    }
}