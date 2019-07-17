using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//To spawn in unity means to Instantiate() a GameObject
//GameObject is the Base class for all entities in Unity Scenes
//A GameObject is a container for many different components. 


public class OrderSpawner2 : MonoBehaviour {


    //An array og GameObject orders. Public means it can be accessed 
    //globally
    public GameObject[] orders;
    //A Vector(x,y,z) is a vector in the physical sense.
    //It describes the position of the source from where all
    //orders are to be issued dispatch signals.
    public Vector3 spawnValues;
    public float spawnMostWait;
    public float spawnLeastWait;
    public float spawnWait;
    public int startWait;
    //as long as bool is not true; continue forever.
    public bool stop;
    //pick a random order every X amount of seconds.
    int randOrder;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
