using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject meteor; // variable to get meteor object
    private GameObject spawnedMeteor; // variable to store created meteor object 
    [SerializeField]
    private float lifeTime = 15f;    // variable for created meteors lifetime
    
    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime; // timer
        //Debug.Log(lifeTime);
        if (lifeTime<0)  
        {
            
            InstantiateMeteors();
        }

    }

    void InstantiateMeteors()
    {
        // Method to instantiate meteors 
        if (spawnedMeteor != null)
        {
            Destroy(spawnedMeteor, lifeTime);
        }
        else
        {
            spawnedMeteor = Instantiate(meteor, new Vector3(Random.Range(0, 50), Random.Range(0, 50), Random.Range(0, 50)), Quaternion.identity);
            lifeTime = 15f; // reset timer for another meteor

        }

    }
}
