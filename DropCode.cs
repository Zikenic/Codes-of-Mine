using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropCode : MonoBehaviour
{
    [SerializeField] float waittime = 5f;
    MeshRenderer renderer;
    Rigidbody rigidb;
    // Start is called before the first frame update
    void Start()
    {
        renderer=GetComponent<MeshRenderer>();
        rigidb=GetComponent<Rigidbody>();
        renderer.enabled=false;
        rigidb.useGravity=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>waittime)
        {
           rigidb.useGravity=true;
           renderer.enabled=true;
        }
    }
}
