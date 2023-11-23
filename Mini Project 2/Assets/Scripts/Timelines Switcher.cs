using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelinesSwitcher : MonoBehaviour
{

    public PlayableDirector timeline1;
    public PlayableDirector timeline2;
    private bool flag;

    // Start is called before the first frame update
    void Start()
    {
        PlayTimeline(timeline1);
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeline1.state == PlayState.Paused && !flag)
        {
            PlayTimeline(timeline2);
            flag = true;
        }
    }

    void PlayTimeline(PlayableDirector timeline)
    {
        if (timeline1.state == PlayState.Playing)
            timeline1.Stop();

        if (timeline2.state == PlayState.Playing)
            timeline2.Stop();

        timeline.Play();
    }

}
