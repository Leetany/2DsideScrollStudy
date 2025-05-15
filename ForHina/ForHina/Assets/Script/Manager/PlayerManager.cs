using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public Player player;

    private void Awake()
    {
        if (instance !=null)
        {
            Destroy(instance.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    //추후 세이브 로드 적용할 때 사용
}
