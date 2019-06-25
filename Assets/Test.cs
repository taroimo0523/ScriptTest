using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;　　　//体力
    private int power = 25;　//攻撃力
    int mp = 53;   //マジックパワー

    public void Attack() {
        //攻撃用の関数
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void defence(int damage) {
        //防御用の関数
        Debug.Log(damage + "のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }
    public void Magic() {
        //魔法攻撃用の関数
       
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りのMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }
}

public class Test : MonoBehaviour {


    void Start()
    {
        Boss lastboss = new Boss();
        //10回魔法を使って正しく表示されるか、確認
        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }
        //要素数5の配列arrayを初期化する
        int[] array = { 20, 40, 50, 10, 200 };
        for (int num = 0; num < array.Length; num++)
        {
            //コンソールに表示する
            Debug.Log(array[num]);
        }
        for (int num = 4; num >= 0; num--)
        {
            //コンソールに表示する
            Debug.Log(array[num]);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
