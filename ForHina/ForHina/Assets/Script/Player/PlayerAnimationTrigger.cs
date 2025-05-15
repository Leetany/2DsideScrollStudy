using UnityEngine;

public class PlayerAnimationTrigger : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    private void FootSound1()
    {
        SoundManager.instance.PlaySFX(0, null);
    }

    private void FootSound2()
    {
        SoundManager.instance.PlaySFX(1, null);
    }
}
