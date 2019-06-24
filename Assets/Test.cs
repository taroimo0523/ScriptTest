using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;　　　//体力
    private int power = 25;　//攻撃力

 public void Attack(){
        //攻撃用の関数
        Debug.Log(this.power + "のダメージを与えた");
        }
public void defence(int damage){
        //防御用の関数
        Debug.Log(damage+"のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }
}

public class Test : MonoBehaviour {

    
    void Start() {
        //要素数5の配列arrayを初期化する
        int[] array = { 20, 40, 50, 10, 200 };
        for (int i=0;i<array.Length;i++){
            Debug.Log(array[i]);

        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
