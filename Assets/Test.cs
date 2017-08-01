using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	private int hp = 100;   // 体力
	private int power = 25; // 攻撃力
	private int mp = 53; // MP

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	// 魔法用の関数
	public  void Magic(int mpdec) { 
		this.mp -= mpdec;

		if(this.mp >= 0){
			Debug.Log( "魔法攻撃をした。残りMPは" + this.mp );
		} else {
			Debug.Log( "MPが足りないため魔法が使えない。" );
		}
	}

}


public class Test : MonoBehaviour {
	void Start () {
		//課題：配列を宣言して出力しましょう
		// 初期化
		int[] array = {1, 2, 3, 4, 5};

		// 配列を順番に表示
		for (int i = 0; i < array.Length; i++) {
				Debug.Log (array [i]);
			}

		// 配列を逆順に表示
		//arry.Lengthは要素数のため、-1が必要だった。
		for (int i = array.Length - 1; i >= 0; i--) {
				Debug.Log (array [i]);
			}


		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);

		//10回魔法使用
		for (int i = 0; i < 10; i++) {
			lastboss.Magic(5);
		}

		// 魔法用の関数を呼び出す(11回目）
		lastboss.Magic(5);
	}

	void Update () {
		
	}
}
