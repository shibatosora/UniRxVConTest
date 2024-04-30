using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
   
public class UniRxTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        this.UpdateAsObservable()
            //.FirstOrDefault() //最初の一回のみ
            .Subscribe(_ =>
            {
                sum++;
            Debug.Log(sum);
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
