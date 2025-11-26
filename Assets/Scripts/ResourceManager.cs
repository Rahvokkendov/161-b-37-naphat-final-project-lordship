using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;


    public int Gold;
   
    public int Food;

    private void Awake()
    {
        Instance = this;
    }
}
