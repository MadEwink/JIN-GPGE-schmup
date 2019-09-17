using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField]
    private float damage;
    [SerializeField]
    private Vector2 speed;
    [SerializeField]
    private Vector2 position;
    
    public float Damage
    {
        get { return this.damage; }
        set { this.damage = value; }
    }
    public Vector2 Speed
    {
        get { return this.speed; }
        set { this.speed = value; }
    }
    public Vector2 Position
    {
        get { return this.position; }
        protected set { this.position = value; }
    }

    public virtual void Init(float damage, Vector2 speed, Vector2 position) { }

    public virtual void UpdatePosition() { }

    public void Update()
    {
        UpdatePosition();
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
