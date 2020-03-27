using System;
using System.Collections.Generic;
using System.Text;

public class Song
{
    private string artistName;
    private string songName;

    public string ArtistName
    {
        get { return artistName; }
        set { artistName = value; }
    }

    public string SongName
    {
        get { return songName; }
        set { songName = value; }
    }

}