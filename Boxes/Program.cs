using System.Text;
using Boxes;

var stacks = Input.ReadInputData();

var movesCount = 0;
var resultBuilder = new StringBuilder();
LogState(stacks);
MoveAllItemsToFirstStack(stacks);
DistributeItemsFromFirstStack(stacks);
DistributeItemsBetweenFirstThreeStacks(stacks);

Console.WriteLine($"Число перекладываний {movesCount}");

LogState(stacks);

Input.WriteResult(resultBuilder.ToString());

void LogState(IReadOnlyList<Stack<int>> stackList)
{
    for (var i = 0; i < stackList.Count; i++)
    {
        var sb = new StringBuilder();
        sb.Append($"Стопка {i + 1}: ");
        foreach (var item in stackList[i]) 
            sb.Append($"{item} ");

        Console.WriteLine(sb.ToString());
    }
}

void MoveAllItemsToFirstStack(IReadOnlyList<Stack<int>> list)
{
    for (var i = 1; i < list.Count; i++)
    {
        while (list[i].Count > 0)
        {
            MoveFromOneStackToAnother(i, 0, list);
            movesCount++;
        }
    }
}

void DistributeItemsFromFirstStack(IReadOnlyList<Stack<int>> list)
{
    var firstStack = list[0];
    while (firstStack.Count != 0)
    {
        var value = list[0].Peek();
        if (value == 1)
            MoveFromOneStackToAnother(0, 1, list);
        else
            MoveFromOneStackToAnother(0, value - 1, list);
        
        movesCount++;
    }
}

void DistributeItemsBetweenFirstThreeStacks(IReadOnlyList<Stack<int>> list)
{
    while (list[1].Count != 0)
    {
        var value = list[1].Peek();
        MoveFromOneStackToAnother(1, value == 2 ? 2 : 0, list);
        movesCount++;
    }

    while (list[2].Peek() == 2)
    {
        MoveFromOneStackToAnother(2, 1, list);
        movesCount++;
    }
}



void MoveFromOneStackToAnother(int fromIndex, int toIndex, IReadOnlyList<Stack<int>> stackList)
{
    var value = stackList[fromIndex].Pop();
    stackList[toIndex].Push(value);
    resultBuilder.AppendLine($"Переложить ящик {value} из стопки {fromIndex + 1} в стопку {toIndex + 1}");
}