using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activereset : MonoBehaviour

{
    public StartingB SB;
    public EndingB EB;
    private void Update()
    {
        StartCoroutine(josh());
    }
 IEnumerator josh()
        {
            yield return new WaitForSeconds(1);
        SB.RobotTarget1[0].gameObject.SetActive(true);
        SB.RobotTarget1[1].gameObject.SetActive(true);
        }

}
