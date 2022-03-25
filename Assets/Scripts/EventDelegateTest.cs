using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDelegateTest : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void TestDelegate(int ivar);
    public static TestDelegate OnTestDelegate;
    private void Awake()
    {
        OnTestDelegate += Test1;// calls Test1 everytime event is called
        OnTestDelegate += Test2;
        OnTestDelegate += Test3;
    }

    private void Start()
    {
        OnTestDelegate.Invoke(5);
    }


    public void Test1(int ivar1)
    {
        Debug.Log("Test1 : " + ivar1);
    }

    public void Test2(int ivar2)
    {
        Debug.Log("Test2 : " + ivar2);
    }

    public void Test3(int ivar3)
    {
        Debug.Log("Test3 : " + ivar3);
    }

    public void Test4(int ivar4)
    {
        Debug.Log("Test4 : " + ivar4);

    }

    void Update()
    {

    }
}