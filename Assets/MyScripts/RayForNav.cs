using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayForNav : MonoBehaviour
{
    //public GameObject game;
    public LayerMask TaRcHANGE;
    RaycastHit TAR ;
    public UnityEngine.AI.NavMeshAgent p1;
  
    public Transform TarTarget;
    public LayerMask stopNav;
    private void Awake()
    {
       //p1.GetComponent<UnityEngine.AI.NavMeshAgent>();
      
        
       
    }
    private void Update()
    {
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out TAR, 2f, TaRcHANGE))
        {
            p1.destination = TarTarget.transform.position;
            
           
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out TAR, 2f, stopNav))
        {

            StartCoroutine(navoff());
        }
    }
    IEnumerator navoff()
    {
        yield return new WaitForSeconds(16f);
        p1.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
     
    }

}
