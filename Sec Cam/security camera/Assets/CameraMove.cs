using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
    new Vector3 v3Rotate = Vector3.zero;
    int rotateSpeed;
    public float min = 0f;
    public float max = 0f;
    float ex;
	// Use this for initialization
	void Start () {
        transform.localEulerAngles = v3Rotate;
    }
	
	// Update is called once per frame
	void Update () {

        v3Rotate.x += Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        v3Rotate.x = Mathf.Clamp(v3Rotate.x, min, max);
        transform.localEulerAngles = v3Rotate;
    }
}
