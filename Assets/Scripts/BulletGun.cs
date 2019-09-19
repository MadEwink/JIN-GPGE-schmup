using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGun : MonoBehaviour
{
    [SerializeField]
    private Bullet projectile;
    protected float timer;
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
            var newProjectile = Instantiate(projectile, transform.position, transform.rotation);
            newProjectile.Init(Damage, Speed, transform.position);
            timer = 0f;
        }
    }
}
