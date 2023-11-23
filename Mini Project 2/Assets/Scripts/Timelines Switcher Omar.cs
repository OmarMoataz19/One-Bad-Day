using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class TimelinesSwitcherOmar : MonoBehaviour
{

    public PlayableDirector timeline1;
    public PlayableDirector timeline2;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        timeline1.Stop();
        timeline2.Stop();
        PlayTimeline(timeline1);
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

    public void Apprehend()
    {
        PlayTimeline(timeline2);
        canvas.SetActive(false);
    }

    public void Kill()
    {
        PlayTimeline(timeline2);
        canvas.SetActive(false);
    }

}