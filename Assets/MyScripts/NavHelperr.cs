using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NavHelperr : MonoBehaviour
{
   
    [SerializeField] GameObject TranformPlane;
    [SerializeField] Transform TranformPlaneTarget;
    [SerializeField] UnityEngine.AI.NavMeshAgent Robot;
   
    [SerializeField] GameObject Presureplate;
    [SerializeField] GameObject TC;
    [SerializeField] GameObject RobotArm;
    [SerializeField] Transform RobotArmDest;
    //Robot Transform
    [SerializeField] Transform BotTarget1;
    [SerializeField] Transform BotTarget2;
    [SerializeField] Transform BotTarget3;
    //RobotLayer

    [SerializeField] LayerMask BotLayer;
   
    
    //Plane
    [SerializeField] UnityEngine.AI.NavMeshAgent SPLANE;
    RaycastHit Joshua;
    private void Update()
    {
        if (Physics.Raycast(Robot.transform.position, Robot.transform.TransformDirection(Vector3.down), out RaycastHit Joshua, BotLayer))
        {   //Save This another script is doing the same thing
          //RobotArm.transform.position = GameObject.Find("ArmDest").transform.position;
           StartCoroutine(OTimer());
           StartCoroutine(Timer());
           
          
        }

      
    }
    IEnumerator Timer()
    {
      
        yield return new WaitForSeconds(41f);
       // Presureplate.layer = 0;
        //Robot.GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(BotTarget1.position);
        RobotArm.transform.position = RobotArmDest.position;
        //Wall1.SetActive(false);
        //NavHelper.GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(Wall2.transform.position);
      
        SPLANE.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        
        Robot.SetDestination(BotTarget1.position);
        
       
        TranformPlane.transform.position = TranformPlaneTarget.position;

        GameObject.Find("A").GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        GameObject.Find("B").GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        GameObject.Find("C").GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        GameObject.Find("D").GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        GameObject.Find("A").transform.parent = GameObject.Find("CBotton").transform.parent;
        GameObject.Find("B").transform.parent = GameObject.Find("CBotton").transform.parent;
        GameObject.Find("C").transform.parent = GameObject.Find("CBotton").transform.parent;
        GameObject.Find("D").transform.parent = GameObject.Find("CBotton").transform.parent;
        GameObject.Find("A").GetComponent<RayForNav>().enabled = false;
        GameObject.Find("B").GetComponent<RayForNav>().enabled = false;
        GameObject.Find("C").GetComponent<RayForNav>().enabled = false;
        GameObject.Find("D").GetComponent<RayForNav>().enabled = false;

       
    }
    IEnumerator OTimer()
    {
        yield return new WaitForSeconds(36);

        TC.layer = 0;
    }
}

