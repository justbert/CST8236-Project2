using UnityEngine;
using System.Collections;

public class Projection : MonoBehaviour
{

    private Camera cam;

    private Matrix4x4 ortho, perspective;

    public float fov = 80f,
        near = 0.3f,
        far = 1000f,
        orthoSize = 5f;

    private float aspect;

    public bool orthoOn;

    // Use this for initialization
    void Start()
    {
        cam = Camera.allCameras[0];
        aspect = (float)Screen.width / (float)Screen.height;
        ortho = Matrix4x4.Ortho(-orthoSize * aspect, orthoSize * aspect, -orthoSize, orthoSize, near, far);
        perspective = Matrix4x4.Perspective(fov, aspect, near, far);
        cam.projectionMatrix = ortho;
        orthoOn = true;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            orthoOn = !orthoOn;
            if (orthoOn)
            {
                cam.projectionMatrix = ortho;
            }
            else
            {
                cam.projectionMatrix = perspective;
            }
        }
    }
}
