using System.Collections.Generic;
using UnityEngine;

public class House : Buildings
{
    public override int BuildingOutput(int output)
    {
       return output + TaxOutput;
    }
}
