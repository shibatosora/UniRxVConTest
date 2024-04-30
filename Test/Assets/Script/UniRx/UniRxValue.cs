using UniRx;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniRxValue : MonoBehaviour
{
    public int Value = 0;
    // Start is called before the first frame update
    void Start()
    {
        //前の値から変わったときのみ実行
        this.ObserveEveryValueChanged(value => Value)
            .Subscribe(value => Debug.Log("値変更！ : " + value));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
