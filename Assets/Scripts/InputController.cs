using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private Engines engines;
    private BulletGun bulletGun;
    
    // Start is called before the first frame update
    void Start()
    {
        engines = GetComponent<Engines>();
        bulletGun = GetComponent<BulletGun>();
    }

    // Update is called once per frame
    void Update()
    {
        //engines.Speed = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (Input.GetAxis("Horizontal") > 0) {
            engines.Speed = new Vector2(1, engines.Speed.y);
        } else if (Input.GetAxis("Horizontal") < 0) {
            engines.Speed = new Vector2(-1, engines.Speed.y);
        } else engines.Speed = new Vector2(0, engines.Speed.y);
        
        if (Input.GetAxis("Vertical") > 0) {
            engines.Speed = new Vector2(engines.Speed.x, 1);
        } else if (Input.GetAxis("Vertical") < 0) {
            engines.Speed = new Vector2(engines.Speed.x, -1);
        } else engines.Speed = new Vector2(engines.Speed.x, 0);

        if (Input.GetButton("Fire"))
        {
            bulletGun.Fire();
        }
    }
}
