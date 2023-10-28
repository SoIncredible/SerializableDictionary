using System;
using UnityEngine;

namespace CheckBox
{
    public class StringInList : PropertyAttribute
    {
        public delegate string[] GetStringList();

        public string[] List { get; private set; }

        public StringInList(params string[] list)
        {
            List = list;
        }

        public StringInList(Type type, string methodName)
        {
            var method = type.GetMethod(methodName);

            if (method != null)
            {
                List = method.Invoke(null, null) as string[];
            }
            else
            {
                Debug.LogError("No such Method" + methodName + "For" + type);
            }
        }
    }
}