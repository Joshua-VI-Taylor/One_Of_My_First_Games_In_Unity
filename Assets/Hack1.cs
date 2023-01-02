using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hack1 : MonoBehaviour
{
    [SerializeField] private LayerMask H1;
    [SerializeField] private LayerMask H2;
    [SerializeField] private GameObject Actiontext;
    [SerializeField] private GameObject Actionkey;
    [SerializeField] private Transform PP2;
    [SerializeField] private Transform PP2Dest;
    //[SerializeField] private GameObject Player;
    public UnityEngine.AI.NavMeshAgent rOBOT;
    public Transform rOBOTdEST;
    private void Awake()
    {
        rOBOT.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
    private void Update()
    {
        if(Physics.Raycast(this.transform.position, this.transform.TransformDirection(Vector3.forward), out RaycastHit HACK1, 3f, H1)&& PP2.position !=PP2Dest.position)
        {
            Actionkey.SetActive(true);
            Actiontext.GetComponent<UnityEngine.UI.Text>().text = " this is a bot that is droping the litter " + "Lets Hack it" ;
            Actiontext.SetActive(true);
            if (Input.GetKeyUp(KeyCode.E))
            {
                PP2.position = PP2Dest.position; 
                
            }
        }
        else if(Physics.Raycast(this.transform.position, this.transform.TransformDirection(Vector3.forward), out RaycastHit HA1, 3f, H2))
        {
            Actionkey.SetActive(true);
            Actiontext.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                rOBOT.destination = rOBOTdEST.position;
            }
        }
        else { Actionkey.SetActive(false); Actiontext.SetActive(false); }
     
    }
}
