using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector Timeline1;
    public bool OneTimeTrigger;

    private void OnTriggerEnter(Collider other)
    {
        Timeline1.Play();
        
        if (OneTimeTrigger == true)
        {
            Destroy(this.gameObject);
        }
    }

}
