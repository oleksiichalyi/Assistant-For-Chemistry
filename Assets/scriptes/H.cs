using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class H : MonoBehaviour {
	public string a;
	public Text imf;
	public void OnClickStart ()
	{
		string a = imf.text;
		if (a == "HCl" || a == "hcl") {
			SceneManager.LoadScene (17);
		}
		if (a == "H2SO4" || a == "h2so4") {
			SceneManager.LoadScene (18);
		}
		if (a == "HNO3" || a == "hno3") {
			SceneManager.LoadScene (19);
		}
		if (a == "h2s" || a == "H2S") {
			SceneManager.LoadScene (20);
		}
		if (a == "hi" || a == "HI") {
			SceneManager.LoadScene (21);
		}
	}
}