using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource auds;
    [SerializeField] AudioClip bmusic;
    void Start()
    {
      auds= GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {
        if (auds.isPlaying==false)
            {auds.PlayOneShot(bmusic,0.1f);}  
    }
}
