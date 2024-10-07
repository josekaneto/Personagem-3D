using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ActvateCutScene : MonoBehaviour
{
    [SerializeField] private PlayableDirector playableDirector;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("CutScene Activated");
            playableDirector.Play();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
