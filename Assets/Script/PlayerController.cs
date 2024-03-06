using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D b2d;
    SurfaceEffector2D SurfaceEffector2D;
    [SerializeField] float TorqueAmount = 2f;
    void Start()
    {
        b2d = GetComponent<Rigidbody2D>(); 
        SurfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Boost();
    }

    private void Boost(){
        if (Input.GetKey(KeyCode.UpArrow))
        {
            SurfaceEffector2D.speed = 15;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            SurfaceEffector2D.speed = 7;
        }
    }

    private void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            b2d.AddTorque(TorqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            b2d.AddTorque(-TorqueAmount);
        }
    }
}
