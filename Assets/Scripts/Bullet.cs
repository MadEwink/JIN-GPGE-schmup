using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    private float damage;
    private Vector2 speed;
    private Vector2 position;
    
    public float Damage
    {
        get { return this.damage; }
        set { this.damage = value; }
    }
    public float Speed
    {
        get { return this.speed }
        set { this.speed = value; }
    }
    public float Position
    {
        get { return this.position }
        private set { this.position = value; }
    }

    public virtual void Init(float damage, Vector2 speed, Vector2 position);
    public virtual void UpdatePosition();

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
