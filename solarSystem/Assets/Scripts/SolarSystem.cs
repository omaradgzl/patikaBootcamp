using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    [Range(0,1)]
    public float orbitalRotationSpeed;   // rotation speed around sun
    [Range(0,1)]
    public float selfRotationSpeed;     // self rotation speed
    
    private float dist;                // variable to store distance in between planet and sun
    private GameObject[] celestials;   // list to store planets 
    private Vector3 sunPos;            // position of sun 
   

    private void Awake()
    {
        celestials = GameObject.FindGameObjectsWithTag("Celestials");  // find gameobjectst tagged as "Celestials" and store them
        sunPos = this.transform.position;                              // set posiiton of sun
    }
    void Update()
    {
        RotateCelestials();
        
    }

    private void RotateCelestials()
    {
        // function that rotates all objects in "Celestials" list
        this.transform.Rotate(Vector3.up, selfRotationSpeed); // rotate this gameobject
        for (int i = 0; i < celestials.Length; i++) 
        {
            dist = Vector3.Distance(sunPos, celestials[i].transform.position);  // calculate each planets distance to sun
            celestials[i].transform.RotateAround(this.transform.position, Vector3.up, (orbitalRotationSpeed * 1000 / dist) * Time.deltaTime); //rotate every list object around sun , if distance is bigger planet will rotate slower
            celestials[i].transform.Rotate(Vector3.up, selfRotationSpeed);   // rotate every planet on its own

        }
    }



}
