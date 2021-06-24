using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppExit : MonoBehaviour {

	public void GameOver()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
