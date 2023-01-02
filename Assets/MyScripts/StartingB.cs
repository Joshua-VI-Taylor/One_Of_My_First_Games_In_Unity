using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class StartingB : MonoBehaviour
{

   

    //Plane/Dest
    public UnityEngine.AI.NavMeshAgent Planee;
    public Transform PlanDest;
    //Robot
    public UnityEngine.AI.NavMeshAgent TheRobot;
    public Transform[] RobotTarget1;
    public Transform BotArm;
    public Transform[] BotArmDest;
    //Smasher
    public int[] timer;
    public Animator AN;
    public string[] Tag;
    public bool CHelper;
    private void Start()
    {
        TheRobot.destination = RobotTarget1[0].position;
        
    }
    private void Update()
    {
       
        RobotTarget1[0].gameObject.SetActive(true);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.tag == Tag[0])
        {
            StartCoroutine(Startt());
            
            
            AN.SetBool("IsSmashing", true);
         
        }
     

     if (collision.collider.gameObject.tag == Tag[1])
        {
            TheRobot.destination = RobotTarget1[1].position;
            
        }
        
       
       
    }
    IEnumerator Startt()
    {
        yield return new WaitForSeconds(timer[0]);
        TheRobot.transform.rotation = RobotTarget1[0].rotation;
        BotArm.position = BotArmDest[0].position;
        Planee.gameObject.SetActive(true);
        Planee.destination = PlanDest.position;
       
        StartCoroutine(Josh());
      
         
         
    }
   
        
   
    IEnumerator Josh()
    {
        
            yield return new WaitForSeconds(timer[1]);
            AN.SetBool("IsSmashing", false);
            GameObject.Find("A").transform.parent = GameObject.Find("BottonC").transform;
            GameObject.Find("B").transform.parent = GameObject.Find("BottonC").transform;
            GameObject.Find("C").transform.parent = GameObject.Find("BottonC").transform;
            GameObject.Find("A").GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            GameObject.Find("B").GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            GameObject.Find("C").GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            yield return new WaitForSeconds(timer[2]);
            BotArm.position = BotArmDest[1].position;
            TheRobot.tag = Tag[1];
            RobotTarget1[0].gameObject.SetActive(false);
           
           
            
     

        
    }
    
}