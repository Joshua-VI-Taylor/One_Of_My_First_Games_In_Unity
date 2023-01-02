using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Responding : MonoBehaviour
{
    SizeChanger changer;
    public GameObject Pro;
    public Transform Barel;
   
    public float Respawntime = 1f;
  
    public void Objectt()
    {
        for (int i = 0; i < 1; i++)
        {
            GameObject A = Instantiate(Pro, Barel.position, Barel.rotation) as GameObject;
            GameObject B = Instantiate(Pro, Barel.position, Barel.rotation) as GameObject;
            GameObject C = Instantiate(Pro, Barel.position, Barel.rotation) as GameObject;
            GameObject D = Instantiate(Pro, Barel.position, Barel.rotation) as GameObject;
            A.name = "A";
            B.name = "B";
            C.name = "C";
            D.name = "D";
        }
        return;
    }

  public IEnumerator Jod()
    {
        while (true)
        {
            yield return new WaitForSeconds(Respawntime);
            //Objectt();
          
            
        }

    }
  
 
}
