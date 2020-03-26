using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
public class TrafficLightFactory
{
    public TrafficLight CreateTrafficLight(string light)
    {
        var type = typeof(TrafficLight);
        var constructor = type.GetConstructor(new Type[] {typeof(Light)});
        var instance = (TrafficLight)constructor.Invoke(new object[] {Enum.Parse(typeof(Light), light)});

        return instance;
    }
}
