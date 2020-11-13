using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    
    public float horizontalInput;
    public float Speed = 10f;
    public float xRange = 10f;
    [SerializeField] GameObject playerProjectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //keep the player in the bounds specified.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch projectile from player 
            Instantiate(playerProjectile, transform.position, playerProjectile.transform.rotation);
            //Debug.Log("Space Has Been Pressed");
        }

        //Movement for player
       
        if (!GameOverScript.IsGameOver)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * Speed);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("GameScene");
                GameOverScript.IsGameOver = false;
            }

        }
    }
}
