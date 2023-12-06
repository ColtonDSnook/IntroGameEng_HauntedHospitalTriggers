using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DoubleTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    public PlayableDirector timeline2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeline.Play();
            timeline2.Play();
            gameObject.SetActive(false);
        }
    }
}
