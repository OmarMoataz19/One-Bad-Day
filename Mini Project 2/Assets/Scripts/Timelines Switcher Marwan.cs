using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class TimelinesSwitcher : MonoBehaviour
{

    public PlayableDirector timeline1;
    public PlayableDirector timeline2;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
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

    public void GoBerserk()
    {
        PlayTimeline(timeline2);
        canvas.SetActive(false);
    }

    public void StayCalm()
    {
        SceneManager.LoadScene("MichelOmarScene");
        canvas.SetActive(false);
    }

}