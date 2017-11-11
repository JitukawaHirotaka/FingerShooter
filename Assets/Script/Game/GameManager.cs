using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	void Start ()
    {
        AudioManager.PlayBGM("千本桜");
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            AudioManager.PauseBGM();
            SceneManager.LoadScene("Result");
        }
    }
}
