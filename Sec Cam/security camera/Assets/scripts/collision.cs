using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {
    public GameObject yw;
	// Use this for initialization
	void Start () {
        yw.SetActive(false);
	}
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            yw.SetActive(true);
        }
    }
    // Update is called once per frame
	void Update () {
	
	}
}
