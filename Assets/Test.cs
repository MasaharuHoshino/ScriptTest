using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;    // 魔法力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた！");
    }

    // 防御用の関数
    public void Defense(int damage)
    {
        Debug.Log(damage + "のダメージを受けた！");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 攻撃魔法用の関数
    public void Magic()
    {
        if (this.mp >= 5)
        {
            // 残りmpを減らす
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

        // 配列の初期化
        int[] array = { 55, 6, 112, 15, 63 };

        // 配列の各要素を順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の各要素を逆順に表示
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }


        // Bossクラスの変数lastbossを宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defense(3);

        // 攻撃魔法用の関数を10回呼び出す
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
        // さらに攻撃魔法用の関数を1回呼び出す
        lastboss.Magic();

        // Bossクラスの変数midbossを宣言してインスタンスを代入
        //Boss midboss = new Boss();

        //// 攻撃用の関数を呼び出す
        //midboss.Attack();
        //// 防御用の関数を呼び出す
        //midboss.Defense(2);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
