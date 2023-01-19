using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilate : MonoBehaviour
{
    Vector3 viTriKhoiDau;
    [SerializeField] Vector3 vectorDiChuyen;
    [SerializeField] [Range(0,1)] float yeuToDiChuyen;
    [SerializeField] float period=2f;
    // Start is called before the first frame update
    void Start()
    {
        viTriKhoiDau = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //đống hằng số vs Sin tan gì đó
        float cycle = Time.time/period;
        const float tau = Mathf.PI*2;
        float rawSinWave = Mathf.Sin(cycle*tau);

        yeuToDiChuyen= rawSinWave/2f +0.5f;
        Vector3 doLech = vectorDiChuyen * yeuToDiChuyen;
        transform.position = viTriKhoiDau + doLech;
    }
}
