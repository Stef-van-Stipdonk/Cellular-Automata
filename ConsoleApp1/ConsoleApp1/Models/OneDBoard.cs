namespace ConsoleApp1.Models;

public class OneDBoard
{
    public Cell[] Cells { get; set; }

    public OneDBoard(int size)
    {
        Cells = new Cell[size];
        
        for (int i = 0; i < size; i++)
        {
            Cells[i] = new Cell();
        }

        Cells[size/2].IsRevealed = true;
    }

    public void PrintState()
    {
        foreach (var cell in Cells)
        {
            Console.Write(cell.IsRevealed ? "■" : "□");
        }
        Console.Write("\n");
        Thread.Sleep(20);
    }
}