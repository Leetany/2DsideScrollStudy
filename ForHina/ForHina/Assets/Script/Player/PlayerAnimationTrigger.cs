using UnityEngine;

public class PlayerAnimationTrigger : MonoBehaviour
{
    private Player player => GetComponentInParent<Player>();

    private void AnimationTrigger()
    {
        player.AnimationTrigger();
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
