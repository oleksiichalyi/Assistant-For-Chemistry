using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class O : MonoBehaviour {
	public string a;
	public Text imf;
	public void OnClickStart ()
	{
		string a = imf.text;
		if (a == "Na" || a == "na") {
			SceneManager.LoadScene (13);
		}
		if (a == "H" || a == "h") {
			SceneManager.LoadScene (12);
		}
		if (a == "Li" || a == "li") {
			SceneManager.LoadScene (14);
		}
		if (a == "He" || a == "he") {
			SceneManager.LoadScene (15);
		}
		if (a == "Be" || a == "be") {
			SceneManager.LoadScene (16);
		}
	}
}

	//if (a=="K") cout<<s;
	//if (a=="Be") cout<<r;
	//if (a=="Mg") cout<<t;
	//if (a=="Ca") cout<<y;
	//if (a=="Ba") cout<<i;
	//if (a=="Na") cout<<c;
	//if (a=="Li") cout<<d;
	//if (a=="B") cout<<p;
	//if (a=="Al") cout<<k;
	//if (a=="C") cout<<l;
	//if (a=="Si") cout<<z;
	//if (a=="N") cout<<m;
	//if (a=="P") cout<<Q;
	//if (a=="S") cout<<T;
	//if (a=="F") cout<<O;
	//if (a=="Cl") cout<<P;
	//if (a=="Br") cout<<A;
	//if (a=="I") cout<<S;
