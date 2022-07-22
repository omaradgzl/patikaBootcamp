using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField]

    private GameObject[] celestials;
    private Transform targetPos;

    [SerializeField]
    private float speed = 5f;

    void Start()
    {
        celestials = GameObject.FindGameObjectsWithTag("Celestials");
        targetPos = celestials[Random.Range(0, celestials.Length)].transform;

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position,targetPos.position,speed*Time.deltaTime);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        Destroy(this.gameObject);
        
    }


}
