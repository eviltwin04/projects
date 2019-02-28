using System;

public class ShieldedInvader : Invader
{
    private static System.Random _random = System.Random();

    public ShieldedInvader (Path path) : base(path)
    { }

    public override void DecreaseHealth(int factor)
    {
        if (_random.NextDouble() < .5)
        {
            base.DecreaseHealth(factor);
        }
        else
        {
            System.Console.WriteLine("Shot at a shielded invader, but it sustained no damage.");
        }
       }
	}
