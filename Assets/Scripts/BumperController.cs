using UnityEngine;

public class BumperController : MonoBehaviour
{
    float bumper_speed = 3f;

    void Update()
    {
        if (transform.position.y > -4f){
            if (Input.GetKey(KeyCode.S)){
                transform.position -= new Vector3(0f, bumper_speed * Time.deltaTime, 0f);
            }
        }

        if (transform.position.y < 6f){
            if (Input.GetKey(KeyCode.W)){
                transform.position += new Vector3(0f, bumper_speed * Time.deltaTime, 0f);
            }
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.Rotate(0f, 0f, 50f * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.D)) {
            transform.Rotate(0f, 0f, -50f * Time.deltaTime, Space.Self);
        }
    }
}
