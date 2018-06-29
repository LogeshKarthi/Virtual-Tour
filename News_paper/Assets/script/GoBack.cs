using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour {

	// Use this for initialization
	public void Back(int index)
	{
		SceneManager.LoadScene (index);
	}
}
