using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

	Chara chara;

	void Start(){
		GameObject obj = GameObject.Find ("Chara") as GameObject;
		chara = obj.GetComponent<Chara> ();
	}
		
	//右ボタンを押した時に呼び出す
	//RightButton->Event Trigger(Script)->Pointer Down
	public void onRightButtonDown(){
		Debug.Log("right button clicked");
		chara.move (2.0f);
	}

	//右ボタンを離した時に呼び出す
	//RightButton->Event Trigger(Script)->Pointer Up
	public void onRightButtonUp(){
		Debug.Log ("right button up");
		chara.move (0);
	}

	//左ボタンを押した時に呼び出す
	//LeftButton->Event Trigger(Script)->Pointer Down
	public void onLeftButtonDown(){
		Debug.Log ("left button clicked");
		chara.move (-2.0f);
	}

	//左ボタンを離した時に呼び出す
	//LeftButton->Event Trigger(Script)->Pointer Up
	public void onLeftButtonUp(){
		Debug.Log ("left button up");
		chara.move (0);
	}
}
