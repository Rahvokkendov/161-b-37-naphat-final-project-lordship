using UnityEngine;

public class Granary : Buildings
{
    public override void BuildingOutput()
    {
        base.BuildingOutput();
        if (CurrentBuild > 0)
        {
            ResourceManager.Instance.Food += 20;
        }
    }
   
}
