using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class GlobalScript : MonoBehaviour
{
    public static GlobalScript Instance;

    public VideoPlayer movie;
    public double time;

    public string notes="";
    
    void Awake()
    {
        //movie=SampleScene.
        if(Instance==null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if(Instance!=this)
        {
            Destroy(gameObject);
        }
    }

    
}
