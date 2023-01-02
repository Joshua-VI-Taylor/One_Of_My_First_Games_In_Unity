using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneChange : MonoBehaviour
{
    public void FuctionStart()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(0).buildIndex);
    }
    public void FuctionBack()
    {

    }
}
