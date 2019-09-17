using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseAvatar : MonoBehaviour
{
    [SerializeField] private float maxSpeed;

    public float MaxSpeed
    {
        get { return this.maxSpeed; }
        private set { this.maxSpeed = value; }
    }
}
