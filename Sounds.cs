using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sounds : MonoBehaviour
{
    Rigidbody2D rb;
   AudioSource auds;
   [SerializeField] AudioClip Crash, Finish;
   
   int SceneNumber;
   bool isTransitioning;
    
    void Start()
    {
        isTransitioning=false;
        auds= GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        SceneNumber=SceneManager.GetActiveScene().buildIndex;
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
                crashsequence();
                break;
                case "End":
                finishsequence();
                break;
            }
        }
    
    void loadNextLevel ()
    {
        if (SceneNumber+1==SceneManager.sceneCountInBuildSettings)
        SceneNumber=-1;
        SceneManager.LoadScene(SceneNumber+1);
    }
    void reloadLevel()
    {
        SceneManager.LoadScene(0);
    }
    void crashsequence()
    {
        if (auds.isPlaying==false)
        auds.PlayOneShot(Crash,0.8f);
        else auds.Stop();
        GetComponent<Movement>().enabled=false;
        Invoke("reloadLevel",1f);
        isTransitioning=true;
    }  
        void finishsequence()
    {
        if (auds.isPlaying==false)
        auds.PlayOneShot(Finish,1.2f);
        else auds.Stop();
        GetComponent<Movement>().enabled=false;
        Invoke("loadNextLevel",1.5f);
        isTransitioning=true;
    }
}