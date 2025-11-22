using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int gold = 0;
    public int food = 0;
    [field: SerializeField] protected List<Buildings> listBuilding = new List<Buildings>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Current Gold : {gold}");
        listBuilding[0].Init("House", 100, 10, 10, 80);
        
        gold = listBuilding[0].BuildingOutput(gold);
        Debug.Log($"Current Gold : {gold}");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {   
            listBuilding[0].Build();
            listBuilding[0].DebugShow();
            
        }
    }
}
