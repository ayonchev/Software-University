using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PetClinic
{
    private string name;
    private int countRooms;
    private Room[] rooms;
    private int currentRoom;
    private int initialRoom;
    private int movingAwayNumber;

    public PetClinic(string name, int numberOfRooms)
    {
        this.Name = name;
        this.CountRooms = numberOfRooms;
        this.rooms = new Room[this.CountRooms];
        FillRooms();
        this.initialRoom = (int)Math.Ceiling(CountRooms / 2.0) - 1;
        this.currentRoom = initialRoom;
        this.movingAwayNumber = 1;
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }
    public int CountRooms
    {
        get { return countRooms; }
        private set
        {
            if (value % 2 == 0)
            {
                throw new InvalidOperationException();
            }
            countRooms = value;
        }
    }

    public bool HasEmptyRooms => this.rooms.Any(r => r.IsEmpty);

    public bool AddPet(Pet currentPet)
    {
        if (!HasEmptyRooms)
            return false;

        rooms[currentRoom].Add(currentPet);

        if (currentRoom < initialRoom)
        {
            currentRoom = initialRoom + movingAwayNumber;
        }
        else if (currentRoom >= initialRoom)
        {
            if (currentRoom > initialRoom)
            {
                movingAwayNumber++;
            }

            currentRoom = initialRoom - movingAwayNumber;
        }

        return true;
    }

    public bool Release()
    {
        if (CheckForAnimal(initialRoom, rooms.Length))
            return true;

        if (CheckForAnimal(0, initialRoom))
            return true;

        return false;
    }

    public string PrintRoom(int roomIndex)
    {
        return rooms[roomIndex - 1].ToString();
    }

    public string PrintAll()
    {
        string result = string.Empty;

        foreach (var room in rooms)
        {
            result += room + Environment.NewLine;
        }

        return result;
    }

    private void FillRooms()
    {
        for (int roomIndex = 0; roomIndex < rooms.Length; roomIndex++)
        {
            rooms[roomIndex] = new Room();
        }
    }

    private bool CheckForAnimal(int startingRoom, int endingRoom)
    {
        for (int index = startingRoom; index < endingRoom; index++)
        {
            if (rooms[index] != null && !rooms[index].IsEmpty)
            {
                rooms[index].Release();
                return true;
            }
        }

        return false;
    }
}
