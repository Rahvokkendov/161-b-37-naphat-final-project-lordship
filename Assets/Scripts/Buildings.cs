using UnityEngine;

public abstract class Buildings : MonoBehaviour
{
    private string buildingName;
    public string BuildingName { get => buildingName; set => buildingName = (!string.IsNullOrEmpty(value) ? value : buildingName = "Building with no name"); }

    private int goldRequire;
    public int GoldRequire { get; set; }

    private int foodRequire;
    public int FoodRequire { get; set; }

    private int maxBuild;
    public int MaxBuild { get; set; }

    private int currentBuild;
    public int CurrebtBuild { get; set; }

    private int taxOutput;
    public int TaxOutput { get; set; }


    public void Init(string buildingType, int goldReq, int foodReq, int buildMax, int tax)
    {
        GoldRequire = goldReq;
        FoodRequire = foodReq;
        MaxBuild = buildMax;
        taxOutput = tax;
    }

    public void Build(Buildings buildTarget)
    {
        Debug.Log($"You built {buildTarget.name}");
        Instantiate(buildTarget);
    }

    public void Build(Buildings buildTarget,int buildAmount)
    {
        Debug.Log($"You built {buildTarget} by {buildAmount} building");
    }

    public void TaxCollect()
    {

    }

    public void MaxBuildingCheck()
    {

    }

}
