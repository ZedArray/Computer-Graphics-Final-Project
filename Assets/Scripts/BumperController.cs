using UnityEngine;

public class BumperController : MonoBehaviour
{
    float bumper_speed = 3f;

    void Update()
    {
        if (transform.position.x < 14.25f){
            if (Input.GetKey(KeyCode.S)){
                transform.position += new Vector3(bumper_speed * Time.deltaTime, 0f, 0f);
            }
        }

        if (transform.position.x > 4.3f){
            if (Input.GetKey(KeyCode.W)){
                transform.position -= new Vector3(bumper_speed * Time.deltaTime, 0f, 0f);
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
