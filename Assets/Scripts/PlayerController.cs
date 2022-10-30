using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioSource pacMoving;
    public AudioSource pacEating;
    public AudioSource pacDeath;
    public AudioSource pacCollision;
    AudioSource audioSource;
    GameObject pacMan;
    Vector3 pos1, pos2, pos3, pos4;
    private Tweener tweener;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("pacSound", 5);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void pacSound()
    {
        audioSource.Play();
    }


}
