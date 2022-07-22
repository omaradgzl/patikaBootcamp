using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 tmpMousePosition;
    private Vector3 center;
    [SerializeField]
    private float moveSpeed = 5f;

    void Start()
    {
        tmpMousePosition = Input.mousePosition;
        center = GameObject.Find("Sun").transform.position;
        
    }


    void Update()
    {
        
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


    }

    private void TARDIS(int value)
    {
        moveSpeed = value;
    }




}
