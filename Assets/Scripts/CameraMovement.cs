using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    
    public float movingSpeed = 0.5f;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }
 void Update()
 {
     transform.position += Vector3.up * Time.deltaTime * movingSpeed;
 }
}
