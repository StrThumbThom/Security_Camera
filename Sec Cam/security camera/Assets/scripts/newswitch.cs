using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class newswitch : MonoBehaviour {
    public int ccam = 0;
    public float timeLeft = 3f;
    public Text ctext;
    public GameObject[] cameras;
	// Use this for initialization
	void Start () {
	}
	void switcher()
    {
        for(int i = 0; i < cameras.Length; i++)
        {
            if(i == ccam)
            {
                cameras[i].SetActive(true);
            }
            else
            {
                cameras[i].SetActive(false);
            }
        }
    }
    void ccc()
    {
        ccam++;
        if (ccam >= cameras.Length)
        {
            ccam = 0;
        }
        switcher();
        texup();

    }
    void texup ()
    {
        ctext.text = "Camera " + (ccam +1);
    }
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Switcher"))
        {

            ccc();
        }
       // timeLeft -= Time.deltaTime;
       // if (timeLeft < 0)
       // {
      //      cc_up();
      //      timeLeft = 3f;
       // }
    }
}
