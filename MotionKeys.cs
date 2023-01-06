using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionKeys : MonoBehaviour
{
    [SerializeField] float moveSpeed=15;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
        Debug.Log("OBSTACLEZ INSANE DIFFICULTY");
    }

    // Update is called once per frame
    void Update()
    {
        MovementInstruction();
    }
   
   void PrintInstruction()
   {
    Debug.Log("Welcome to Ghost Car Run");
    Debug.Log("You can use the Arrow Keys or WASD to move in directions Up, Left, Down, Right respectively");
    Debug.Log("Hitting the obstacles will negatively affect your points");
    Debug.Log("You can gain more points by collecting Purple Cubes");
    }
   void MovementInstruction()
   {
        float xValue=Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed*-1;
        float zValue=Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(zValue,0,xValue);
    }



}
