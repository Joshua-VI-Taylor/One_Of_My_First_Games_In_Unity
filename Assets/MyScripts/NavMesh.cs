using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    public GameObject Object;
    
    public LayerMask Layer;
    public LayerMask LayerD;
    public LayerMask LayerD1;
    [SerializeField] private Transform movePositionTransform;
    [SerializeField] private Transform movePositionTransform1;
    [SerializeField] private Transform movePositionTransform2;

    RaycastHit hit;
    RaycastHit hitt;
    private NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        //navMeshAgent.destination = movePositionTransform.position;
       
    }
    private void Start()
    {
      navMeshAgent.SetDestination(movePositionTransform.position);
    }
    private void Update()
    {
      

        if (Physics.Raycast(transform.position, transform.TransformDirection (Vector3.down), out RaycastHit hit, 20f, Layer))
        {
            //navMeshAgent.destination = movePositionTransform1.position;
            navMeshAgent.SetDestination(movePositionTransform1.position);
        }
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 20f, Color.green);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit hitt, 20f, LayerD))
        {
            //Object.transform.position.Set(-15.84f, 12.06f, 15.682f);

            navMeshAgent.SetDestination(movePositionTransform.position);
            Object.transform.position = GameObject.Find("Destination").transform.position;
            Object.transform.rotation = GameObject.Find("Destination").transform.rotation;
            navMeshAgent.SetDestination(movePositionTransform.position);

        }

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit hittt, 20f, LayerD1))
        {
            navMeshAgent.SetDestination(movePositionTransform2.position);

        }

    }
  
}
  
