using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeStory : MonoBehaviour {

	public Sprite[] s1;
	public Button b1;

	int count=0;

	void Awake(){
		s1 = Resources.LoadAll<Sprite> ("story");
	}

	public void On_Click_ButtonButton(){
		count++;
		if (count == s1.Length) {
			count = 0;
		}
		b1.image.sprite = s1 [count];
	}

}
