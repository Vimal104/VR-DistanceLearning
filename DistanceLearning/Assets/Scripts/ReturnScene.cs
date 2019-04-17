using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnScene : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
