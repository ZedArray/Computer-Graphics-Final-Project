using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnder : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
