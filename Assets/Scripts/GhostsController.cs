using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostsController : MonoBehaviour
{
    public AudioSource nomalState;
    public AudioSource scaredState;
    public AudioSource deadState;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("bgPlay", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void bgPlay() {
        audioSource.Play();
    }
}
