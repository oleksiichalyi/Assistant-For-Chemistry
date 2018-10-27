using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class exam : MonoBehaviour {
	public string a;
	public Text imf;
	public void OnClickStart()

	{ string a = imf.text;
		if (a == "Na" || a == "na") {
			SceneManager.LoadScene (7);
		}
		if (a == "H" || a == "h") {
			SceneManager.LoadScene (8);
		}
		if (a == "Li" || a == "li") {
			SceneManager.LoadScene (9);
		}
		if (a == "He" || a == "he") {
			SceneManager.LoadScene (10);
		}
		if (a == "Be" || a == "be") {
			SceneManager.LoadScene (11);
		}
	}
}
