using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Button;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        Panel.SetActive(true);
        Button.SetActive(true);

        Debug.Log("충돌함");
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
