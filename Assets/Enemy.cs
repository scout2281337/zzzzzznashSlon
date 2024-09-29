using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int MaxHealth = 100;
    private int Currenthealth;


    void Start()
    {
        Currenthealth = MaxHealth; 
    }

    public void TakeDamage(int damage) 
    {
        Currenthealth -= damage;

        if (Currenthealth < 0) 
        {
            Die();
        }
    
    }
    void Die() 
    {
        Destroy(this);
    }
    
}
