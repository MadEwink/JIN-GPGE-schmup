using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engines : MonoBehaviour
{
    [SerializeField]
    private Vector2 speed;
    [SerializeField]
    private Vector2 position;

    private BaseAvatar baseAvatar;

    public Vector2 Speed
    {
        get { return this.speed; }
        set { this.speed = value; }
    }
    public Vector2 Position
    {
        get { return this.position; }
        private set { this.position = value; }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        baseAvatar = GetComponent<BaseAvatar>();
    }

    // Update is called once per frame
    void Update()
    {
        Position = transform.position;
        Position = Position + Speed.normalized * baseAvatar.MaxSpeed * Time.deltaTime;
        transform.position = Position;
    }
}
