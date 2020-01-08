using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AttackTarget : MonoBehaviour
{
    private TargetHit scoreComp;  //Scoreコンポーネント

    void Start()
    {
        //シーン内にあるScoreコンポーネントを確保
        scoreComp = GameObject.Find("Happy").GetComponent<TargetHit>();
    }

    //衝突時処理：Scoreコンポーネントの衝突時メソッドにタグを渡す
    void OnCollisionEnter(Collision collision)
    {
        scoreComp.HitTarget(collision.gameObject.tag);
    }
}