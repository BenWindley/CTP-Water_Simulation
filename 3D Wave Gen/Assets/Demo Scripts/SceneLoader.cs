using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int current_scene = 0;

	void Update ()
    {
		if(Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(current_scene);
        }
	}
}
