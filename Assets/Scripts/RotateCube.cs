using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {

    // Use this for initialization
    public float speedFactor = 1.0f;
    public float angle;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            speedFactor += 0.1f;
        } else if(Input.GetKey(KeyCode.DownArrow)) {
            speedFactor -= 0.1f;
        }
       
        angle += 40.0f * Time.deltaTime * speedFactor;
        transform.localRotation = Quaternion.Euler(0.0f, angle, 0.0f);
    }
}
