using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TargetHit : MonoBehaviour
{
    public Text scoreText; //Text用変数
    private int score = 0; //スコア計算用変数

    void Start()
    {
        score = 0;
        SetScore();   //初期スコアを代入して表示
    }

    //OnCollisionEnterから変更、当たったオブジェクトのタグを渡される
    public void HitTarget(string hittag)
    {
        if (hittag == "Player")
        {
            score -= 150;
        }
        else
        {
            score += 100;
        }

        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }
}