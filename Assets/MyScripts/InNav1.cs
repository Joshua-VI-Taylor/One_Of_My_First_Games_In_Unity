using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class InNav1 : MonoBehaviour
{
    public GameObject Object;

    bool Josh;
    public LayerMask Layer;
    public LayerMask LayerD;
    public LayerMask LayerD1;
    public LayerMask LayerD2;
    public LayerMask LayerD3;
    public LayerMask LayerD4;
   
    [SerializeField] private Transform movePositionTransform;
    [SerializeField] private Transform movePositionTransform1;
    [SerializeField] private Transform movePositionTransform2;
    
    RaycastHit hit;
    RaycastHit hitt;
    private NavMeshAgent navMeshAgent;
   
    //Intansttence
    //  public virtual decimal d
    //
    
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.destination = movePositionTransform.position;
        //navMeshAgent.SetDestination(movePositionTransform.position);
        Object.transform.localScale = GameObject.Find("Destination1").transform.localScale;
        Object.transform.localScale.Set (1, 1, 1);
        Josh = true;
    }


    private void Update()
    {


        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit hit, 1f, Layer))
        {
            //navMeshAgent.SetDestination(movePositionTransform1.position);
            navMeshAgent.destination = movePositionTransform2.position;
            navMeshAgent.speed = 1;
            Object.transform.localScale = new Vector3(3, 0.1f, 3);
            Josh = false;
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit HIT, 2f, LayerD1))
        {
            Object.transform.localScale = GameObject.Find("Destination1").transform.localScale;
            Object.transform.localScale.Set(1, 1, 1);
          
        }

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.down) * 20f, Color.green);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit hitt, 2f, LayerD))
        {
            navMeshAgent.destination=movePositionTransform2.position;
            //navMeshAgent.SetDestination(movePositionTransform2.position);
            navMeshAgent.speed = 6;

        }
        Debug.DrawRay(Object.transform.position, Object.transform.TransformDirection(Vector3.forward) * 20f, Color.red);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hittt, 2f, LayerD2))
        {
            
            
            navMeshAgent.destination = movePositionTransform.position;
            Object.transform.position = GameObject.Find("Destination1").transform.position;
            Object.transform.rotation = GameObject.Find("Destination1").transform.rotation;
            Object.transform.localScale = new Vector3(1, 1, 1);
            


        }

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit t, 2f, LayerD4))
        {
            navMeshAgent.destination = movePositionTransform.position;
          
            Object.transform.localScale = new Vector3(1, 1, 1);
        }
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit my, 2f, LayerD3))
        {
            Object.transform.localScale = new Vector3(1, 1, 1);
        }
        
    }
     void Start()
    {
        //Debug.DrawRay(Object.transform.position,Object.transform.TransformDirection(Vector3.forward) * 20f, Color.red);
        
    }
   
}
  

