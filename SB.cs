using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SB : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision other)
    {
    if(other.gameObject.tag=="Player")
    {
    GetComponent<MeshRenderer>().enabled=false;
    GetComponent<BoxCollider>().enabled=false;
    }
    }
     void Update()
    {
        transform.Rotate(1,1,1);
    }
}
