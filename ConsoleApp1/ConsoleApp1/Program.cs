// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using ConsoleApp1.Models;

var board = new OneDBoard(600);

while (true)
{
    board = board.CoolHatsRule();
    board.PrintState();
}
