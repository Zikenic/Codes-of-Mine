using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
     int hits=0, total=0;
     int score_up = 0;
    private void OnCollisionEnter(Collision other) 
    {
        
        if(other.gameObject.tag=="Score")
        {
            score_up=score_up+5;
            Debug.Log("Score Up!" + "+" + score_up);
            other.gameObject.tag="Score Item";
        }
        if(other.gameObject.tag=="Finish Plate")
        {
            total=35-hits+score_up;
            Debug.Log("Your score is:"+total+"Nice Try!");
        }
        if ((other.gameObject.tag!= "Finish Plate" ) && ( other.gameObject.tag!="Score") && (other.gameObject.tag!="Hit")&&(other.gameObject.tag!="Score Item")) 
        {
            hits++;
            Debug.Log("You have bumped:"+ hits + "Time(s)");
        }
    }
}
