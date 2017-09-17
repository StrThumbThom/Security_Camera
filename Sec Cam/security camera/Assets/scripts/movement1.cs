using UnityEngine;
using System.Collections;

public class movement1 : MonoBehaviour {
    public float rotspeed = 3f;
    public float speed = 0.1F;
    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame

    void Update()
    {
        float movementx = Input.GetAxisRaw("Horizontal2") * rotspeed;
        float movementz = Input.GetAxisRaw("Vertical2") * speed;
        movementx *= Time.deltaTime;
        movementz *= Time.deltaTime;
        transform.Rotate(0, movementx, 0);
        transform.position+= transform.forward * movementz;

    }
}
