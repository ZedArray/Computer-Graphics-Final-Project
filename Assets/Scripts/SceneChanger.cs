using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void twoD(){
        SceneManager.LoadScene(1);
    }

    public void threeD(){
        SceneManager.LoadScene(2);
    }
}
