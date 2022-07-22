using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField]

    private GameObject[] celestials;   // used to store planets(potantial targets)
    private Transform targetPos;       // used to store target position


    [SerializeField]
    private float speed = 5f;           // default movement speed

    void Start()
    {
        celestials = GameObject.FindGameObjectsWithTag("Celestials");     // find gameobjectst tagged as "Celestials" and store them
        targetPos = celestials[Random.Range(0, celestials.Length)].transform; // randomly select one of planets 
  
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlanet();        
        
    }

    void MoveToPlanet()
    {
        // Method to move this obejct(meteor) to one of selected planets

        transform.position = Vector3.MoveTowards(transform.position, targetPos.position, speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        //If meteor collides with something, destroy it

        Debug.Log(collision.gameObject.name);
        Destroy(this.gameObject);
        
    }


}
