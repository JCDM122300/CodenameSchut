using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //One thing I need to do is figure out how to get the bullet to ignore the player since it destroys it too
        Debug.Log("Game Over");
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
