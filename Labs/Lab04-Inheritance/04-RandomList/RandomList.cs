using System;
using System.Collections.Generic;
using System.Text;

public class RandomList : List<string>
{
    Random random = new Random();

    public string RandomString()
    {
        string result = string.Empty;

        if (Count > 0)
        {
            int index = random.Next(0, Count - 1);
            result = this[index];
            this.RemoveAt(index);
        }

        return result;
    }
    
}