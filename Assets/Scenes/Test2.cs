using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public class Test2 : MonoBehaviour
{
    private Test1 m1;

    private void Start()
    {
        m1 = GetComponent<Test1>();

        if (m1 != null)
        {
            FieldInfo fieldInfo = typeof(Test1).GetField("id");

            if (fieldInfo != null)
            {
                fieldInfo.SetValue(m1, Convert.ChangeType(123, fieldInfo.FieldType));
            }
        }
    }
}