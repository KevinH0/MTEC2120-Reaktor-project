using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDelegateHandler : MonoBehaviour
{
    void Start()
    {
        EventDelegateTest.OnTestDelegate += Test1;
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
    // Update is called once per frame
    void Update()
    {
        
    }
}
