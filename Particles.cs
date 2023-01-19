using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
[SerializeField] ParticleSystem Fail;
[SerializeField] ParticleSystem Success;
bool isTransitioning;    
 void Start()
{
    isTransitioning=false;
}

void OnCollisionEnter2D(Collision2D other) 
{
if (isTransitioning==true)
    {
        return;
    }
     switch (other.gameObject.tag)
            {
                case "Untouchable":
                particlefail();
                isTransitioning=true;
                break;
                case "End":
                particlesuccess();
                isTransitioning=true;
                break;
            }
    void particlefail()
    {
    if(Fail.isPlaying==false)
        {
        Fail.Play();
        }
    else
        Fail.Stop();
    }
    void particlesuccess()
    {
        if(Success.isPlaying==false)
        {
        Success.Play();
        }
    else
    Success.Stop();
    }
}
}

