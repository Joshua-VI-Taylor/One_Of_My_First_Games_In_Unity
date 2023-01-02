using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
  

    public Transform PlaneS;
    public Transform Spawner;
    public UnityEngine.AI.NavMeshAgent Plane;
    public Transform SPDest;
    //spp
    public GameObject SPP;
    public Transform SPPB;
    public Transform T;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Smasher")
        {
         
            PlaneS.transform.localScale = new Vector3(3, 0.1f, 3);
            print("d");
            Plane.destination=SPDest.position;
            GameObject A = Instantiate(SPP, SPPB.position, SPPB.rotation); A.name = "A";
            GameObject B = Instantiate(SPP, SPPB.position, SPPB.rotation); B.name = "B";
            GameObject C = Instantiate(SPP, SPPB.position, SPPB.rotation); C.name = "C"; 
            A.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled=true;
            B.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled=true;
            C.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled=true;
            A.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = T.position;
            B.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = T.position;  
            C.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = T.position;
            
           
        }
        
        if(collision.collider.gameObject.tag == "End")
        {
            PlaneS.transform.localScale = new Vector3(1,1,1);
            PlaneS.position = new Vector3(Spawner.position.x,Spawner.position.y,Spawner.position.z);
            PlaneS.gameObject.SetActive(!true);
        }
    }
   

}
