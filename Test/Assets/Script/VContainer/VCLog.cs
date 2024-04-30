using VContainer;
using System.Collections.Generic;
using UnityEngine;

//戦闘に[Logger]をつけてログを出力するクラス
public sealed class Logger
{
    public void Log(string message) => Debug.Log("[Logger]" + message);
}
//足し算するクラス
public sealed class Calculator
{
    public int Add(int a, int b) => a + b;
}

public sealed class HogeClass
{
    private readonly Logger logger;
    private readonly Calculator calculator;

    [Inject]
    public HogeClass(Logger logger, Calculator calculator)
    {
        this.logger = logger;
        this.calculator = calculator;
    }

    public void LoggerTest()
    {
        logger.Log("LoggerTest");
    }

    public void CalculatorTest(int a, int b)
    {
        int result = calculator.Add(a, b);
        logger.Log($"{a}+{b}={result}");
    }
}
public class VCLog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
