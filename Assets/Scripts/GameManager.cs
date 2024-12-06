using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject pause_screen;
    public bool is_paused = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake() {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!is_paused){
                Time.timeScale = 0f;
                is_paused = !is_paused;
                pause_screen.SetActive(true);
            }
            else if (is_paused) {
                Time.timeScale = 1f;
                is_paused = !is_paused;
                pause_screen.SetActive(false);
            }
        }
    }
}
