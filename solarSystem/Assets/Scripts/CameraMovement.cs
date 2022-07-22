using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 tmpMousePosition; // variable to store mouse position
    private Vector3 center;           // variable for position of object which camera will rotates around
    [SerializeField]
    private float moveSpeed = 5f;      // camera movement speed 

    void Start()
    {
        tmpMousePosition = Input.mousePosition;      // first mouse position 
        center = GameObject.Find("Sun").transform.position;   // our center position 
        
    }


    void Update()
    {
        // region that checks if current mouse position is different from last one 
        #region CheckIfMouseIsIdle
        if (tmpMousePosition != Input.mousePosition)
        {
            TARDIS(0);
            tmpMousePosition = Input.mousePosition;
        }
        else
        {
            TARDIS(1);
            transform.RotateAround(center,Vector3.up,moveSpeed*Time.deltaTime);
        }
        #endregion 

    }

    private void TARDIS(int value)
    {
        // TIME AND RELATIVE DIMENSIONS IN SPACE :)  (actually just adjusts camera movement speed, nothing fancy :P)
        moveSpeed = value;
    }




}
