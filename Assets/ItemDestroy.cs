using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {
	//ユニティちゃんのゲームオブジェクト型を宣言する
	private GameObject maincamera;
	// Use this for initialization
	void Start () {
		//ユニティちゃん変数にゲームオブジェクトを代入する
		this.maincamera = GameObject.Find ("maincamera");
	}
	
	// Update is called once per frame
	void Update () {
			//ユニティちゃんのZ座標より小さい場合オブジェクト破棄する
			if (maincamera.transform.position.z > this.gameObject.transform.position.z) {
				Destroy (this.gameObject);
			}
	}
}
