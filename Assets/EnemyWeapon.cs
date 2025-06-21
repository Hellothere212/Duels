using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    private GameObject player;
    public int weaponDamage;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) <= 20) {
            Camera.main.GetComponent<PlayerHealth>().damage(weaponDamage);
        }
        
    }
}
