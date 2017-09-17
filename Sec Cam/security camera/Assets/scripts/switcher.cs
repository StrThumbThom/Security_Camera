using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class switcher : MonoBehaviour {

    public Text cameranum;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;

    public int cam = 1;
    public float timeLeft = 3f;
    private string cn = "Camera ";
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                cam = cam + 1;
                timeLeft = 3f;
            }
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            cam = cam + 1;
        }
        if (cam == 1)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cameranum.text = cn + cam;
        }
        if (cam ==2 )
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            cameranum.text = cn + cam;
        }
        if (cam == 3)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            cameranum.text = cn + cam;
        }
        if (cam == 4)
        {
            cam = 1;
        }
    }
}
