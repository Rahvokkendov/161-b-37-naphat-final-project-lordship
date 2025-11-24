using UnityEngine;

public abstract class Buildings : MonoBehaviour
{

    [field: SerializeField] protected Transform spawnParent;
    [field: SerializeField] protected GameObject buildingPrefab;

    public string BuildingName { get; protected set; }
   
    public int GoldRequire { get; protected set; }

    public int FoodRequire { get; protected set; }
   
    public int MaxBuild { get; protected set; }

    private int currentBuild = 0;
    public int CurrentBuild { get; private set; }
    public int TaxOutput { get; protected set; }

    private int spawnIndex = 0;


  

    public void Init(string buildingType, int goldReq, int foodReq, int buildMax, int tax)
    {
        BuildingName = buildingType;
        GoldRequire = goldReq;
        FoodRequire = foodReq;
        MaxBuild = buildMax;
        TaxOutput = tax;
        CurrentBuild = currentBuild;
        spawnIndex = 0;
    }

    public void Build()
    {
        if (spawnParent.childCount == 0) return;

        Transform spawnPoint = spawnParent.GetChild(spawnIndex);

        if (CurrentBuild < MaxBuild && FoodRequire <= ResourceManager.Instance.Food && GoldRequire <= ResourceManager.Instance.Gold)
        {
            ResourceManager.Instance.Food -= FoodRequire;
            ResourceManager.Instance.Gold -= GoldRequire;
            Instantiate(this.buildingPrefab, spawnPoint.position, spawnPoint.rotation);
            spawnIndex = (spawnIndex + 1) % spawnParent.childCount;
            CurrentBuild++;
        }
        else if (FoodRequire > ResourceManager.Instance.Food)
        {
            Debug.Log($"Not Enough Food!");
            return;
        }
        else if (GoldRequire > ResourceManager.Instance.Gold)
        {
            Debug.Log($"Not Enough Gold!");
            return;
        }
        else 
        { 
            CurrentBuild = MaxBuild;
        } return;

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
        Debug.Log($"Current Gold : {ResourceManager.Instance.Gold} Current Food: {ResourceManager.Instance.Food}");
    }


    public virtual void BuildingOutput()
    {
        if (this.CurrentBuild > 0)
        {
            for (int i = 0; i < CurrentBuild; i++)
            {
                ResourceManager.Instance.Gold += this.TaxOutput;
            }
        }
        else return;

    }
}
