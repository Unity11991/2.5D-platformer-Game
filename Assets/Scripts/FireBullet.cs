using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public float timeBetweenBullets = 0.15f;
    public GameObject projectile;

    float nextBullets;

    // Start is called before the first frame update
    void Awake ()
    {
        nextBullets = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController myPlayer = transform.root.GetComponent<PlayerController>();

        if (Input.GetAxisRaw("Fire1") > 0 && nextBullets < Time.time)
        {
            nextBullets = Time.time + timeBetweenBullets;
            Vector3 rot;
            if(myPlayer.GetFacing() == -1f)
            {
                rot = new Vector3(0, -90, 0);
            }
            else
            {
                rot = new Vector3(0, 90, 0);
            }

            Instantiate(projectile, transform.position, Quaternion.Euler(rot));
        }
    }
}
