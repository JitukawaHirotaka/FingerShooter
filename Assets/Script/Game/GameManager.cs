using UnityEngine;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
	void Start ()
    {
        AudioManager.PlayBGM("千本桜");
	}
	
	void Update ()
    {
		
	}
}
