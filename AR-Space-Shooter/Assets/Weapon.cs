using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;

    public GameObject bulletPrefab;
    float timer;
    int waitingTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        timer += Time.deltaTime;
        if(timer > waitingTime){
            //Action
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            timer = 0;
        }
    }
}
