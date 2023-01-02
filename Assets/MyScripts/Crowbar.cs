using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crowbar : MonoBehaviour
{
    public Camera cam;
    public RaycastHit hit; 
    public RaycastHit hhit; 
    public float Range;
    public GameObject ActionTxt;
    public GameObject ActionKey;
    public GameObject CrowBar;
    public GameObject Dest;
    public Animator anim;
    public bool Ishittingg = false;
    public LayerMask J;
    int hp = 3;
    int Damage = 1;
    bool hasCrowBar = false;
    public UnityEngine.AI.NavMeshAgent enemynav;
    bool Hack = false;
    public GameObject RigidKey;
    public int pointsa;
    string textchange = "Hit robot";


    void Update()
    {
    

        if (Physics.Raycast(cam.transform.position, transform.TransformDirection(Vector3.forward), out hit, Range) && hit.transform.tag == "Crowbar")
        {
            ActionKey.SetActive(true);
            ActionTxt.GetComponent<UnityEngine.UI.Text>().text = "Pick Up Crowbar";
            ActionTxt.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
              
                CrowBar.transform.rotation = Dest.transform.rotation; 
                CrowBar.transform.position = Dest.transform.position;
                CrowBar.transform.parent = Dest.transform;
                hasCrowBar = !false;


            } 
          
        }  if (Input.GetKeyDown(KeyCode.Mouse0))
                {
           // Ishittingg = !Ishittingg; 
            anim.SetBool("Ishitting", !Ishittingg);
                    StartCoroutine(reset());
            
            if(Physics.Raycast(Dest.transform.position, Dest.transform.TransformDirection(Vector3.forward),  out hhit, 3f, J))
                {
                   
                      hp-= Damage;
           
                }
               
                } 

                IEnumerator reset()
            {
            yield return new WaitForSeconds(0.2f);
            anim.SetBool("Ishitting", Ishittingg);
        }
 Debug.DrawRay(Dest.transform.position, Dest.transform.TransformDirection(Vector3.forward) * 3f, Color.green);
        if(hp <= 0)
        {
            enemynav.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            enemynav.GetComponent<Nav>().enabled = false;
            print("Joshua");
            
            textchange = "Go closer; Hack robot";
            Hack = true;
       
        }
        if(hp == 0)
        {
            RigidKey.GetComponent<Rigidbody>().isKinematic = false;
            RigidKey.transform.parent = null;
            StartCoroutine(until());

        }
        IEnumerator until()
        {
           
           
            yield return new WaitForSeconds(0.2f);
           
            hp = -1; 
            StopCoroutine(until());
           
        }
      

        if (Physics.Raycast(cam.transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit New, 15f, J) && hasCrowBar == !false)
        {
            ActionTxt.GetComponent<UnityEngine.UI.Text>().text = textchange;
            ActionTxt.SetActive(true);
         
        }
        if (Physics.Raycast(cam.transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit Hacker, 3f, J) && Hack == true)
        {
            ActionKey.SetActive(true);
            ActionTxt.GetComponent<UnityEngine.UI.Text>().text = "Hack robot";
            ActionTxt.SetActive(true);
            
        }

      

    }
   
    
}
