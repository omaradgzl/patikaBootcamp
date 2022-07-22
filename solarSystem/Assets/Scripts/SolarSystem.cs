using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    [Range(0,1)]
    public float orbitalRotationSpeed;
    [Range(0,1)]
    public float selfRotationSpeed;
    
    private float dist;
    private GameObject[] celestials;
    private Vector3 sunPos;
   

    private void Awake()
    {
        celestials = GameObject.FindGameObjectsWithTag("Celestials");
        sunPos = this.transform.position;
    }
    void Update()
    {
        RotateCelestials();
        
    }

    private void RotateCelestials()
    {
        this.transform.Rotate(Vector3.up, selfRotationSpeed);
        for (int i = 0; i < celestials.Length; i++)
        {
            dist = Vector3.Distance(sunPos, celestials[i].transform.position);
            celestials[i].transform.RotateAround(this.transform.position, Vector3.up, (orbitalRotationSpeed * 1000 / dist) * Time.deltaTime);
            celestials[i].transform.Rotate(Vector3.up, selfRotationSpeed);

        }
    }



}
