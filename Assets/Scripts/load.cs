using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load : MonoBehaviour
{
   public void SceneChange()
    {
        SceneManager.LoadScene("second");
       
    }
}

