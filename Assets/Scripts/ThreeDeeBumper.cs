using UnityEngine;

public class ThreeDeeBumper : MonoBehaviour
{
    float bumper_speed = 3f;
    public bool p1 = true;

    // Update is called once per frame
    void Update()
    {
        if (p1){
            if (transform.position.x < 14.25f){
                if (Input.GetKey(KeyCode.D)){
                    transform.position += new Vector3(bumper_speed * Time.deltaTime, 0f, 0f);
                }
            }

            if (transform.position.x > 4.3f){
                if (Input.GetKey(KeyCode.A)){
                    transform.position -= new Vector3(bumper_speed * Time.deltaTime, 0f, 0f);
                }
            }

            if (transform.position.y < 13.5f){
                if (Input.GetKey(KeyCode.W)){
                    transform.position += new Vector3(0f, bumper_speed * Time.deltaTime, 0f);
                }
            }

            if (transform.position.y > 6f){
                if (Input.GetKey(KeyCode.S)){
                    transform.position -= new Vector3(0f, bumper_speed * Time.deltaTime, 0f);
                }
            }
        }

        else if (!p1){
            if (transform.position.x < 14.25f){
                if (Input.GetKey(KeyCode.RightArrow)){
                    transform.position -= new Vector3(bumper_speed * Time.deltaTime, 0f, 0f);
                }
            }

            if (transform.position.x > 4.3f){
                if (Input.GetKey(KeyCode.LeftArrow)){
                    transform.position += new Vector3(bumper_speed * Time.deltaTime, 0f, 0f);
                }
            }

            if (transform.position.y < 13.5f){
                if (Input.GetKey(KeyCode.UpArrow)){
                    transform.position += new Vector3(0f, bumper_speed * Time.deltaTime, 0f);
                }
            }

            if (transform.position.y > 6f){
                if (Input.GetKey(KeyCode.DownArrow)){
                    transform.position -= new Vector3(0f, bumper_speed * Time.deltaTime, 0f);
                }
            }
        }


        // if (Input.GetKey(KeyCode.A)) {
        //     transform.Rotate(0f, 0f, 50f * Time.deltaTime, Space.Self);
        // }
        // else if (Input.GetKey(KeyCode.D)) {
        //     transform.Rotate(0f, 0f, -50f * Time.deltaTime, Space.Self);
        // }
    }
}
