using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rigidbody2D;
    public float playerSpeed;
    public float jump;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (transform.right * speed * Time.deltaTime);

        transform.Translate(playerSpeed * Time.deltaTime, 0f, 0f);
        if (Input.GetKeyDown(KeyCode.Space) || 
            Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(
                GetComponent<Rigidbody2D>().velocity.x, jump);
        }
    }

    
}
