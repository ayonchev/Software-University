using System;
using System.Collections.Generic;
using System.Text;

public class Engine
{
    private int engineSpeed;
    private int enginePower;

    public int EngineSpeed
    {
        get { return engineSpeed; }
        set { engineSpeed = value; }
    }

    public int EnginePower
    {
        get { return enginePower; }
        set { enginePower = value; }
    }

    public Engine(int currentEngineSpeed, int currentEnginePower)
    {
        enginePower = currentEnginePower;
        engineSpeed = currentEngineSpeed;
    }
}
