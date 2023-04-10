using System;
using System.Linq;
using System.Collections.Generic;
class Dice
{
    private int[] surfaces = {0, 1, 2, 3, 4, 5, 6};

    public Dice(int[] surfaces)
    {
        this.surfaces = surfaces;
    }

    public void up()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[2];
        surfaces[2] = surfaces[6];
        surfaces[6] = surfaces[5];
        surfaces[5] = surfaces[0];
    }

    public void down()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[5];
        surfaces[5] = surfaces[6];
        surfaces[6] = surfaces[2];
        surfaces[2] = surfaces[0];
    }

    public void left()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[3];
        surfaces[3] = surfaces[6];
        surfaces[6] = surfaces[4];
        surfaces[4] = surfaces[0];
    }

    public void right()
    {
        surfaces[0] = surfaces[1];

        surfaces[1] = surfaces[4];
        surfaces[4] = surfaces[6];
        surfaces[6] = surfaces[3];
        surfaces[3] = surfaces[0];
    }

    public int getNum(int num)
    {
        return surfaces[num];
    }
}

class Program
{
    static void Main()
    {
        string[] Input = Console.ReadLine().Split(' ');
        string direction = Console.ReadLine();

        int[] ints = new int[7];
        ints[0] = 0;
        for(int i = 0; i < Input.Length; i++)
        {
            ints[i + 1] = int.Parse(Input[i]);  
        }

        Dice d = new Dice(ints);

        foreach(char c in direction)
        {
            switch(c)
            {
                case 'N':
                    d.up();
                    break;
                case 'S':
                    d.down();
                    break;
                case 'E':
                    d.right();
                    break;
                case 'W':
                    d.left();
                    break;
            }
        }
        Console.WriteLine(d.getNum(1));
    }
}

