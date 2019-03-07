using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {
	//カメラのゲームオブジェクト型を宣言する
	private GameObject maincamera;

	// Use this for initialization
	void Start () {
		//カメラ変数にゲームオブジェクトを代入する
		this.maincamera = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
			//カメラのZ座標より小さい場合オブジェクト破棄する
			if (maincamera.transform.position.z > this.gameObject.transform.position.z) {
				Destroy (this.gameObject);
			}
	}
}
