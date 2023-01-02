using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LastSP : MonoBehaviour
{
    public GameObject[] steelPices;
    public Transform Tar;
    public NavMeshAgent Nagent;

    private void Awake()
    {
        
        Nagent = GetComponent<NavMeshAgent>();
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "target")
        {
            print("joshua");
            Nagent.destination = Tar.position;
        }
    }
}
