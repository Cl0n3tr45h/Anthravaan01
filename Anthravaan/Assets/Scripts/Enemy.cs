using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public int maxHealth = 100;
    private int currenthealth; 
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        //PlayerController hurt anim

        if(currenthealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died");
        //Die animation

        //disable
        enemy.SetActive(false);
        this.enabled = false;
    }
}
