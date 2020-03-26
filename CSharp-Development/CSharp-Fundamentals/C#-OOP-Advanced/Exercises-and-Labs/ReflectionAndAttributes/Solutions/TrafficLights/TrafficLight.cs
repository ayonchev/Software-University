using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;


public class TrafficLight
{
    private Light currentLight;

    public TrafficLight(Light light)
    {
        this.currentLight = light;
    }

    public void Update()
    {
        int previousLight = (int) currentLight;
        currentLight = (Light) (++previousLight % typeof(Light).GetEnumNames().Length);
    }

    public override string ToString()
    {
        return this.currentLight.ToString();
    }
}
