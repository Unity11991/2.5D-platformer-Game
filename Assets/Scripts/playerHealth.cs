using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float fullHealth;
    float currentHealth;

    public GameObject bloodDamageFx;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = fullHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDamage(float damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            makeDead();
        }
    }

    public void makeDead()
    {
        Instantiate(bloodDamageFx, transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
        Destroy (gameObject);
    }
}
