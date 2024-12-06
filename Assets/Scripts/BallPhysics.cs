using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    public float ball_speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().linearVelocity = new Vector3(ball_speed * sx, ball_speed * sy, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
