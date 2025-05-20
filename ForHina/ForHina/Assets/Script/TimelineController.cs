using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector introTimeline;
    private Player player;
    [SerializeField] private GameObject DirPrefab;

    void Start()
    {
        player = PlayerManager.instance.player;
        introTimeline.stopped += OnTimelineEnd;
        PlayIntro();
    }


    void Update()
    {

    }

    public void PlayIntro()
    {
        introTimeline.Play();
        //플레이어 속도 제어할 필요 있어
        player.enabled = false;
    }

    void OnTimelineEnd(PlayableDirector dir)
    {
        player.enabled = true;
        StartCoroutine("AnnounceDir");
    }

    IEnumerator AnnounceDir()
    {
        GameObject dir1 = Instantiate(DirPrefab, new Vector3(1.3f, -0.7f, 0), Quaternion.identity);
        //Destroy(dir1, 1f);
        yield return new WaitForSeconds(0.1f);
        GameObject dir2 = Instantiate(DirPrefab, new Vector3(4f, -0.7f, 0), Quaternion.identity);
        //Destroy(dir2, 1f);
        yield return new WaitForSeconds(0.1f);
        GameObject dir3 = Instantiate(DirPrefab, new Vector3(6.7f, -0.7f, 0), Quaternion.identity);
        //Destroy(dir3, 1f);
        yield return new WaitForSeconds(0.1f);
    }
}
