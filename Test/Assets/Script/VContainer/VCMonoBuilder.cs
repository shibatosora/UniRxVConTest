using VContainer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public　sealed class VCMonoBuilder : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        //1.IcontainerBuilderを生成
        IContainerBuilder containerBuilder = new ContainerBuilder();
        //2.IContainerBuilderに使いたいクラスを登録
      containerBuilder.Register<Logger>(Lifetime.Singleton);
      containerBuilder.Register<Calculator>(Lifetime.Singleton);
      containerBuilder.Register<HogeClass>(Lifetime.Singleton);
      //3.IContainerBuilderからIObjectResolverを生成
     // using (IObjectResolver objectResolver = containerBuilder.Build())   
      //{
       //         //4.　IObjectResolverで使いたいクラスを生成
      //          HogeClass hoge = objectResolver.Resolve<HogeClass>();
     //           hoge.LoggerTest();//[Logger] LoggerTestと出力される
      //          hoge.CalculatorTest(3,5);//[Logger] 3+5=8と出力される
      //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
