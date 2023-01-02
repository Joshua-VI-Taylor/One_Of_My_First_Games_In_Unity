using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Newnav : MonoBehaviour
{


    public GameObject Object;
    public LayerMask Layer;
    [SerializeField] private Transform movePositionTransform;

    private NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (Object.gameObject.layer == Layer)
        {
            navMeshAgent.destination = movePositionTransform.position;
        }

        else { }

    }
}