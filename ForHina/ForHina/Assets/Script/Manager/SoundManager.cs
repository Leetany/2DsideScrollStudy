using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] private float sfxMinimumDistance;
    [SerializeField] private AudioSource[] sfx;
    [SerializeField] private AudioSource[] bgm;

    public bool playBgm;
    private int bgmIndex;
    private bool canPlaySFX;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        Invoke("AllowSFX", 1f);
    }

    void Update()
    {
        
    }

    public void PlaySFX(int _sfxIndex, Transform _source)
    {
        if (canPlaySFX != true)
            return;

        if(_source != null && Vector2.Distance(PlayerManager.instance.player.transform.position, _source.position)
        >sfxMinimumDistance)
            return;

        if(_sfxIndex < sfx.Length)
        {
            sfx[_sfxIndex].pitch = Random.Range(0.85f, 1.1f);
            sfx[_sfxIndex].Play();
        }
    }

    public void StopSFX(int _index) => sfx[_index].Stop();
    private void AllowSFX() => canPlaySFX = true;
}
