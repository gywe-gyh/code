using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodbyeworld : MonoBehaviour
{
    public Vector3 abeme;

    public int health = 5;
    public int level = 2;
    public float speed = 1.2f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       transform.position=transform.position + abeme;
        

    }
}
