using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    protected enum Type
    {
        PlayerBullet,
        EnemyBullet
    };
    
    [SerializeField]
    private float damage;
    [SerializeField]
    private Vector2 speed;
    [SerializeField]
    private Vector2 position;
    [SerializeField]
    protected Type type;
    
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

    public virtual void Init(float damage, Vector2 speed, Vector2 position)
    {
        Damage = damage;
        Speed = speed;
        Position = position;
        transform.position = Position;
    }

    public virtual void UpdatePosition()
    {
    }

    public void Update()
    {
        UpdatePosition();
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        var target = collider2D.GetComponent<BaseAvatar>();
        if (target)
            target.TakeDamage(Damage);
    }

}
