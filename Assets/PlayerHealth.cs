using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void damage(int weapon) {

        health-= weapon;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(health);
    }
}
