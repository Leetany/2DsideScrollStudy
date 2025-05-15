using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector introTimeline;
    private Player player;

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
    }
}
