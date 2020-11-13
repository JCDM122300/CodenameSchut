using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject GameOverText;
    private AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        
            
            if ( !GameOverScript.IsGameOver)
            {

                GameOverText.SetActive(true);
                //cue sound effect here
                audiosource.Play();
                
                GameOverScript.IsGameOver = true;
            }
        
    }
}
