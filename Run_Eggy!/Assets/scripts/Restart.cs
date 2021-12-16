using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject restart;
    private bool paused = false;


    // Start is called before the first frame update
    void Start()
    {
        restart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    public void OnClickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
