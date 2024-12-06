using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cam;
    public float Speed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float xAxisValue = Input.GetAxis("Horizontal") / 5;
        float zAxisValue = Input.GetAxis("Vertical") / 5;
        float yAxisValue = 0;

        if (Input.GetKey(KeyCode.Space)){
            yAxisValue = 1 / 10f;
            print(yAxisValue);
        }
        else if (Input.GetKey(KeyCode.LeftShift)) {
            yAxisValue = -1 / 10f;
        }

        if(cam != null) {
            cam.transform.Translate(new Vector3(xAxisValue, yAxisValue, zAxisValue));
        }
    }
}
