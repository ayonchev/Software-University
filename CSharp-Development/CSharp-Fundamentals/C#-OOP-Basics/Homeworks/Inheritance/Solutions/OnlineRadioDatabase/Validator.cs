using System;
using System.Collections.Generic;
using System.Text;

public class Validator
{
    public static void ValidateArtistName(string artistName)
    {
        if (artistName.Length < 3 || artistName.Length > 20)
        {
            throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
        }
    }

    public static void ValidateSongName(string songName)
    {
        if (songName.Length < 3 || songName.Length > 30)
        {
            throw new ArgumentException("Artist name should be between 3 and 30 symbols.");
        }
    }

    public static void ValidateSongLength(int minutes, int seconds)
    {
        
        
    }

    public bool ValidateMinutes(int minutes)
    {
        if (minutes < 0 || minutes > 14)
        {
            throw new ArgumentException("Song minutes should be between 0 and 14.");
        }

        return true;
    }

    public bool ValidateSeconds(int seconds)
    {
        if (seconds < 0 || seconds > 59)
        {
            throw new ArgumentException("Song seconds should be between 0 and 59.");
        }

        return 
    }
}
