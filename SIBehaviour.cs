using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIBehaviour : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<MeshRenderer>().enabled=true;
       GetComponent<BoxCollider>().enabled=true;
    }

    // Update is called once per frame
    void Update()
    {
    void OnCollisionEnter(Collision other)
    {
    if(other.gameObject.tag=="Player")
    {
    Debug.Log("True");
    GetComponent<MeshRenderer>().enabled=false;
    GetComponent<BoxCollider>().enabled=false;
    }
    }
    }
}