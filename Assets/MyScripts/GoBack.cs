using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBack : MonoBehaviour
{
    [Header("Lets the litter bot go to the second level")]
   public UnityEngine.AI.NavMeshAgent TheRobot;
    public Transform tarrrr;
    [SerializeField] private LayerMask h;

    private void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out RaycastHit Hit , 6f))
        {
            if(Hit.transform.tag =="GoBack")
            TheRobot.destination = tarrrr.position;
            TheRobot.SetDestination(tarrrr.position);
        }
    }



}
