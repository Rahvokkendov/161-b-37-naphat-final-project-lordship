using UnityEngine;

public abstract class Buildings : MonoBehaviour
{
    public string BuildingName { get; private set; }
   
    public int GoldRequire { get; private set; }

    public int FoodRequire { get; private set; }
   
    public int MaxBuild { get; private set; }

    public int CurrentBuild { get; private set; }
    public int TaxOutput { get; private set; }


    public void Init(string buildingType, int goldReq, int foodReq, int buildMax, int tax)
    {
        BuildingName = buildingType;
        GoldRequire = goldReq;
        FoodRequire = foodReq;
        MaxBuild = buildMax;
        TaxOutput = tax;
    }

    public abstract void Build();


    public abstract void Build(int buildAmount);

    public bool MaxBuildingCheck()
    {
        if (CurrentBuild == MaxBuild)
        {
            return true;
        }
        else return false;
    }

}
