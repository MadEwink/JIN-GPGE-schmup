using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAvatar : MonoBehaviour
{
    [SerializeField] private float maxSpeed;

    public float MaxSpeed
    {
        get { return this.maxSpeed; }
        private set { this.maxSpeed = value; }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
