using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hack2 : MonoBehaviour
{
    public GameObject ActionText;
    public GameObject Player;
    private void Update()
    {
        if(Physics.Raycast(Player.transform.position, Player.transform.TransformDirection(Vector3.down), out RaycastHit raycastHit, 2f))
        {
            if(raycastHit.collider == this)
            {
                ActionText.SetActive(true);
                ActionText.SetActive(true);
                print("Josh" );
            }
        }
    }
}
