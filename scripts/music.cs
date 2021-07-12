using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public AudioClip audio;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(audio, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
