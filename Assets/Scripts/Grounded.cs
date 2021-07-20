using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Grounded : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground"){
            Player.GetComponent<PlayerMoveScript>().isGrounded= true;
        } else if (collision.collider.tag == "Victoria")
        {
            SceneManager.LoadScene("Victory");
        }
    }
        void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground"){
            Player.GetComponent<PlayerMoveScript>().isGrounded= false;
        }
    }
}
