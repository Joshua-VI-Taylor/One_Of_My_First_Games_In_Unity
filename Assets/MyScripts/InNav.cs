using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InNav : MonoBehaviour
{
    public GameObject Player;
    public UnityEngine.AI.NavMeshAgent rOBOT;
    public Transform rOBOTdEST;
    public LayerMask BladeBotl;
    public GameObject ActionKey;
    public GameObject ActionTxt;
    private void Awake()
    {
        rOBOT.GetComponent<UnityEngine.AI.NavMeshAgent>();  
    }
    private void Update()
    {
        if(Physics.Raycast(Player.transform.position, Player.transform.TransformDirection(Vector3.forward), out RaycastHit vr, 1f, BladeBotl))
        {
            
            ActionKey.SetActive(true); 
            ActionTxt.GetComponent<UnityEngine.UI.Text>().text = "There are going to trash the blades, lets hack to recylce them";
            ActionTxt.SetActive(true);
           
            if (Input.GetKeyDown(KeyCode.E))
            {
                rOBOT.destination = rOBOTdEST.position;
            }
        }
    }
}
