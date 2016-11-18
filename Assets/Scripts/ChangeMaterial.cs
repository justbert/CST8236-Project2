using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

    // Use this for initialization
    public Material jazzHands;
    public Material rickAndMorty;
    public Material sandman;
    public Material rayGilette;
    public Material dontPanic;
    public Material JWilkinson;

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        MeshRenderer renderer = GetComponent<MeshRenderer>();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            renderer.material = sandman;
        } else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            renderer.material = rickAndMorty;
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            renderer.material = jazzHands;
        } else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            renderer.material = rayGilette;
        } else if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            renderer.material = dontPanic;
        } else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            renderer.material = JWilkinson;
        }

    }
}
