using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    House house;
    Buildings buildings;

    [field: SerializeField] public List<Buildings> listBuilding = new List<Buildings>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buildings = GetComponent<Buildings>();
        buildings.Build(listBuilding[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
