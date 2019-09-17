using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : MonoBehaviour
{
    [SerializeField]
    private SimpleBullet projectile;
    private float timer;
    [SerializeField]
    private float damage;
    [SerializeField]
    private Vector2 speed;
    [SerializeField]
    private float coolDown;

    public float Damage {
        get { return this.damage; }
        private set { this.damage = value; }
    }
    public Vector2 Speed {
        get { return this.speed; }
        set { this.speed = value; }
    }
    public float CoolDown {
        get { return this.coolDown; }
        set { this.coolDown = value; }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;
    }
    
    public void Fire()
    {
        if ( timer >= CoolDown )
        {
            var new_projectile = Instantiate(projectile, transform.position, transform.rotation);
            new_projectile.
                Init(Damage, Speed, transform.position);
            timer = 0f;
        }
    }
}
