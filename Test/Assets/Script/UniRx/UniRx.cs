using UniRx;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script.UniRx
{
    public class UniRx : MonoBehaviour
    {
        void Start()
        {
            GetComponent<Button>()
                .OnClickAsObservable()
                .Buffer(2) //2回分の処理をまとめて行う
                .Subscribe(_=>Debug.Log("偶数！"));
        
        }
    }
}