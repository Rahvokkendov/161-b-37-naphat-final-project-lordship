using System.Collections.Generic;
using UnityEngine;

public class House : Buildings
{
    [field: SerializeField] protected Transform houseSpawnParent;

    public override void Build()
    {
        foreach (Transform child in houseSpawnParent)
        {
            Instantiate(this, child.position, child.rotation);
        }
    }

    public override void Build(int buildAmount)
    {
        for (int i = 0; i < buildAmount; i++)
        {
            foreach (Transform child in houseSpawnParent)
            {
                Instantiate(this, child.position, child.rotation);
            }
        }
    }


    public void Start()
    {
        base.Init("House", 100, 10, 10, 80);
    }


   
}
