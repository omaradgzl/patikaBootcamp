using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject meteor;
    private GameObject spawnedMeteor;
    private float lifeTime = 5f;
    

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        //Debug.Log(lifeTime);
        if (lifeTime<0)
        {
            
            InstantiateMeteors();
        }

    }

    void InstantiateMeteors()
    {
        if (spawnedMeteor != null)
        {
            Destroy(spawnedMeteor, lifeTime);
        }
        else
        {
            spawnedMeteor = Instantiate(meteor, new Vector3(Random.Range(0, 50), Random.Range(0, 50), Random.Range(0, 50)), Quaternion.identity);
            lifeTime = 15f;

        }

    }
}
