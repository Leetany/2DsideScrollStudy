using UnityEngine;

public class JumpDust : MonoBehaviour
{
    public float lifetime = 0.5f;

    private void Awake()
    {
        //뛸 때마다 생겼다 지워지게
        Destroy(gameObject, lifetime);
    }
}
