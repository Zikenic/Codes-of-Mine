using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
   Rigidbody2D rb;
   AudioSource auds;
   [SerializeField] float Tforce=1f;
   [SerializeField] float Sforce=1f;
   [SerializeField] ParticleSystem flightparticle;
   [SerializeField] ParticleSystem leftparticle;
   [SerializeField] ParticleSystem rightparticle;

void Start()
    {
        auds= GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

void Update()
    {
        ThrustProc();
        SpinProc();
    }
        
void RotateMethod(float Sforce)
    {
        rb.freezeRotation=true;
        transform.Rotate(Vector3.forward*Time.deltaTime*Sforce);
        rb.freezeRotation=false;
    }
void SpinProc()
    {
    if (Input.GetKey(KeyCode.RightArrow))
    {
        RotateMethod(-Sforce);
        if(leftparticle.isPlaying==false)
        leftparticle.Play();
    }
        else
    {
        leftparticle.Stop();
    }
       if (Input.GetKey(KeyCode.LeftArrow))
       {
        RotateMethod(Sforce);
       if (rightparticle.isPlaying==false)
       rightparticle.Play();
       }
       else
       {
        rightparticle.Stop();
       }
       }
       
       
void ThrustProc()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (auds.isPlaying==false)
            {auds.Play();}
            rb.AddRelativeForce(Vector2.up*Time.deltaTime*Tforce);
            if(flightparticle.isPlaying==false)
            flightparticle.Play();
        }
        else
        {
            auds.Stop();
            flightparticle.Stop();

        }
    }
}