using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [field: SerializeField] protected List<Buildings> listBuilding = new List<Buildings>();
    [field: SerializeField] protected List<TextMeshProUGUI> textMeshes = new List<TextMeshProUGUI>();
    [field: SerializeField] protected AudioSource buildingPop;
    private int day = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AllBuildingInit();
        listBuilding[0].Build();
        listBuilding[1].Build();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshes[0].text = $"{ResourceManager.Instance.Gold}";
        textMeshes[1].text = $"{ResourceManager.Instance.Food}";
        textMeshes[2].text = $"Days {day}/30";
        ButtonCheck();
        LoseChech();
    }

    public void ButtonCheck()
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
            day++;
    
            foreach (Buildings building in listBuilding)
            {
                building.BuildingOutput();
                building.DebugShow();
            }

            
        }

    }

    public void AllBuildingInit()
    {
        listBuilding[0].Init("House", 100, 10, 10, 80);
        listBuilding[1].Init("Farm", 300, 20, 9, 40);
        listBuilding[2].Init("Mine", 500, 50, 6, 200);
        listBuilding[3].Init("Granary", 200, 10, 1, 80);
        listBuilding[4].Init("Apothecary", 500, 20, 1, 100);
        listBuilding[5].Init("Barrack", 500, 20, 1, 200);
        listBuilding[6].Init("Castle", 2000, 100, 1, 1000);
    }


    public void LoseChech()
    {
        if(ResourceManager.Instance.Food < 0 || day > 30)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


    //Methods for Build Button
    public void HouseBuildButton()
    {
        listBuilding[0].Build();
        buildingPop.Play();
    }
    public void FarmBuildButton()
    {
        listBuilding[1].Build();
        buildingPop.Play();
    }
    public void MineBuildButton()
    {
        listBuilding[2].Build();
        buildingPop.Play();
    }
    public void GranaryBuildButton()
    {
        listBuilding[3].Build();
        buildingPop.Play();
    }
    public void ApothecaryBuildButton()
    {
        listBuilding[4].Build();
        buildingPop.Play();
    }
    public void BarrackBuildButton()
    {
        listBuilding[5].Build();
        buildingPop.Play();
    }
    public void CastleBuildButton()
    {
        listBuilding[6].Build();
        buildingPop.Play();
    }

}
