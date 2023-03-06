using ConsoleApp1.Models;

namespace ConsoleApp1;

public static class OneDArrayRules
{
    public static OneDBoard CoolHatsRule(this OneDBoard oneDBoard)
    {
        var newSet = new OneDBoard(oneDBoard.Cells.Length);
    
        for (int i = 0; i < oneDBoard.Cells.Length; i++)
        {
            var minIsRevealed = i != 0 && oneDBoard.Cells[i - 1].IsRevealed;
            var maxIsRevealed = i != oneDBoard.Cells.Length - 1 && oneDBoard.Cells[i + 1].IsRevealed;
        
            if((minIsRevealed && !maxIsRevealed) || (!minIsRevealed && maxIsRevealed))
            {
                newSet.Cells[i].IsRevealed = true;
            }
        }

        return newSet;
    }
    
}