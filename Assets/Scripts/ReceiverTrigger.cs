using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ReceiverTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    public void RunTimeline()
    {
        timeline.Play();
    }
    public void EndTimeline()
    {
        timeline.Stop();
    }
}
