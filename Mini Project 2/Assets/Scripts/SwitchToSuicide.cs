using UnityEngine;
using UnityEngine.Playables;

public class SwitchToSuicide : MonoBehaviour
{
    public PlayableDirector timeline;
    public PlayableDirector timeline1;
    public PlayableDirector timeline2;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PlayTimeline(PlayableDirector timeline)
    {
        if (timeline1.state == PlayState.Playing)
            timeline1.Stop();

        if (timeline2.state == PlayState.Playing)
            timeline2.Stop();

        timeline.Play();
    }

    public void GiveUp()
    {
        timeline.Stop();
        PlayTimeline(timeline1);
        canvas.SetActive(false);
    }

    public void Suicide()
    {
        timeline.Stop();
        PlayTimeline(timeline2);
        canvas.SetActive(false);
    }

}