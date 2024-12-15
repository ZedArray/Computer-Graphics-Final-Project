using UnityEngine;

public class Bumper2Controller : MonoBehaviour
{
    float bumper_speed = 3f;

    void Update()
    {
        if (transform.position.x < 14.25f){
            if (Input.GetKey(KeyCode.DownArrow)){
                transform.position += new Vector3(bumper_speed * Time.deltaTime, 0f, 0f);
            }
        }

        if (transform.position.x > 4.3f){
            if (Input.GetKey(KeyCode.UpArrow)){
                transform.position -= new Vector3(bumper_speed * Time.deltaTime, 0f, 0f);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(0f, 0f, 50f * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(0f, 0f, -50f * Time.deltaTime, Space.Self);
        }
    }
}
