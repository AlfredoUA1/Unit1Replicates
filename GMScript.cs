using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMScript : MonoBehaviour
{
    //Create variables for the bomb, explosion, and bomb's health points
    public GameObject bomb;
    public GameObject explosionPrefab;
    public int bombHealth;

    // Start is called before the first frame update
    void Start()
    {
        //When the game starts, bombHealth should start at 3
        bombHealth = 3;
    }

    // Update is called once per frame
    void Update()
    {
        // If I press the space key...
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Take away 1 bomb health
            bombHealth -= 1;

            //If bombhealth reaches 0,,,
            if(bombHealth == 0)
            {
                //Play the audio sound, spawn the explosion, destroy the bomb object, and write "Destroyed" in the console
                GetComponent<AudioSource>().Play();
                Instantiate(explosionPrefab);
                Destroy(bomb);
                Debug.Log("Destroyed");
            }
        }
    }

    
    /*void DestroyObject(GameObject obj)
    {
        Destroy(obj);
    }*/
}
