using System;

namespace CarLotSimulator;

public class Car
{
    
    
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public void MakeEngineNoise(string engine)
    {
        Console.WriteLine(engine);
    }

    public void MakeHonkNoise(string honk)
    {
        Console.WriteLine(honk);
    }

    
}

