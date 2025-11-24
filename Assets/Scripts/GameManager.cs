using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [field: SerializeField] protected List<Buildings> listBuilding = new List<Buildings>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        listBuilding[0].Init("House", 100, 10, 10, 80);
        listBuilding[1].Init("Farm", 300, 20, 9, 40);
        listBuilding[0].Build();
        listBuilding[1].Build();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {   
            listBuilding[0].Build();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            listBuilding[1].Build();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (Buildings building in listBuilding)
            {
                building.BuildingOutput();
                building.DebugShow();
            }
        }
    }
}
