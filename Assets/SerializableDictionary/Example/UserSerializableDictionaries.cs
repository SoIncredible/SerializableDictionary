using System;
using CheckBox;
using UnityEngine;

[Serializable]
public class StringStringDictionary : SerializableDictionary<string, string>
{
}

[Serializable]
public class ObjectColorDictionary : SerializableDictionary<UnityEngine.Object, Color>
{
}

[Serializable]
public class ColorArrayStorage : SerializableDictionary.Storage<Color[]>
{
}

[Serializable]
public class StringColorArrayDictionary : SerializableDictionary<string, Color[], ColorArrayStorage>
{
}

[Serializable]
public class MyClass
{
    [StringInList("1", "2")] public string[] str;
}

[Serializable]
public class QuaternionMyClassDictionary : SerializableDictionary<Font, MyClass>
{
}

[Serializable]
public class StringMyClassDictionary : SerializableDictionary<string, MyClass>
{
}

#if NET_4_6 || NET_STANDARD_2_0
[Serializable]
public class StringHashSet : SerializableHashSet<string>
{
}
#endif