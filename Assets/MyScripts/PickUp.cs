using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUp : MonoBehaviour
{
    
    [SerializeField] Camera cam;
    [SerializeField] UnityEngine.UI.Text Score;
    [SerializeField] GameObject ActionTxt;
    [SerializeField] GameObject ActionKey;
    [SerializeField] LayerMask Litter;
    public int Points;
   public int addedPoints=2;
    Crowbar a;

   

   public IEnumerator add()
        {
        yield return new WaitForSeconds(3);
        //Points += a.pointsa;
      
        }

    public void Update()
    {
     StartCoroutine(add());

        Score.GetComponent<UnityEngine.UI.Text>().text = "Score "  + Points.ToString();
        if(Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out RaycastHit DEL, 3f, Litter))
        {
            ActionKey.SetActive(true);
            ActionTxt.GetComponent<UnityEngine.UI.Text>().text = "Pick up litter";
            ActionTxt.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(DEL.transform.gameObject);
                
                    Points += 10;
                 
            }
          
           
            
        }
    }
}
