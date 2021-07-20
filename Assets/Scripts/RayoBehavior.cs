using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoBehavior : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionPlayer)
    {
        if (collisionPlayer.gameObject.tag == "Player")
        {
            collisionPlayer.gameObject.SendMessage("DeathPlayer");
        }
}
}