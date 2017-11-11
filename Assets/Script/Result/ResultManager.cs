using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultManager :MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Title");
        }
    }
}
