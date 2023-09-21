using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wepon : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject shooter;
    private Transform _firePoint;
    // Start is called before the first frame update

    public void Awake()
    {
        _firePoint = transform.Find("FirePoint");

    }
    void Start()
    {
        // Instantiate(bulletPrefab, _firePoint.transform.position, Quaternion.identity);


        Invoke("Shoot", 1f);
        Invoke("Shoot", 2f);
        Invoke("Shoot", 3f);
        Invoke("Shoot", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        if (bulletPrefab != null && _firePoint != null && shooter != null) 
        { 
            GameObject myBullet = Instantiate(bulletPrefab, _firePoint.position, Quaternion.identity) as GameObject;
            bullet bulletComponente = myBullet.GetComponent<bullet>();

            if (shooter.transform.localScale.x <0f)
            {
                bulletComponente.direction = Vector2.left;
            }
            else
            {
                bulletComponente.direction = Vector2.right;
            }


        }
    }

}
