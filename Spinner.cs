using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float x=1,y=1,z=1;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x,y,z);
    }
}
