using UniRx;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class UniRxClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Sample sample = new Sample();
    }
}

public class Sample
{
    public Sample()
    {
        int a = 0;
        var disposable = new SingleAssignmentDisposable();
        disposable.Disposable = Observable.EveryUpdate()
            .Subscribe(_ =>
            {
                a++;
                if (a == 15)
                {
                    disposable.Dispose();
                }
                Debug.Log(a);
                
            });
        
            //MonoBehaviourを継承していない
            //Observable.EveryUpdate()
                //.Subscribe(_ =>
                //{
                    //Debug.Log("EveryUpdate");
                //});
    }

}
