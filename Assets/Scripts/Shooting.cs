using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.TransformPoint(0,1,1), firePoint.rotation); // esto esta mal porq lo que tengo que hacer es spawnear las balas a una 
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();                                                // cierta distancia del punto pero no me sale, no se como hacer asi que
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);                                       // por lo menos q funcione ALGO y se pueda disparar. spawnean arriba del pj
    }                                                                                                       // en vez de dentro de el. tampoco se porque esta en vector 3 solamente 
}                                                                                                           // esta funcion de transformpoint en vez de estar en vector 2 no se q onda
