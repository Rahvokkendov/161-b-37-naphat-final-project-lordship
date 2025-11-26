using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;


    public int Gold = 1000;
   
    public int Food = 50;

    private void Awake()
    {
        Instance = this;
    }
}
