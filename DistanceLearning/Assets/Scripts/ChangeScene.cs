using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ChangeScene : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    VideoPlayer movie;
    public double time;
    public VideoClip DefaultClip;

    void Start()
    {
        movie = GetComponent<VideoPlayer>();
        time = GlobalScript.Instance.time;
        movie.time = time;
        movie.Play();
        //movie.
        //movie.time=time;
       // movie.Video
        //movie.Play();
    }

    void OnTriggerEnter()
    {
        // movie = GetComponent<VideoPlayer>();
        movie.Pause();
        time = movie.time;
        SavePlayer(time);
        //VideoPlayer.Pause();//Application.LoadLevel("Notes");
        GlobalScript.Instance.notes += "These are the sample subtitles (not real; static).";
        LoadScene();
    }

    public void SavePlayer(double movieTime)
    {
        GlobalScript.Instance.time = movieTime;
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("Notes");
    }
    /*
    public void Play()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }
   
  //  public void QuitGame()
  //  {
 //       Application.Quit();
   // }*/

}
