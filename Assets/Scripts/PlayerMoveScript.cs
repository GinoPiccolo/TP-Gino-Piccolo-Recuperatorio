using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMoveScript : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float camSweetSpot = 5.5f;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    private Vector2 mouse_pos;
    public Transform target;
    private Vector2 object_pos;
    private float angle;
    float mx;
    public Renderer playerRenderer;
    public Camera cam;
    Vector2 mousePos;
    public bool isGrounded = false;
    void Start()
    {
        playerRenderer = GetComponent<Renderer>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if   (rb2d.transform.position.y < cam.transform.position.y - camSweetSpot) //si el pj es invisible y su posicion esta por debajo de la camara
        {
            DeathPlayer();
        }
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mx = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
        { 
            Jump();
        }
     /*  Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
       transform.position += movement * Time.deltaTime * moveSpeed; */            // colisiona raro horizontalmente
    }
    private void FixedUpdate() // esto sirve para trabajar con fisicas porque iguala el rendimiento del juego sin importar la máquina
        {   
            Vector2 movement = new Vector2(mx * moveSpeed, rb2d.velocity.y);
            rb2d.velocity = movement;
            mouse_pos = Input.mousePosition;
            object_pos = Camera.main.WorldToScreenPoint(target.position); //lo q hace este chunk de codigo es q ya que no me servia el codigo anterior porque era para rotar un 
            mouse_pos.x = mouse_pos.x - object_pos.x;                        //rigidbody y no quiero hacer eso sino rotar un transform, tome un codigo de internet random que rota un transform
            mouse_pos.y = mouse_pos.y - object_pos.y;                       // basado en donde esta el mouse 
            angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg - 90f;
            target.transform.rotation = Quaternion.Euler(0, 0, angle);
        } 

        void Jump()
        {
             Vector2 movement = new Vector2(rb2d.velocity.x, jumpForce);
             rb2d.velocity = movement;
        } 

        void DeathPlayer()
        {
            SceneManager.LoadScene("MainLevel");
        }
}
