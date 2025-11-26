using UnityEngine;

public class Apothecary : Buildings
{
    public override void BuildingOutput()
    {
        base.BuildingOutput();
        if (CurrentBuild > 0)
        {
            for (int i = 0; i < CurrentBuild; i++)
            {
                ResourceManager.Instance.Food -= 5;
            }
        }
    }
}
