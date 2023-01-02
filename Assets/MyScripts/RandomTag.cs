using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTag : MonoBehaviour
{
    public GameObject P1;
    public LayerMask L;
    public string[] Tags;

    private void Update()
    {
        if (P1.tag == "Untagged")
        {
            if(Physics.Raycast(P1.transform.position, P1.transform.TransformDirection(Vector3.down), out RaycastHit raycast, 1f, L))
            {
            int n = Random.Range(0, Tags.Length);
            P1.tag = Tags[n];
            } 
        }
    }
}
