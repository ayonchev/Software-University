using System;

public class Sneaking
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        char[][] room = FillRoom(rows);

        var moves = Console.ReadLine().ToCharArray();
        int[] samPosition = GetSamsPosition(room);

        for (int move = 0; move < moves.Length; move++)
        {
            room = MoveEnemies(room);

            int[] getEnemy = GetEnemyPositionOnSamsRow(room, samPosition);

            if (IsSamDead(room, getEnemy, samPosition))
            {
                break;
            }

            room = MoveSam(room, moves, move, samPosition);

            getEnemy = GetEnemyPositionOnSamsRow(room, samPosition);

            if (IsNikoladzeKilled(room, getEnemy, samPosition))
            {
                break;
            }
        }
    }

    static bool IsNikoladzeKilled(char[][] room, int[] getEnemy, int[] samPosition)
    {
        if (room[getEnemy[0]][getEnemy[1]] == 'N' && samPosition[0] == getEnemy[0])
        {
            room[getEnemy[0]][getEnemy[1]] = 'X';
            Console.WriteLine("Nikoladze killed!");
            PrintRoom(room);
            return true;
        }

        return false;
    }

    static bool IsSamDead(char[][] room, int[] getEnemy, int[] samPosition)
    {
        if ((samPosition[1] < getEnemy[1] && room[getEnemy[0]][getEnemy[1]] == 'd' && getEnemy[0] == samPosition[0]) ||
            (getEnemy[1] < samPosition[1] && room[getEnemy[0]][getEnemy[1]] == 'b' && getEnemy[0] == samPosition[0]))
        {
            room[samPosition[0]][samPosition[1]] = 'X';
            Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");
            PrintRoom(room);
            return true;
        }

        return false;
    }

    static int[] GetEnemyPositionOnSamsRow(char[][] room, int[] samPosition)
    {
        int[] getEnemy = new int[2];

        for (int col = 0; col < room[samPosition[0]].Length; col++)
        {
            if (room[samPosition[0]][col] != '.' && room[samPosition[0]][col] != 'S')
            {
                getEnemy[0] = samPosition[0];
                getEnemy[1] = col;
            }
        }

        return getEnemy;
    }
    static char[][] MoveSam(char[][] room, char[] moves, int move, int[] samPosition)
    {
        room[samPosition[0]][samPosition[1]] = '.';
        switch (moves[move])
        {
            case 'U':
                samPosition[0]--;
                break;
            case 'D':
                samPosition[0]++;
                break;
            case 'L':
                samPosition[1]--;
                break;
            case 'R':
                samPosition[1]++;
                break;
        }
        room[samPosition[0]][samPosition[1]] = 'S';

        return room;
    }

    static void PrintRoom(char[][] room)
    {
        for (int row = 0; row < room.Length; row++)
        {
            for (int col = 0; col < room[row].Length; col++)
            {
                Console.Write(room[row][col]);
            }
            Console.WriteLine();
        }
    }

    static char[][] MoveEnemies(char[][] room)
    {
        for (int row = 0; row < room.Length; row++)
        {
            for (int col = 0; col < room[row].Length; col++)
            {
                if (room[row][col] == 'b')
                {
                    if (row >= 0 && row < room.Length && col + 1 >= 0 && col + 1 < room[row].Length)
                    {
                        room[row][col] = '.';
                        room[row][col + 1] = 'b';
                        col++;
                    }
                    else
                    {
                        room[row][col] = 'd';
                    }
                }
                else if (room[row][col] == 'd')
                {
                    if (row >= 0 && row < room.Length && col - 1 >= 0 && col - 1 < room[row].Length)
                    {
                        room[row][col] = '.';
                        room[row][col - 1] = 'd';
                    }
                    else
                    {
                        room[row][col] = 'b';
                    }
                }
            }
        }

        return room;
    }

    static int[] GetSamsPosition(char[][] room)
    {
        int[] samPosition = new int[2];

        for (int row = 0; row < room.Length; row++)
        {
            for (int col = 0; col < room[row].Length; col++)
            {
                if (room[row][col] == 'S')
                {
                    samPosition[0] = row;
                    samPosition[1] = col;
                }
            }
        }

        return samPosition;
    }

    static char[][] FillRoom(int rows)
    {
        char[][] room = new char[rows][];

        for (int row = 0; row < rows; row++)
        {
            var input = Console.ReadLine().ToCharArray();
            room[row] = new char[input.Length];
            for (int col = 0; col < input.Length; col++)
            {
                room[row][col] = input[col];
            }
        }

        return room;
    }
}
