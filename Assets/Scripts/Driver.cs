using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float SteerSpeed = 1f;
    [SerializeField]float Speed = 20f;
    [SerializeField]float slowSpeed = 15f;
    [SerializeField]float BoostSpeed = 30f;


    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")*SteerSpeed *Time.deltaTime;
        float CurrentSpeed = Input.GetAxis("Vertical")*Speed *Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,CurrentSpeed,0);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Boost")
        {
            Speed = BoostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Speed = slowSpeed;
    }
    
}
