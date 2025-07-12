using System;
using UnityEngine;

public class AIeyes : MonoBehaviour
{
    [SerializeField] float sightlength = 100f;
    RaycastHit hit;
    bool hitsomething;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hitsomething = Physics.Raycast(transform.position,transform.forward,out hit);
    }

    void OnDrawGizmos()
    {
        if (hitsomething && hit.transform.CompareTag("Player"))
        {

            print("Jeg kan se dig");
            Gizmos.color = Color.green;
        }
        else
        {
            print("Jeg kan ikke se dig");
            Gizmos.color = Color.red;
        }
        Gizmos.DrawRay(transform.position,transform.forward*sightlength);
    }
}
