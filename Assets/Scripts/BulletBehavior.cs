using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision3)
    {
        if (collision3.gameObject.tag == "Enemy")
        {
            collision3.gameObject.SendMessage("Death");
            Destroy(gameObject);
        } else {
        Destroy(gameObject);
        }
    }
}
