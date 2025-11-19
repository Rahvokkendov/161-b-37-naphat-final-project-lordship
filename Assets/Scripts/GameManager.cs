using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [field: SerializeField] protected List<Buildings> listBuilding = new List<Buildings>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listBuilding[0].Build();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
