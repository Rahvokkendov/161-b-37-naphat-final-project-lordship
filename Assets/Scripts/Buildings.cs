using UnityEngine;

public abstract class Buildings : MonoBehaviour
{

    [field: SerializeField] protected Transform spawnParent;
    [field: SerializeField] protected GameObject buildingPrefab;

    public string BuildingName { get; protected set; }
   
    public int GoldRequire { get; protected set; }

    public int FoodRequire { get; protected set; }
   
    public int MaxBuild { get; protected set; }

    public int CurrentBuild { get; private set; }
    public int TaxOutput { get; protected set; }

    private int spawnIndex = 0;

    void Start()
    {
        CurrentBuild = 0;
    }

    public void Init(string buildingType, int goldReq, int foodReq, int buildMax, int tax)
    {
        BuildingName = buildingType;
        GoldRequire = goldReq;
        FoodRequire = foodReq;
        MaxBuild = buildMax;
        TaxOutput = tax;
    }

    public void Build()
    {
        if (spawnParent.childCount == 0) return;

        Transform spawnPoint = spawnParent.GetChild(spawnIndex);

        if (CurrentBuild <= MaxBuild && CurrentBuild !> MaxBuild)
        {
            
            Instantiate(buildingPrefab, spawnPoint.position, spawnPoint.rotation);
            spawnIndex = (spawnIndex + 1) % spawnParent.childCount;
            CurrentBuild++;
        }
        else return;

    }


    public void Build(int buildAmount)
    {
        if (buildAmount > MaxBuild)
        {
            buildAmount = MaxBuild;
            for (int i = 0; i < buildAmount; i++)
            {

                Build();

            }
        }
        else
        {
            for (int i = 0; i < buildAmount; i++)
            {

                Build();

            }
        }
    }

    public void DebugShow()
    {
        Debug.Log($"N{BuildingName}, G{GoldRequire}, F{FoodRequire}, Mb{MaxBuild}, T{TaxOutput}, Cb{CurrentBuild}");
    }


    public abstract int BuildingOutput(int output);
}
